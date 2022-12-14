using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sev1.Accounts.Contracts.Authorization;
using Sev1.Congratulations.Contracts.Contracts.Category.Requests;

namespace Sev1.Congratulations.Api.Controllers.Category
{
    public partial class CategoryController
    {
        /// <summary>
        /// Создает новую категорию
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Authorize("Administrator", "Moderator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(
            [FromBody] //[FromBody] <= "Content-Type: application/json-patch+json"
            CategoryCreateRequest request, 
            CancellationToken cancellationToken)
        {
            var response = await _categoryService.Create(
                request, 
                cancellationToken);

            return Created($"api/v1/categories/{response}", new { });
        }
    }
}