using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Validators;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.Contracts.Enums;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        /// <summary>
        /// Получить объявление по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task<CongratulationGetResponse> GetById(
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

            // Достаем объявление из базы по идентификатору
            var congratulation = await _advertisementRepository.FindByIdWithCategoriesAndTagsAndUserFiles(
                id,
                cancellationToken);

            // Если объявление с таким идентификатором не существует, то исключение
            if (congratulation == null)
            {
                throw new CongratulationNotFoundException(id);
            }

            // Объявление активно?
            var isActive = congratulation.Status == CongratulationStatus.Active;

            // Если объявление активно, то маппим сущность на DTO и возвращаем
            if (isActive)
            {
                return _mapper.Map<CongratulationGetResponse>(congratulation);
            }

            // Иначе:
            // Пользователь может просматривать неактивное объявление:
            //  - если он администратор;
            //  - если он модератор;
            //  - если он создал это объявление.
            var isAdministrator = _userProvider.IsInRole("Administrator");
            var isModerator = _userProvider.IsInRole("Moderator");
            var isOwnerId = (congratulation.OwnerId == _userProvider.GetUserId());
            if (!(isAdministrator || isModerator || isOwnerId))
            {
                throw new NoRightsException("Не хватает прав просмотреть неактивное объявление!");
            }

            // Маппим сущность на DTO и возвращаем
            return _mapper.Map<CongratulationGetResponse>(congratulation);
        }
    }
}