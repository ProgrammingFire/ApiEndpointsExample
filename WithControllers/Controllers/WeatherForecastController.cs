using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace WithControllers.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
	private readonly ILogger<WeatherForecastController> _logger;
	private readonly WeatherForecastService _weatherForecastService;

	public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService weatherForecastService)
	{
		_logger = logger;
		_weatherForecastService = weatherForecastService;
	}

	[HttpGet(Name = "GetWeatherForecast")]
	public IEnumerable<WeatherForecast> Get()
	{
		return _weatherForecastService.Get().ToArray();
	}
}
