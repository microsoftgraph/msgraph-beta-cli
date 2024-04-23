// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UserInsightsRoot : Entity, IParsable 
    {
        /// <summary>Summaries of daily user activities on apps registered in your tenant that is configured for Microsoft Entra External ID for customers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DailyUserInsightMetricsRoot? Daily { get; set; }
#nullable restore
#else
        public DailyUserInsightMetricsRoot Daily { get; set; }
#endif
        /// <summary>Summaries of monthly user activities on apps registered in your tenant that is configured for Microsoft Entra External ID for customers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MonthlyUserInsightMetricsRoot? Monthly { get; set; }
#nullable restore
#else
        public MonthlyUserInsightMetricsRoot Monthly { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserInsightsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserInsightsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserInsightsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"daily", n => { Daily = n.GetObjectValue<DailyUserInsightMetricsRoot>(DailyUserInsightMetricsRoot.CreateFromDiscriminatorValue); } },
                {"monthly", n => { Monthly = n.GetObjectValue<MonthlyUserInsightMetricsRoot>(MonthlyUserInsightMetricsRoot.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<DailyUserInsightMetricsRoot>("daily", Daily);
            writer.WriteObjectValue<MonthlyUserInsightMetricsRoot>("monthly", Monthly);
        }
    }
}