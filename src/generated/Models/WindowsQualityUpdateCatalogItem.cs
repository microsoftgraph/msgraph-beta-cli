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
    /// Windows update catalog item entity
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsQualityUpdateCatalogItem : global::ApiSdk.Models.WindowsUpdateCatalogItem, IParsable
    {
        /// <summary>Windows quality update category</summary>
        public global::ApiSdk.Models.WindowsQualityUpdateCategory? Classification { get; set; }
        /// <summary>When TRUE, indicates that the quality updates qualify for expedition. When FALSE, indicates the quality updates do not quality for expedition. Default value is FALSE. Read-only</summary>
        public bool? IsExpeditable { get; set; }
        /// <summary>Identifies the knowledge base article associated with the Windows quality update catalog item. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KbArticleId { get; set; }
#nullable restore
#else
        public string KbArticleId { get; set; }
#endif
        /// <summary>The operating system product revisions that are released as part of this quality update. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsQualityUpdateCatalogProductRevision>? ProductRevisions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsQualityUpdateCatalogProductRevision> ProductRevisions { get; set; }
#endif
        /// <summary>The publishing cadence of the quality update. Possible values are: monthly, outOfBand. This property cannot be modified and is automatically populated when the catalog is created.</summary>
        public global::ApiSdk.Models.WindowsQualityUpdateCadence? QualityUpdateCadence { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsQualityUpdateCatalogItem"/> and sets the default values.
        /// </summary>
        public WindowsQualityUpdateCatalogItem() : base()
        {
            OdataType = "#microsoft.graph.windowsQualityUpdateCatalogItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsQualityUpdateCatalogItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsQualityUpdateCatalogItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsQualityUpdateCatalogItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "classification", n => { Classification = n.GetEnumValue<global::ApiSdk.Models.WindowsQualityUpdateCategory>(); } },
                { "isExpeditable", n => { IsExpeditable = n.GetBoolValue(); } },
                { "kbArticleId", n => { KbArticleId = n.GetStringValue(); } },
                { "productRevisions", n => { ProductRevisions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsQualityUpdateCatalogProductRevision>(global::ApiSdk.Models.WindowsQualityUpdateCatalogProductRevision.CreateFromDiscriminatorValue)?.AsList(); } },
                { "qualityUpdateCadence", n => { QualityUpdateCadence = n.GetEnumValue<global::ApiSdk.Models.WindowsQualityUpdateCadence>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsQualityUpdateCategory>("classification", Classification);
            writer.WriteBoolValue("isExpeditable", IsExpeditable);
            writer.WriteStringValue("kbArticleId", KbArticleId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsQualityUpdateCatalogProductRevision>("productRevisions", ProductRevisions);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsQualityUpdateCadence>("qualityUpdateCadence", QualityUpdateCadence);
        }
    }
}
#pragma warning restore CS0618
