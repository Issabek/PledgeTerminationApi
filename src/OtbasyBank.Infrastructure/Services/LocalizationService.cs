using Microsoft.Extensions.Localization;
using OtbasyBank.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace OtbasyBank.Infrastructure.Services
{

    public class LocalizationService : ILocalizationService
    {
        private readonly IStringLocalizer _localizer;

        public LocalizationService(IStringLocalizerFactory factory)
        {
            var type = typeof(Resource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("Resources.Resource", assemblyName.Name);
        }

        public LocalizedString this[string key] => _localizer[key];

        public LocalizedString GetLocalizedString(string key)
        {
            return _localizer[key];
        }

        public LocalizedString GetCulturedLocalizedString(string key, bool isRus)
        {
            var culture = isRus ? "ru" : "kk";
            CultureInfo cultureInfo = new CultureInfo(culture);
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
            return GetLocalizedString(key);
        }

        public string GetLocalizedString(string key, params string[] parameters)
        {
            return string.Format(_localizer[key], parameters);
        }
    }

}
