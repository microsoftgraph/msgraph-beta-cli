// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UsageRight : Entity, IParsable 
    {
        /// <summary>Product id corresponding to the usage right.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogId { get; set; }
#nullable restore
#else
        public string CatalogId { get; set; }
#endif
        /// <summary>Identifier of the service corresponding to the usage right.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceIdentifier { get; set; }
#nullable restore
#else
        public string ServiceIdentifier { get; set; }
#endif
        /// <summary>The state property</summary>
        public UsageRightState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UsageRight"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UsageRight CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsageRight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"catalogId", n => { CatalogId = n.GetStringValue(); } },
                {"serviceIdentifier", n => { ServiceIdentifier = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<UsageRightState>(); } },
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
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteStringValue("serviceIdentifier", ServiceIdentifier);
            writer.WriteEnumValue<UsageRightState>("state", State);
        }
    }
}