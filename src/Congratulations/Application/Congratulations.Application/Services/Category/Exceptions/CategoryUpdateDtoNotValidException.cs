using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Category.Exceptions
{
    /// <summary>
    /// Исключение при несоответствующем запросе на обновление категории
    /// </summary>
    public class CategoryUpdateRequestNotValidException : BadRequestException
    {
        public CategoryUpdateRequestNotValidException(string message) : base(message)
        {
        }
    }
}