using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Region.Exceptions
{
    /// <summary>
    /// Исключение при нессответсвующем запросе на пагинацию
    /// </summary>
    public class RegionGetPagedRequestNotValidException : BadRequestException
    {
        public RegionGetPagedRequestNotValidException(string message) : base(message)
        {
        }
    }
}