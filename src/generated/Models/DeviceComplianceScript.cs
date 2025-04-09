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
    /// Intune will provide customer the ability to run their Powershell Compliance scripts (detection) on the enrolled windows 10 Azure Active Directory joined devices.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceComplianceScript : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The list of group assignments for the device compliance script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceHealthScriptAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceHealthScriptAssignment> Assignments { get; set; }
#endif
        /// <summary>The timestamp of when the device compliance script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>Description of the device compliance script</summary>
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
        /// <summary>List of run states for the device compliance script across all devices</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceComplianceScriptDeviceState>? DeviceRunStates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceComplianceScriptDeviceState> DeviceRunStates { get; set; }
#endif
        /// <summary>Name of the device compliance script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicate whether the script signature needs be checked</summary>
        public bool? EnforceSignatureCheck { get; set; }
        /// <summary>The timestamp of when the device compliance script was modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>Name of the device compliance script publisher</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher { get; set; }
#nullable restore
#else
        public string Publisher { get; set; }
#endif
        /// <summary>List of Scope Tag IDs for the device compliance script</summary>
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
        public global::ApiSdk.Models.RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>High level run summary for device compliance script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceComplianceScriptRunSummary? RunSummary { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceComplianceScriptRunSummary RunSummary { get; set; }
#endif
        /// <summary>Version of the device compliance script</summary>
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
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceComplianceScript"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceComplianceScript CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceComplianceScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceHealthScriptAssignment>(global::ApiSdk.Models.DeviceHealthScriptAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detectionScriptContent", n => { DetectionScriptContent = n.GetByteArrayValue(); } },
                { "deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceComplianceScriptDeviceState>(global::ApiSdk.Models.DeviceComplianceScriptDeviceState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "publisher", n => { Publisher = n.GetStringValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                { "runAsAccount", n => { RunAsAccount = n.GetEnumValue<global::ApiSdk.Models.RunAsAccountType>(); } },
                { "runSummary", n => { RunSummary = n.GetObjectValue<global::ApiSdk.Models.DeviceComplianceScriptRunSummary>(global::ApiSdk.Models.DeviceComplianceScriptRunSummary.CreateFromDiscriminatorValue); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceHealthScriptAssignment>("assignments", Assignments);
            writer.WriteStringValue("description", Description);
            writer.WriteByteArrayValue("detectionScriptContent", DetectionScriptContent);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceComplianceScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<global::ApiSdk.Models.RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceComplianceScriptRunSummary>("runSummary", RunSummary);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
