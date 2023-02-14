using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OtbasyBank.Application.Behaviours;
using System.Reflection;

namespace OtbasyBank.Application;

public static class ServiceCollectionExtension
{
    /// <summary>
    /// inject application layer dependencies
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidatorBehaviour<,>));

        return services;
    }
}
