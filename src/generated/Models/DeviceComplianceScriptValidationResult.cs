// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class DeviceComplianceScriptValidationResult : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Errors in json for the script for rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceComplianceScriptRuleError>? RuleErrors { get; set; }
#nullable restore
#else
        public List<DeviceComplianceScriptRuleError> RuleErrors { get; set; }
#endif
        /// <summary>Parsed rules from json.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceComplianceScriptRule>? Rules { get; set; }
#nullable restore
#else
        public List<DeviceComplianceScriptRule> Rules { get; set; }
#endif
        /// <summary>Errors in json for the script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceComplianceScriptError>? ScriptErrors { get; set; }
#nullable restore
#else
        public List<DeviceComplianceScriptError> ScriptErrors { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DeviceComplianceScriptValidationResult"/> and sets the default values.
        /// </summary>
        public DeviceComplianceScriptValidationResult()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceComplianceScriptValidationResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceComplianceScriptValidationResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptValidationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "ruleErrors", n => { RuleErrors = n.GetCollectionOfObjectValues<DeviceComplianceScriptRuleError>(DeviceComplianceScriptRuleError.CreateFromDiscriminatorValue)?.ToList(); } },
                { "rules", n => { Rules = n.GetCollectionOfObjectValues<DeviceComplianceScriptRule>(DeviceComplianceScriptRule.CreateFromDiscriminatorValue)?.ToList(); } },
                { "scriptErrors", n => { ScriptErrors = n.GetCollectionOfObjectValues<DeviceComplianceScriptError>(DeviceComplianceScriptError.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptRuleError>("ruleErrors", RuleErrors);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptRule>("rules", Rules);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptError>("scriptErrors", ScriptErrors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
