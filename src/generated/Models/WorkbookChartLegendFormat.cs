using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class WorkbookChartLegendFormat : Entity, IParsable {
        /// <summary>Represents the fill format of an object, which includes background formating information. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartFill? Fill { get; set; }
#nullable restore
#else
        public WorkbookChartFill Fill { get; set; }
#endif
        /// <summary>Represents the font attributes such as font name, font size, color, etc. of a chart legend. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartFont? Font { get; set; }
#nullable restore
#else
        public WorkbookChartFont Font { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookChartLegendFormat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartLegendFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fill", n => { Fill = n.GetObjectValue<WorkbookChartFill>(WorkbookChartFill.CreateFromDiscriminatorValue); } },
                {"font", n => { Font = n.GetObjectValue<WorkbookChartFont>(WorkbookChartFont.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartFill>("fill", Fill);
            writer.WriteObjectValue<WorkbookChartFont>("font", Font);
        }
    }
}