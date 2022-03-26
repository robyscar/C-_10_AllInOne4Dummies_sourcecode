using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 10).Select(index => GetWeatherForecast())
            .ToArray();
        }

        private int DaysToAdd = 0;

        public WeatherForecast GetWeatherForecast()
        {
            var rng = new Random();

            WeatherForecast thisForecast = new WeatherForecast();
            thisForecast.Date = DateTime.Now.AddDays(DaysToAdd);
            DaysToAdd += 1;
            thisForecast.TemperatureC = rng.Next(-20, 40);
            switch(thisForecast.TemperatureC)
            {
                case int n when (n < -14): 
                    thisForecast.Summary = Summaries[0];
                    break;
                case int n when (n >= -14 && n < -7):
                    thisForecast.Summary = Summaries[1];
                    break;
                case int n when (n >= -7 && n < 0):
                    thisForecast.Summary = Summaries[2];
                    break;
                case int n when (n >= 0 && n < 6):
                    thisForecast.Summary = Summaries[3];
                    break;
                case int n when (n >= 6 && n < 12):
                    thisForecast.Summary = Summaries[4];
                    break;
                case int n when (n >= 12 && n < 18):
                    thisForecast.Summary = Summaries[5];
                    break;
                case int n when (n >= 18 && n < 24):
                    thisForecast.Summary = Summaries[6];
                    break;
                case int n when (n >= 24 && n < 30):
                    thisForecast.Summary = Summaries[7];
                    break;
                case int n when (n >= 30 && n < 36):
                    thisForecast.Summary = Summaries[8];
                    break;
                case int n when (n >= 36):
                    thisForecast.Summary = Summaries[9];
                    break;
            }

            return thisForecast;
        }
    }
}
