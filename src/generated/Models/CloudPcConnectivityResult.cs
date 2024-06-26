// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CloudPcConnectivityResult : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of failed health check items. If the status property is available, this property will be empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcHealthCheckItem>? FailedHealthCheckItems { get; set; }
#nullable restore
#else
        public List<CloudPcHealthCheckItem> FailedHealthCheckItems { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The status property</summary>
        public CloudPcConnectivityStatus? Status { get; set; }
        /// <summary>Datetime when the status was updated. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? UpdatedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="CloudPcConnectivityResult"/> and sets the default values.
        /// </summary>
        public CloudPcConnectivityResult()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcConnectivityResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcConnectivityResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcConnectivityResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failedHealthCheckItems", n => { FailedHealthCheckItems = n.GetCollectionOfObjectValues<CloudPcHealthCheckItem>(CloudPcHealthCheckItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<CloudPcConnectivityStatus>(); } },
                { "updatedDateTime", n => { UpdatedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CloudPcHealthCheckItem>("failedHealthCheckItems", FailedHealthCheckItems);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<CloudPcConnectivityStatus>("status", Status);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
