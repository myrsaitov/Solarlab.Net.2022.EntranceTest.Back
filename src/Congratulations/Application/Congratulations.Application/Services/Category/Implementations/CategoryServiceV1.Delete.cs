using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Services.Category.Interfaces;
using Sev1.Congratulations.AppServices.Services.Category.Exceptions;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.AppServices.Services.Category.Validators;

namespace Sev1.Congratulations.AppServices.Services.Category.Implementations
{
    public sealed partial class CategoryServiceV1 : ICategoryService
    {
        /// <summary>
        /// Удалить категорию по идентификатору
        /// (только администратор или модератор)
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task Delete(
            int? id,
            CancellationToken cancellationToken)
        {
            // TODO
            // что будет с объявлениями у удаленной категории?
            // может их тоже удалить?

            // Fluent Validation
            var validator = new CategoryIdValidator();
            var result = await validator.ValidateAsync(id);
            if (!result.IsValid)
            {
                throw new CategoryIdNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            // Достать из базы категорию по Id
            var category = await _categoryRepository.FindById(
                id, 
                cancellationToken);
            if (category == null)
            {
                throw new CategoryNotFoundException(id);
            }

            // Пользователь может удалить категорию:
            //  - если он администратор;
            //  - если он модератор;
            var isAdministrator = _userProvider.IsInRole("Administrator");
            var isModerator = _userProvider.IsInRole("Moderator");
            if (!(isAdministrator || isModerator))
            {
                throw new NoRightsException("Удалить категорию может только модератор или админ!");
            }

            // Категория не удаляется, а лишь помечается удаленной
            category.IsDeleted = true;

            // Сохраняем время редактирования
            category.UpdatedAt = DateTime.UtcNow;

            // Изменения в базу
            await _categoryRepository.Save(
                category, 
                cancellationToken);
        }
    }
}