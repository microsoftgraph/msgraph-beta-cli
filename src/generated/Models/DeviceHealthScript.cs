// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Intune will provide customer the ability to run their Powershell Health scripts (remediation + detection) on the enrolled windows 10 Azure Active Directory joined devices.
    /// </summary>
    public class DeviceHealthScript : Entity, IParsable 
    {
        /// <summary>The list of group assignments for the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<DeviceHealthScriptAssignment> Assignments { get; set; }
#endif
        /// <summary>The timestamp of when the device health script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>Description of the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The entire content of the detection powershell script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? DetectionScriptContent { get; set; }
#nullable restore
#else
        public byte[] DetectionScriptContent { get; set; }
#endif
        /// <summary>List of ComplexType DetectionScriptParameters objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptParameter>? DetectionScriptParameters { get; set; }
#nullable restore
#else
        public List<DeviceHealthScriptParameter> DetectionScriptParameters { get; set; }
#endif
        /// <summary>Indicates the type of device script.</summary>
        public ApiSdk.Models.DeviceHealthScriptType? DeviceHealthScriptType { get; set; }
        /// <summary>List of run states for the device health script across all devices</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptDeviceState>? DeviceRunStates { get; set; }
#nullable restore
#else
        public List<DeviceHealthScriptDeviceState> DeviceRunStates { get; set; }
#endif
        /// <summary>Name of the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicate whether the script signature needs be checked</summary>
        public bool? EnforceSignatureCheck { get; set; }
        /// <summary>Highest available version for a Microsoft Proprietary script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HighestAvailableVersion { get; set; }
#nullable restore
#else
        public string HighestAvailableVersion { get; set; }
#endif
        /// <summary>Determines if this is Microsoft Proprietary Script. Proprietary scripts are read-only</summary>
        public bool? IsGlobalScript { get; set; }
        /// <summary>The timestamp of when the device health script was modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>Name of the device health script publisher</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher { get; set; }
#nullable restore
#else
        public string Publisher { get; set; }
#endif
        /// <summary>The entire content of the remediation powershell script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? RemediationScriptContent { get; set; }
#nullable restore
#else
        public byte[] RemediationScriptContent { get; set; }
#endif
        /// <summary>List of ComplexType RemediationScriptParameters objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptParameter>? RemediationScriptParameters { get; set; }
#nullable restore
#else
        public List<DeviceHealthScriptParameter> RemediationScriptParameters { get; set; }
#endif
        /// <summary>List of Scope Tag IDs for the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>Indicate whether PowerShell script(s) should run as 32-bit</summary>
        public bool? RunAs32Bit { get; set; }
        /// <summary>Indicates the type of execution context the app runs in.</summary>
        public RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>High level run summary for device health script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceHealthScriptRunSummary? RunSummary { get; set; }
#nullable restore
#else
        public DeviceHealthScriptRunSummary RunSummary { get; set; }
#endif
        /// <summary>Version of the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceHealthScript"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScript CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceHealthScriptAssignment>(DeviceHealthScriptAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detectionScriptContent", n => { DetectionScriptContent = n.GetByteArrayValue(); } },
                {"detectionScriptParameters", n => { DetectionScriptParameters = n.GetCollectionOfObjectValues<DeviceHealthScriptParameter>(DeviceHealthScriptParameter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceHealthScriptType", n => { DeviceHealthScriptType = n.GetEnumValue<DeviceHealthScriptType>(); } },
                {"deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<DeviceHealthScriptDeviceState>(DeviceHealthScriptDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                {"highestAvailableVersion", n => { HighestAvailableVersion = n.GetStringValue(); } },
                {"isGlobalScript", n => { IsGlobalScript = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"remediationScriptContent", n => { RemediationScriptContent = n.GetByteArrayValue(); } },
                {"remediationScriptParameters", n => { RemediationScriptParameters = n.GetCollectionOfObjectValues<DeviceHealthScriptParameter>(DeviceHealthScriptParameter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", n => { RunSummary = n.GetObjectValue<DeviceHealthScriptRunSummary>(DeviceHealthScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptAssignment>("assignments", Assignments);
            writer.WriteStringValue("description", Description);
            writer.WriteByteArrayValue("detectionScriptContent", DetectionScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptParameter>("detectionScriptParameters", DetectionScriptParameters);
            writer.WriteEnumValue<DeviceHealthScriptType>("deviceHealthScriptType", DeviceHealthScriptType);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteStringValue("highestAvailableVersion", HighestAvailableVersion);
            writer.WriteBoolValue("isGlobalScript", IsGlobalScript);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteByteArrayValue("remediationScriptContent", RemediationScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptParameter>("remediationScriptParameters", RemediationScriptParameters);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceHealthScriptRunSummary>("runSummary", RunSummary);
            writer.WriteStringValue("version", Version);
        }
    }
}