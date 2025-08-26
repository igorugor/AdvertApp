using WeatherForecast.Application.Interfaces;
using WeatherForecast.Domain.Entities;

namespace WeatherForecast.Infrastructure.Persistence;

public class WeatherForecastRepository(WeatherForecastDbContext context) : IWeatherForecastRepository
{

    private IEnumerable<TWeatherForecast> GetWeatherForecastLocally() {
        return [.. Enumerable.Range(1, 5).Select(index => new TWeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })];
    }

    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];
    private readonly WeatherForecastDbContext _context = context;

    public async Task<IEnumerable<TWeatherForecast>> GetAllAsync()
    {
        return await Task.Run(GetWeatherForecastLocally);
    }
}
