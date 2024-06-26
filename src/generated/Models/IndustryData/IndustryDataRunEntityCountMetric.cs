// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IndustryData
{
    #pragma warning disable CS1591
    public class IndustryDataRunEntityCountMetric : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The count of entries for the entity marked as Active.</summary>
        public int? Active { get; private set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count of entries for the entity marked as Inactive.</summary>
        public int? Inactive { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Total count of the entity.</summary>
        public int? Total { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="IndustryDataRunEntityCountMetric"/> and sets the default values.
        /// </summary>
        public IndustryDataRunEntityCountMetric()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IndustryDataRunEntityCountMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IndustryDataRunEntityCountMetric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IndustryDataRunEntityCountMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetIntValue(); } },
                { "inactive", n => { Inactive = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "total", n => { Total = n.GetIntValue(); } },
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
