

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Weather.Services.extensions;
using Weather.Services.Interface;


using IHost host = HostBuilderExtensions.BuildWeatherHost(args);

var weatherService = host.Services.GetRequiredService<IWeatherService>();

var result = await weatherService.RetreiveWeatherAsnc();



Console.WriteLine($"City: {result.Name}, Temp: {result.Main.Temp}°C");
Console.ReadKey();