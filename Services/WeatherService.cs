using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using static client1.Models.WeatherModel;

namespace client1.Services
{
    public class WeatherService
    { 
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;
        public WeatherService(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _config = config;
        }

        public async Task<WeatherResponse> GetWeatherAsync(string location)
        {
            var client = _httpClientFactory.CreateClient();
            string apiKey = _config["ApiKey"];
            string requestUrl = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={location}&aqi=no";

            var response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            
            // read and deserialize
            var jsonString = await response.Content.ReadAsStringAsync();
            var weatherData = JsonSerializer.Deserialize<WeatherResponse>(jsonString);

            return weatherData;
        }
    }
}