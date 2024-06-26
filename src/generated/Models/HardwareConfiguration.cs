// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// BIOS configuration and other settings provides customers the ability to configure hardware/bios settings on the enrolled Windows 10/11 Entra ID joined devices by uploading a configuration file generated with their OEM tool (e.g. Dell Command tool). A BIOS configuration policy can be assigned to multiple devices, allowing admins to remotely control a device&apos;s hardware properties (e.g. enable Secure Boot) from the Intune Portal.
    /// </summary>
    public class HardwareConfiguration : Entity, IParsable
    {
        /// <summary>A list of the Entra user group ids that hardware configuration will be applied to. Only security groups and Office 365 Groups are supported. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HardwareConfigurationAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<HardwareConfigurationAssignment> Assignments { get; set; }
#endif
        /// <summary>The file content contains custom hardware settings that will be applied to the assigned devices&apos; BIOS. Max allowed file size is 5KB. Represented as bytes. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ConfigurationFileContent { get; set; }
#nullable restore
#else
        public byte[] ConfigurationFileContent { get; set; }
#endif
        /// <summary>The date and time  of when the BIOS configuration profile was created. The value cannot be modified and is automatically populated when the device is enrolled. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-Only. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>The description of the hardware configuration. Use this to provide context, purpose, applications, etc of the BIOS configuration profile for your organization&apos;s admins. Max length is 1000 characters. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>List of run states for the hardware configuration across all devices. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HardwareConfigurationDeviceState>? DeviceRunStates { get; set; }
#nullable restore
#else
        public List<HardwareConfigurationDeviceState> DeviceRunStates { get; set; }
#endif
        /// <summary>The name of the hardware BIOS configuration profile. It serves as user-friendly name to identify hardware BIOS configuration profiles. Max length is 150 characters. Required. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The file name for the BIOS configuration profile&apos;s ConfigurationFileContent. Max length is 150 characters. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>Indicates the supported oems of hardware configuration</summary>
        public ApiSdk.Models.HardwareConfigurationFormat? HardwareConfigurationFormat { get; set; }
        /// <summary>The date and time  of when the BIOS configuration profile was last modified. The value cannot be modified and is automatically populated when the device is enrolled. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-Only. Read-Only. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>When TRUE, indicates whether the policy-assigned devices&apos; passwords are disabled. When FALSE, indicates they are enabled. Default is FALSE. Required.</summary>
        public bool? PerDevicePasswordDisabled { get; set; }
        /// <summary>A list of unique Scope Tag IDs associated with the hardware configuration. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>A summary of the results from an attempt to configure hardware settings. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HardwareConfigurationRunSummary? RunSummary { get; set; }
#nullable restore
#else
        public HardwareConfigurationRunSummary RunSummary { get; set; }
#endif
        /// <summary>List of run states for the hardware configuration across all users. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HardwareConfigurationUserState>? UserRunStates { get; set; }
#nullable restore
#else
        public List<HardwareConfigurationUserState> UserRunStates { get; set; }
#endif
        /// <summary>The version of the hardware configuration (E.g. 1, 2, 3 ...). This is incremented after a change to the BIOS configuration profile&apos;s settings file name (FileName property), settings file content (ConfigurationFileContent property), or the PerDevicePasswordDisabled property. Read-Only.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HardwareConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HardwareConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HardwareConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<HardwareConfigurationAssignment>(HardwareConfigurationAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "configurationFileContent", n => { ConfigurationFileContent = n.GetByteArrayValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<HardwareConfigurationDeviceState>(HardwareConfigurationDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "hardwareConfigurationFormat", n => { HardwareConfigurationFormat = n.GetEnumValue<HardwareConfigurationFormat>(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "perDevicePasswordDisabled", n => { PerDevicePasswordDisabled = n.GetBoolValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "runSummary", n => { RunSummary = n.GetObjectValue<HardwareConfigurationRunSummary>(HardwareConfigurationRunSummary.CreateFromDiscriminatorValue); } },
                { "userRunStates", n => { UserRunStates = n.GetCollectionOfObjectValues<HardwareConfigurationUserState>(HardwareConfigurationUserState.CreateFromDiscriminatorValue)?.ToList(); } },
                { "version", n => { Version = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<HardwareConfigurationAssignment>("assignments", Assignments);
            writer.WriteByteArrayValue("configurationFileContent", ConfigurationFileContent);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<HardwareConfigurationDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteEnumValue<HardwareConfigurationFormat>("hardwareConfigurationFormat", HardwareConfigurationFormat);
            writer.WriteBoolValue("perDevicePasswordDisabled", PerDevicePasswordDisabled);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteObjectValue<HardwareConfigurationRunSummary>("runSummary", RunSummary);
            writer.WriteCollectionOfObjectValues<HardwareConfigurationUserState>("userRunStates", UserRunStates);
            writer.WriteIntValue("version", Version);
        }
    }
}
