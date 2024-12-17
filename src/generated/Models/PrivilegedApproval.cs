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
    public partial class PrivilegedApproval : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The approvalDuration property</summary>
        public TimeSpan? ApprovalDuration { get; set; }
        /// <summary>The approvalState property</summary>
        public global::ApiSdk.Models.ApprovalState? ApprovalState { get; set; }
        /// <summary>The approvalType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApprovalType { get; set; }
#nullable restore
#else
        public string ApprovalType { get; set; }
#endif
        /// <summary>The approverReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApproverReason { get; set; }
#nullable restore
#else
        public string ApproverReason { get; set; }
#endif
        /// <summary>The endDateTime property</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The request property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PrivilegedRoleAssignmentRequest? Request { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PrivilegedRoleAssignmentRequest Request { get; set; }
#endif
        /// <summary>The requestorReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestorReason { get; set; }
#nullable restore
#else
        public string RequestorReason { get; set; }
#endif
        /// <summary>The roleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleId { get; set; }
#nullable restore
#else
        public string RoleId { get; set; }
#endif
        /// <summary>The roleInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PrivilegedRole? RoleInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PrivilegedRole RoleInfo { get; set; }
#endif
        /// <summary>The startDateTime property</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PrivilegedApproval"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PrivilegedApproval CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PrivilegedApproval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "approvalDuration", n => { ApprovalDuration = n.GetTimeSpanValue(); } },
                { "approvalState", n => { ApprovalState = n.GetEnumValue<global::ApiSdk.Models.ApprovalState>(); } },
                { "approvalType", n => { ApprovalType = n.GetStringValue(); } },
                { "approverReason", n => { ApproverReason = n.GetStringValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "request", n => { Request = n.GetObjectValue<global::ApiSdk.Models.PrivilegedRoleAssignmentRequest>(global::ApiSdk.Models.PrivilegedRoleAssignmentRequest.CreateFromDiscriminatorValue); } },
                { "requestorReason", n => { RequestorReason = n.GetStringValue(); } },
                { "roleId", n => { RoleId = n.GetStringValue(); } },
                { "roleInfo", n => { RoleInfo = n.GetObjectValue<global::ApiSdk.Models.PrivilegedRole>(global::ApiSdk.Models.PrivilegedRole.CreateFromDiscriminatorValue); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
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
            writer.WriteTimeSpanValue("approvalDuration", ApprovalDuration);
            writer.WriteEnumValue<global::ApiSdk.Models.ApprovalState>("approvalState", ApprovalState);
            writer.WriteStringValue("approvalType", ApprovalType);
            writer.WriteStringValue("approverReason", ApproverReason);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.PrivilegedRoleAssignmentRequest>("request", Request);
            writer.WriteStringValue("requestorReason", RequestorReason);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<global::ApiSdk.Models.PrivilegedRole>("roleInfo", RoleInfo);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
#pragma warning restore CS0618
