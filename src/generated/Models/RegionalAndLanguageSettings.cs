// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class RegionalAndLanguageSettings : Entity, IParsable 
    {
        /// <summary>Prioritized list of languages the user reads and authors in.Returned by default. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LocaleInfo>? AuthoringLanguages { get; set; }
#nullable restore
#else
        public List<LocaleInfo> AuthoringLanguages { get; set; }
#endif
        /// <summary>The  user&apos;s preferred user interface language (menus, buttons, ribbons, warning messages) for Microsoft web applications.Returned by default. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocaleInfo? DefaultDisplayLanguage { get; set; }
#nullable restore
#else
        public LocaleInfo DefaultDisplayLanguage { get; set; }
#endif
        /// <summary>The locale that drives the default date, time, and calendar formatting.Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocaleInfo? DefaultRegionalFormat { get; set; }
#nullable restore
#else
        public LocaleInfo DefaultRegionalFormat { get; set; }
#endif
        /// <summary>The language a user expected to use as input for text to speech scenarios.Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocaleInfo? DefaultSpeechInputLanguage { get; set; }
#nullable restore
#else
        public LocaleInfo DefaultSpeechInputLanguage { get; set; }
#endif
        /// <summary>The language a user expects to have documents, emails, and messages translated into.Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocaleInfo? DefaultTranslationLanguage { get; set; }
#nullable restore
#else
        public LocaleInfo DefaultTranslationLanguage { get; set; }
#endif
        /// <summary>Allows a user to override their defaultRegionalFormat with field specific formats.Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RegionalFormatOverrides? RegionalFormatOverrides { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RegionalFormatOverrides RegionalFormatOverrides { get; set; }
#endif
        /// <summary>The user&apos;s preferred settings when consuming translated documents, emails, messages, and websites.Returned by default. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TranslationPreferences? TranslationPreferences { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TranslationPreferences TranslationPreferences { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RegionalAndLanguageSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RegionalAndLanguageSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegionalAndLanguageSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"authoringLanguages", n => { AuthoringLanguages = n.GetCollectionOfObjectValues<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultDisplayLanguage", n => { DefaultDisplayLanguage = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"defaultRegionalFormat", n => { DefaultRegionalFormat = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"defaultSpeechInputLanguage", n => { DefaultSpeechInputLanguage = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"defaultTranslationLanguage", n => { DefaultTranslationLanguage = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"regionalFormatOverrides", n => { RegionalFormatOverrides = n.GetObjectValue<ApiSdk.Models.RegionalFormatOverrides>(ApiSdk.Models.RegionalFormatOverrides.CreateFromDiscriminatorValue); } },
                {"translationPreferences", n => { TranslationPreferences = n.GetObjectValue<ApiSdk.Models.TranslationPreferences>(ApiSdk.Models.TranslationPreferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<LocaleInfo>("authoringLanguages", AuthoringLanguages);
            writer.WriteObjectValue<LocaleInfo>("defaultDisplayLanguage", DefaultDisplayLanguage);
            writer.WriteObjectValue<LocaleInfo>("defaultRegionalFormat", DefaultRegionalFormat);
            writer.WriteObjectValue<LocaleInfo>("defaultSpeechInputLanguage", DefaultSpeechInputLanguage);
            writer.WriteObjectValue<LocaleInfo>("defaultTranslationLanguage", DefaultTranslationLanguage);
            writer.WriteObjectValue<ApiSdk.Models.RegionalFormatOverrides>("regionalFormatOverrides", RegionalFormatOverrides);
            writer.WriteObjectValue<ApiSdk.Models.TranslationPreferences>("translationPreferences", TranslationPreferences);
        }
    }
}