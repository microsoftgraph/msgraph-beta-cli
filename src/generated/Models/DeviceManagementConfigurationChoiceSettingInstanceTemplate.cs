// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Choice Setting Instance Template
    /// </summary>
    public class DeviceManagementConfigurationChoiceSettingInstanceTemplate : DeviceManagementConfigurationSettingInstanceTemplate, IParsable 
    {
        /// <summary>Choice Setting Value Template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationChoiceSettingValueTemplate? ChoiceSettingValueTemplate { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationChoiceSettingValueTemplate ChoiceSettingValueTemplate { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementConfigurationChoiceSettingInstanceTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingInstanceTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationChoiceSettingInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementConfigurationChoiceSettingInstanceTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationChoiceSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationChoiceSettingInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"choiceSettingValueTemplate", n => { ChoiceSettingValueTemplate = n.GetObjectValue<DeviceManagementConfigurationChoiceSettingValueTemplate>(DeviceManagementConfigurationChoiceSettingValueTemplate.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<DeviceManagementConfigurationChoiceSettingValueTemplate>("choiceSettingValueTemplate", ChoiceSettingValueTemplate);
        }
    }
}