// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security
{
    #pragma warning disable CS1591
    public class InformationProtectionAction : IAdditionalDataHolder, IParsable
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
        /// <summary>
        /// Instantiates a new <see cref="InformationProtectionAction"/> and sets the default values.
        /// </summary>
        public InformationProtectionAction()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="InformationProtectionAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InformationProtectionAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.addContentFooterAction" => new AddContentFooterAction(),
                "#microsoft.graph.security.addContentHeaderAction" => new AddContentHeaderAction(),
                "#microsoft.graph.security.addWatermarkAction" => new AddWatermarkAction(),
                "#microsoft.graph.security.applyLabelAction" => new ApplyLabelAction(),
                "#microsoft.graph.security.customAction" => new CustomAction(),
                "#microsoft.graph.security.justifyAction" => new JustifyAction(),
                "#microsoft.graph.security.metadataAction" => new MetadataAction(),
                "#microsoft.graph.security.protectAdhocAction" => new ProtectAdhocAction(),
                "#microsoft.graph.security.protectByTemplateAction" => new ProtectByTemplateAction(),
                "#microsoft.graph.security.protectDoNotForwardAction" => new ProtectDoNotForwardAction(),
                "#microsoft.graph.security.recommendLabelAction" => new RecommendLabelAction(),
                "#microsoft.graph.security.removeContentFooterAction" => new RemoveContentFooterAction(),
                "#microsoft.graph.security.removeContentHeaderAction" => new RemoveContentHeaderAction(),
                "#microsoft.graph.security.removeProtectionAction" => new RemoveProtectionAction(),
                "#microsoft.graph.security.removeWatermarkAction" => new RemoveWatermarkAction(),
                _ => new InformationProtectionAction(),
            };
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
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
