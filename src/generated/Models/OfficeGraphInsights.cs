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
    public partial class OfficeGraphInsights : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SharedInsight>? Shared { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SharedInsight> Shared { get; set; }
#endif
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Trending>? Trending { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Trending> Trending { get; set; }
#endif
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UsedInsight>? Used { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UsedInsight> Used { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.OfficeGraphInsights"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.OfficeGraphInsights CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.itemInsights" => new global::ApiSdk.Models.ItemInsights(),
                _ => new global::ApiSdk.Models.OfficeGraphInsights(),
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
                { "shared", n => { Shared = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SharedInsight>(global::ApiSdk.Models.SharedInsight.CreateFromDiscriminatorValue)?.AsList(); } },
                { "trending", n => { Trending = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Trending>(global::ApiSdk.Models.Trending.CreateFromDiscriminatorValue)?.AsList(); } },
                { "used", n => { Used = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UsedInsight>(global::ApiSdk.Models.UsedInsight.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SharedInsight>("shared", Shared);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Trending>("trending", Trending);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UsedInsight>("used", Used);
        }
    }
}
#pragma warning restore CS0618
