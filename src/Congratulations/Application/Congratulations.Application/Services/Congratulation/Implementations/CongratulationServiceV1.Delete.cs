using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Validators;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.Contracts.Enums;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        /// <summary>
        /// Удаляет объявление по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task Delete(
            int? id,
            CancellationToken cancellationToken)
        {
            // Fluent Validation
            var validator = new CongratulationIdValidator();
            var result = await validator.ValidateAsync(id);
            if (!result.IsValid)
            {
                throw new CongratulationIdNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            // Достаем объявление из базы
            var congratulation = await _advertisementRepository.FindByIdWithTagsInclude(
                id,
                cancellationToken);

            // Если объявления с таким Id нет, то выход
            if (congratulation == null)
            {
                throw new CongratulationNotFoundException(id);
            }

            // Пользователь может удалять объявление:
            //  - если он администратор;
            //  - если он модератор;
            //  - если он создал это объявление.
            var isAdministrator = _userProvider.IsInRole("Administrator");
            var isModerator = _userProvider.IsInRole("Moderator");
            var isOwnerId = (congratulation.OwnerId == _userProvider.GetUserId());
            if(!(isAdministrator||isModerator||isOwnerId))
            {
                throw new NoRightsException("Не хватает прав удалить объявление!");
            }

            // Объявленние не удаляется, а лишь помечается удаленным
            congratulation.Status = CongratulationStatus.Deleted;

            // Обновляется дата редактирования
            congratulation.UpdatedAt = DateTime.UtcNow;

            // Сохраняет изменения в базу
            await _advertisementRepository.Save(
                congratulation, 
                cancellationToken);
        }
    }
}