namespace OtbasyBank.Domain.Exceptions;

public class OtbasyBankNoClassifiedException : Exception
{
    public OtbasyBankNoClassifiedException()
    { }

    public OtbasyBankNoClassifiedException(string message)
        : base(message)
    {

    }
}
