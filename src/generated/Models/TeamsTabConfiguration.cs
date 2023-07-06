using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TeamsTabConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Url used for rendering tab contents in Teams. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentUrl { get; set; }
#nullable restore
#else
        public string ContentUrl { get; set; }
#endif
        /// <summary>Identifier for the entity hosted by the tab provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EntityId { get; set; }
#nullable restore
#else
        public string EntityId { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Url called by Teams client when a Tab is removed using the Teams Client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoveUrl { get; set; }
#nullable restore
#else
        public string RemoveUrl { get; set; }
#endif
        /// <summary>Url for showing tab contents outside of Teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebsiteUrl { get; set; }
#nullable restore
#else
        public string WebsiteUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new teamsTabConfiguration and sets the default values.
        /// </summary>
        public TeamsTabConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamsTabConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsTabConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contentUrl", n => { ContentUrl = n.GetStringValue(); } },
                {"entityId", n => { EntityId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"removeUrl", n => { RemoveUrl = n.GetStringValue(); } },
                {"websiteUrl", n => { WebsiteUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contentUrl", ContentUrl);
            writer.WriteStringValue("entityId", EntityId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("removeUrl", RemoveUrl);
            writer.WriteStringValue("websiteUrl", WebsiteUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}