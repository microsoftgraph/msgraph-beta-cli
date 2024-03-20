// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class DiscoveredSensitiveType : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The classificationAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClassificationAttribute>? ClassificationAttributes { get; set; }
#nullable restore
#else
        public List<ClassificationAttribute> ClassificationAttributes { get; set; }
#endif
        /// <summary>The confidence property</summary>
        public int? Confidence { get; set; }
        /// <summary>The count property</summary>
        public int? Count { get; set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DiscoveredSensitiveType"/> and sets the default values.
        /// </summary>
        public DiscoveredSensitiveType()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DiscoveredSensitiveType"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DiscoveredSensitiveType CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DiscoveredSensitiveType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"classificationAttributes", n => { ClassificationAttributes = n.GetCollectionOfObjectValues<ClassificationAttribute>(ClassificationAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"count", n => { Count = n.GetIntValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationAttribute>("classificationAttributes", ClassificationAttributes);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteIntValue("count", Count);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}