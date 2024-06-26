// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IndustryData
{
    #pragma warning disable CS1591
    public class IndustryDataRunStatistics : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of statistics for each activity included in this run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IndustryDataActivityStatistics>? ActivityStatistics { get; private set; }
#nullable restore
#else
        public List<IndustryDataActivityStatistics> ActivityStatistics { get; private set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The aggregate statistics for all inbound flows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AggregatedInboundStatistics? InboundTotals { get; private set; }
#nullable restore
#else
        public AggregatedInboundStatistics InboundTotals { get; private set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The ID of the underlying run for the statistics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunId { get; private set; }
#nullable restore
#else
        public string RunId { get; private set; }
#endif
        /// <summary>The status property</summary>
        public IndustryDataRunStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="IndustryDataRunStatistics"/> and sets the default values.
        /// </summary>
        public IndustryDataRunStatistics()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IndustryDataRunStatistics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IndustryDataRunStatistics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IndustryDataRunStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activityStatistics", n => { ActivityStatistics = n.GetCollectionOfObjectValues<IndustryDataActivityStatistics>(IndustryDataActivityStatistics.CreateFromDiscriminatorValue)?.ToList(); } },
                { "inboundTotals", n => { InboundTotals = n.GetObjectValue<AggregatedInboundStatistics>(AggregatedInboundStatistics.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "runId", n => { RunId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<IndustryDataRunStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<IndustryDataRunStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
