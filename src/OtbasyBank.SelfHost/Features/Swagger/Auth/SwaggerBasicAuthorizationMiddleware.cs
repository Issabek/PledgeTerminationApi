using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace OtbasyBank.SelfHost.Features.Swagger.Auth;

/// <summary>
/// Middleware to authorize in swagger
/// </summary>
public class SwaggerBasicAuthorizationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly SwaggerCredentialsOptions _options;

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="next"></param>
    /// <param name="options"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public SwaggerBasicAuthorizationMiddleware(RequestDelegate next, SwaggerCredentialsOptions options)
    {
        _next = next;
        _options = options ?? throw new ArgumentNullException(nameof(options));
    }

    /// <summary>
    /// method start middleware
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Path.Value == null || context.Request.Path.Value.Contains("swagger") == false)
        {
            await _next(context);
            return;
        }

        string authorizationHeader = context.Request.Headers["Authorization"];

        if (AuthorizationIsValid(authorizationHeader))
        {
            await _next(context);
            return;
        }

        ReturnUnauthorizedResult(context);
    }

    private bool AuthorizationIsValid(string authorizationHeader)
    {
        if (string.IsNullOrEmpty(authorizationHeader))
        {
            return false;
        }

        var authorizationHeaderValue = AuthenticationHeaderValue.Parse(authorizationHeader);

        if (!authorizationHeaderValue.Scheme.Equals(AuthenticationSchemes.Basic.ToString(),
            StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var credentials = Encoding.UTF8
            .GetString(Convert.FromBase64String(authorizationHeaderValue.Parameter ?? string.Empty))
            .Split(':', 2);

        if (credentials.Length != 2)
        {
            return false;
        }

        return _options.UserName.Equals(credentials[0]) &&
               _options.Password.Equals(credentials[1]);
    }

    private static void ReturnUnauthorizedResult(HttpContext context)
    {
        context.Response.Headers["WWW-Authenticate"] = "Basic realm=OtbasyBank";
        context.Response.StatusCode = 401;
    }
}
