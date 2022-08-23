using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions
{
    /// <summary>
    /// Исключение при несоответсвующем запросе обновления
    /// </summary>
    public class CongratulationUpdateRequestNotValidException : BadRequestException
    {
        public CongratulationUpdateRequestNotValidException(string message) : base(message)
        {
        }
    }
}