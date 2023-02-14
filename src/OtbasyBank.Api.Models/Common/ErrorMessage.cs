using Newtonsoft.Json;

namespace OtbasyBank.Api.Models.Common;

/// <summary>
/// Error message model
/// </summary>
public class ErrorMessage : WarningMessage
{
    /// <summary>HTTP status code associated.</summary>
    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; private set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="requestGuid"></param>
    /// <param name="status"></param>
    /// <param name="code"></param>
    /// <param name="title"></param>
    /// <param name="detail"></param>
    public ErrorMessage(string? requestGuid, string? status, string? code, string? title, string? detail)
        : base(requestGuid, code, title, detail)
    {
        Status = status;
    }
}
