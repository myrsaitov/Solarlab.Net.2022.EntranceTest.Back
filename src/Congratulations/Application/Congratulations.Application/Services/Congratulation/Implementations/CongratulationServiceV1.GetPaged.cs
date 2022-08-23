using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Contracts.Congratulation;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using System.Linq.Expressions;
using Sev1.Congratulations.AppServices.Services.GetPaged.Validators;
using Sev1.Congratulations.Contracts.Contracts.GetPaged.Requests;
using Sev1.Congratulations.Contracts.Contracts.GetPaged.Responses;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        /// <summary>
        /// Получить пагинированные объявления
        /// </summary>
        /// <param name="request">Запрос на пагинацию</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task<CongratulationGetPagedResponse> GetPaged(
            CongratulationGetPagedRequest request,
            CancellationToken cancellationToken)
        {
            // Fluent Validation
            var validator = new CongratulationGetPagedRequestValidator();
            var result = await validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                throw new CongratulationGetPagedRequestNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            // Вычислить смещение (skip)
            var offset = request.Page * request.PageSize;
            
            // Параметр поиска в базе
            Expression<Func<Domain.Congratulation, bool>> predicate = a => true;

            // Если нет параметров поиска, выводим без какой-либо фильтрации
            if ((string.IsNullOrWhiteSpace(request.SearchStr))
                && (string.IsNullOrWhiteSpace(request.OwnerId))
                && (request.CategoryId is null)
                && (string.IsNullOrWhiteSpace(request.Tag)))
            {
                predicate = a => true; // Фильтрация отсутствует
            }
            // Если пришли параметры поиска
            else if ((!string.IsNullOrWhiteSpace(request.SearchStr))
                && (string.IsNullOrWhiteSpace(request.OwnerId))
                && (request.CategoryId is null)
                && (string.IsNullOrWhiteSpace(request.Tag)))
            {
                // Общий поиск
                predicate =
                    o => o.Body.ToLower().Contains(request.SearchStr.ToLower())  // В теле объявления
                    || o.Title.ToLower().Contains(request.SearchStr.ToLower())  // В названии объявления
                    || o.Category.Name.ToLower().Contains(request.SearchStr.ToLower()) // По имени категории
                    || o.Tags.Select(a => a.Body).ToArray().Contains(request.SearchStr.ToLower()); // По tag
            }
            else if ((string.IsNullOrWhiteSpace(request.SearchStr))
                && (!string.IsNullOrWhiteSpace(request.OwnerId))
                && (request.CategoryId is null)
                && (string.IsNullOrWhiteSpace(request.Tag)))
            {
                // Поиск по UserId
                predicate =
                    a => a.OwnerId == request.OwnerId;
            }
            else if ((string.IsNullOrWhiteSpace(request.SearchStr))
                && (string.IsNullOrWhiteSpace(request.OwnerId))
                && (!(request.CategoryId is null))
                && (string.IsNullOrWhiteSpace(request.Tag)))
            {
                // Поиск по CategoryId
                predicate =
                    a => a.CategoryId == request.CategoryId;
            }
            else if ((string.IsNullOrWhiteSpace(request.SearchStr))
                && (string.IsNullOrWhiteSpace(request.OwnerId))
                && ((request.CategoryId is null))
                && (!string.IsNullOrWhiteSpace(request.Tag)))
            {
                // Поиск по Tag
                predicate =
                    a => a.Tags.Any(t => t.Body == request.Tag);
            }

            // Подсчет общего количества объявлений
            var total = await _advertisementRepository.CountActive(
                predicate,
                cancellationToken);

            // Если объявления не найдены, то возвращаем "пустой" ответ 
            if (total == 0)
            {
                return new CongratulationGetPagedResponse
                {
                    Items = Array.Empty<CongratulationGetPagedDto>(),
                    Total = 0,
                    Offset = offset,
                    Limit = request.PageSize
                };
            }

            // Если объявления найдены
            var entities = await _advertisementRepository.GetPagedWithTagsAndCategoryAndUserFilesInclude(
                predicate,
                offset,
                request.PageSize,
                cancellationToken);

            // Создание обёртки (wrapper)
            return new CongratulationGetPagedResponse
            {
                Items = entities.Select(entity => _mapper.Map<CongratulationGetPagedDto>(entity)),
                Total = total,
                Offset = offset,
                Limit = request.PageSize
            };
        }
    }
}