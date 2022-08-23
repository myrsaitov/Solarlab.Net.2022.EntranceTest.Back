using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses;
using System;

namespace Sev1.Avdertisements.Contracts.ApiClients.CongratulationValidate
{
    public sealed partial class CongratulationValidateApiClient : ICongratulationValidateApiClient
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;

        public CongratulationValidateApiClient(
            IConfiguration configuration,
            IHttpClientFactory clientFactory)
        {
            _configuration = configuration;
            _clientFactory = clientFactory;
        }

        /// <summary>
        /// Проверяет, существует ли объявление 
        /// с таким идентификатором,
        /// а также, является ли текущий пользователь
        /// владельцем этого объявления
        /// </summary>
        /// <param name="advertisementId">Идентификатор объявления, которое проверяем</param>
        /// <param name="ownerId">Идентификатор владельца объявления</param>
        /// <returns></returns>
        public async Task<bool> CongratulationValidate(
            int? advertisementId,
            string ownerId)
        {
            // Считыватем URI запроса из конфига "appsettings.json"
            string uri = _configuration["CongratulationValidateApiClientUri"] + advertisementId.ToString();
            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new Exception("API-клиент: адрес не задан");
            }

            // Создание клиента
            var client = _clientFactory.CreateClient();

            // Выполнение GET-запроса
            HttpResponseMessage response = await client.GetAsync(uri);

            // Преобразование в json
            string responseJson = await response.Content.ReadAsStringAsync();

            // Конвертируем JSON в DTO
            var advertisementDto = JsonConvert
                .DeserializeObject<CongratulationGetResponse>(responseJson);

            // Логика проверки объявления на соответствие
            if (advertisementDto.OwnerId == ownerId)
            {
                // Если Id пользователей совпадает, то проверка пройдена
                return true;
            }
            else
            {
                // Иначе - не достаточно прав!
                throw new Exception("Не достаточно прав!");
            }
        }
    }
}