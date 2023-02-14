using OtbasyBank.Domain.Common;

namespace OtbasyBank.Domain.Replies;

public class GenericReply<T> : CommonReply
    where T : class
{
    public T? Data { get; private set; }

    public GenericReply()
    {
        Data = null;
    }

    public GenericReply(T? data)
    {
        Data = data;
    }

    public void Add(T? data)
    {
        Data = data;
    }
}
