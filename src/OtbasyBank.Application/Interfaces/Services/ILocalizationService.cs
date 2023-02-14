using Microsoft.Extensions.Localization;

namespace OtbasyBank.Application.Interfaces.Services
{
    public interface ILocalizationService
    {
        LocalizedString this[string key] { get; }

        LocalizedString GetCulturedLocalizedString(string key, bool isRus);
        LocalizedString GetLocalizedString(string key);
        string GetLocalizedString(string key, params string[] parameters);
    }
}
