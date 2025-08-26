using WeatherForecast.Domain.Entities;
using WeatherForecast.Application.Interfaces;

namespace WeatherForecast.Application.Features.GetWeatherForecasts;

public class GetWeatherForecastsHandler
{
    private readonly IWeatherForecastRepository _repository;

    public GetWeatherForecastsHandler(IWeatherForecastRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<TWeatherForecast>> Handle(GetWeatherForecastsQuery query)
    {
        return await _repository.GetAllAsync();
    }
}
