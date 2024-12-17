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
    public partial class RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident : global::ApiSdk.Models.UnifiedRoleManagementAlertIncident, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Display name of the subject that the incident applies to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeDisplayName { get; set; }
#nullable restore
#else
        public string AssigneeDisplayName { get; set; }
#endif
        /// <summary>The identifier of the subject that the incident applies to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeId { get; set; }
#nullable restore
#else
        public string AssigneeId { get; set; }
#endif
        /// <summary>User principal name of the subject that the incident applies to. Applies to user principals.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeUserPrincipalName { get; set; }
#nullable restore
#else
        public string AssigneeUserPrincipalName { get; set; }
#endif
        /// <summary>Date and time of assignment creation.</summary>
        public DateTimeOffset? AssignmentCreatedDateTime { get; set; }
        /// <summary>The identifier for the directory role definition that&apos;s in scope of this incident.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId { get; set; }
#nullable restore
#else
        public string RoleDefinitionId { get; set; }
#endif
        /// <summary>The display name for the directory role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDisplayName { get; set; }
#nullable restore
#else
        public string RoleDisplayName { get; set; }
#endif
        /// <summary>The globally unique identifier for the directory role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleTemplateId { get; set; }
#nullable restore
#else
        public string RoleTemplateId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident"/> and sets the default values.
        /// </summary>
        public RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident() : base()
        {
            OdataType = "#microsoft.graph.rolesAssignedOutsidePrivilegedIdentityManagementAlertIncident";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assigneeDisplayName", n => { AssigneeDisplayName = n.GetStringValue(); } },
                { "assigneeId", n => { AssigneeId = n.GetStringValue(); } },
                { "assigneeUserPrincipalName", n => { AssigneeUserPrincipalName = n.GetStringValue(); } },
                { "assignmentCreatedDateTime", n => { AssignmentCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                { "roleDisplayName", n => { RoleDisplayName = n.GetStringValue(); } },
                { "roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
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
            writer.WriteStringValue("assigneeDisplayName", AssigneeDisplayName);
            writer.WriteStringValue("assigneeId", AssigneeId);
            writer.WriteStringValue("assigneeUserPrincipalName", AssigneeUserPrincipalName);
            writer.WriteDateTimeOffsetValue("assignmentCreatedDateTime", AssignmentCreatedDateTime);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteStringValue("roleDisplayName", RoleDisplayName);
            writer.WriteStringValue("roleTemplateId", RoleTemplateId);
        }
    }
}
#pragma warning restore CS0618
