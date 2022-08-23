using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sev1.Accounts.Contracts.Authorization;
using Sev1.Congratulations.Contracts.Contracts.GetPaged.Requests;

namespace Sev1.Congratulations.Api.Controllers.Congratulation
{
    public partial class CongratulationController
    {
        /// <summary>
        /// Возвращает объявления с пагинацией (и поиском)
        /// </summary>
        /// <param name="request">Запрос на пагинацию и поиск</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetPaged(
            [FromQuery] // Get values from the query string, e.g.: ?PageSize=10&Page=0
            CongratulationGetPagedRequest request, 
            CancellationToken cancellationToken)
        {
            var result = await _advertisementService.GetPaged(
                request, 
                cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Возвращает объявление по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(
            [FromRoute] // Get values from route data, e.g.: "/api/v1/congratulations/{id}"
            int? id, 
            CancellationToken cancellationToken)
        {
            var found = await _advertisementService.GetById(
                id,
                cancellationToken);

            return Ok(found);
        }
    }
}