using Microsoft.Extensions.Options;
using Weather.Services.Interface;
using Weather.Services.Models;
using Weather.Services.Service;
using Xunit;

namespace Weather.Services.Integration.Tests
{
    public class WeatherServiceIntegrationTests
    {
        private readonly IWeatherService _weatherService;

        public WeatherServiceIntegrationTests()
        {
            var options = Options.Create(new OpenWeatherOptions
            {
                Url = "https://api.openweathermap.org",
                Lat = 37.7749,
                Lon = -122.4194,
                Key = "0b586f7faccd6ceaadbf5f27746f5a1b",
                Units = "metric"
            });

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(options.Value.Url)
            };

            _weatherService = new WeatherService(httpClient, options);
        }

        [Fact]
        public async Task RetreiveWeatherAsnc_ReturnsValidWeatherResponse()
        {
            var result = await _weatherService.RetreiveWeatherAsnc();

            Assert.NotNull(result);
            Assert.NotNull(result.Main);
            Assert.NotNull(result.Weather);
            Assert.NotEmpty(result.Weather);
            Assert.InRange(result.Main.Temp, -100, 60);
            Assert.False(string.IsNullOrWhiteSpace(result.Weather[0].Description));

            Console.WriteLine($"Temperature: {result.Main.Temp}°C");
            Console.WriteLine($"Weather: {result.Weather[0].Description}");
        }
    }
}
