using Sev1.Congratulations.Domain.Base.Exceptions.Base;

namespace Sev1.Congratulations.Domain.Base.Exceptions
{
    /// <summary>
    /// Несоответствующий запрос
    /// </summary>
    public class BadRequestException : DomainException
    {
        public BadRequestException(string message) : base(message)
        {
        }
    }
}