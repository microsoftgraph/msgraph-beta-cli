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
    /// By providing the configurations in this profile you can instruct the iOS device to connect to desired VPN endpoint. By specifying the authentication method and security types expected by VPN endpoint you can make the VPN connection seamless for end user.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosVpnConfiguration : global::ApiSdk.Models.AppleVpnConfiguration, IParsable
    {
        /// <summary>Zscaler only. Zscaler cloud which the user is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudName { get; set; }
#nullable restore
#else
        public string CloudName { get; set; }
#endif
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceManagementDerivedCredentialSettings? DerivedCredentialSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceManagementDerivedCredentialSettings DerivedCredentialSettings { get; set; }
#endif
        /// <summary>Zscaler only. List of network addresses which are not sent through the Zscaler cloud.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeList { get; set; }
#nullable restore
#else
        public List<string> ExcludeList { get; set; }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IosCertificateProfileBase? IdentityCertificate { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IosCertificateProfileBase IdentityCertificate { get; set; }
#endif
        /// <summary>Microsoft Tunnel site ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftTunnelSiteId { get; set; }
#nullable restore
#else
        public string MicrosoftTunnelSiteId { get; set; }
#endif
        /// <summary>Zscaler only. Blocks network traffic until the user signs into Zscaler app. &apos;True&apos; means traffic is blocked.</summary>
        public bool? StrictEnforcement { get; set; }
        /// <summary>Targeted mobile apps. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AppListItem>? TargetedMobileApps { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AppListItem> TargetedMobileApps { get; set; }
#endif
        /// <summary>Zscaler only. Enter a static domain to pre-populate the login field with in the Zscaler app. If this is left empty, the user&apos;s Azure Active Directory domain will be used instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDomain { get; set; }
#nullable restore
#else
        public string UserDomain { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.IosVpnConfiguration"/> and sets the default values.
        /// </summary>
        public IosVpnConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IosVpnConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.IosVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.iosikEv2VpnConfiguration" => new global::ApiSdk.Models.IosikEv2VpnConfiguration(),
                _ => new global::ApiSdk.Models.IosVpnConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cloudName", n => { CloudName = n.GetStringValue(); } },
                { "derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<global::ApiSdk.Models.DeviceManagementDerivedCredentialSettings>(global::ApiSdk.Models.DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                { "excludeList", n => { ExcludeList = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "identityCertificate", n => { IdentityCertificate = n.GetObjectValue<global::ApiSdk.Models.IosCertificateProfileBase>(global::ApiSdk.Models.IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                { "microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                { "strictEnforcement", n => { StrictEnforcement = n.GetBoolValue(); } },
                { "targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AppListItem>(global::ApiSdk.Models.AppListItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userDomain", n => { UserDomain = n.GetStringValue(); } },
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
            writer.WriteStringValue("cloudName", CloudName);
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeList", ExcludeList);
            writer.WriteObjectValue<global::ApiSdk.Models.IosCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteBoolValue("strictEnforcement", StrictEnforcement);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AppListItem>("targetedMobileApps", TargetedMobileApps);
            writer.WriteStringValue("userDomain", UserDomain);
        }
    }
}
#pragma warning restore CS0618
