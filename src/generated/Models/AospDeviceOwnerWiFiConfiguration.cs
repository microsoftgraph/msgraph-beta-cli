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
    /// By providing the configurations in this profile you can instruct the AOSP device to connect to desired Wi-Fi endpoint. By specifying the authentication method and security types expected by Wi-Fi endpoint you can make the Wi-Fi connection seamless for end user. This profile provides limited and simpler security types than Enterprise Wi-Fi profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AospDeviceOwnerWiFiConfiguration : global::ApiSdk.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.</summary>
        public bool? ConnectAutomatically { get; set; }
        /// <summary>When set to true, this profile forces the device to connect to a network that doesn&apos;t broadcast its SSID to all devices.</summary>
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
        /// <summary>Network Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkName { get; set; }
#nullable restore
#else
        public string NetworkName { get; set; }
#endif
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreSharedKey { get; set; }
#nullable restore
#else
        public string PreSharedKey { get; set; }
#endif
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public bool? PreSharedKeyIsSet { get; set; }
        /// <summary>Specify the proxy server configuration script URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyAutomaticConfigurationUrl { get; set; }
#nullable restore
#else
        public string ProxyAutomaticConfigurationUrl { get; set; }
#endif
        /// <summary>List of hosts to exclude using the proxy on connections for. These hosts can use wildcards such as .example.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProxyExclusionList { get; set; }
#nullable restore
#else
        public List<string> ProxyExclusionList { get; set; }
#endif
        /// <summary>Specify the proxy server IP address. Both IPv4 and IPv6 addresses are supported. For example: 192.168.1.1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyManualAddress { get; set; }
#nullable restore
#else
        public string ProxyManualAddress { get; set; }
#endif
        /// <summary>Specify the proxy server port.</summary>
        public int? ProxyManualPort { get; set; }
        /// <summary>Wi-Fi Proxy Settings.</summary>
        public global::ApiSdk.Models.WiFiProxySetting? ProxySetting { get; set; }
        /// <summary>This is the name of the Wi-Fi network that is broadcast to all devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ssid { get; set; }
#nullable restore
#else
        public string Ssid { get; set; }
#endif
        /// <summary>Wi-Fi Security Types for AOSP Device Owner.</summary>
        public global::ApiSdk.Models.AospDeviceOwnerWiFiSecurityType? WiFiSecurityType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AospDeviceOwnerWiFiConfiguration"/> and sets the default values.
        /// </summary>
        public AospDeviceOwnerWiFiConfiguration() : base()
        {
            OdataType = "#microsoft.graph.aospDeviceOwnerWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AospDeviceOwnerWiFiConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AospDeviceOwnerWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.aospDeviceOwnerEnterpriseWiFiConfiguration" => new global::ApiSdk.Models.AospDeviceOwnerEnterpriseWiFiConfiguration(),
                _ => new global::ApiSdk.Models.AospDeviceOwnerWiFiConfiguration(),
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
                { "connectAutomatically", n => { ConnectAutomatically = n.GetBoolValue(); } },
                { "connectWhenNetworkNameIsHidden", n => { ConnectWhenNetworkNameIsHidden = n.GetBoolValue(); } },
                { "networkName", n => { NetworkName = n.GetStringValue(); } },
                { "preSharedKey", n => { PreSharedKey = n.GetStringValue(); } },
                { "preSharedKeyIsSet", n => { PreSharedKeyIsSet = n.GetBoolValue(); } },
                { "proxyAutomaticConfigurationUrl", n => { ProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                { "proxyExclusionList", n => { ProxyExclusionList = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "proxyManualAddress", n => { ProxyManualAddress = n.GetStringValue(); } },
                { "proxyManualPort", n => { ProxyManualPort = n.GetIntValue(); } },
                { "proxySetting", n => { ProxySetting = n.GetEnumValue<global::ApiSdk.Models.WiFiProxySetting>(); } },
                { "ssid", n => { Ssid = n.GetStringValue(); } },
                { "wiFiSecurityType", n => { WiFiSecurityType = n.GetEnumValue<global::ApiSdk.Models.AospDeviceOwnerWiFiSecurityType>(); } },
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
            writer.WriteBoolValue("connectAutomatically", ConnectAutomatically);
            writer.WriteBoolValue("connectWhenNetworkNameIsHidden", ConnectWhenNetworkNameIsHidden);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteStringValue("preSharedKey", PreSharedKey);
            writer.WriteBoolValue("preSharedKeyIsSet", PreSharedKeyIsSet);
            writer.WriteStringValue("proxyAutomaticConfigurationUrl", ProxyAutomaticConfigurationUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyExclusionList", ProxyExclusionList);
            writer.WriteStringValue("proxyManualAddress", ProxyManualAddress);
            writer.WriteIntValue("proxyManualPort", ProxyManualPort);
            writer.WriteEnumValue<global::ApiSdk.Models.WiFiProxySetting>("proxySetting", ProxySetting);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<global::ApiSdk.Models.AospDeviceOwnerWiFiSecurityType>("wiFiSecurityType", WiFiSecurityType);
        }
    }
}
#pragma warning restore CS0618
