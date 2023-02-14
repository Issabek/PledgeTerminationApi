using AutoMapper;
using OtbasyBank.Api.Models;
using OtbasyBank.Api.Models.Replies;

namespace OtbasyBank.Api.Profiles;

/// <summary>
/// AutoMapper profile
/// </summary>
public class ReplyProfile : Profile
{
    /// <summary>
    /// Start mapping
    /// </summary>
    public ReplyProfile()
    {
        CreateMap<GenericReply<IEnumerable<WeatherForecast>>,
            Domain.Replies.GenericReply<IEnumerable<Domain.WeatherForecast>>>()
            .ReverseMap();
    }
}
