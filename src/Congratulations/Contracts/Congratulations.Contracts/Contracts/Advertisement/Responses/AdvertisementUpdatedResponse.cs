using Sev1.Congratulations.Contracts.Enums;

namespace Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses
{
    /// <summary>
    /// DTO ответа на запрос обновления объявления
    /// </summary>
    public sealed class CongratulationUpdatedResponse
    {
        /// <summary>
        /// Статус объявления
        /// </summary>
        public CongratulationStatus Status { get; set; }
    }
}