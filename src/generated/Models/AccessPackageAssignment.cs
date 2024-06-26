// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AccessPackageAssignment : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccessPackage? AccessPackage { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccessPackage AccessPackage { get; set; }
#endif
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccessPackageAssignmentPolicy? AccessPackageAssignmentPolicy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccessPackageAssignmentPolicy AccessPackageAssignmentPolicy { get; set; }
#endif
        /// <summary>The accessPackageAssignmentRequests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentRequest>? AccessPackageAssignmentRequests { get; set; }
#nullable restore
#else
        public List<AccessPackageAssignmentRequest> AccessPackageAssignmentRequests { get; set; }
#endif
        /// <summary>The resource roles delivered to the target user for this assignment. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentResourceRole>? AccessPackageAssignmentResourceRoles { get; set; }
#nullable restore
#else
        public List<AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles { get; set; }
#endif
        /// <summary>The identifier of the access package. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageId { get; set; }
#nullable restore
#else
        public string AccessPackageId { get; set; }
#endif
        /// <summary>The identifier of the access package assignment policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentPolicyId { get; set; }
#nullable restore
#else
        public string AssignmentPolicyId { get; set; }
#endif
        /// <summary>The state of the access package assignment. Possible values are Delivering, Delivered, or Expired. Read-only. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentState { get; set; }
#nullable restore
#else
        public string AssignmentState { get; set; }
#endif
        /// <summary>More information about the assignment lifecycle. Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentStatus { get; set; }
#nullable restore
#else
        public string AssignmentStatus { get; set; }
#endif
        /// <summary>The identifier of the catalog containing the access package. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogId { get; set; }
#nullable restore
#else
        public string CatalogId { get; set; }
#endif
        /// <summary>Information about all the custom extension calls that were made during the access package assignment workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionCalloutInstance>? CustomExtensionCalloutInstances { get; set; }
#nullable restore
#else
        public List<CustomExtensionCalloutInstance> CustomExtensionCalloutInstances { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpiredDateTime { get; set; }
        /// <summary>Indicates whether the access package assignment is extended. Read-only.</summary>
        public bool? IsExtended { get; set; }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestSchedule? Schedule { get; set; }
#nullable restore
#else
        public RequestSchedule Schedule { get; set; }
#endif
        /// <summary>The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageSubject? Target { get; set; }
#nullable restore
#else
        public AccessPackageSubject Target { get; set; }
#endif
        /// <summary>The ID of the subject with the assignment. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetId { get; set; }
#nullable restore
#else
        public string TargetId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccessPackageAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackage", n => { AccessPackage = n.GetObjectValue<ApiSdk.Models.AccessPackage>(ApiSdk.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                { "accessPackageAssignmentPolicy", n => { AccessPackageAssignmentPolicy = n.GetObjectValue<ApiSdk.Models.AccessPackageAssignmentPolicy>(ApiSdk.Models.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue); } },
                { "accessPackageAssignmentRequests", n => { AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageAssignmentResourceRoles", n => { AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>(AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageId", n => { AccessPackageId = n.GetStringValue(); } },
                { "assignmentPolicyId", n => { AssignmentPolicyId = n.GetStringValue(); } },
                { "assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                { "assignmentStatus", n => { AssignmentStatus = n.GetStringValue(); } },
                { "catalogId", n => { CatalogId = n.GetStringValue(); } },
                { "customExtensionCalloutInstances", n => { CustomExtensionCalloutInstances = n.GetCollectionOfObjectValues<CustomExtensionCalloutInstance>(CustomExtensionCalloutInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "expiredDateTime", n => { ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                { "isExtended", n => { IsExtended = n.GetBoolValue(); } },
                { "schedule", n => { Schedule = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                { "target", n => { Target = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
                { "targetId", n => { TargetId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<ApiSdk.Models.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicy", AccessPackageAssignmentPolicy);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("accessPackageAssignmentRequests", AccessPackageAssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentResourceRole>("accessPackageAssignmentResourceRoles", AccessPackageAssignmentResourceRoles);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
            writer.WriteStringValue("assignmentPolicyId", AssignmentPolicyId);
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("assignmentStatus", AssignmentStatus);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteCollectionOfObjectValues<CustomExtensionCalloutInstance>("customExtensionCalloutInstances", CustomExtensionCalloutInstances);
            writer.WriteDateTimeOffsetValue("expiredDateTime", ExpiredDateTime);
            writer.WriteBoolValue("isExtended", IsExtended);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
            writer.WriteObjectValue<AccessPackageSubject>("target", Target);
            writer.WriteStringValue("targetId", TargetId);
        }
    }
}
