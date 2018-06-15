using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Bestwise.WJCourt.Localization
{
    public static class WJCourtLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(WJCourtConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(WJCourtLocalizationConfigurer).GetAssembly(),
                        "Bestwise.WJCourt.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
