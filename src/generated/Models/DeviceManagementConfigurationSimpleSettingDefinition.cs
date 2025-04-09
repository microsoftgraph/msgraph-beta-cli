// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DeviceManagementConfigurationSimpleSettingDefinition : global::ApiSdk.Models.DeviceManagementConfigurationSettingDefinition, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Default setting value for this setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingValue? DefaultValue { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingValue DefaultValue { get; set; }
#endif
        /// <summary>list of child settings that depend on this setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceManagementConfigurationSettingDependedOnBy>? DependedOnBy { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy { get; set; }
#endif
        /// <summary>list of parent settings this setting is dependent on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceManagementConfigurationDependentOn>? DependentOn { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceManagementConfigurationDependentOn> DependentOn { get; set; }
#endif
        /// <summary>Definition of the value for this setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingValueDefinition? ValueDefinition { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingValueDefinition ValueDefinition { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingCollectionDefinition(),
                _ => new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "defaultValue", n => { DefaultValue = n.GetObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingValue>(global::ApiSdk.Models.DeviceManagementConfigurationSettingValue.CreateFromDiscriminatorValue); } },
                { "dependedOnBy", n => { DependedOnBy = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationSettingDependedOnBy>(global::ApiSdk.Models.DeviceManagementConfigurationSettingDependedOnBy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "dependentOn", n => { DependentOn = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationDependentOn>(global::ApiSdk.Models.DeviceManagementConfigurationDependentOn.CreateFromDiscriminatorValue)?.AsList(); } },
                { "valueDefinition", n => { ValueDefinition = n.GetObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingValueDefinition>(global::ApiSdk.Models.DeviceManagementConfigurationSettingValueDefinition.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingValue>("defaultValue", DefaultValue);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationSettingDependedOnBy>("dependedOnBy", DependedOnBy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationDependentOn>("dependentOn", DependentOn);
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingValueDefinition>("valueDefinition", ValueDefinition);
        }
    }
}
#pragma warning restore CS0618
