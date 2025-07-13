using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Weather.Services.Interface;
using Weather.Services.Models;
using Weather.Services.Service;


namespace Weather.Services.extensions
{
    internal static class HostBuilderExtensions
    {
        public static IHost BuildWeatherHost(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                 .ConfigureAppConfiguration((context, config) =>
                 {
                     config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                 })
                 .ConfigureServices((context, services) =>
                 {
                     services.Configure<OpenWeatherOptions>(
                         context.Configuration.GetSection("WeatherSettings"));

                     services.AddHttpClient<IWeatherService, WeatherService>();
                 })
                 .Build();
        }
    }
}
