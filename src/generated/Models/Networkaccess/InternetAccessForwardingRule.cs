// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Networkaccess
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class InternetAccessForwardingRule : global::ApiSdk.Models.Networkaccess.ForwardingRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ports { get; set; }
#nullable restore
#else
        public List<string> Ports { get; set; }
#endif
        /// <summary>The protocol property</summary>
        public global::ApiSdk.Models.Networkaccess.NetworkingProtocol? Protocol { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Networkaccess.InternetAccessForwardingRule"/> and sets the default values.
        /// </summary>
        public InternetAccessForwardingRule() : base()
        {
            OdataType = "#microsoft.graph.networkaccess.internetAccessForwardingRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Networkaccess.InternetAccessForwardingRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Networkaccess.InternetAccessForwardingRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Networkaccess.InternetAccessForwardingRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "ports", n => { Ports = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "protocol", n => { Protocol = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.NetworkingProtocol>(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("ports", Ports);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.NetworkingProtocol>("protocol", Protocol);
        }
    }
}
#pragma warning restore CS0618
