using OtbasyBank.Api.Models.Common;

namespace OtbasyBank.Api.Models.Replies;

/// <summary>
/// weather forecast reply
/// </summary>
public class GenericReply<T> : CommonReply
    where T : class
{
    /// <summary>
    /// weather forecast collection
    /// </summary>
    public T? Data { get; private set; }

    /// <summary>
    /// null constructor
    /// </summary>
    public GenericReply()
    {
        Data = null;
    }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="data"></param>
    public GenericReply(T? data)
    {
        Data = data;
    }

    /// <summary>
    /// Add data to response body
    /// </summary>
    /// <param name="data"></param>
    public void Add(T? data)
    {
        Data = data;
    }
}
