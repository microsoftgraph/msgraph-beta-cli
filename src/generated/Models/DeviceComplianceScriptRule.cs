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
    public partial class DeviceComplianceScriptRule : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Data types for rules.</summary>
        public global::ApiSdk.Models.DataType? DataType { get; set; }
        /// <summary>Data types for rules.</summary>
        public global::ApiSdk.Models.DeviceComplianceScriptRuleDataType? DeviceComplianceScriptRuleDataType { get; set; }
        /// <summary>Operator for rules.</summary>
        public global::ApiSdk.Models.DeviceComplianceScriptRulOperator? DeviceComplianceScriptRulOperator { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Operand specified in the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operand { get; set; }
#nullable restore
#else
        public string Operand { get; set; }
#endif
        /// <summary>Operator for rules.</summary>
        public global::ApiSdk.Models.Operator? Operator { get; set; }
        /// <summary>Setting name specified in the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingName { get; set; }
#nullable restore
#else
        public string SettingName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceComplianceScriptRule"/> and sets the default values.
        /// </summary>
        public DeviceComplianceScriptRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceComplianceScriptRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.DeviceComplianceScriptRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceComplianceScriptRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dataType", n => { DataType = n.GetEnumValue<global::ApiSdk.Models.DataType>(); } },
                { "deviceComplianceScriptRulOperator", n => { DeviceComplianceScriptRulOperator = n.GetEnumValue<global::ApiSdk.Models.DeviceComplianceScriptRulOperator>(); } },
                { "deviceComplianceScriptRuleDataType", n => { DeviceComplianceScriptRuleDataType = n.GetEnumValue<global::ApiSdk.Models.DeviceComplianceScriptRuleDataType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "operand", n => { Operand = n.GetStringValue(); } },
                { "operator", n => { Operator = n.GetEnumValue<global::ApiSdk.Models.Operator>(); } },
                { "settingName", n => { SettingName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.DataType>("dataType", DataType);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceComplianceScriptRuleDataType>("deviceComplianceScriptRuleDataType", DeviceComplianceScriptRuleDataType);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceComplianceScriptRulOperator>("deviceComplianceScriptRulOperator", DeviceComplianceScriptRulOperator);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operand", Operand);
            writer.WriteEnumValue<global::ApiSdk.Models.Operator>("operator", Operator);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
