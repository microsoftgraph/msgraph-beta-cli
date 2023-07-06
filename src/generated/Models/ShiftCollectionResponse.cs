using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ShiftCollectionResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Shift>? ShiftCollectionResponseValue { get; set; }
#nullable restore
#else
        public List<Shift> ShiftCollectionResponseValue { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Shift>? ShiftCollectionResponseValue0 { get; set; }
#nullable restore
#else
        public List<Shift> ShiftCollectionResponseValue0 { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Shift>? Value { get; set; }
#nullable restore
#else
        public List<Shift> Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ShiftCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShiftCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { ShiftCollectionResponseValue = n.GetCollectionOfObjectValues<Shift>(Shift.CreateFromDiscriminatorValue)?.ToList(); } },
                {"value", n => { ShiftCollectionResponseValue0 = n.GetCollectionOfObjectValues<Shift>(Shift.CreateFromDiscriminatorValue)?.ToList(); } },
                {"value", n => { Value = n.GetCollectionOfObjectValues<Shift>(Shift.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Shift>("value", ShiftCollectionResponseValue);
            writer.WriteCollectionOfObjectValues<Shift>("value", ShiftCollectionResponseValue0);
            writer.WriteCollectionOfObjectValues<Shift>("value", Value);
        }
    }
}