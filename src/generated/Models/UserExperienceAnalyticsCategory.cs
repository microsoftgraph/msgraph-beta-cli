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
    /// The user experience analytics category entity contains the scores and insights for the various metrics of a category.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserExperienceAnalyticsCategory : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The insights for the category. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UserExperienceAnalyticsInsight>? Insights { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UserExperienceAnalyticsInsight> Insights { get; set; }
#endif
        /// <summary>The metric values for the user experience analytics category. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UserExperienceAnalyticsMetric>? MetricValues { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UserExperienceAnalyticsMetric> MetricValues { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserExperienceAnalyticsCategory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UserExperienceAnalyticsCategory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserExperienceAnalyticsCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "insights", n => { Insights = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UserExperienceAnalyticsInsight>(global::ApiSdk.Models.UserExperienceAnalyticsInsight.CreateFromDiscriminatorValue)?.AsList(); } },
                { "metricValues", n => { MetricValues = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UserExperienceAnalyticsMetric>(global::ApiSdk.Models.UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UserExperienceAnalyticsInsight>("insights", Insights);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UserExperienceAnalyticsMetric>("metricValues", MetricValues);
        }
    }
}
#pragma warning restore CS0618
