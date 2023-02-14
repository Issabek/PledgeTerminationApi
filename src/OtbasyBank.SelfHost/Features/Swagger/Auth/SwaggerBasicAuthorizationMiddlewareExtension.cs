namespace OtbasyBank.SelfHost.Features.Swagger.Auth
{
    /// <summary>
    /// The extension apply using swagger middlewares
    /// </summary>
    public static class SwaggerBasicAuthorizationMiddlewareExtension
    {
        /// <summary>
        /// method to inject middleware to project
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSwaggerBasicAuthorization(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SwaggerBasicAuthorizationMiddleware>();
        }
    }
}
