using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Category.Exceptions
{
    /// <summary>
    /// Исключение при несоответсвующем идентификаторе при запросе на получение категории
    /// </summary>
    public class CategoryIdNotValidException : BadRequestException
    {
        public CategoryIdNotValidException(string message) : base(message)
        {
        }
    }
}