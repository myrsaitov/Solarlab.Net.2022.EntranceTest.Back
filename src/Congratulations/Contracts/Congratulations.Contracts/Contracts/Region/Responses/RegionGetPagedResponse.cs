using System.Collections.Generic;

namespace Sev1.Congratulations.Contracts.Contracts.Region.Responses
{
    /// <summary>
    /// DTO ответа на запрос пагинации по тагам
    /// </summary>
    public sealed class RegionGetPagedResponse
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
        public IEnumerable<RegionGetResponse> Items { get; set; }
    }
}