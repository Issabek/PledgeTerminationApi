using Microsoft.AspNetCore.Mvc.ApiExplorer;
using OtbasyBank.SelfHost.Features.Swagger;

namespace OtbasyBank.SelfHost.Features.DeveloperMode;

/// <summary>
/// use settings if developer mode.
/// </summary>
public static class AppDeveloperModeExtension
{
    /// <summary>
    /// apply settings for application developoer mode.
    /// </summary>
    /// <param name="app"></param>
    /// <param name="provider"></param>
    public static void UseDeveloperMode(this WebApplication app,
        IApiVersionDescriptionProvider provider)
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger(provider);
    }
}
