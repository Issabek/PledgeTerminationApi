using Microsoft.AspNetCore.Http;
using OtbasyBank.Application.Interfaces.Sessions;
using Newtonsoft.Json;

namespace OtbasyBank.Infrastructure.Sessions;

public class SessionService : ISessionService
{
    /// <inheritdoc/>
    private readonly IHttpContextAccessor _httpContextAccessor;

    /// <inheritdoc/>
    public SessionService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
    }

    /// <inheritdoc/>
    public string GetCurrentSessionId => _httpContextAccessor.HttpContext.Session.Id;

    /// <inheritdoc/>
    public Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default)
    {
        return Task.Run(() =>
        {
            var value = Session.GetString(BuildKey(key));
            return value is null ? default : JsonConvert.DeserializeObject<T?>(value);
        }, cancellationToken);
    }

    /// <inheritdoc/>
    public Task SetAsync<T>(string key, T value, CancellationToken cancellationToken = default)
    {
        return Task.Run(() => Session.SetString(BuildKey(key), JsonConvert.SerializeObject(value)), cancellationToken);
    }

    /// <inheritdoc/>
    private ISession Session => _httpContextAccessor.HttpContext.Session;

    /// <inheritdoc/>
    private string BuildKey(string key)
    {
        return $"{GetCurrentSessionId}:{key}";
    }
}
