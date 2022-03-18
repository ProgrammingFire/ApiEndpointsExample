namespace WithEndpoints.Endpoints.WeatherForecast;

public class GetWeatherForecastEndpoint : EndpointBaseSync
    .WithoutRequest
    .WithActionResult<Shared.Models.WeatherForecast>
{
    private readonly WeatherForecastService _weatherForecastService;
    private readonly ILogger _logger;

    public GetWeatherForecastEndpoint(WeatherForecastService weatherForecastService, ILogger logger)
    {
        _weatherForecastService = weatherForecastService;
        _logger = logger;
    }

    [HttpGet("/Api/WeatherForecast")]
    public override ActionResult<Shared.Models.WeatherForecast> Handle()
    {
        var result = _weatherForecastService.Get();
        return Ok(result);
    }
}