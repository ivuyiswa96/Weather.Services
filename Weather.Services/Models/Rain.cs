
using System.Text.Json.Serialization;


namespace Weather.Services.Models
{
    public class Rain
    {

        [JsonPropertyName("1h")]
        public double OneHour { get; set; }
    }
}
