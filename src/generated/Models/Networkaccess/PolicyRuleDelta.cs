// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class PolicyRuleDelta : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public ForwardingRuleAction? Action { get; set; }
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
        /// <summary>The identifier of the policy rule to update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleId { get; set; }
#nullable restore
#else
        public string RuleId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PolicyRuleDelta"/> and sets the default values.
        /// </summary>
        public PolicyRuleDelta()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyRuleDelta"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PolicyRuleDelta CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyRuleDelta();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<ForwardingRuleAction>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "ruleId", n => { RuleId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ForwardingRuleAction>("action", Action);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("ruleId", RuleId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
