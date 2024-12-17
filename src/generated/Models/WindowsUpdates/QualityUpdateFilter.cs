// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class QualityUpdateFilter : global::ApiSdk.Models.WindowsUpdates.WindowsUpdateFilter, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the cadence for publishing quality updates of the filter. The possible values are: monthly, outOfBand, unknownFutureValue.</summary>
        public global::ApiSdk.Models.WindowsUpdates.QualityUpdateCadence? Cadence { get; set; }
        /// <summary>Specifies the quality update classification of the filter. The possible values are: all, security, nonSecurity, unknownFutureValue.</summary>
        public global::ApiSdk.Models.WindowsUpdates.QualityUpdateClassification? Classification { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsUpdates.QualityUpdateFilter"/> and sets the default values.
        /// </summary>
        public QualityUpdateFilter() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.qualityUpdateFilter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsUpdates.QualityUpdateFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsUpdates.QualityUpdateFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsUpdates.QualityUpdateFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cadence", n => { Cadence = n.GetEnumValue<global::ApiSdk.Models.WindowsUpdates.QualityUpdateCadence>(); } },
                { "classification", n => { Classification = n.GetEnumValue<global::ApiSdk.Models.WindowsUpdates.QualityUpdateClassification>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsUpdates.QualityUpdateCadence>("cadence", Cadence);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsUpdates.QualityUpdateClassification>("classification", Classification);
        }
    }
}
#pragma warning restore CS0618
