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
    /// Windows X WifiXml configuration profile
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Windows10XWifiConfiguration : global::ApiSdk.Models.DeviceManagementResourceAccessProfileBase, IParsable
    {
        /// <summary>ID to the Authentication Certificate</summary>
        public Guid? AuthenticationCertificateId { get; set; }
        /// <summary>Custom XML commands that configures the VPN connection. (UTF8 byte encoding)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? CustomXml { get; set; }
#nullable restore
#else
        public byte[] CustomXml { get; set; }
#endif
        /// <summary>Custom Xml file name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomXmlFileName { get; set; }
#nullable restore
#else
        public string CustomXmlFileName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Windows10XWifiConfiguration"/> and sets the default values.
        /// </summary>
        public Windows10XWifiConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windows10XWifiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Windows10XWifiConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Windows10XWifiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Windows10XWifiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationCertificateId", n => { AuthenticationCertificateId = n.GetGuidValue(); } },
                { "customXml", n => { CustomXml = n.GetByteArrayValue(); } },
                { "customXmlFileName", n => { CustomXmlFileName = n.GetStringValue(); } },
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
            writer.WriteGuidValue("authenticationCertificateId", AuthenticationCertificateId);
            writer.WriteByteArrayValue("customXml", CustomXml);
            writer.WriteStringValue("customXmlFileName", CustomXmlFileName);
        }
    }
}
#pragma warning restore CS0618
