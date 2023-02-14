namespace OtbasyBank.Shared.Exceptions;

/// <summary>
///     Исключение, которое возникает в предметной области.
/// </summary>
/// <remarks>
///     Позволяет глобальному фильтру исключении обработать исключение и обернуть в конверт WebResponse с кодом "HTTP
///     400 Bad Request"
/// </remarks>
[Serializable]
public class DomainException : BadRequestException
{
    #region Constructors

    public DomainException()
    {
    }

    public DomainException(string message) : base(message)
    {
    }

    public DomainException(string message, System.Exception inner) : base(message, inner)
    {
    }

    public DomainException(string message, IEnumerable<ErrorInfo> errorInfos) : base(message, errorInfos)
    {
    }

    public DomainException(string message, System.Exception inner, IEnumerable<ErrorInfo> errorInfos) : base(
        message, inner, errorInfos)
    {
    }

    #endregion
}
