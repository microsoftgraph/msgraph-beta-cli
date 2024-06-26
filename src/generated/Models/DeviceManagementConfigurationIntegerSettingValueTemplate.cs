// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Integer Setting Value Template
    /// </summary>
    public class DeviceManagementConfigurationIntegerSettingValueTemplate : DeviceManagementConfigurationSimpleSettingValueTemplate, IParsable
    {
        /// <summary>Integer Setting Value Default Template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationIntegerSettingValueDefaultTemplate? DefaultValue { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationIntegerSettingValueDefaultTemplate DefaultValue { get; set; }
#endif
        /// <summary>Recommended value definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate? RecommendedValueDefinition { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate RecommendedValueDefinition { get; set; }
#endif
        /// <summary>Required value definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate? RequiredValueDefinition { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate RequiredValueDefinition { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementConfigurationIntegerSettingValueTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationIntegerSettingValueTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationIntegerSettingValueTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementConfigurationIntegerSettingValueTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationIntegerSettingValueTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationIntegerSettingValueTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "defaultValue", n => { DefaultValue = n.GetObjectValue<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate>(DeviceManagementConfigurationIntegerSettingValueDefaultTemplate.CreateFromDiscriminatorValue); } },
                { "recommendedValueDefinition", n => { RecommendedValueDefinition = n.GetObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>(DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
                { "requiredValueDefinition", n => { RequiredValueDefinition = n.GetObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>(DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefaultTemplate>("defaultValue", DefaultValue);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("recommendedValueDefinition", RecommendedValueDefinition);
            writer.WriteObjectValue<DeviceManagementConfigurationIntegerSettingValueDefinitionTemplate>("requiredValueDefinition", RequiredValueDefinition);
        }
    }
}
