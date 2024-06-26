// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// The user experience analytics battery health os performance entity contains battery related information for all operating system versions in their organization.
    /// </summary>
    public class UserExperienceAnalyticsBatteryHealthOsPerformance : Entity, IParsable
    {
        /// <summary>Number of active devices for that os version. Valid values 0 to 2147483647</summary>
        public int? ActiveDevices { get; set; }
        /// <summary>The mean of the battery age for all devices running a particular operating system version in a tenant. Unit in days. Valid values 0 to 2147483647</summary>
        public int? AverageBatteryAgeInDays { get; set; }
        /// <summary>The mean of the estimated runtimes on full charge for all devices running a particular operating system version. Unit in minutes. Valid values 0 to 2147483647</summary>
        public int? AverageEstimatedRuntimeInMinutes { get; set; }
        /// <summary>The mean of the maximum capacity for all devices running a particular operating system version. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values 0 to 2147483647</summary>
        public int? AverageMaxCapacityPercentage { get; set; }
        /// <summary>The mean of number of times the battery has been discharged an amount that equals 100% of its capacity for all devices running a particular operating system version in a tenant. Valid values 0 to 2147483647</summary>
        public int? MeanFullBatteryDrainCount { get; set; }
        /// <summary>The median of the estimated runtimes on full charge for all devices running a particular operating system version. Unit in minutes. Valid values 0 to 2147483647</summary>
        public int? MedianEstimatedRuntimeInMinutes { get; set; }
        /// <summary>The median of number of times the battery has been discharged an amount that equals 100% of its capacity for all devices running a particular operating system version in a tenant. Valid values 0 to 2147483647</summary>
        public int? MedianFullBatteryDrainCount { get; set; }
        /// <summary>The median of the maximum capacity for all devices running a particular operating system version. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values 0 to 2147483647</summary>
        public int? MedianMaxCapacityPercentage { get; set; }
        /// <summary>A weighted average of battery health score across all devices running a particular operating system version. Values range from 0-100. Valid values 0 to 2147483647</summary>
        public int? OsBatteryHealthScore { get; set; }
        /// <summary>Build number of the operating system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsBuildNumber { get; set; }
#nullable restore
#else
        public string OsBuildNumber { get; set; }
#endif
        /// <summary>The osHealthStatus property</summary>
        public UserExperienceAnalyticsHealthState? OsHealthStatus { get; set; }
        /// <summary>Version of the operating system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserExperienceAnalyticsBatteryHealthOsPerformance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsBatteryHealthOsPerformance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthOsPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDevices", n => { ActiveDevices = n.GetIntValue(); } },
                { "averageBatteryAgeInDays", n => { AverageBatteryAgeInDays = n.GetIntValue(); } },
                { "averageEstimatedRuntimeInMinutes", n => { AverageEstimatedRuntimeInMinutes = n.GetIntValue(); } },
                { "averageMaxCapacityPercentage", n => { AverageMaxCapacityPercentage = n.GetIntValue(); } },
                { "meanFullBatteryDrainCount", n => { MeanFullBatteryDrainCount = n.GetIntValue(); } },
                { "medianEstimatedRuntimeInMinutes", n => { MedianEstimatedRuntimeInMinutes = n.GetIntValue(); } },
                { "medianFullBatteryDrainCount", n => { MedianFullBatteryDrainCount = n.GetIntValue(); } },
                { "medianMaxCapacityPercentage", n => { MedianMaxCapacityPercentage = n.GetIntValue(); } },
                { "osBatteryHealthScore", n => { OsBatteryHealthScore = n.GetIntValue(); } },
                { "osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                { "osHealthStatus", n => { OsHealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                { "osVersion", n => { OsVersion = n.GetStringValue(); } },
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
            writer.WriteIntValue("activeDevices", ActiveDevices);
            writer.WriteIntValue("averageBatteryAgeInDays", AverageBatteryAgeInDays);
            writer.WriteIntValue("averageEstimatedRuntimeInMinutes", AverageEstimatedRuntimeInMinutes);
            writer.WriteIntValue("averageMaxCapacityPercentage", AverageMaxCapacityPercentage);
            writer.WriteIntValue("meanFullBatteryDrainCount", MeanFullBatteryDrainCount);
            writer.WriteIntValue("medianEstimatedRuntimeInMinutes", MedianEstimatedRuntimeInMinutes);
            writer.WriteIntValue("medianFullBatteryDrainCount", MedianFullBatteryDrainCount);
            writer.WriteIntValue("medianMaxCapacityPercentage", MedianMaxCapacityPercentage);
            writer.WriteIntValue("osBatteryHealthScore", OsBatteryHealthScore);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("osHealthStatus", OsHealthStatus);
            writer.WriteStringValue("osVersion", OsVersion);
        }
    }
}
