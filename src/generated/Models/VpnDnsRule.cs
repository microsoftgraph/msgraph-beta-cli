// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// VPN DNS Rule definition.
    /// </summary>
    public class VpnDnsRule : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Automatically connect to the VPN when the device connects to this domain: Default False.</summary>
        public bool? AutoTrigger { get; set; }
        /// <summary>Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Keep this rule active even when the VPN is not connected: Default False</summary>
        public bool? Persistent { get; set; }
        /// <summary>Proxy Server Uri.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyServerUri { get; set; }
#nullable restore
#else
        public string ProxyServerUri { get; set; }
#endif
        /// <summary>Servers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Servers { get; set; }
#nullable restore
#else
        public List<string> Servers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="VpnDnsRule"/> and sets the default values.
        /// </summary>
        public VpnDnsRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VpnDnsRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VpnDnsRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VpnDnsRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"autoTrigger", n => { AutoTrigger = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"persistent", n => { Persistent = n.GetBoolValue(); } },
                {"proxyServerUri", n => { ProxyServerUri = n.GetStringValue(); } },
                {"servers", n => { Servers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("autoTrigger", AutoTrigger);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("persistent", Persistent);
            writer.WriteStringValue("proxyServerUri", ProxyServerUri);
            writer.WriteCollectionOfPrimitiveValues<string>("servers", Servers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}