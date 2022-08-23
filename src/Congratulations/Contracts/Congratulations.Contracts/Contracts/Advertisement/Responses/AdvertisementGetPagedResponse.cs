using Sev1.Congratulations.AppServices.Contracts.Congratulation;
using System.Collections.Generic;

namespace Sev1.Congratulations.Contracts.Contracts.GetPaged.Responses
{
    /// <summary>
    /// DTO ответа на запрос пагинации по объявлениям
    /// </summary>
    public sealed class CongratulationGetPagedResponse
    {
        /// <summary>
        /// Всего элементов
        /// </summary>
        public int? Total { get; set; }

        /// <summary>
        /// Количество элементов на странице
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Смещение (число элементов)
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// Список элементов
        /// </summary>
        public IEnumerable<CongratulationGetPagedDto> Items { get; set; }
    }
}