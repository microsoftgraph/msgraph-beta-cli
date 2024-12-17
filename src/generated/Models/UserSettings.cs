// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UserSettings : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The user&apos;s settings for the visibility of merge suggestion for the duplicate contacts in the user&apos;s contact list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ContactMergeSuggestions? ContactMergeSuggestions { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ContactMergeSuggestions ContactMergeSuggestions { get; set; }
#endif
        /// <summary>Reflects the Office Delve organization level setting. When set to true, the organization doesn&apos;t have access to Office Delve. This setting is read-only and can only be changed by administrators in the SharePoint admin center.</summary>
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
        /// <summary>When set to true, documents in the user&apos;s Office Delve are disabled. Users can control this setting in Office Delve.</summary>
        public bool? ContributionToContentDiscoveryDisabled { get; set; }
        /// <summary>The user&apos;s settings for the visibility of meeting hour insights, and insights derived between a user and other items in Microsoft 365, such as documents or sites. Get userInsightsSettings through this navigation property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.UserInsightsSettings? ItemInsights { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.UserInsightsSettings ItemInsights { get; set; }
#endif
        /// <summary>The user&apos;s preferences for languages, regional locale and date/time formatting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RegionalAndLanguageSettings? RegionalAndLanguageSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RegionalAndLanguageSettings RegionalAndLanguageSettings { get; set; }
#endif
        /// <summary>The shift preferences for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ShiftPreferences? ShiftPreferences { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ShiftPreferences ShiftPreferences { get; set; }
#endif
        /// <summary>The storage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.UserStorage? Storage { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.UserStorage Storage { get; set; }
#endif
        /// <summary>The Windows settings of the user stored in the cloud.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsSetting>? Windows { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsSetting> Windows { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UserSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contactMergeSuggestions", n => { ContactMergeSuggestions = n.GetObjectValue<global::ApiSdk.Models.ContactMergeSuggestions>(global::ApiSdk.Models.ContactMergeSuggestions.CreateFromDiscriminatorValue); } },
                { "contributionToContentDiscoveryAsOrganizationDisabled", n => { ContributionToContentDiscoveryAsOrganizationDisabled = n.GetBoolValue(); } },
                { "contributionToContentDiscoveryDisabled", n => { ContributionToContentDiscoveryDisabled = n.GetBoolValue(); } },
                { "itemInsights", n => { ItemInsights = n.GetObjectValue<global::ApiSdk.Models.UserInsightsSettings>(global::ApiSdk.Models.UserInsightsSettings.CreateFromDiscriminatorValue); } },
                { "regionalAndLanguageSettings", n => { RegionalAndLanguageSettings = n.GetObjectValue<global::ApiSdk.Models.RegionalAndLanguageSettings>(global::ApiSdk.Models.RegionalAndLanguageSettings.CreateFromDiscriminatorValue); } },
                { "shiftPreferences", n => { ShiftPreferences = n.GetObjectValue<global::ApiSdk.Models.ShiftPreferences>(global::ApiSdk.Models.ShiftPreferences.CreateFromDiscriminatorValue); } },
                { "storage", n => { Storage = n.GetObjectValue<global::ApiSdk.Models.UserStorage>(global::ApiSdk.Models.UserStorage.CreateFromDiscriminatorValue); } },
                { "windows", n => { Windows = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsSetting>(global::ApiSdk.Models.WindowsSetting.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ContactMergeSuggestions>("contactMergeSuggestions", ContactMergeSuggestions);
            writer.WriteBoolValue("contributionToContentDiscoveryAsOrganizationDisabled", ContributionToContentDiscoveryAsOrganizationDisabled);
            writer.WriteBoolValue("contributionToContentDiscoveryDisabled", ContributionToContentDiscoveryDisabled);
            writer.WriteObjectValue<global::ApiSdk.Models.UserInsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<global::ApiSdk.Models.RegionalAndLanguageSettings>("regionalAndLanguageSettings", RegionalAndLanguageSettings);
            writer.WriteObjectValue<global::ApiSdk.Models.ShiftPreferences>("shiftPreferences", ShiftPreferences);
            writer.WriteObjectValue<global::ApiSdk.Models.UserStorage>("storage", Storage);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsSetting>("windows", Windows);
        }
    }
}
#pragma warning restore CS0618
