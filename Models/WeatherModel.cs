using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace client1.Models
{
    public class WeatherModel
    {
        public class WeatherResponse
        {
            [JsonPropertyName("location")]
            public Location? Location {get; set;}

            [JsonPropertyName("current")]
            public Current? Current {get;set;}
        }

        public class Location
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("region")]
            public string? Region { get; set; }

            [JsonPropertyName("country")]
            public string? Country { get; set; }

            [JsonPropertyName("lat")]
            public float Lat { get; set; }

            [JsonPropertyName("lon")]
            public float Lon { get; set; }

            [JsonPropertyName("tz_id")]
            public string? Timezone_id { get; set; }

            [JsonPropertyName("localtime")]
            public string? Localtime { get; set; }
        }

        public class Current
        {
            [JsonPropertyName("temp_c")]
            public float Temp_c { get; set; }

            [JsonPropertyName("temp_f")]
            public float Temp_f { get; set; }

            [JsonPropertyName("is_day")]
            public int Is_day { get; set; }

            [JsonPropertyName("wind_kph")]
            public float Wind_KPH {get; set;}

            [JsonPropertyName("wind_dir")]
            public string? Wind_Dir {get; set;}
            
            [JsonPropertyName("humidity")]
            public int Humidity {get; set;}

            [JsonPropertyName("condition")]
            public Condition? Condition {get; set;}
        }

        public class Condition
        {
            [JsonPropertyName("text")]
            public string? Text { get; set; }

            [JsonPropertyName("icon")]
            public string? Icon { get; set; }
        }
    }
}