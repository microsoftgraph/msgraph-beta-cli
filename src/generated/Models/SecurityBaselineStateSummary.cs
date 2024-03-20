// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The security baseline compliance state summary for the security baseline of the account.
    /// </summary>
    public class SecurityBaselineStateSummary : Entity, IParsable 
    {
        /// <summary>Number of conflict devices</summary>
        public int? ConflictCount { get; set; }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of not secure devices</summary>
        public int? NotSecureCount { get; set; }
        /// <summary>Number of secure devices</summary>
        public int? SecureCount { get; set; }
        /// <summary>Number of unknown devices</summary>
        public int? UnknownCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SecurityBaselineStateSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityBaselineStateSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.securityBaselineCategoryStateSummary" => new SecurityBaselineCategoryStateSummary(),
                _ => new SecurityBaselineStateSummary(),
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
                {"conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                {"errorCount", n => { ErrorCount = n.GetIntValue(); } },
                {"notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                {"notSecureCount", n => { NotSecureCount = n.GetIntValue(); } },
                {"secureCount", n => { SecureCount = n.GetIntValue(); } },
                {"unknownCount", n => { UnknownCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("notSecureCount", NotSecureCount);
            writer.WriteIntValue("secureCount", SecureCount);
            writer.WriteIntValue("unknownCount", UnknownCount);
        }
    }
}