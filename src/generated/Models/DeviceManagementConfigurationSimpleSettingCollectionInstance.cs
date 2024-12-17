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
    /// Simple setting collection instance
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationSimpleSettingCollectionInstance : global::ApiSdk.Models.DeviceManagementConfigurationSettingInstance, IParsable
    {
        /// <summary>Simple setting collection instance value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValue>? SimpleSettingCollectionValue { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValue> SimpleSettingCollectionValue { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingCollectionInstance"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingCollectionInstance() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingCollectionInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingCollectionInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingCollectionInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "simpleSettingCollectionValue", n => { SimpleSettingCollectionValue = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValue>(global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValue.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingValue>("simpleSettingCollectionValue", SimpleSettingCollectionValue);
        }
    }
}
#pragma warning restore CS0618
