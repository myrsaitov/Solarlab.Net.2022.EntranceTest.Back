using Sev1.Congratulations.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests
{
    /// <summary>
    /// DTO запроса на обновление статуса объявления
    /// </summary>
    public sealed class CongratulationUpdateStatusRequest
    {
        /// <summary>
        /// Id объявления
        /// </summary>
        [Required]
        [Range(1, 100_000_000_000, ErrorMessage = "Значение Id должно быть от 1 до 100_000_000_000")]
        public int? Id { get; set; }

        /// <summary>
        /// Статус объявления
        /// </summary>
        [Required]
        public CongratulationStatus Status { get; set; }
    }
}