using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using OtbasyBank.Api.Models.Common;
using OtbasyBank.Application.Queries;
using OtbasyBank.Api.Models.Replies;
using OtbasyBank.Api.Models;

namespace OtbasyBank.Api.Controllers.Test;

/// <summary>
/// test weather rest api controller
/// </summary>
[ApiController]
[Route("api/weather")]
public class WeatherController : BaseController
{
    private readonly ILogger<WeatherController> _logger;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="logger"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public WeatherController(ILogger<WeatherController> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// method to retrieve test information about weather
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    [HttpGet("retrieve-weather-data")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericReply<IEnumerable<WeatherForecast>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(CommonReply))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(CommonReply))]
    public async Task<IActionResult> RetrieveWeather()
    {
        _logger.LogInformation("{msg}", "Start {RetrieveWeather} method...", nameof(RetrieveWeather));
        var query = new RetrieveWeatherInfoQuery();
        var reply = await Mediator.Send(query);
        var mappedReply = Mapper.Map<GenericReply<IEnumerable<WeatherForecast>>>(reply);
        _logger.LogInformation("{msg}", "Method {RetrieveWeather} success...", nameof(RetrieveWeather));
        return Ok(mappedReply);
    }
}
