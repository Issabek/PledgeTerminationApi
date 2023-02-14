namespace OtbasyBank.Domain.Exceptions;

public class HttpRequestTimeoutException : Exception
{
    public HttpRequestTimeoutException()
    {

    }

    public HttpRequestTimeoutException(string message)
        : base(message)
    {

    }
}
