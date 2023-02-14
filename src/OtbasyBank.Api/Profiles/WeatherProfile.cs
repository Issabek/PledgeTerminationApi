using AutoMapper;
using OtbasyBank.Api.Models;

namespace OtbasyBank.Api.Profiles;

/// <summary>
/// AutoMapper profile
/// </summary>
public class WeatherProfile : Profile
{
    /// <summary>
    /// constructor
    /// </summary>
    public WeatherProfile()
    {
        CreateMap<WeatherForecast, Domain.WeatherForecast>()
            .ReverseMap();
    }
}
