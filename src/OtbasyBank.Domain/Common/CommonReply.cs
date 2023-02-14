using Newtonsoft.Json;

namespace OtbasyBank.Domain.Common;

public abstract class CommonReply
{
    [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ErrorMessage>? Errors { get; private set; } = null;

    [JsonProperty("warnings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WarningMessage>? Warnings { get; private set; } = null;

    public bool IsSuccess => !Errors?.Any() ?? true;

    public void AddError(ErrorMessage error)
    {
        Errors?.Add(error);
    }

    public void AddErrors(IList<ErrorMessage> errors)
    {
        foreach (var error in errors)
            Errors?.Add(error);
    }

    public void AddError(Exception ex)
    {
        Errors ??= new List<ErrorMessage>();
        foreach (var error in GetStackTrace(ex))
            Errors?.Add(error);
    }

    public void AddWarning(WarningMessage warning)
    {
        Warnings?.Add(warning);
    }

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

        return GetStackTrace(ex.InnerException, errors);
    }
}
