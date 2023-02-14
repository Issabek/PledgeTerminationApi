using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace OtbasyBank.SelfHost.Features.Swagger;

public class SwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly ILogger<SwaggerOptions> _logger;
    private readonly IApiVersionDescriptionProvider _apiProvider;

    public SwaggerOptions(ILogger<SwaggerOptions> logger, IApiVersionDescriptionProvider apiProvider)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _apiProvider = apiProvider ?? throw new ArgumentNullException(nameof(apiProvider));
    }

    public void Configure(SwaggerGenOptions options)
    {
        // Add a swagger document for each discovered API version.
        // Note: you might choose to skip or document deprecated API versions differently.
        foreach (var description in _apiProvider.ApiVersionDescriptions)
            try
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
            catch (Exception)
            {
                // ignored
            }
    }

    private OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
    {
        var info = new OpenApiInfo
        {
            Title = "Otbasy bank service API.",
            Version = GetAssemblyVersion(),
            Description = GetSwaggerDescription()
        };

        if (description.IsDeprecated)
        {
            info.Description += " This API version has been deprecated.";
        }

        return info;
    }

    private static string GetAssemblyVersion()
    {
        return Assembly.GetEntryAssembly()
            ?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            ?.InformationalVersion ?? "undefined";
    }

    private string GetSwaggerDescription()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "SwaggerDescription.xml");
        try
        {
            return File.ReadAllText(path);
        }
        catch (Exception)
        {
            _logger.LogError("Failed to read swagger description. Path: {Path}", path);
            return string.Empty;
        }
    }
}
