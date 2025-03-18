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
    /// VPN Proxy Server.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Windows81VpnProxyServer : global::ApiSdk.Models.VpnProxyServer, IParsable
    {
        /// <summary>Automatically detect proxy settings.</summary>
        public bool? AutomaticallyDetectProxySettings { get; set; }
        /// <summary>Bypass proxy server for local address.</summary>
        public bool? BypassProxyServerForLocalAddress { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Windows81VpnProxyServer"/> and sets the default values.
        /// </summary>
        public Windows81VpnProxyServer() : base()
        {
            OdataType = "#microsoft.graph.windows81VpnProxyServer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Windows81VpnProxyServer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Windows81VpnProxyServer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Windows81VpnProxyServer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "automaticallyDetectProxySettings", n => { AutomaticallyDetectProxySettings = n.GetBoolValue(); } },
                { "bypassProxyServerForLocalAddress", n => { BypassProxyServerForLocalAddress = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("automaticallyDetectProxySettings", AutomaticallyDetectProxySettings);
            writer.WriteBoolValue("bypassProxyServerForLocalAddress", BypassProxyServerForLocalAddress);
        }
    }
}
#pragma warning restore CS0618
