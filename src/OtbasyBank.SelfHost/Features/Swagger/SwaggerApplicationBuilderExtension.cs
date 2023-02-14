using Microsoft.AspNetCore.Mvc.ApiExplorer;
using OtbasyBank.SelfHost.Features.Swagger.Auth;

namespace OtbasyBank.SelfHost.Features.Swagger;

internal static class SwaggerApplicationBuilderExtension
{
    public static IApplicationBuilder UseSwagger(this IApplicationBuilder app,
            IApiVersionDescriptionProvider apiVersionDescriptionProvider)
    {
        app.UseSwaggerBasicAuthorization();
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
            {
                options.SwaggerEndpoint($"{description.GroupName}/swagger.json",
                    description.GroupName.ToUpperInvariant());
                options.RoutePrefix = SwaggerConstants.SwaggerRoutePrefix;
            }
        });

        return app;
    }
}
