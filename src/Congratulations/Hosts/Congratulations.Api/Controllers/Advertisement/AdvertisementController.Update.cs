using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sev1.Accounts.Contracts.Authorization;
using Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests;

namespace Sev1.Congratulations.Api.Controllers.Congratulation
{
    public partial class CongratulationController
    {
        /// <summary>
        /// Редактирует объявление
        /// </summary>
        /// <param name="jsonString">DTO-модель, переданная через FormData</param>
        /// <param name="files">Файлы в FormData</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Authorize("User")]
        [HttpPut("update")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Update(
            [FromForm] string jsonString,
            [FromForm] List<IFormFile> files,
            CancellationToken cancellationToken)
        {
            var request = JsonConvert
                .DeserializeObject<CongratulationUpdateRequest>(jsonString);

            return Ok(await _advertisementService.Update(
                request,
                files,
                cancellationToken));
        }
    }
}