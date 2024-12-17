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
    /// Represents an Autopilot flow event.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementAutopilotEvent : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Time spent in user ESP.</summary>
        public TimeSpan? AccountSetupDuration { get; set; }
        /// <summary>Deployment states for Autopilot devices</summary>
        public global::ApiSdk.Models.WindowsAutopilotDeploymentState? AccountSetupStatus { get; set; }
        /// <summary>Autopilot deployment duration including enrollment.</summary>
        public TimeSpan? DeploymentDuration { get; set; }
        /// <summary>Deployment end time.</summary>
        public DateTimeOffset? DeploymentEndDateTime { get; set; }
        /// <summary>Deployment start time.</summary>
        public DateTimeOffset? DeploymentStartDateTime { get; set; }
        /// <summary>Deployment states for Autopilot devices</summary>
        public global::ApiSdk.Models.WindowsAutopilotDeploymentState? DeploymentState { get; set; }
        /// <summary>Total deployment duration from enrollment to Desktop screen.</summary>
        public TimeSpan? DeploymentTotalDuration { get; set; }
        /// <summary>Device id associated with the object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>Device registration date.</summary>
        public DateTimeOffset? DeviceRegisteredDateTime { get; set; }
        /// <summary>Device serial number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceSerialNumber { get; set; }
#nullable restore
#else
        public string DeviceSerialNumber { get; set; }
#endif
        /// <summary>Time spent in device ESP.</summary>
        public TimeSpan? DeviceSetupDuration { get; set; }
        /// <summary>Deployment states for Autopilot devices</summary>
        public global::ApiSdk.Models.WindowsAutopilotDeploymentState? DeviceSetupStatus { get; set; }
        /// <summary>Enrollment failure details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrollmentFailureDetails { get; set; }
#nullable restore
#else
        public string EnrollmentFailureDetails { get; set; }
#endif
        /// <summary>Device enrollment start date.</summary>
        public DateTimeOffset? EnrollmentStartDateTime { get; set; }
        /// <summary>The enrollmentState property</summary>
        public global::ApiSdk.Models.EnrollmentState? EnrollmentState { get; set; }
        /// <summary>The enrollmentType property</summary>
        public global::ApiSdk.Models.WindowsAutopilotEnrollmentType? EnrollmentType { get; set; }
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Managed device name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName { get; set; }
#nullable restore
#else
        public string ManagedDeviceName { get; set; }
#endif
        /// <summary>Device operating system version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>UserId id associated with the object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>User principal name used to enroll the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>Enrollment Status Page profile name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Windows10EnrollmentCompletionPageConfigurationDisplayName { get; set; }
#nullable restore
#else
        public string Windows10EnrollmentCompletionPageConfigurationDisplayName { get; set; }
#endif
        /// <summary>Enrollment Status Page profile ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Windows10EnrollmentCompletionPageConfigurationId { get; set; }
#nullable restore
#else
        public string Windows10EnrollmentCompletionPageConfigurationId { get; set; }
#endif
        /// <summary>Autopilot profile name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WindowsAutopilotDeploymentProfileDisplayName { get; set; }
#nullable restore
#else
        public string WindowsAutopilotDeploymentProfileDisplayName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceManagementAutopilotEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceManagementAutopilotEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceManagementAutopilotEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountSetupDuration", n => { AccountSetupDuration = n.GetTimeSpanValue(); } },
                { "accountSetupStatus", n => { AccountSetupStatus = n.GetEnumValue<global::ApiSdk.Models.WindowsAutopilotDeploymentState>(); } },
                { "deploymentDuration", n => { DeploymentDuration = n.GetTimeSpanValue(); } },
                { "deploymentEndDateTime", n => { DeploymentEndDateTime = n.GetDateTimeOffsetValue(); } },
                { "deploymentStartDateTime", n => { DeploymentStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "deploymentState", n => { DeploymentState = n.GetEnumValue<global::ApiSdk.Models.WindowsAutopilotDeploymentState>(); } },
                { "deploymentTotalDuration", n => { DeploymentTotalDuration = n.GetTimeSpanValue(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "deviceRegisteredDateTime", n => { DeviceRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                { "deviceSerialNumber", n => { DeviceSerialNumber = n.GetStringValue(); } },
                { "deviceSetupDuration", n => { DeviceSetupDuration = n.GetTimeSpanValue(); } },
                { "deviceSetupStatus", n => { DeviceSetupStatus = n.GetEnumValue<global::ApiSdk.Models.WindowsAutopilotDeploymentState>(); } },
                { "enrollmentFailureDetails", n => { EnrollmentFailureDetails = n.GetStringValue(); } },
                { "enrollmentStartDateTime", n => { EnrollmentStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "enrollmentState", n => { EnrollmentState = n.GetEnumValue<global::ApiSdk.Models.EnrollmentState>(); } },
                { "enrollmentType", n => { EnrollmentType = n.GetEnumValue<global::ApiSdk.Models.WindowsAutopilotEnrollmentType>(); } },
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                { "osVersion", n => { OsVersion = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "windows10EnrollmentCompletionPageConfigurationDisplayName", n => { Windows10EnrollmentCompletionPageConfigurationDisplayName = n.GetStringValue(); } },
                { "windows10EnrollmentCompletionPageConfigurationId", n => { Windows10EnrollmentCompletionPageConfigurationId = n.GetStringValue(); } },
                { "windowsAutopilotDeploymentProfileDisplayName", n => { WindowsAutopilotDeploymentProfileDisplayName = n.GetStringValue(); } },
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
            writer.WriteTimeSpanValue("accountSetupDuration", AccountSetupDuration);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsAutopilotDeploymentState>("accountSetupStatus", AccountSetupStatus);
            writer.WriteTimeSpanValue("deploymentDuration", DeploymentDuration);
            writer.WriteDateTimeOffsetValue("deploymentEndDateTime", DeploymentEndDateTime);
            writer.WriteDateTimeOffsetValue("deploymentStartDateTime", DeploymentStartDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsAutopilotDeploymentState>("deploymentState", DeploymentState);
            writer.WriteTimeSpanValue("deploymentTotalDuration", DeploymentTotalDuration);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("deviceRegisteredDateTime", DeviceRegisteredDateTime);
            writer.WriteStringValue("deviceSerialNumber", DeviceSerialNumber);
            writer.WriteTimeSpanValue("deviceSetupDuration", DeviceSetupDuration);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsAutopilotDeploymentState>("deviceSetupStatus", DeviceSetupStatus);
            writer.WriteStringValue("enrollmentFailureDetails", EnrollmentFailureDetails);
            writer.WriteDateTimeOffsetValue("enrollmentStartDateTime", EnrollmentStartDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsAutopilotEnrollmentType>("enrollmentType", EnrollmentType);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("windows10EnrollmentCompletionPageConfigurationDisplayName", Windows10EnrollmentCompletionPageConfigurationDisplayName);
            writer.WriteStringValue("windows10EnrollmentCompletionPageConfigurationId", Windows10EnrollmentCompletionPageConfigurationId);
            writer.WriteStringValue("windowsAutopilotDeploymentProfileDisplayName", WindowsAutopilotDeploymentProfileDisplayName);
        }
    }
}
#pragma warning restore CS0618
