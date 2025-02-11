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
    public partial class GcpIdentity : global::ApiSdk.Models.AuthorizationSystemIdentity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.GcpIdentity"/> and sets the default values.
        /// </summary>
        public GcpIdentity() : base()
        {
            OdataType = "#microsoft.graph.gcpIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GcpIdentity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.GcpIdentity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.gcpCloudFunction" => new global::ApiSdk.Models.GcpCloudFunction(),
                "#microsoft.graph.gcpGroup" => new global::ApiSdk.Models.GcpGroup(),
                "#microsoft.graph.gcpServiceAccount" => new global::ApiSdk.Models.GcpServiceAccount(),
                "#microsoft.graph.gcpUser" => new global::ApiSdk.Models.GcpUser(),
                _ => new global::ApiSdk.Models.GcpIdentity(),
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
        }
    }
}
#pragma warning restore CS0618
