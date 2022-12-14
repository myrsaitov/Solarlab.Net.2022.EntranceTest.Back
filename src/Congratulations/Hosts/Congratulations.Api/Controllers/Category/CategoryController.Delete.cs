using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sev1.Accounts.Contracts.Authorization;

namespace Sev1.Congratulations.Api.Controllers.Category
{
    public partial class CategoryController
    {
        /// <summary>
        /// Удаляет категорию
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Authorize("Administrator", "Moderator")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(
            [FromRoute] // Get values from route data, e.g.: "/api/v1/congratulations/{id}"
            int? id, 
            CancellationToken cancellationToken)
        {
            await _categoryService.Delete(
                id,
                cancellationToken);

            //  Creates a Microsoft.AspNetCore.Mvc.NoContentResult object that produces an empty
            //  Microsoft.AspNetCore.Http.StatusCodes.Status204NoContent response.
            return NoContent();
        }
    }
}