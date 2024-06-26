// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class GovernanceRoleAssignment : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The state of the assignment. The value can be Eligible for eligible assignment or Active if it&apos;s directly assigned Active by administrators, or activated on an eligible assignment by the users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentState { get; set; }
#nullable restore
#else
        public string AssignmentState { get; set; }
#endif
        /// <summary>For a non-permanent role assignment, this is the time when the role assignment is expired. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The external ID the resource that is used to identify the role assignment in the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>Read-only. If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceRoleAssignment? LinkedEligibleRoleAssignment { get; set; }
#nullable restore
#else
        public GovernanceRoleAssignment LinkedEligibleRoleAssignment { get; set; }
#endif
        /// <summary>If this is an active assignment and created due to activation on an eligible assignment, it represents the ID of that eligible assignment; Otherwise, the value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedEligibleRoleAssignmentId { get; set; }
#nullable restore
#else
        public string LinkedEligibleRoleAssignmentId { get; set; }
#endif
        /// <summary>The type of member. The value can be: Inherited (if the role assignment is inherited from a parent resource scope), Group (if the role assignment isn&apos;t inherited, but comes from the membership of a group assignment), or User (if the role assignment isn&apos;t inherited or from a group assignment).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberType { get; set; }
#nullable restore
#else
        public string MemberType { get; set; }
#endif
        /// <summary>Read-only. The resource associated with the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceResource? Resource { get; set; }
#nullable restore
#else
        public GovernanceResource Resource { get; set; }
#endif
        /// <summary>Required. The ID of the resource that the role assignment is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId { get; set; }
#nullable restore
#else
        public string ResourceId { get; set; }
#endif
        /// <summary>Read-only. The role definition associated with the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceRoleDefinition? RoleDefinition { get; set; }
#nullable restore
#else
        public GovernanceRoleDefinition RoleDefinition { get; set; }
#endif
        /// <summary>Required. The ID of the role definition that the role assignment is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId { get; set; }
#nullable restore
#else
        public string RoleDefinitionId { get; set; }
#endif
        /// <summary>The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>Read-only. The subject associated with the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceSubject? Subject { get; set; }
#nullable restore
#else
        public GovernanceSubject Subject { get; set; }
#endif
        /// <summary>Required. The ID of the subject that the role assignment is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectId { get; set; }
#nullable restore
#else
        public string SubjectId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GovernanceRoleAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GovernanceRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "linkedEligibleRoleAssignment", n => { LinkedEligibleRoleAssignment = n.GetObjectValue<GovernanceRoleAssignment>(GovernanceRoleAssignment.CreateFromDiscriminatorValue); } },
                { "linkedEligibleRoleAssignmentId", n => { LinkedEligibleRoleAssignmentId = n.GetStringValue(); } },
                { "memberType", n => { MemberType = n.GetStringValue(); } },
                { "resource", n => { Resource = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
                { "roleDefinition", n => { RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetObjectValue<GovernanceSubject>(GovernanceSubject.CreateFromDiscriminatorValue); } },
                { "subjectId", n => { SubjectId = n.GetStringValue(); } },
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
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<GovernanceRoleAssignment>("linkedEligibleRoleAssignment", LinkedEligibleRoleAssignment);
            writer.WriteStringValue("linkedEligibleRoleAssignmentId", LinkedEligibleRoleAssignmentId);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<GovernanceSubject>("subject", Subject);
            writer.WriteStringValue("subjectId", SubjectId);
        }
    }
}
