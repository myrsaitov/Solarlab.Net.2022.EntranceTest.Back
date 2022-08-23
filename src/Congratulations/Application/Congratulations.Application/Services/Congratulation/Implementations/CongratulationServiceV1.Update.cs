using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Validators;
using System.Linq;
using Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.AppServices.Services.Region.Exceptions;
using Sev1.Congratulations.AppServices.Services.Category.Exceptions;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses;
using Microsoft.AspNetCore.Http;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        /// <summary>
        /// Обновляет объявление
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task<CongratulationUpdatedResponse> Update(
            CongratulationUpdateRequest request,
            List<IFormFile> files,
            CancellationToken cancellationToken)
        {
          
            // Fluent Validation
            var validator = new CongratulationUpdateDtoValidator();
            var result = await validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                throw new CongratulationUpdateRequestNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            var congratulation = await _advertisementRepository.FindByIdWithCategoriesAndTagsAndUserFiles(
                request.Id,
                cancellationToken);

            if (congratulation == null)
            {
                throw new CongratulationNotFoundException(request.Id);
            }

            // Обычный пользователь может обновлять только свои собственные объявления
            // Модератор и админ не могут редактировать, только удалять
            var isOwnerId = (congratulation.OwnerId == _userProvider.GetUserId());
            if (!isOwnerId)
            {
                throw new NoRightsException("Вы не создали это объявление!");
            }

            // Проверка, существует ли регион с таким идентификатором
            var region = await _regionRepository.FindById(
                request.RegionId,
                cancellationToken);
            if (region == null)
            {
                throw new RegionNotFoundException(request.RegionId);
            }

            // Здесь использовать Mapper нельзя,
            // т.к. маппер создает новую сущность,
            // и в базу ее не положить заместо старой.
            // Нужно редактировать старую.
            congratulation.Title = request.Title;
            congratulation.Body = request.Body;
            congratulation.Price = request.Price;
            congratulation.CategoryId = request.CategoryId;
            congratulation.Address = request.Address;
            congratulation.RegionId = request.RegionId;
            congratulation.Status = request.Status;

            congratulation.IsDeleted = false;
            congratulation.UpdatedAt = DateTime.UtcNow;

            // Ищет категорию в базе
            var category = await _categoryRepository.FindById(
                congratulation.CategoryId,
                cancellationToken);
            if (category == null)
            {
                throw new CategoryNotFoundException(congratulation.CategoryId);
            }

            // Если категория существует, то присваивает объявлению
            congratulation.Category = category;

            // Если переданы таги
            if (congratulation.Tags == null)
            {
                congratulation.Tags = new List<Domain.Tag>();
            }
            congratulation.Tags.Clear();

            // Добавляем таги
            await AddTags(
                congratulation,
                request.TagBodies,
                cancellationToken);

            // Сохраняем в базу
            await _advertisementRepository.Save(
                congratulation, 
                cancellationToken);

            // Возвращаем идентификатор обновленного объявления
            return new CongratulationUpdatedResponse()
            {
                Status = congratulation.Status
            };
        }
    }
}