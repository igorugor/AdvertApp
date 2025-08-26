using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Features.GetWeatherForecasts;

namespace WeatherForecast.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(GetWeatherForecastsHandler handler) : ControllerBase
{
    private readonly GetWeatherForecastsHandler _handler = handler;

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get()
    {
        var forecasts = await _handler.Handle(new GetWeatherForecastsQuery());

        return Ok(forecasts);
    }
}
