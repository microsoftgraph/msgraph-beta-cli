// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AlertHistoryState : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Application ID of the calling application that submitted an update (PATCH) to the alert. The appId should be extracted from the auth token and not entered manually by the calling application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>UPN of user the alert was assigned to (note: alert.assignedTo only stores the last value/UPN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>Comment entered by signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Comments { get; set; }
#nullable restore
#else
        public List<string> Comments { get; set; }
#endif
        /// <summary>Analyst feedback on the alert in this update. Possible values are: unknown, truePositive, falsePositive, benignPositive.</summary>
        public AlertFeedback? Feedback { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Alert status value (if updated). Possible values are: unknown, newAlert, inProgress, resolved, dismissed.</summary>
        public AlertStatus? Status { get; set; }
        /// <summary>Date and time of the alert update. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? UpdatedDateTime { get; set; }
        /// <summary>UPN of the signed-in user that updated the alert (taken from the bearer token - if in user/delegated auth mode).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AlertHistoryState"/> and sets the default values.
        /// </summary>
        public AlertHistoryState()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AlertHistoryState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AlertHistoryState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlertHistoryState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "comments", n => { Comments = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "feedback", n => { Feedback = n.GetEnumValue<AlertFeedback>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<AlertStatus>(); } },
                { "updatedDateTime", n => { UpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteCollectionOfPrimitiveValues<string>("comments", Comments);
            writer.WriteEnumValue<AlertFeedback>("feedback", Feedback);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
