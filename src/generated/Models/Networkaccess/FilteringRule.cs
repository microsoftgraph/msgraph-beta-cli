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
    public partial class FilteringRule : global::ApiSdk.Models.Networkaccess.PolicyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Possible destinations and types of destinations accessed by the user in accordance with the network filtering policy, such as IP addresses and FQDNs/URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Networkaccess.RuleDestination>? Destinations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Networkaccess.RuleDestination> Destinations { get; set; }
#endif
        /// <summary>The ruleType property</summary>
        public global::ApiSdk.Models.Networkaccess.NetworkDestinationType? RuleType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Networkaccess.FilteringRule"/> and sets the default values.
        /// </summary>
        public FilteringRule() : base()
        {
            OdataType = "#microsoft.graph.networkaccess.filteringRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Networkaccess.FilteringRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Networkaccess.FilteringRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.networkaccess.fqdnFilteringRule" => new global::ApiSdk.Models.Networkaccess.FqdnFilteringRule(),
                "#microsoft.graph.networkaccess.webCategoryFilteringRule" => new global::ApiSdk.Models.Networkaccess.WebCategoryFilteringRule(),
                _ => new global::ApiSdk.Models.Networkaccess.FilteringRule(),
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
                { "destinations", n => { Destinations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Networkaccess.RuleDestination>(global::ApiSdk.Models.Networkaccess.RuleDestination.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ruleType", n => { RuleType = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.NetworkDestinationType>(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Networkaccess.RuleDestination>("destinations", Destinations);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.NetworkDestinationType>("ruleType", RuleType);
        }
    }
}
#pragma warning restore CS0618
