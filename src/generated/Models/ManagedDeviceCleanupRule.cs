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
    /// Define the rule when the admin wants the devices to be cleaned up.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedDeviceCleanupRule : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Indicates the description for the device clean up rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Define the platform type for which the admin wants to create the device clean up rule</summary>
        public global::ApiSdk.Models.DeviceCleanupRulePlatformType? DeviceCleanupRulePlatformType { get; set; }
        /// <summary>Indicates the number of days when the device has not contacted Intune. Valid values 0 to 2147483647</summary>
        public int? DeviceInactivityBeforeRetirementInDays { get; set; }
        /// <summary>Indicates the display name of the device cleanup rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicates the date and time when the device cleanup rule was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedDeviceCleanupRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ManagedDeviceCleanupRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ManagedDeviceCleanupRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceCleanupRulePlatformType", n => { DeviceCleanupRulePlatformType = n.GetEnumValue<global::ApiSdk.Models.DeviceCleanupRulePlatformType>(); } },
                { "deviceInactivityBeforeRetirementInDays", n => { DeviceInactivityBeforeRetirementInDays = n.GetIntValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceCleanupRulePlatformType>("deviceCleanupRulePlatformType", DeviceCleanupRulePlatformType);
            writer.WriteIntValue("deviceInactivityBeforeRetirementInDays", DeviceInactivityBeforeRetirementInDays);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
#pragma warning restore CS0618
