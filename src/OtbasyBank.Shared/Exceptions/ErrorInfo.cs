namespace OtbasyBank.Shared.Exceptions;

/// <summary>
///     Информация об ошибке.
/// </summary>
[Serializable]
public class ErrorInfo
{
    /// <summary>
    ///     Конструктор
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <param name="params">Параметр.</param>
    /// <param name="message">Дополнительный текст ошибки.</param>
    public ErrorInfo(string? key, object? @params, string message)
    {
        Key = key;
        Params = @params;
        Message = message;
    }

    /// <summary>
    ///     Ключ.
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    ///     Параметр.
    /// </summary>
    public object? Params { get; set; }

    /// <summary>
    ///     Дополнительный текст ошибки.
    /// </summary>
    public string Message { get; set; }
}
