using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.Contracts.Contracts.Category.Requests;
using Sev1.Congratulations.Contracts.Contracts.Category.Responses;
using Sev1.Congratulations.Contracts.Contracts.GetPaged.Requests;

namespace Sev1.Congratulations.AppServices.Services.Category.Interfaces
{
    public interface ICategoryService
    {
        /// <summary>
        /// Создает новую категорию
        /// </summary>
        /// <param name="request">Модель DTO категории</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<int?> Create(
            CategoryCreateRequest request,
            CancellationToken cancellationToken);

        /// <summary>
        /// Обновляет существующую категорию
        /// </summary>
        /// <param name="request">Модель DTO категории</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<int?> Update(
            CategoryUpdateRequest request,
            CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет категорию по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task Delete(
            int? id,
            CancellationToken cancellationToken);

        /// <summary>
        /// Восстанавливает категорию по идентификатор
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task Restore(
            int? id,
            CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает категорию по идентификатор
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<CategoryGetResponse> GetById(
            int? id, 
            CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает категории с пагинацией
        /// </summary>
        /// <param name="request">Параметры пагинации</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<CategoryGetPagedResponse> GetPaged(
            GetPagedRequest request, 
            CancellationToken cancellationToken);
    }
}