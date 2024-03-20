// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates {
    public class QualityUpdateCatalogEntry : SoftwareUpdateCatalogEntry, IParsable 
    {
        /// <summary>The catalog name of the content. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogName { get; set; }
#nullable restore
#else
        public string CatalogName { get; set; }
#endif
        /// <summary>Severity information of the Common Vulnerabilities and Exposures associated with the content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public QualityUpdateCveSeverityInformation? CveSeverityInformation { get; set; }
#nullable restore
#else
        public QualityUpdateCveSeverityInformation CveSeverityInformation { get; set; }
#endif
        /// <summary>Indicates whether the content can be deployed as an expedited quality update. Read-only.</summary>
        public bool? IsExpeditable { get; set; }
        /// <summary>The operating system product revisions that are released as part of this quality update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProductRevision>? ProductRevisions { get; set; }
#nullable restore
#else
        public List<ProductRevision> ProductRevisions { get; set; }
#endif
        /// <summary>The publishing cadence of the quality update. Possible values are: monthly, outOfBand, unknownFutureValue. Read-only.</summary>
        public ApiSdk.Models.WindowsUpdates.QualityUpdateCadence? QualityUpdateCadence { get; set; }
        /// <summary>The qualityUpdateClassification property</summary>
        public ApiSdk.Models.WindowsUpdates.QualityUpdateClassification? QualityUpdateClassification { get; set; }
        /// <summary>The short name of the content. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortName { get; set; }
#nullable restore
#else
        public string ShortName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="QualityUpdateCatalogEntry"/> and sets the default values.
        /// </summary>
        public QualityUpdateCatalogEntry() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.qualityUpdateCatalogEntry";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="QualityUpdateCatalogEntry"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new QualityUpdateCatalogEntry CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new QualityUpdateCatalogEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"catalogName", n => { CatalogName = n.GetStringValue(); } },
                {"cveSeverityInformation", n => { CveSeverityInformation = n.GetObjectValue<QualityUpdateCveSeverityInformation>(QualityUpdateCveSeverityInformation.CreateFromDiscriminatorValue); } },
                {"isExpeditable", n => { IsExpeditable = n.GetBoolValue(); } },
                {"productRevisions", n => { ProductRevisions = n.GetCollectionOfObjectValues<ProductRevision>(ProductRevision.CreateFromDiscriminatorValue)?.ToList(); } },
                {"qualityUpdateCadence", n => { QualityUpdateCadence = n.GetEnumValue<QualityUpdateCadence>(); } },
                {"qualityUpdateClassification", n => { QualityUpdateClassification = n.GetEnumValue<QualityUpdateClassification>(); } },
                {"shortName", n => { ShortName = n.GetStringValue(); } },
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
            writer.WriteStringValue("catalogName", CatalogName);
            writer.WriteObjectValue<QualityUpdateCveSeverityInformation>("cveSeverityInformation", CveSeverityInformation);
            writer.WriteBoolValue("isExpeditable", IsExpeditable);
            writer.WriteCollectionOfObjectValues<ProductRevision>("productRevisions", ProductRevisions);
            writer.WriteEnumValue<QualityUpdateCadence>("qualityUpdateCadence", QualityUpdateCadence);
            writer.WriteEnumValue<QualityUpdateClassification>("qualityUpdateClassification", QualityUpdateClassification);
            writer.WriteStringValue("shortName", ShortName);
        }
    }
}