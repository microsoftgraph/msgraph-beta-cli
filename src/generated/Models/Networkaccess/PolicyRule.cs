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
    public partial class PolicyRule : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Networkaccess.PolicyRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Networkaccess.PolicyRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.networkaccess.filteringRule" => new global::ApiSdk.Models.Networkaccess.FilteringRule(),
                "#microsoft.graph.networkaccess.forwardingRule" => new global::ApiSdk.Models.Networkaccess.ForwardingRule(),
                "#microsoft.graph.networkaccess.fqdnFilteringRule" => new global::ApiSdk.Models.Networkaccess.FqdnFilteringRule(),
                "#microsoft.graph.networkaccess.internetAccessForwardingRule" => new global::ApiSdk.Models.Networkaccess.InternetAccessForwardingRule(),
                "#microsoft.graph.networkaccess.m365ForwardingRule" => new global::ApiSdk.Models.Networkaccess.M365ForwardingRule(),
                "#microsoft.graph.networkaccess.privateAccessForwardingRule" => new global::ApiSdk.Models.Networkaccess.PrivateAccessForwardingRule(),
                "#microsoft.graph.networkaccess.webCategoryFilteringRule" => new global::ApiSdk.Models.Networkaccess.WebCategoryFilteringRule(),
                _ => new global::ApiSdk.Models.Networkaccess.PolicyRule(),
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
                { "name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteStringValue("name", Name);
        }
    }
}
#pragma warning restore CS0618
