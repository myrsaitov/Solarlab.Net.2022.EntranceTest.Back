using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Category.Exceptions
{
    /// <summary>
    /// Исключение при несоответствующем запросе при создании категории
    /// </summary>
    public class CategoryCreateDtoNotValidException : BadRequestException
    {
        public CategoryCreateDtoNotValidException(string message) : base(message)
        {
        }
    }
}