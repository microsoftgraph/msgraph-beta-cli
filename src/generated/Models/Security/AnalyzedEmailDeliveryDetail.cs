// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class AnalyzedEmailDeliveryDetail : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The delivery action of the email. The possible values are: unknown, deliveredToJunk, delivered, blocked, replaced, unknownFutureValue.</summary>
        public DeliveryAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The delivery location of the email. The possible values are: unknown, inboxfolder, junkFolder, deletedFolder, quarantine, onpremexternal, failed, dropped, others, unknownFutureValue.</summary>
        public DeliveryLocation? Location { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AnalyzedEmailDeliveryDetail"/> and sets the default values.
        /// </summary>
        public AnalyzedEmailDeliveryDetail()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AnalyzedEmailDeliveryDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AnalyzedEmailDeliveryDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnalyzedEmailDeliveryDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"action", n => { Action = n.GetEnumValue<DeliveryAction>(); } },
                {"location", n => { Location = n.GetEnumValue<DeliveryLocation>(); } },
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
            writer.WriteEnumValue<DeliveryAction>("action", Action);
            writer.WriteEnumValue<DeliveryLocation>("location", Location);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}