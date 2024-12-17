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
        /// <summary>Windows quality update classification</summary>
        public global::ApiSdk.Models.WindowsQualityUpdateClassification? Classification { get; set; }
        /// <summary>Flag indicating if update qualifies for expedite</summary>
        public bool? IsExpeditable { get; set; }
        /// <summary>Knowledge base article id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KbArticleId { get; set; }
#nullable restore
#else
        public string KbArticleId { get; set; }
#endif
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
                { "classification", n => { Classification = n.GetEnumValue<global::ApiSdk.Models.WindowsQualityUpdateClassification>(); } },
                { "isExpeditable", n => { IsExpeditable = n.GetBoolValue(); } },
                { "kbArticleId", n => { KbArticleId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsQualityUpdateClassification>("classification", Classification);
            writer.WriteBoolValue("isExpeditable", IsExpeditable);
            writer.WriteStringValue("kbArticleId", KbArticleId);
        }
    }
}
#pragma warning restore CS0618
