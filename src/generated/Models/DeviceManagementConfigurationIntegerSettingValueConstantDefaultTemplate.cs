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
    /// Integer Setting Value Constant Default Template
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate : global::ApiSdk.Models.DeviceManagementConfigurationIntegerSettingValueDefaultTemplate, IParsable
    {
        /// <summary>Default Constant Value. Valid values -2147483648 to 2147483647</summary>
        public int? ConstantValue { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "constantValue", n => { ConstantValue = n.GetIntValue(); } },
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
            writer.WriteIntValue("constantValue", ConstantValue);
        }
    }
}
#pragma warning restore CS0618
