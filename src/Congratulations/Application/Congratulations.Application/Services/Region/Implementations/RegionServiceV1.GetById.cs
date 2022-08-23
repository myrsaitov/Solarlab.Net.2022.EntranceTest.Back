using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Services.Congratulation.Validators;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.AppServices.Services.Region.Interfaces;
using Sev1.Congratulations.Contracts.Contracts.Region.Responses;
using Sev1.Congratulations.AppServices.Services.Region.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Region.Implementations
{
    public sealed partial class RegionServiceV1 : IRegionService
    {
        /// <summary>
        /// Получить регион по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор региона</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task<RegionGetResponse> GetById(
            int? id,
            CancellationToken cancellationToken)
        {
            // Fluent Validation
            var validator = new RegionIdValidator();
            var result = await validator.ValidateAsync(id);
            if (!result.IsValid)
            {
                throw new CongratulationIdNotValidException(result.Errors.Select(x => x.ErrorMessage).ToString());
            }

            // Достаем объявление из базы по идентификатору
            var region = await _regionRepository.FindById(
                id,
                cancellationToken);

            // Если объявление с таким идентификатором не существует, то исключение
            if (region == null)
            {
                throw new RegionNotFoundException(id);
            }

            // Маппим сущность на DTO и возвращаем
            return _mapper.Map<RegionGetResponse>(region);
        }
    }
}