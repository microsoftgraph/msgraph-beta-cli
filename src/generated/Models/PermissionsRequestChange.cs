// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PermissionsRequestChange : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The status of the active occurence of the schedule if one exists. The possible values are: grantingFailed, granted, granting, revoked, revoking, revokingFailed, unknownFutureValue.</summary>
        public global::ApiSdk.Models.PermissionsRequestOccurrenceStatus? ActiveOccurrenceStatus { get; set; }
        /// <summary>Time when the change occurred.</summary>
        public DateTimeOffset? ModificationDateTime { get; set; }
        /// <summary>The ID of the scheduledPermissionsRequest object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PermissionsRequestId { get; set; }
#nullable restore
#else
        public string PermissionsRequestId { get; set; }
#endif
        /// <summary>The statusDetail property</summary>
        public global::ApiSdk.Models.StatusDetail? StatusDetail { get; set; }
        /// <summary>Represents the ticketing system identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TicketId { get; set; }
#nullable restore
#else
        public string TicketId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PermissionsRequestChange"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PermissionsRequestChange CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PermissionsRequestChange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeOccurrenceStatus", n => { ActiveOccurrenceStatus = n.GetEnumValue<global::ApiSdk.Models.PermissionsRequestOccurrenceStatus>(); } },
                { "modificationDateTime", n => { ModificationDateTime = n.GetDateTimeOffsetValue(); } },
                { "permissionsRequestId", n => { PermissionsRequestId = n.GetStringValue(); } },
                { "statusDetail", n => { StatusDetail = n.GetEnumValue<global::ApiSdk.Models.StatusDetail>(); } },
                { "ticketId", n => { TicketId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.PermissionsRequestOccurrenceStatus>("activeOccurrenceStatus", ActiveOccurrenceStatus);
            writer.WriteDateTimeOffsetValue("modificationDateTime", ModificationDateTime);
            writer.WriteStringValue("permissionsRequestId", PermissionsRequestId);
            writer.WriteEnumValue<global::ApiSdk.Models.StatusDetail>("statusDetail", StatusDetail);
            writer.WriteStringValue("ticketId", TicketId);
        }
    }
}
#pragma warning restore CS0618
