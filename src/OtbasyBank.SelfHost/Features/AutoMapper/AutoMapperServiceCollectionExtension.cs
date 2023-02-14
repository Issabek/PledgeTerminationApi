using OtbasyBank.Api.Controllers;

namespace OtbasyBank.SelfHost.Features.AutoMapper;

public static class AutoMapperServiceCollectionExtension
{
    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(BaseController).Assembly);

        return services;
    }
}
