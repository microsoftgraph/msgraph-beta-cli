// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Partner.Security
{
    #pragma warning disable CS1591
    public class ActivityLog : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The statusFrom property</summary>
        public SecurityAlertStatus? StatusFrom { get; set; }
        /// <summary>The statusTo property</summary>
        public SecurityAlertStatus? StatusTo { get; set; }
        /// <summary>The UPN of the partner user who did the status update activity. This attribute is set by the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedBy { get; set; }
#nullable restore
#else
        public string UpdatedBy { get; set; }
#endif
        /// <summary>The date and time for the status update activity. This attribute is set by the system. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? UpdatedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ActivityLog"/> and sets the default values.
        /// </summary>
        public ActivityLog()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActivityLog"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ActivityLog CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivityLog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "statusFrom", n => { StatusFrom = n.GetEnumValue<SecurityAlertStatus>(); } },
                { "statusTo", n => { StatusTo = n.GetEnumValue<SecurityAlertStatus>(); } },
                { "updatedBy", n => { UpdatedBy = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<SecurityAlertStatus>("statusFrom", StatusFrom);
            writer.WriteEnumValue<SecurityAlertStatus>("statusTo", StatusTo);
            writer.WriteStringValue("updatedBy", UpdatedBy);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
