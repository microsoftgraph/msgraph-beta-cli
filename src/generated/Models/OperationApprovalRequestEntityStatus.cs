// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The operationApprovalRequestEntityStatus complex type is used to provide the basic infortmation relating to the status of a request without revealing too much information to the calling user as it may be an object out of scope.
    /// </summary>
    public class OperationApprovalRequestEntityStatus : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The status of the Entity connected to the OperationApprovalRequest in regard to changes, whether further requests are allowed or if the Entity is locked. When true, a lock is present on the Entity and no approval requests can be currently made for it. When false, the Entity is not locked and approval requests are allowed. Default value is false. Read-only. This property is read-only.</summary>
        public bool? EntityLocked { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates the DateTime when any action on the OperationApprovalRequest is no longer permitted. The value cannot be modified and is automatically populated when the request is created using expiration offset values defined in the service controllers. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only. This property is read-only.</summary>
        public DateTimeOffset? RequestExpirationDateTime { get; private set; }
        /// <summary>The unique identifier of the OperationApprovalRequest. This property cannot be modified and is required when the entity status is created. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestId { get; private set; }
#nullable restore
#else
        public string RequestId { get; private set; }
#endif
        /// <summary>Indicates the status of the Approval Request. The status of a request will change when an action is successfully performed on it, such as when it is `approved` or `rejected`, or when the request&apos;s expiration DateTime passes and the result is `expired`.</summary>
        public OperationApprovalRequestStatus? RequestStatus { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="OperationApprovalRequestEntityStatus"/> and sets the default values.
        /// </summary>
        public OperationApprovalRequestEntityStatus()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OperationApprovalRequestEntityStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OperationApprovalRequestEntityStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OperationApprovalRequestEntityStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"entityLocked", n => { EntityLocked = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"requestExpirationDateTime", n => { RequestExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestId", n => { RequestId = n.GetStringValue(); } },
                {"requestStatus", n => { RequestStatus = n.GetEnumValue<OperationApprovalRequestStatus>(); } },
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
            writer.WriteEnumValue<OperationApprovalRequestStatus>("requestStatus", RequestStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}