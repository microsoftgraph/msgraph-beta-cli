// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.TermStore
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Term : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Children of current term.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.Term>? Children { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.Term> Children { get; set; }
#endif
        /// <summary>Date and time of term creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description about term that is dependent on the languageTag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.LocalizedDescription>? Descriptions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.LocalizedDescription> Descriptions { get; set; }
#endif
        /// <summary>Label metadata for a term.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.LocalizedLabel>? Labels { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.LocalizedLabel> Labels { get; set; }
#endif
        /// <summary>Last date and time of term modification. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Collection of properties on the term.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.KeyValue>? Properties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.KeyValue> Properties { get; set; }
#endif
        /// <summary>To indicate which terms are related to the current term as either pinned or reused.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.Relation>? Relations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.Relation> Relations { get; set; }
#endif
        /// <summary>The [set] in which the term is created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TermStore.Set? Set { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TermStore.Set Set { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TermStore.Term"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.TermStore.Term CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TermStore.Term();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "children", n => { Children = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Term>(global::ApiSdk.Models.TermStore.Term.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "descriptions", n => { Descriptions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.LocalizedDescription>(global::ApiSdk.Models.TermStore.LocalizedDescription.CreateFromDiscriminatorValue)?.AsList(); } },
                { "labels", n => { Labels = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.LocalizedLabel>(global::ApiSdk.Models.TermStore.LocalizedLabel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "properties", n => { Properties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.KeyValue>(global::ApiSdk.Models.KeyValue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "relations", n => { Relations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Relation>(global::ApiSdk.Models.TermStore.Relation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "set", n => { Set = n.GetObjectValue<global::ApiSdk.Models.TermStore.Set>(global::ApiSdk.Models.TermStore.Set.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Term>("children", Children);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.LocalizedDescription>("descriptions", Descriptions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.LocalizedLabel>("labels", Labels);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.KeyValue>("properties", Properties);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Relation>("relations", Relations);
            writer.WriteObjectValue<global::ApiSdk.Models.TermStore.Set>("set", Set);
        }
    }
}
#pragma warning restore CS0618
