namespace OtbasyBank.Shared.Exceptions;

/// <summary>
///     Базовое исключение, которая позволяет глобальному фильтру исключении обработать исключение и обернуть в конверт
///     WebResponse с кодом "HTTP 500 Internal Server Error"
/// </summary>
[Serializable]
public class InternalServerErrorException : Exception
{
    /// <summary>
    ///     Информация об ошибках.
    /// </summary>
    public IEnumerable<ErrorInfo>? ErrorInfos { get; }

    #region Constructors

    public InternalServerErrorException()
    {
    }

    public InternalServerErrorException(string message) : base(message)
    {
        ErrorInfos = new[] { new ErrorInfo(null, null, message) };
    }

    public InternalServerErrorException(string message, System.Exception inner) : base(message, inner)
    {
        ErrorInfos = new[] { new ErrorInfo(null, null, message) };
    }

    public InternalServerErrorException(string message, IEnumerable<ErrorInfo> errorInfos) : base(message)
    {
        ErrorInfos = errorInfos;
    }

    public InternalServerErrorException(string message, System.Exception inner, IEnumerable<ErrorInfo> errorInfos) :
        base(message, inner)
    {
        ErrorInfos = errorInfos;
    }

    #endregion
}
