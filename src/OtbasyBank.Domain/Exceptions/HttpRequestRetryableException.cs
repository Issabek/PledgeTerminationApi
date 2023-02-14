namespace OtbasyBank.Domain.Exceptions;

public class HttpRequestRetryableException : Exception
{
    public HttpRequestRetryableException()
    {

    }

    public HttpRequestRetryableException(string message)
        : base(message)
    {

    }
}
