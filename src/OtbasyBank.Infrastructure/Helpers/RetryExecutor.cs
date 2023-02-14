using Microsoft.Extensions.Configuration;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Exceptions;
using OtbasyBank.Infrastructure.Services;

namespace OtbasyBank.Infrastructure.Helpers;

public class RetryExecutor
{
    private readonly IBusService _busService;

    public RetryExecutor(IBusService busService)
    {
        _busService = busService ?? throw new ArgumentNullException(nameof(busService));
    }
    public void Retry(Action action, int maxRetries, int interval)
    {
        Retry<object>(() =>
        {
            action();
            return null;
        }, maxRetries, interval);
    }

    public T Retry<T>(Func<T> logic, int maxRetries, int interval)
    {
        int attempts = 0;
        T retval = default(T);
        do
        {
            try
            {
                attempts++;
                retval = logic();
                break;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Токен недействителен!") || ex.Message.Contains("Не корректный Токен"))
                    _busService.UpdateToken();
                if (attempts == maxRetries)
                {
                    break;
                }
                else
                {
                    Task.Delay(TimeSpan.FromSeconds(interval)).GetAwaiter().GetResult();
                }
            }
        }
        while (attempts < maxRetries);
        return retval;
    }
}
