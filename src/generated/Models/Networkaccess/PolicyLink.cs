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
    public partial class PolicyLink : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The policy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Networkaccess.Policy? Policy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Networkaccess.Policy Policy { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.Networkaccess.Status? State { get; set; }
        /// <summary>Version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Networkaccess.PolicyLink"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Networkaccess.PolicyLink CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.networkaccess.filteringPolicyLink" => new global::ApiSdk.Models.Networkaccess.FilteringPolicyLink(),
                "#microsoft.graph.networkaccess.forwardingPolicyLink" => new global::ApiSdk.Models.Networkaccess.ForwardingPolicyLink(),
                _ => new global::ApiSdk.Models.Networkaccess.PolicyLink(),
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
                { "policy", n => { Policy = n.GetObjectValue<global::ApiSdk.Models.Networkaccess.Policy>(global::ApiSdk.Models.Networkaccess.Policy.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.Status>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.Networkaccess.Policy>("policy", Policy);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.Status>("state", State);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
