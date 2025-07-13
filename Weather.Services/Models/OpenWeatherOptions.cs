using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Services.Models
{
    public class OpenWeatherOptions
    {
        public string Key { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Url { get; set; }
        public string Units { get; set; }
    }
}
