using System;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Validators;
using System.Linq;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Requests;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.AppServices.Services.Region.Exceptions;
using Sev1.Congratulations.AppServices.Services.Category.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        /// <summary>
        /// Создать объявление
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task<CongratulationCreatedResponse> Create(
            CongratulationCreateRequest request,
            CancellationToken cancellationToken)
        {
            // Fluent Validation
            var validator = new CongratulationCreateRequestValidator();
            var result = await validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                throw new CongratulationCreateDtoNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            // Возвращаем Id пользователя
            var userId = _userProvider.GetUserId();
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new NoRightsException("Нет создателя объявления!");
            }

            // Проверка категории на существование
            var category = await _categoryRepository.FindById(
                request.CategoryId,
                cancellationToken);
            if (category is null)
            {
                throw new CategoryNotFoundException(request.CategoryId);
            }

            // Если категория удалена
            if (category.IsDeleted)
            {
                throw new CategoryNotFoundException(request.CategoryId);
            }

            // Проверка, существует ли регион с таким идентификатором
            var region = await _regionRepository.FindById(
                request.RegionId,
                cancellationToken);
            if (region == null)
            {
                throw new RegionNotFoundException(request.RegionId);
            }

            // Создаёт доменную сущность нового объявления
            var congratulation = _mapper.Map<Domain.Congratulation>(request);

            // Дополняет сущность
            congratulation.IsDeleted = false; // не используется, т.к. есть Status // TODO убрать
            congratulation.CreatedAt = DateTime.UtcNow;
            congratulation.Category = category;
            congratulation.OwnerId = userId;

            // Загружает файлы в UserFiles
            var userFilesResponse = await _userFilesUploadApiClient
                .UploadBase64(request.UserFiles);

            // Добавляем идентификаторы файлов в таблицу
            await AddUserFiles(
                congratulation,
                userFilesResponse.Id,
                cancellationToken);

            // Добавляем таги
            await AddTags(
                congratulation,
                request.TagBodies,
                cancellationToken);

            // Сохраняем в базе
            await _advertisementRepository.Save(
                congratulation, 
                cancellationToken);

            // Возвращаем идентификатор созданного объявления
            return new CongratulationCreatedResponse() 
            {
                Id = congratulation.Id
            };
        }
    }
}