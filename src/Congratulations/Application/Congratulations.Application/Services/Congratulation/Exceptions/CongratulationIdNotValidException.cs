using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions
{
    /// <summary>
    /// Исключение при неправильном идентификаторе объявления
    /// </summary>
    public class CongratulationIdNotValidException : BadRequestException
    {
        public CongratulationIdNotValidException(string message) : base(message)
        {
        }
    }
}