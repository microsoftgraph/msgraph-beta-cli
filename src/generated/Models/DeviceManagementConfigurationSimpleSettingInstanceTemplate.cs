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
    /// Simple Setting Instance Template
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationSimpleSettingInstanceTemplate : global::ApiSdk.Models.DeviceManagementConfigurationSettingInstanceTemplate, IParsable
    {
        /// <summary>Simple Setting Value Template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValueTemplate? SimpleSettingValueTemplate { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValueTemplate SimpleSettingValueTemplate { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingInstanceTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingInstanceTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingInstanceTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "simpleSettingValueTemplate", n => { SimpleSettingValueTemplate = n.GetObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValueTemplate>(global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValueTemplate.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValueTemplate>("simpleSettingValueTemplate", SimpleSettingValueTemplate);
        }
    }
}
#pragma warning restore CS0618
