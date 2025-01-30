using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using client1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace client1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;
        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;   
        }

        [HttpGet("{location}")]
        public async Task<IActionResult> Get(string location)
        {
            var data = await _weatherService.GetWeatherAsync(location);
            return Ok(data);
        }
    }
}