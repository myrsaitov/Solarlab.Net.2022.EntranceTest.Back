using System;
using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Validators;
using System.Linq;
using Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.Contracts.Enums;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses;

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
        public async Task<CongratulationUpdatedResponse> UpdateStatus(
            CongratulationUpdateStatusRequest request,
            CancellationToken cancellationToken)
        {
          
            // Fluent Validation
            var validator = new CongratulationUpdateStatusDtoValidator();
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

            var isAdministrator = _userProvider.IsInRole("Administrator");
            var isModerator = _userProvider.IsInRole("Moderator");
            var isOwnerId = (congratulation.OwnerId == _userProvider.GetUserId());
            var isUser = _userProvider.IsInRole("User");

            // Администратор может только ставить статус "Приостановлено",
            // если до этого было "Не соответсвует нормам"
            if (isAdministrator)
            {
                if (((congratulation.Status != CongratulationStatus.NotAllowed) ||
                    (request.Status != CongratulationStatus.Stopped)))
                {
                    throw new ConflictException("Вы не можете установить этот статус!");
                }
                else
                {
                    // Обновляет статус и время редактирования
                    congratulation.Status = request.Status;
                    congratulation.UpdatedAt = DateTime.UtcNow;
                    // Сохраняет в базе
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

            // Модератор может только ставить статус "Не соответсвует нормам"
            else if (isModerator)
            {
                if ((request.Status != CongratulationStatus.NotAllowed))
                {
                    throw new ConflictException("Вы не можете установить этот статус!");
                }
                else
                {
                    // Обновляет статус и время редактирования
                    congratulation.Status = request.Status;
                    congratulation.UpdatedAt = DateTime.UtcNow;
                    // Сохраняет в базе
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

            // Обычный пользователь может обновлять статус только свои собственные объявления
            else if (isOwnerId)
            {
                if (!isOwnerId)
                {
                    throw new NoRightsException("Вы не создали это объявление!");
                }
                else
                {
                    // Обычный пользователь не может изменить
                    // установленный модератором статус "Не соответсвует нормам"
                    if ((congratulation.Status == CongratulationStatus.NotAllowed) &&
                        (isUser))
                    {
                        throw new ConflictException("Вы не можете изменить этот статус!");
                    }

                    // Обновляет статус и время редактирования
                    congratulation.Status = request.Status;
                    congratulation.UpdatedAt = DateTime.UtcNow;
                    // Сохраняет в базе
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
            else
            {
                throw new NoRightsException("Нет прав обновить статус!");
            }
        }
    }
}