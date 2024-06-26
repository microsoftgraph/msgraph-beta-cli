// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants
{
    #pragma warning disable CS1591
    public class DeviceHealthStatus : ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The blueScreenCount property</summary>
        public int? BlueScreenCount { get; set; }
        /// <summary>The bootTotalDurationInSeconds property</summary>
        public double? BootTotalDurationInSeconds { get; set; }
        /// <summary>The deviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The deviceMake property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceMake { get; set; }
#nullable restore
#else
        public string DeviceMake { get; set; }
#endif
        /// <summary>The deviceModel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel { get; set; }
#nullable restore
#else
        public string DeviceModel { get; set; }
#endif
        /// <summary>The deviceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>The healthStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HealthStatus { get; set; }
#nullable restore
#else
        public string HealthStatus { get; set; }
#endif
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The osVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>The primaryDiskType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryDiskType { get; set; }
#nullable restore
#else
        public string PrimaryDiskType { get; set; }
#endif
        /// <summary>The restartCount property</summary>
        public int? RestartCount { get; set; }
        /// <summary>The startupPerformanceScore property</summary>
        public double? StartupPerformanceScore { get; set; }
        /// <summary>The tenantDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName { get; set; }
#nullable restore
#else
        public string TenantDisplayName { get; set; }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The topProcesses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TopProcesses { get; set; }
#nullable restore
#else
        public string TopProcesses { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceHealthStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "blueScreenCount", n => { BlueScreenCount = n.GetIntValue(); } },
                { "bootTotalDurationInSeconds", n => { BootTotalDurationInSeconds = n.GetDoubleValue(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "deviceMake", n => { DeviceMake = n.GetStringValue(); } },
                { "deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "healthStatus", n => { HealthStatus = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "osVersion", n => { OsVersion = n.GetStringValue(); } },
                { "primaryDiskType", n => { PrimaryDiskType = n.GetStringValue(); } },
                { "restartCount", n => { RestartCount = n.GetIntValue(); } },
                { "startupPerformanceScore", n => { StartupPerformanceScore = n.GetDoubleValue(); } },
                { "tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "topProcesses", n => { TopProcesses = n.GetStringValue(); } },
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
            writer.WriteIntValue("blueScreenCount", BlueScreenCount);
            writer.WriteDoubleValue("bootTotalDurationInSeconds", BootTotalDurationInSeconds);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceMake", DeviceMake);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("healthStatus", HealthStatus);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("primaryDiskType", PrimaryDiskType);
            writer.WriteIntValue("restartCount", RestartCount);
            writer.WriteDoubleValue("startupPerformanceScore", StartupPerformanceScore);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topProcesses", TopProcesses);
        }
    }
}
