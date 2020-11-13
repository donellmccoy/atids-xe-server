using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFund.AtidsXe.Blazor.Server.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            return await Task.FromResult(Enumerable.Range(1, 500).Select(index => new WeatherForecast
            {
                Index = index,
                Date = startDate.AddDays(index).ToShortDateString(),
                TemperatureC = rng.Next(-20, 70),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
