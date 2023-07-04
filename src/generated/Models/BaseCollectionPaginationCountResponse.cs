using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class BaseCollectionPaginationCountResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataCount property</summary>
        public long? BaseCollectionPaginationCountResponseOdataCount { get; set; }
        /// <summary>The OdataCount property</summary>
        public long? BaseCollectionPaginationCountResponseOdataCount0 { get; set; }
        /// <summary>The OdataCount property</summary>
        public long? BaseCollectionPaginationCountResponseOdataCount1 { get; set; }
        /// <summary>The OdataNextLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseCollectionPaginationCountResponseOdataNextLink { get; set; }
#nullable restore
#else
        public string BaseCollectionPaginationCountResponseOdataNextLink { get; set; }
#endif
        /// <summary>The OdataNextLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseCollectionPaginationCountResponseOdataNextLink0 { get; set; }
#nullable restore
#else
        public string BaseCollectionPaginationCountResponseOdataNextLink0 { get; set; }
#endif
        /// <summary>The OdataNextLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseCollectionPaginationCountResponseOdataNextLink1 { get; set; }
#nullable restore
#else
        public string BaseCollectionPaginationCountResponseOdataNextLink1 { get; set; }
#endif
        /// <summary>The OdataNextLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseCollectionPaginationCountResponseOdataNextLink2 { get; set; }
#nullable restore
#else
        public string BaseCollectionPaginationCountResponseOdataNextLink2 { get; set; }
#endif
        /// <summary>The OdataCount property</summary>
        public long? OdataCount { get; set; }
        /// <summary>The OdataNextLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataNextLink { get; set; }
#nullable restore
#else
        public string OdataNextLink { get; set; }
#endif
        /// <summary>
        /// Instantiates a new BaseCollectionPaginationCountResponse and sets the default values.
        /// </summary>
        public BaseCollectionPaginationCountResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BaseCollectionPaginationCountResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BaseCollectionPaginationCountResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.count", n => { BaseCollectionPaginationCountResponseOdataCount = n.GetLongValue(); } },
                {"@odata.count", n => { BaseCollectionPaginationCountResponseOdataCount0 = n.GetLongValue(); } },
                {"@odata.count", n => { BaseCollectionPaginationCountResponseOdataCount1 = n.GetLongValue(); } },
                {"@odata.nextLink", n => { BaseCollectionPaginationCountResponseOdataNextLink = n.GetStringValue(); } },
                {"@odata.nextLink", n => { BaseCollectionPaginationCountResponseOdataNextLink0 = n.GetStringValue(); } },
                {"@odata.nextLink", n => { BaseCollectionPaginationCountResponseOdataNextLink1 = n.GetStringValue(); } },
                {"@odata.nextLink", n => { BaseCollectionPaginationCountResponseOdataNextLink2 = n.GetStringValue(); } },
                {"@odata.count", n => { OdataCount = n.GetLongValue(); } },
                {"@odata.nextLink", n => { OdataNextLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("@odata.count", BaseCollectionPaginationCountResponseOdataCount);
            writer.WriteLongValue("@odata.count", BaseCollectionPaginationCountResponseOdataCount0);
            writer.WriteLongValue("@odata.count", BaseCollectionPaginationCountResponseOdataCount1);
            writer.WriteStringValue("@odata.nextLink", BaseCollectionPaginationCountResponseOdataNextLink);
            writer.WriteStringValue("@odata.nextLink", BaseCollectionPaginationCountResponseOdataNextLink0);
            writer.WriteStringValue("@odata.nextLink", BaseCollectionPaginationCountResponseOdataNextLink1);
            writer.WriteStringValue("@odata.nextLink", BaseCollectionPaginationCountResponseOdataNextLink2);
            writer.WriteLongValue("@odata.count", OdataCount);
            writer.WriteStringValue("@odata.nextLink", OdataNextLink);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
