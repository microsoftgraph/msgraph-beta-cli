// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// By providing the configurations in this profile you can instruct the macOS device to connect to desired Wi-Fi endpoint. By specifying the authentication method and security types expected by Wi-Fi endpoint you can make the Wi-Fi connection seamless for end user.
    /// </summary>
    public class MacOSWiFiConfiguration : DeviceConfiguration, IParsable 
    {
        /// <summary>Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.</summary>
        public bool? ConnectAutomatically { get; set; }
        /// <summary>Connect when the network is not broadcasting its name (SSID). When set to true, this profile forces the device to connect to a network that doesn&apos;t broadcast its SSID to all devices.</summary>
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
        /// <summary>URL of the proxy server automatic configuration script when automatic configuration is selected. This URL is typically the location of PAC (Proxy Auto Configuration) file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyAutomaticConfigurationUrl { get; set; }
#nullable restore
#else
        public string ProxyAutomaticConfigurationUrl { get; set; }
#endif
        /// <summary>IP Address or DNS hostname of the proxy server when manual configuration is selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyManualAddress { get; set; }
#nullable restore
#else
        public string ProxyManualAddress { get; set; }
#endif
        /// <summary>Port of the proxy server when manual configuration is selected.</summary>
        public int? ProxyManualPort { get; set; }
        /// <summary>Wi-Fi Proxy Settings.</summary>
        public WiFiProxySetting? ProxySettings { get; set; }
        /// <summary>This is the name of the Wi-Fi network that is broadcast to all devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ssid { get; set; }
#nullable restore
#else
        public string Ssid { get; set; }
#endif
        /// <summary>Wi-Fi Security Types.</summary>
        public ApiSdk.Models.WiFiSecurityType? WiFiSecurityType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="MacOSWiFiConfiguration"/> and sets the default values.
        /// </summary>
        public MacOSWiFiConfiguration() : base()
        {
            OdataType = "#microsoft.graph.macOSWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MacOSWiFiConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.macOSEnterpriseWiFiConfiguration" => new MacOSEnterpriseWiFiConfiguration(),
                _ => new MacOSWiFiConfiguration(),
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
                {"connectAutomatically", n => { ConnectAutomatically = n.GetBoolValue(); } },
                {"connectWhenNetworkNameIsHidden", n => { ConnectWhenNetworkNameIsHidden = n.GetBoolValue(); } },
                {"networkName", n => { NetworkName = n.GetStringValue(); } },
                {"preSharedKey", n => { PreSharedKey = n.GetStringValue(); } },
                {"proxyAutomaticConfigurationUrl", n => { ProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"proxyManualAddress", n => { ProxyManualAddress = n.GetStringValue(); } },
                {"proxyManualPort", n => { ProxyManualPort = n.GetIntValue(); } },
                {"proxySettings", n => { ProxySettings = n.GetEnumValue<WiFiProxySetting>(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wiFiSecurityType", n => { WiFiSecurityType = n.GetEnumValue<WiFiSecurityType>(); } },
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
            writer.WriteStringValue("proxyAutomaticConfigurationUrl", ProxyAutomaticConfigurationUrl);
            writer.WriteStringValue("proxyManualAddress", ProxyManualAddress);
            writer.WriteIntValue("proxyManualPort", ProxyManualPort);
            writer.WriteEnumValue<WiFiProxySetting>("proxySettings", ProxySettings);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<WiFiSecurityType>("wiFiSecurityType", WiFiSecurityType);
        }
    }
}