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
    public partial class UnifiedRoleAssignmentSchedule : global::ApiSdk.Models.UnifiedRoleScheduleBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If the request is from an eligible administrator to activate a role, this parameter shows the related eligible assignment for that activation. Otherwise, it&apos;s null. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.UnifiedRoleEligibilitySchedule? ActivatedUsing { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.UnifiedRoleEligibilitySchedule ActivatedUsing { get; set; }
#endif
        /// <summary>The type of the assignment that can either be Assigned or Activated. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentType { get; set; }
#nullable restore
#else
        public string AssignmentType { get; set; }
#endif
        /// <summary>How the assignment is inherited. It can either be Inherited, Direct, or Group. It can further imply whether the unifiedRoleAssignmentSchedule can be managed by the caller. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberType { get; set; }
#nullable restore
#else
        public string MemberType { get; set; }
#endif
        /// <summary>The period of the role assignment. It can represent a single occurrence or multiple recurrences.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RequestSchedule? ScheduleInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RequestSchedule ScheduleInfo { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UnifiedRoleAssignmentSchedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UnifiedRoleAssignmentSchedule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UnifiedRoleAssignmentSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activatedUsing", n => { ActivatedUsing = n.GetObjectValue<global::ApiSdk.Models.UnifiedRoleEligibilitySchedule>(global::ApiSdk.Models.UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue); } },
                { "assignmentType", n => { AssignmentType = n.GetStringValue(); } },
                { "memberType", n => { MemberType = n.GetStringValue(); } },
                { "scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<global::ApiSdk.Models.RequestSchedule>(global::ApiSdk.Models.RequestSchedule.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.UnifiedRoleEligibilitySchedule>("activatedUsing", ActivatedUsing);
            writer.WriteStringValue("assignmentType", AssignmentType);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<global::ApiSdk.Models.RequestSchedule>("scheduleInfo", ScheduleInfo);
        }
    }
}
#pragma warning restore CS0618
