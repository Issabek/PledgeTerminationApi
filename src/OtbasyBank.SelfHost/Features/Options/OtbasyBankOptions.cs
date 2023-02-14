namespace OtbasyBank.SelfHost.Features.Options;

public class OtbasyBankOptions
{
    public const string SectionName = "OtbasyBankOptions";

    public string InstanceName { get; }
    public string WebAddress { get; }

    public OtbasyBankOptions(string instanceName, string webAddress)
    {
        InstanceName = instanceName ?? throw new ArgumentNullException(nameof(instanceName));
        WebAddress = webAddress ?? throw new ArgumentNullException(nameof(webAddress));
    }
}
