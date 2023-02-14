using Microsoft.AspNetCore.Mvc.Filters;

namespace OtbasyBank.SelfHost.Features.Filters;

/// <summary>
/// http global exception filter
/// </summary>
public class HttpGlobalExceptionFilter : IExceptionFilter
{
    private readonly IDictionary<Type, Action<ExceptionContext>> _exceptionHandlers;

    /// <summary>
    /// constructor
    /// </summary>
    public HttpGlobalExceptionFilter()
    {
        _exceptionHandlers = new Dictionary<Type, Action<ExceptionContext>>();
    }

    /// <summary>
    /// on exception method
    /// </summary>
    /// <param name="context"></param>
    public void OnException(ExceptionContext context)
    {
        HandleException(context);
    }

    /// <summary>
    /// method to handle different global exceptions
    /// </summary>
    /// <param name="context"></param>
    private void HandleException(ExceptionContext context)
    {
        context.ExceptionHandled = true;
    }
}
