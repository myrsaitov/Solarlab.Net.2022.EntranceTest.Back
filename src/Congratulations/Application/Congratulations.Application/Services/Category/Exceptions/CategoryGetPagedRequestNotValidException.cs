using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Category.Exceptions
{
    /// <summary>
    /// Исключение при нессответсвующем запросе на пагинацию
    /// </summary>
    public class CategoryGetPagedRequestNotValidException : BadRequestException
    {
        public CategoryGetPagedRequestNotValidException(string message) : base(message)
        {
        }
    }
}