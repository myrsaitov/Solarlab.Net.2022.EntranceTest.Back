using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Validators;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.Contracts.Enums;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        /// <summary>
        /// Восстановить объявление
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task Restore(
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

            // TODO Нужно сделать, чтобы при восстановлении
            // объявления обновлялись счетчики тагов
            var congratulation = await _advertisementRepository.FindByIdWithTagsInclude(
                id,
                cancellationToken);

            if (congratulation == null)
            {
                throw new CongratulationNotFoundException(id);
            }

            // Пользователь может восстановить объявление:
            //  - если он создал это объявление;
            //  - модератор и администратор не могут это сделать;
            var isOwnerId = (congratulation.OwnerId == _userProvider.GetUserId());
            if (!isOwnerId)
            {
                throw new NoRightsException("Вы не создали это объявление!");
            }

            // Восстановливает объявление
            congratulation.Status = CongratulationStatus.Active;

            // Сохраняет изменения в базу
            congratulation.UpdatedAt = DateTime.UtcNow;
            await _advertisementRepository.Save(
                congratulation, 
                cancellationToken);
        }
    }
}