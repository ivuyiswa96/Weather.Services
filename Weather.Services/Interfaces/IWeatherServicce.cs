using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Services.Models;

namespace Weather.Services.Interface
{
    public interface IWeatherService
    {

        Task<WeatherResponse> RetreiveWeatherAsnc();
      
    }
}
