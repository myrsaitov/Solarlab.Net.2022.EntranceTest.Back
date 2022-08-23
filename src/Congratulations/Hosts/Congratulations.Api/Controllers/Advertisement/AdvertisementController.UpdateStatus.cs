using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sev1.Accounts.Contracts.Authorization;
using Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests;

namespace Sev1.Congratulations.Api.Controllers.Congratulation
{
    public partial class CongratulationController
    {
        /// <summary>
        /// Изменяет статус объявления
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Authorize("User")]
        [HttpPut("update-status")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdateStatus(
            [FromBody] //[FromBody] <= "Content-Type: application/json-patch+json"
            CongratulationUpdateStatusRequest request, 
            CancellationToken cancellationToken)
        {
            return Ok(await _advertisementService.UpdateStatus(
                request, 
                cancellationToken));
        }
    }
}