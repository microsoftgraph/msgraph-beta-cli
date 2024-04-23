// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Local Action Configuration
    /// </summary>
    public class AndroidDeviceComplianceLocalActionBase : Entity, IParsable 
    {
        /// <summary>Number of minutes to wait till a local action is enforced. Valid values 0 to 2147483647</summary>
        public int? GracePeriodInMinutes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidDeviceComplianceLocalActionBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceComplianceLocalActionBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidDeviceComplianceLocalActionLockDevice" => new AndroidDeviceComplianceLocalActionLockDevice(),
                "#microsoft.graph.androidDeviceComplianceLocalActionLockDeviceWithPasscode" => new AndroidDeviceComplianceLocalActionLockDeviceWithPasscode(),
                _ => new AndroidDeviceComplianceLocalActionBase(),
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
                {"gracePeriodInMinutes", n => { GracePeriodInMinutes = n.GetIntValue(); } },
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
            writer.WriteIntValue("gracePeriodInMinutes", GracePeriodInMinutes);
        }
    }
}