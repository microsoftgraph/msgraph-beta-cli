// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PlannerTask : global::ApiSdk.Models.PlannerDelta, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The number of checklist items with value set to false, representing incomplete items.</summary>
        public int? ActiveChecklistItemCount { get; set; }
        /// <summary>The categories to which the task is applied. See plannerAppliedCategories resource type for possible values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerAppliedCategories? AppliedCategories { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerAppliedCategories AppliedCategories { get; set; }
#endif
        /// <summary>Read-only. Nullable. Contains information about who archived or unarchived the task and why.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerArchivalInfo? ArchivalInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerArchivalInfo ArchivalInfo { get; set; }
#endif
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerAssignedToTaskBoardTaskFormat? AssignedToTaskBoardFormat { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat { get; set; }
#endif
        /// <summary>A hint that is used to order items of this type in a list view. For more information, see Using order hints in planner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneePriority { get; set; }
#nullable restore
#else
        public string AssigneePriority { get; set; }
#endif
        /// <summary>The set of assignees the task is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerAssignments? Assignments { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerAssignments Assignments { get; set; }
#endif
        /// <summary>Bucket ID to which the task belongs. The bucket needs to be in the same plan as the task. The value of the bucketId property is 28 characters long and case-sensitive. Format validation is done on the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BucketId { get; set; }
#nullable restore
#else
        public string BucketId { get; set; }
#endif
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by bucket.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerBucketTaskBoardTaskFormat? BucketTaskBoardFormat { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat { get; set; }
#endif
        /// <summary>The number of checklist items that are present on the task.</summary>
        public int? ChecklistItemCount { get; set; }
        /// <summary>The identity of the user that completed the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CompletedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CompletedBy { get; set; }
#endif
        /// <summary>Read-only. The date and time at which the &apos;percentComplete&apos; of the task is set to &apos;100&apos;. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationThreadId { get; set; }
#nullable restore
#else
        public string ConversationThreadId { get; set; }
#endif
        /// <summary>The identity of the user who created the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Read-only. The date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Information about the origin of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerTaskCreation? CreationSource { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerTaskCreation CreationSource { get; set; }
#endif
        /// <summary>Read-only. Nullable. More details about the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerTaskDetails? Details { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerTaskDetails Details { get; set; }
#endif
        /// <summary>The date and time at which the task is due. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime { get; set; }
        /// <summary>Read-only. This value is true if the details object of the task has a nonempty description. Otherwise,false.</summary>
        public bool? HasDescription { get; set; }
        /// <summary>Read-only. If set to true, the task is archived. An archived task is read-only.</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Indicates whether to show this task in the MyDay view. If true, it shows the task.</summary>
        public bool? IsOnMyDay { get; set; }
        /// <summary>Read-only. The date on which task is added to or removed from MyDay.</summary>
        public Date? IsOnMyDayLastModifiedDate { get; set; }
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The hint used to order items of this type in a list view. For more information, see Using order hints in plannern.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderHint { get; set; }
#nullable restore
#else
        public string OrderHint { get; set; }
#endif
        /// <summary>The percentage of task completion. When set to 100, the task is completed.</summary>
        public int? PercentComplete { get; set; }
        /// <summary>Plan ID to which the task belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlanId { get; set; }
#nullable restore
#else
        public string PlanId { get; set; }
#endif
        /// <summary>The type of preview that shows up on the task. Possible values are: automatic, noPreview, checklist, description, reference.</summary>
        public global::ApiSdk.Models.PlannerPreviewType? PreviewType { get; set; }
        /// <summary>The priority of the task. Valid values are between 0 and 10, inclusive. Larger values indicate lower priority. For example, 0 has the highest priority and 10 has the lowest priority. Currently, planner interprets values 0 and 1 as &apos;urgent&apos;, 2 and 3 and 4 as &apos;important&apos;, 5, 6, and 7 as &apos;medium&apos;, and 8, 9, and 10 as &apos;low&apos;. Currently, planner sets the value 1 for &apos;urgent&apos;, 3 for &apos;important&apos;, 5 for &apos;medium&apos;, and 9 for &apos;low&apos;.</summary>
        public int? Priority { get; set; }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by progress.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerProgressTaskBoardTaskFormat? ProgressTaskBoardFormat { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat { get; set; }
#endif
        /// <summary>Defines active or inactive recurrence for the task. null when the recurrence has never been defined for the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerTaskRecurrence? Recurrence { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerTaskRecurrence Recurrence { get; set; }
#endif
        /// <summary>Number of external references that exist on the task.</summary>
        public int? ReferenceCount { get; set; }
        /// <summary>Indicates all the requirements specified on the plannerTask. Possible values are: none, checklistCompletion, unknownFutureValue, formCompletion, approvalCompletion. Read-only. You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: formCompletion, approvalCompletion. The plannerTaskCompletionRequirementDetails in plannerTaskDetails has details of the requirements specified, if any.</summary>
        public global::ApiSdk.Models.PlannerTaskCompletionRequirements? SpecifiedCompletionRequirements { get; set; }
        /// <summary>Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Title of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PlannerTask"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PlannerTask CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.businessScenarioTask" => new global::ApiSdk.Models.BusinessScenarioTask(),
                _ => new global::ApiSdk.Models.PlannerTask(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeChecklistItemCount", n => { ActiveChecklistItemCount = n.GetIntValue(); } },
                { "appliedCategories", n => { AppliedCategories = n.GetObjectValue<global::ApiSdk.Models.PlannerAppliedCategories>(global::ApiSdk.Models.PlannerAppliedCategories.CreateFromDiscriminatorValue); } },
                { "archivalInfo", n => { ArchivalInfo = n.GetObjectValue<global::ApiSdk.Models.PlannerArchivalInfo>(global::ApiSdk.Models.PlannerArchivalInfo.CreateFromDiscriminatorValue); } },
                { "assignedToTaskBoardFormat", n => { AssignedToTaskBoardFormat = n.GetObjectValue<global::ApiSdk.Models.PlannerAssignedToTaskBoardTaskFormat>(global::ApiSdk.Models.PlannerAssignedToTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                { "assigneePriority", n => { AssigneePriority = n.GetStringValue(); } },
                { "assignments", n => { Assignments = n.GetObjectValue<global::ApiSdk.Models.PlannerAssignments>(global::ApiSdk.Models.PlannerAssignments.CreateFromDiscriminatorValue); } },
                { "bucketId", n => { BucketId = n.GetStringValue(); } },
                { "bucketTaskBoardFormat", n => { BucketTaskBoardFormat = n.GetObjectValue<global::ApiSdk.Models.PlannerBucketTaskBoardTaskFormat>(global::ApiSdk.Models.PlannerBucketTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                { "checklistItemCount", n => { ChecklistItemCount = n.GetIntValue(); } },
                { "completedBy", n => { CompletedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "conversationThreadId", n => { ConversationThreadId = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "creationSource", n => { CreationSource = n.GetObjectValue<global::ApiSdk.Models.PlannerTaskCreation>(global::ApiSdk.Models.PlannerTaskCreation.CreateFromDiscriminatorValue); } },
                { "details", n => { Details = n.GetObjectValue<global::ApiSdk.Models.PlannerTaskDetails>(global::ApiSdk.Models.PlannerTaskDetails.CreateFromDiscriminatorValue); } },
                { "dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                { "hasDescription", n => { HasDescription = n.GetBoolValue(); } },
                { "isArchived", n => { IsArchived = n.GetBoolValue(); } },
                { "isOnMyDay", n => { IsOnMyDay = n.GetBoolValue(); } },
                { "isOnMyDayLastModifiedDate", n => { IsOnMyDayLastModifiedDate = n.GetDateValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "orderHint", n => { OrderHint = n.GetStringValue(); } },
                { "percentComplete", n => { PercentComplete = n.GetIntValue(); } },
                { "planId", n => { PlanId = n.GetStringValue(); } },
                { "previewType", n => { PreviewType = n.GetEnumValue<global::ApiSdk.Models.PlannerPreviewType>(); } },
                { "priority", n => { Priority = n.GetIntValue(); } },
                { "progressTaskBoardFormat", n => { ProgressTaskBoardFormat = n.GetObjectValue<global::ApiSdk.Models.PlannerProgressTaskBoardTaskFormat>(global::ApiSdk.Models.PlannerProgressTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                { "recurrence", n => { Recurrence = n.GetObjectValue<global::ApiSdk.Models.PlannerTaskRecurrence>(global::ApiSdk.Models.PlannerTaskRecurrence.CreateFromDiscriminatorValue); } },
                { "referenceCount", n => { ReferenceCount = n.GetIntValue(); } },
                { "specifiedCompletionRequirements", n => { SpecifiedCompletionRequirements = n.GetEnumValue<global::ApiSdk.Models.PlannerTaskCompletionRequirements>(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteIntValue("activeChecklistItemCount", ActiveChecklistItemCount);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerAppliedCategories>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerArchivalInfo>("archivalInfo", ArchivalInfo);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerAssignedToTaskBoardTaskFormat>("assignedToTaskBoardFormat", AssignedToTaskBoardFormat);
            writer.WriteStringValue("assigneePriority", AssigneePriority);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerAssignments>("assignments", Assignments);
            writer.WriteStringValue("bucketId", BucketId);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerBucketTaskBoardTaskFormat>("bucketTaskBoardFormat", BucketTaskBoardFormat);
            writer.WriteIntValue("checklistItemCount", ChecklistItemCount);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("completedBy", CompletedBy);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerTaskCreation>("creationSource", CreationSource);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerTaskDetails>("details", Details);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteBoolValue("hasDescription", HasDescription);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isOnMyDay", IsOnMyDay);
            writer.WriteDateValue("isOnMyDayLastModifiedDate", IsOnMyDayLastModifiedDate);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteIntValue("percentComplete", PercentComplete);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteEnumValue<global::ApiSdk.Models.PlannerPreviewType>("previewType", PreviewType);
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerProgressTaskBoardTaskFormat>("progressTaskBoardFormat", ProgressTaskBoardFormat);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerTaskRecurrence>("recurrence", Recurrence);
            writer.WriteIntValue("referenceCount", ReferenceCount);
            writer.WriteEnumValue<global::ApiSdk.Models.PlannerTaskCompletionRequirements>("specifiedCompletionRequirements", SpecifiedCompletionRequirements);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
