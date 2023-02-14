using Newtonsoft.Json;

namespace OtbasyBank.Domain.Common;

/// <summary>
/// Error message.
/// </summary>
public class ErrorMessage : WarningMessage
{
    /// <summary>HTTP status code associated.</summary>
    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; private set; }

    public ErrorMessage(string? requestGuid, string? status, string? code, string? title, string? detail)
        : base(requestGuid, code, title, detail)
    {
        Status = status;
    }
}
