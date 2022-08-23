using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions
{
    /// <summary>
    /// Исключение при нессответсвующем запросе на пагинацию
    /// </summary>
    public class CongratulationGetPagedRequestNotValidException : BadRequestException
    {
        public CongratulationGetPagedRequestNotValidException(string message) : base(message)
        {
        }
    }
}