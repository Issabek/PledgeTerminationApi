using Newtonsoft.Json;

namespace OtbasyBank.Api.Models.Common;

/// <summary>
/// Common reply model
/// </summary>
public abstract class CommonReply
{
    /// <summary>error messages</summary>
    [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ErrorMessage>? Errors { get; private set; } = null;

    /// <summary>warning messages</summary>
    [JsonProperty("warnings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WarningMessage>? Warnings { get; private set; } = null;

    /// <summary>success status</summary>
    public bool IsSuccess => !Errors?.Any() ?? true;

    /// <summary>method adds new error</summary>
    public void AddError(ErrorMessage error)
    {
        Errors?.Add(error);
    }

    /// <summary>method adds new error list</summary>
    public void AddErrors(IList<ErrorMessage> errors)
    {
        foreach (var error in errors)
            Errors?.Add(error);
    }

    /// <summary>method adds new error from exception</summary>
    public void AddError(Exception ex)
    {
        foreach (var error in GetStackTrace(ex))
            Errors?.Add(error);
    }

    /// <summary>method adds new warning</summary>
    public void AddWarning(WarningMessage warning)
    {
        Warnings?.Add(warning);
    }

    /// <summary>method clears the lists</summary>
    public void Clear()
    {
        Errors = null;
        Warnings = null;
    }

    private IList<ErrorMessage> GetStackTrace(Exception? ex, IList<ErrorMessage>? errors = null)
    {
        if (errors is null)
            errors = new List<ErrorMessage>();

        if (ex is null)
            return errors;

        errors.Add(new ErrorMessage(
            requestGuid: null,
            status: null,
            code: ex.Source,
            title: "error",
            detail: ex.Message));

        return GetStackTrace(ex, errors);
    }
}
