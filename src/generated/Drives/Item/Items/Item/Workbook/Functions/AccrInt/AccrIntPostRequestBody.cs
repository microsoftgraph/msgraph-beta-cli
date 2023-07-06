using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.AccrInt {
    public class AccrIntPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The basis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Basis { get; set; }
#nullable restore
#else
        public Json Basis { get; set; }
#endif
        /// <summary>The calcMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? CalcMethod { get; set; }
#nullable restore
#else
        public Json CalcMethod { get; set; }
#endif
        /// <summary>The firstInterest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? FirstInterest { get; set; }
#nullable restore
#else
        public Json FirstInterest { get; set; }
#endif
        /// <summary>The frequency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Frequency { get; set; }
#nullable restore
#else
        public Json Frequency { get; set; }
#endif
        /// <summary>The issue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Issue { get; set; }
#nullable restore
#else
        public Json Issue { get; set; }
#endif
        /// <summary>The par property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Par { get; set; }
#nullable restore
#else
        public Json Par { get; set; }
#endif
        /// <summary>The rate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Rate { get; set; }
#nullable restore
#else
        public Json Rate { get; set; }
#endif
        /// <summary>The settlement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Settlement { get; set; }
#nullable restore
#else
        public Json Settlement { get; set; }
#endif
        /// <summary>
        /// Instantiates a new accrIntPostRequestBody and sets the default values.
        /// </summary>
        public AccrIntPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccrIntPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccrIntPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"basis", n => { Basis = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"calcMethod", n => { CalcMethod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"firstInterest", n => { FirstInterest = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"frequency", n => { Frequency = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"issue", n => { Issue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"par", n => { Par = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rate", n => { Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"settlement", n => { Settlement = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("calcMethod", CalcMethod);
            writer.WriteObjectValue<Json>("firstInterest", FirstInterest);
            writer.WriteObjectValue<Json>("frequency", Frequency);
            writer.WriteObjectValue<Json>("issue", Issue);
            writer.WriteObjectValue<Json>("par", Par);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}