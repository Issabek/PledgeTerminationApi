using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OtbasyBank.Api.Models.Common;

/// <summary>
/// Warning message model
/// </summary>
public class WarningMessage
{
    /// <summary>Unique request guid</summary>
    [JsonProperty("requestGuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestGuid { get; private set; }

    /// <summary>An application-specific error code.</summary>
    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; private set; }

    /// <summary>A short summary of the error.</summary>
    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; private set; }

    /// <summary>Explanation of the error.</summary>
    [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Detail { get; private set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="requestGuid"></param>
    /// <param name="code"></param>
    /// <param name="title"></param>
    /// <param name="detail"></param>
    public WarningMessage(string? requestGuid, string? code, string? title, string? detail)
    {
        Code = code;
        Title = title;
        Detail = detail;
        RequestGuid = requestGuid;
    }
}
