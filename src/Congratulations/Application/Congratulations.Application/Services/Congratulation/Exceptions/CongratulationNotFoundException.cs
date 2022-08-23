using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions
{
    /// <summary>
    /// Исключение, когда объявление с таким идентификатором не найдено
    /// </summary>
    public sealed class CongratulationNotFoundException : NotFoundException
    {
        private const string MessageTemplate = "Объявление с таким ID[{0}] не было найдено.";
        public CongratulationNotFoundException(int? advertisementId) : base(string.Format(MessageTemplate, advertisementId))
        {
        }
    }
}