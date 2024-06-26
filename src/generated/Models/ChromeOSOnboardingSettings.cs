// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Entity that represents a Chromebook tenant settings
    /// </summary>
    public class ChromeOSOnboardingSettings : Entity, IParsable
    {
        /// <summary>The ChromebookTenant&apos;s LastDirectorySyncDateTime</summary>
        public DateTimeOffset? LastDirectorySyncDateTime { get; set; }
        /// <summary>The ChromebookTenant&apos;s LastModifiedDateTime</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The onboarding status of the tenant.</summary>
        public ApiSdk.Models.OnboardingStatus? OnboardingStatus { get; set; }
        /// <summary>The ChromebookTenant&apos;s OwnerUserPrincipalName</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerUserPrincipalName { get; set; }
#nullable restore
#else
        public string OwnerUserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ChromeOSOnboardingSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChromeOSOnboardingSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChromeOSOnboardingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "lastDirectorySyncDateTime", n => { LastDirectorySyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<OnboardingStatus>(); } },
                { "ownerUserPrincipalName", n => { OwnerUserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("lastDirectorySyncDateTime", LastDirectorySyncDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<OnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteStringValue("ownerUserPrincipalName", OwnerUserPrincipalName);
        }
    }
}
