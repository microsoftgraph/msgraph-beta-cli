// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class InsightsSettings : Entity, IParsable 
    {
        /// <summary>The ID of a Microsoft Entra group, of which the specified type of insights are disabled for its members. Default is empty. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisabledForGroup { get; set; }
#nullable restore
#else
        public string DisabledForGroup { get; set; }
#endif
        /// <summary>true if the specified type of insights is enabled for the organization; false if the specified type of insights is disabled for all users without exceptions. Default is true. Optional.</summary>
        public bool? IsEnabledInOrganization { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="InsightsSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InsightsSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InsightsSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"disabledForGroup", n => { DisabledForGroup = n.GetStringValue(); } },
                {"isEnabledInOrganization", n => { IsEnabledInOrganization = n.GetBoolValue(); } },
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
            writer.WriteStringValue("disabledForGroup", DisabledForGroup);
            writer.WriteBoolValue("isEnabledInOrganization", IsEnabledInOrganization);
        }
    }
}