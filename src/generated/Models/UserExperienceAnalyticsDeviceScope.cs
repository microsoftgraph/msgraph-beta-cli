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
    /// The user experience analytics device scope entity contains device scope configuration values use to apply filtering on the endpoint analytics reports.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserExperienceAnalyticsDeviceScope : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Indicates the creation date and time for the custom device scope.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The name of the user experience analytics device Scope configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceScopeName { get; set; }
#nullable restore
#else
        public string DeviceScopeName { get; set; }
#endif
        /// <summary>Indicates whether a device scope is enabled or disabled. When TRUE, the device scope is enabled. When FALSE, the device scope is disabled. Default value is FALSE.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Indicates whether the device scope configuration is built-in or custom. When TRUE, the device scope configuration is built-in. When FALSE, the device scope configuration is custom. Default value is FALSE.</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>Indicates the last updated date and time for the custom device scope.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Device scope configuration query operator. Possible values are: equals, notEquals, contains, notContains, greaterThan, lessThan. Default value: equals.</summary>
        public global::ApiSdk.Models.DeviceScopeOperator? Operator { get; set; }
        /// <summary>The unique identifier of the person (admin) who created the device scope configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId { get; set; }
#nullable restore
#else
        public string OwnerId { get; set; }
#endif
        /// <summary>Device scope configuration parameter. It will be expend in future to add more parameter. Eg: device scope parameter can be OS version, Disk Type, Device manufacturer, device model or Scope tag. Default value: scopeTag.</summary>
        public global::ApiSdk.Models.DeviceScopeParameter? Parameter { get; set; }
        /// <summary>Indicates the device scope status after the device scope has been enabled. Possible values are: none, computing, insufficientData or completed. Default value is none.</summary>
        public global::ApiSdk.Models.DeviceScopeStatus? Status { get; set; }
        /// <summary>The device scope configuration query clause value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>The unique identifier for a user device scope tag Id used for the creation of device scope configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueObjectId { get; set; }
#nullable restore
#else
        public string ValueObjectId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserExperienceAnalyticsDeviceScope"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UserExperienceAnalyticsDeviceScope CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserExperienceAnalyticsDeviceScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deviceScopeName", n => { DeviceScopeName = n.GetStringValue(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "operator", n => { Operator = n.GetEnumValue<global::ApiSdk.Models.DeviceScopeOperator>(); } },
                { "ownerId", n => { OwnerId = n.GetStringValue(); } },
                { "parameter", n => { Parameter = n.GetEnumValue<global::ApiSdk.Models.DeviceScopeParameter>(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.DeviceScopeStatus>(); } },
                { "value", n => { Value = n.GetStringValue(); } },
                { "valueObjectId", n => { ValueObjectId = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceScopeName", DeviceScopeName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceScopeOperator>("operator", Operator);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceScopeParameter>("parameter", Parameter);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceScopeStatus>("status", Status);
            writer.WriteStringValue("value", Value);
            writer.WriteStringValue("valueObjectId", ValueObjectId);
        }
    }
}
#pragma warning restore CS0618
