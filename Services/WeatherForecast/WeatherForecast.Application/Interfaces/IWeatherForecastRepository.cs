using WeatherForecast.Domain.Entities;

namespace WeatherForecast.Application.Interfaces;

public interface IWeatherForecastRepository
{
    Task<IEnumerable<TWeatherForecast>> GetAllAsync();
}