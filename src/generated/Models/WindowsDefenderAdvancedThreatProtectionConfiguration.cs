// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Windows Defender AdvancedThreatProtection Configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsDefenderAdvancedThreatProtectionConfiguration : global::ApiSdk.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Auto populate onboarding blob programmatically from Advanced Threat protection service</summary>
        public bool? AdvancedThreatProtectionAutoPopulateOnboardingBlob { get; set; }
        /// <summary>Windows Defender AdvancedThreatProtection Offboarding Blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdvancedThreatProtectionOffboardingBlob { get; set; }
#nullable restore
#else
        public string AdvancedThreatProtectionOffboardingBlob { get; set; }
#endif
        /// <summary>Name of the file from which AdvancedThreatProtectionOffboardingBlob was obtained.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdvancedThreatProtectionOffboardingFilename { get; set; }
#nullable restore
#else
        public string AdvancedThreatProtectionOffboardingFilename { get; set; }
#endif
        /// <summary>Windows Defender AdvancedThreatProtection Onboarding Blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdvancedThreatProtectionOnboardingBlob { get; set; }
#nullable restore
#else
        public string AdvancedThreatProtectionOnboardingBlob { get; set; }
#endif
        /// <summary>Name of the file from which AdvancedThreatProtectionOnboardingBlob was obtained.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdvancedThreatProtectionOnboardingFilename { get; set; }
#nullable restore
#else
        public string AdvancedThreatProtectionOnboardingFilename { get; set; }
#endif
        /// <summary>Windows Defender AdvancedThreatProtection &apos;Allow Sample Sharing&apos; Rule</summary>
        public bool? AllowSampleSharing { get; set; }
        /// <summary>Expedite Windows Defender Advanced Threat Protection telemetry reporting frequency.</summary>
        public bool? EnableExpeditedTelemetryReporting { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsDefenderAdvancedThreatProtectionConfiguration"/> and sets the default values.
        /// </summary>
        public WindowsDefenderAdvancedThreatProtectionConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsDefenderAdvancedThreatProtectionConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsDefenderAdvancedThreatProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsDefenderAdvancedThreatProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "advancedThreatProtectionAutoPopulateOnboardingBlob", n => { AdvancedThreatProtectionAutoPopulateOnboardingBlob = n.GetBoolValue(); } },
                { "advancedThreatProtectionOffboardingBlob", n => { AdvancedThreatProtectionOffboardingBlob = n.GetStringValue(); } },
                { "advancedThreatProtectionOffboardingFilename", n => { AdvancedThreatProtectionOffboardingFilename = n.GetStringValue(); } },
                { "advancedThreatProtectionOnboardingBlob", n => { AdvancedThreatProtectionOnboardingBlob = n.GetStringValue(); } },
                { "advancedThreatProtectionOnboardingFilename", n => { AdvancedThreatProtectionOnboardingFilename = n.GetStringValue(); } },
                { "allowSampleSharing", n => { AllowSampleSharing = n.GetBoolValue(); } },
                { "enableExpeditedTelemetryReporting", n => { EnableExpeditedTelemetryReporting = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("advancedThreatProtectionAutoPopulateOnboardingBlob", AdvancedThreatProtectionAutoPopulateOnboardingBlob);
            writer.WriteStringValue("advancedThreatProtectionOffboardingBlob", AdvancedThreatProtectionOffboardingBlob);
            writer.WriteStringValue("advancedThreatProtectionOffboardingFilename", AdvancedThreatProtectionOffboardingFilename);
            writer.WriteStringValue("advancedThreatProtectionOnboardingBlob", AdvancedThreatProtectionOnboardingBlob);
            writer.WriteStringValue("advancedThreatProtectionOnboardingFilename", AdvancedThreatProtectionOnboardingFilename);
            writer.WriteBoolValue("allowSampleSharing", AllowSampleSharing);
            writer.WriteBoolValue("enableExpeditedTelemetryReporting", EnableExpeditedTelemetryReporting);
        }
    }
}
#pragma warning restore CS0618
