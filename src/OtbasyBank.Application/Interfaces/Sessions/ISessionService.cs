namespace OtbasyBank.Application.Interfaces.Sessions;

/// <summary>
///     service to manage sessions.
/// </summary>
public interface ISessionService
{
    /// <summary>
    ///     get the current session id.
    /// </summary>
    string GetCurrentSessionId { get; }

    /// <summary>
    ///     add data to session by id.
    /// </summary>
    Task SetAsync<T>(string key, T data, CancellationToken cancellationToken = default);

    /// <summary>
    ///     get data from session by id.
    /// </summary>
    Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default);
}
