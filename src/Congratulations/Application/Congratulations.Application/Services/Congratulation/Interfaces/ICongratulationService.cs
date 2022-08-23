using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Requests;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses;
using Sev1.Congratulations.Contracts.Contracts.GetPaged.Requests;
using Sev1.Congratulations.Contracts.Contracts.GetPaged.Responses;
using Sev1.UserFiles.Contracts.Contracts.UserFile.Requests;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces
{
    public interface ICongratulationService
    {
        /// <summary>
        /// Создает новое объявление
        /// </summary>
        /// <param name="request">Модель DTO объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<CongratulationCreatedResponse> Create(
            CongratulationCreateRequest request,
            CancellationToken cancellationToken);

        /// <summary>
        /// Обновляет существующее обявление
        /// </summary>
        /// <param name="request">Модель DTO объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<CongratulationUpdatedResponse> Update(
            CongratulationUpdateRequest request,
            List<IFormFile> files,
            CancellationToken cancellationToken);

        /// <summary>
        /// Обновляет статус существующего обявления
        /// </summary>
        /// <param name="request">Модель DTO объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<CongratulationUpdatedResponse> UpdateStatus(
            CongratulationUpdateStatusRequest request,
            CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет объявление по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task Delete(
            int? id,
            CancellationToken cancellationToken);

        /// <summary>
        /// Восстанавливает объявление по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task Restore(
            int? id,
            CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает объявление по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<CongratulationGetResponse> GetById(
            int? id, 
            CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает объявления с пагинацией
        /// </summary>
        /// <param name="request">Параметры пагинации</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<CongratulationGetPagedResponse> GetPaged(
            CongratulationGetPagedRequest request, 
            CancellationToken cancellationToken);

        /// <summary>
        /// Добавить таги к объявлению
        /// </summary>
        /// <param name="congratulation">Объект объявления</param>
        /// <param name="TagBodies">Массив тагов</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task AddTags(
            Domain.Congratulation congratulation,
            string[] TagBodies,
            CancellationToken cancellationToken);
    }
}