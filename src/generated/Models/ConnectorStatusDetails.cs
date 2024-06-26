// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Represent connector status
    /// </summary>
    public class ConnectorStatusDetails : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Connector Instance Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorInstanceId { get; set; }
#nullable restore
#else
        public string ConnectorInstanceId { get; set; }
#endif
        /// <summary>Connectors name for connector status</summary>
        public ApiSdk.Models.ConnectorName? ConnectorName { get; set; }
        /// <summary>Event datetime</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Connector health state for connector status</summary>
        public ConnectorHealthState? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ConnectorStatusDetails"/> and sets the default values.
        /// </summary>
        public ConnectorStatusDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConnectorStatusDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConnectorStatusDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectorStatusDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "connectorInstanceId", n => { ConnectorInstanceId = n.GetStringValue(); } },
                { "connectorName", n => { ConnectorName = n.GetEnumValue<ConnectorName>(); } },
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<ConnectorHealthState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("connectorInstanceId", ConnectorInstanceId);
            writer.WriteEnumValue<ConnectorName>("connectorName", ConnectorName);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ConnectorHealthState>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
