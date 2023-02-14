namespace OtbasyBank.Shared.Exceptions;

/// <summary>
///     Базовое исключение, которая позволяет глобальному фильтру исключении обработать исключение и обернуть в конверт
///     WebResponse с кодом "HTTP 400 Bad Request"
/// </summary>
[Serializable]
public class BadRequestException : Exception
{
    /// <summary>
    ///     Информация об ошибках
    /// </summary>
    public IEnumerable<ErrorInfo>? ErrorInfos { get; }

    #region Constructors

    public BadRequestException()
    {
    }

    public BadRequestException(string message) : base(message)
    {
        ErrorInfos = new[] { new ErrorInfo(null, null, message) };
    }

    public BadRequestException(string message, System.Exception inner) : base(message, inner)
    {
        ErrorInfos = new[] { new ErrorInfo(null, null, message) };
    }

    public BadRequestException(string message, IEnumerable<ErrorInfo> errorInfos) : base(message)
    {
        ErrorInfos = errorInfos;
    }

    public BadRequestException(string message, System.Exception inner, IEnumerable<ErrorInfo> errorInfos) : base(
        message, inner)
    {
        ErrorInfos = errorInfos;
    }

    #endregion
}
