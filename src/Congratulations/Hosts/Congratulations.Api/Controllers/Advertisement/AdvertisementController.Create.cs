using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sev1.Accounts.Contracts.Authorization;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Requests;

namespace Sev1.Congratulations.Api.Controllers.Congratulation
{
    public partial class CongratulationController
    {
        /// <summary>
        /// Создает новое объявление
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Authorize("Administrator","Moderator","User")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(
            [FromBody] CongratulationCreateRequest request,
            CancellationToken cancellationToken)
        {
            return Ok(await _advertisementService.Create(
                request,
                cancellationToken));
        }
    }
}