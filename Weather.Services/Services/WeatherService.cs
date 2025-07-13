using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Weather.Services.Interface;
using Weather.Services.Models;

namespace Weather.Services.Service
{
    public class WeatherService : IWeatherService
    {

        private readonly HttpClient _httpClient;
        private readonly OpenWeatherOptions _options;

        public WeatherService(HttpClient httpClient, IOptions<OpenWeatherOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;

            _httpClient.BaseAddress = new Uri(_options.Url);
        }
        public async Task<WeatherResponse> RetreiveWeatherAsnc()
        {
            var response = await _httpClient.GetAsync($"/data/2.5/weather?lat={_options.Lat}&lon={_options.Lon}&appid={_options.Key}&units={_options.Units}");

            var stringResult = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Fail to retrieve weather");
            }

            return JsonConvert.DeserializeObject<WeatherResponse>(stringResult);
        }

    }
}
