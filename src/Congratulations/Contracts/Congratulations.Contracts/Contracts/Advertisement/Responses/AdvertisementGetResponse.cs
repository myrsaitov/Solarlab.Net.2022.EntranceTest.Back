using Sev1.Congratulations.Contracts.Enums;

namespace Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses
{
    /// <summary>
    /// DTO ответа на запрос объявления по идентификатору
    /// </summary>
    public sealed class CongratulationGetResponse
    {
        /// <summary>
        /// Id объявления
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Заголовок объявления
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Текст объявления
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Когда создано
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Id категории
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Статус объявления
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Таги в виде массива строк
        /// </summary>
        public string[] Tags { get; set; }
        
        /// <summary>
        /// Создатель объявления
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор региона
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// Статус объявления
        /// </summary>
        public CongratulationStatus Status { get; set; }

        /// <summary>
        /// Идентификаторы файлов
        /// </summary>
        public int?[] UserFiles { get; set; }
    }
}