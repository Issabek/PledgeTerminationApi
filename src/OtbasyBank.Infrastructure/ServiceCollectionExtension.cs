using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using OtbasyBank.Application.Interfaces.Persistence;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Infrastructure.Sessions;
using OtbasyBank.Shared.Extensions.Options;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using OtbasyBank.Infrastructure.Persistance;
using OtbasyBank.Infrastructure.Services;
using OtbasyBank.Shared.Helpers;

namespace OtbasyBank.Infrastructure;

public static class ServiceCollectionExtension
{
    private static string key = "DCStrPN10012018";

    public static readonly string SECRET = "SLEDUYUSHII KTO POMENYAET ZDES CHTOTO DOLZHEN BUDET MNE OBED V VAHTANGURI";
    /// <summary>
    /// add infrastructure layer dependencies
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddHttpContextAccessor()
            .AddDistributedMemoryCache()
            .AddConfigurations(configuration)
            .AddSessions(configuration)
            .AddJWTAuthentication()
            .AddPersistence(configuration)
            .AddTransientServices()
            .AddScopedServices()
            .AddSingletonServices();
        return services;
    }

    /// <summary>
    /// inject sessions
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    private static IServiceCollection AddSessions(this IServiceCollection services,
        IConfiguration configuration)
    {
        var options = configuration.GetValidOptions<SessionOptions>(SessionOptions.SectionName);
        services.AddSession(configure =>
        {
            configure.Cookie.Name = options.Name;
#if !DEBUG
configure.Cookie.Domain = options.Domain;
#endif
            configure.Cookie.HttpOnly = options.HttpOnly;
            configure.Cookie.IsEssential = options.IsEssential;
            configure.IdleTimeout = options.GetIdleTimeout();
        });
        return services;
    }

    /// <summary>
    /// inject persistence
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    private static IServiceCollection AddPersistence(this IServiceCollection services,
        IConfiguration configuration)
    {
        var isTest = configuration["ServiceBus:IsTest"]=="Test";

        services.AddDbContext<InternetBankingContext>(options =>
        {
            if (isTest)
            {
                options.UseSqlServer(configuration.GetConnectionString("OnlineBank"),
                    sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly(typeof(ServiceCollectionExtension).GetTypeInfo()
                            .Assembly.GetName().Name);
                        sqlOptions.EnableRetryOnFailure(
                            3,
                            TimeSpan.FromSeconds(10),
                            null);
                    });
            }
            else
            {
                options.UseSqlServer(Crypt.Decrypt(configuration.GetConnectionString("OnlineBank"), key),
                   sqlOptions =>
                   {
                       sqlOptions.MigrationsAssembly(typeof(ServiceCollectionExtension).GetTypeInfo()
                           .Assembly.GetName().Name);
                       sqlOptions.EnableRetryOnFailure(
                           3,
                           TimeSpan.FromSeconds(10),
                           null);
                   });
            }
        });

        services.AddScoped<IInternetBankingContext, InternetBankingContext>();

        return services;
    }

    /// <summary>
    /// inject singleton configurations
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    private static IServiceCollection AddConfigurations(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }

    /// <summary>
    /// inject transient lifecycle services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    private static IServiceCollection AddTransientServices(this IServiceCollection services)
    {

        return services;
    }

    /// <summary>
    /// inject scope lifecycle services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    private static IServiceCollection AddScopedServices(this IServiceCollection services)
    {
        services.AddScoped<IBusService, BusService>();
        services.AddScoped<IPledgeTerminatorUserService, PledgeTerminatorUserService>();
        services.AddScoped<IPledgeTerminatorService, PledgeTerminatorService>();
        services.AddScoped<ISignService, SignService>();
        services.AddScoped<ILocalizationService, LocalizationService>();
        return services;
    }

    /// <summary>
    /// inject singleton lifecycle services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    private static IServiceCollection AddSingletonServices(this IServiceCollection services)
    {

        return services;
    }

    /// <summary>
    /// inject singleton lifecycle services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    private static IServiceCollection AddJWTAuthentication(this IServiceCollection services)
    {

        var key = Encoding.ASCII.GetBytes(SECRET);

        services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = true;
            x.SaveToken = true;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
        return services;
    }
}
