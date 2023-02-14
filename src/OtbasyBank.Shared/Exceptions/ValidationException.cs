namespace OtbasyBank.Shared.Exceptions;

/// <summary>
///     Исключение, которое возникает во время проверки полей данных.
/// </summary>
/// <remarks>
///     Позволяет глобальному фильтру исключении обработать исключение и обернуть в конверт WebResponse с кодом "HTTP
///     400 Bad Request"
/// </remarks>
[Serializable]
public class ValidationException : BadRequestException
{
    #region Constructors

    public ValidationException()
    {
    }

    public ValidationException(string message) : base(message)
    {
    }

    public ValidationException(string message, System.Exception inner) : base(message, inner)
    {
    }

    public ValidationException(string message, IEnumerable<ErrorInfo> errorInfos) : base(message, errorInfos)
    {
    }

    public ValidationException(string message, System.Exception inner, IEnumerable<ErrorInfo> errorInfos) : base(
        message, inner, errorInfos)
    {
    }

    #endregion
}
