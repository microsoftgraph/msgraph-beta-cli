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
    /// The user experience analytics anomaly correlation group overview entity contains the information for each correlation group of an anomaly.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserExperienceAnalyticsAnomalyCorrelationGroupOverview : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Indicates the number of correlation groups in the anomaly. Valid values -2147483648 to 2147483647</summary>
        public int? AnomalyCorrelationGroupCount { get; set; }
        /// <summary>The unique identifier of the anomaly. Anomaly details such as name and type can be found in the UserExperienceAnalyticsAnomalySeverityOverview entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnomalyId { get; set; }
#nullable restore
#else
        public string AnomalyId { get; set; }
#endif
        /// <summary>Indicates the total number of devices affected by the anomaly in the correlation group. Valid values -2147483648 to 2147483647</summary>
        public int? CorrelationGroupAnomalousDeviceCount { get; set; }
        /// <summary>Indicates the total number of devices at risk in the correlation group. Valid values -2147483648 to 2147483647</summary>
        public int? CorrelationGroupAtRiskDeviceCount { get; set; }
        /// <summary>Indicates the total number of devices in a correlation group. Valid values -2147483648 to 2147483647</summary>
        public int? CorrelationGroupDeviceCount { get; set; }
        /// <summary>Describes the features of a device that are shared between all devices in a correlation group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupFeature>? CorrelationGroupFeatures { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupFeature> CorrelationGroupFeatures { get; set; }
#endif
        /// <summary>The unique identifier for the correlation group which will uniquely identify one of the correlation group within an anomaly. The correlation Id can be mapped to the correlation group name by concatinating the correlation group features. Example of correlation group name which is the indicative of concatenated features names are  for names, Contoso manufacture 4.4.1 and Windows 11.22621.1485.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationGroupId { get; set; }
#nullable restore
#else
        public string CorrelationGroupId { get; set; }
#endif
        /// <summary>Indicates the level of prevalence of the correlation group features in the anomaly. Possible values are: high, medium or low</summary>
        public global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence? CorrelationGroupPrevalence { get; set; }
        /// <summary>The percentage of the devices in the correlation group that are anomalous. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CorrelationGroupPrevalencePercentage { get; set; }
        /// <summary>Indicates the total number of devices in the tenant. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "anomalyCorrelationGroupCount", n => { AnomalyCorrelationGroupCount = n.GetIntValue(); } },
                { "anomalyId", n => { AnomalyId = n.GetStringValue(); } },
                { "correlationGroupAnomalousDeviceCount", n => { CorrelationGroupAnomalousDeviceCount = n.GetIntValue(); } },
                { "correlationGroupAtRiskDeviceCount", n => { CorrelationGroupAtRiskDeviceCount = n.GetIntValue(); } },
                { "correlationGroupDeviceCount", n => { CorrelationGroupDeviceCount = n.GetIntValue(); } },
                { "correlationGroupFeatures", n => { CorrelationGroupFeatures = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupFeature>(global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupFeature.CreateFromDiscriminatorValue)?.AsList(); } },
                { "correlationGroupId", n => { CorrelationGroupId = n.GetStringValue(); } },
                { "correlationGroupPrevalence", n => { CorrelationGroupPrevalence = n.GetEnumValue<global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence>(); } },
                { "correlationGroupPrevalencePercentage", n => { CorrelationGroupPrevalencePercentage = n.GetDoubleValue(); } },
                { "totalDeviceCount", n => { TotalDeviceCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("anomalyCorrelationGroupCount", AnomalyCorrelationGroupCount);
            writer.WriteStringValue("anomalyId", AnomalyId);
            writer.WriteIntValue("correlationGroupAnomalousDeviceCount", CorrelationGroupAnomalousDeviceCount);
            writer.WriteIntValue("correlationGroupAtRiskDeviceCount", CorrelationGroupAtRiskDeviceCount);
            writer.WriteIntValue("correlationGroupDeviceCount", CorrelationGroupDeviceCount);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupFeature>("correlationGroupFeatures", CorrelationGroupFeatures);
            writer.WriteStringValue("correlationGroupId", CorrelationGroupId);
            writer.WriteEnumValue<global::ApiSdk.Models.UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence>("correlationGroupPrevalence", CorrelationGroupPrevalence);
            writer.WriteDoubleValue("correlationGroupPrevalencePercentage", CorrelationGroupPrevalencePercentage);
            writer.WriteIntValue("totalDeviceCount", TotalDeviceCount);
        }
    }
}
#pragma warning restore CS0618
