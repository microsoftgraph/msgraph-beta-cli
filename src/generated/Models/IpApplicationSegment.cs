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
    public partial class IpApplicationSegment : global::ApiSdk.Models.ApplicationSegment, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Application? Application { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Application Application { get; set; }
#endif
        /// <summary>The destinationHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationHost { get; set; }
#nullable restore
#else
        public string DestinationHost { get; set; }
#endif
        /// <summary>The destinationType property</summary>
        public global::ApiSdk.Models.PrivateNetworkDestinationType? DestinationType { get; set; }
        /// <summary>The port property</summary>
        public int? Port { get; set; }
        /// <summary>The ports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ports { get; set; }
#nullable restore
#else
        public List<string> Ports { get; set; }
#endif
        /// <summary>The protocol property</summary>
        public global::ApiSdk.Models.PrivateNetworkProtocol? Protocol { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.IpApplicationSegment"/> and sets the default values.
        /// </summary>
        public IpApplicationSegment() : base()
        {
            OdataType = "#microsoft.graph.ipApplicationSegment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IpApplicationSegment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.IpApplicationSegment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.IpApplicationSegment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "application", n => { Application = n.GetObjectValue<global::ApiSdk.Models.Application>(global::ApiSdk.Models.Application.CreateFromDiscriminatorValue); } },
                { "destinationHost", n => { DestinationHost = n.GetStringValue(); } },
                { "destinationType", n => { DestinationType = n.GetEnumValue<global::ApiSdk.Models.PrivateNetworkDestinationType>(); } },
                { "port", n => { Port = n.GetIntValue(); } },
                { "ports", n => { Ports = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "protocol", n => { Protocol = n.GetEnumValue<global::ApiSdk.Models.PrivateNetworkProtocol>(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.Application>("application", Application);
            writer.WriteStringValue("destinationHost", DestinationHost);
            writer.WriteEnumValue<global::ApiSdk.Models.PrivateNetworkDestinationType>("destinationType", DestinationType);
            writer.WriteIntValue("port", Port);
            writer.WriteCollectionOfPrimitiveValues<string>("ports", Ports);
            writer.WriteEnumValue<global::ApiSdk.Models.PrivateNetworkProtocol>("protocol", Protocol);
        }
    }
}
#pragma warning restore CS0618
