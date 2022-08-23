using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions
{
    /// <summary>
    /// Исключение при несоответсвующем запросе создания объвления
    /// </summary>
    public class CongratulationCreateDtoNotValidException : BadRequestException
    {
        public CongratulationCreateDtoNotValidException(string message) : base(message)
        {
        }
    }
}