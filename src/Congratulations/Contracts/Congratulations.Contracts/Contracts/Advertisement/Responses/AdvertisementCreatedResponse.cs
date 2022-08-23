namespace Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses
{
    /// <summary>
    /// DTO ответа на запрос создания нового объявления
    /// </summary>
    public sealed class CongratulationCreatedResponse
    {
        /// <summary>
        /// Id объявления
        /// </summary>
        public int? Id { get; set; }
    }
}