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
    public partial class AccessPackageAssignmentRequestRequirements : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Answers that have already been provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageAnswer>? ExistingAnswers { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageAnswer> ExistingAnswers { get; set; }
#endif
        /// <summary>Indicates whether a request must be approved by an approver.</summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary>Indicates whether approval is required when a user tries to extend their access.</summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>Indicates whether the requestor is allowed to set a custom schedule.</summary>
        public bool? IsCustomAssignmentScheduleAllowed { get; set; }
        /// <summary>Indicates whether a requestor must supply justification when submitting an assignment request.</summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The description of the policy that the user is trying to request access using.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyDescription { get; set; }
#nullable restore
#else
        public string PolicyDescription { get; set; }
#endif
        /// <summary>The display name of the policy that the user is trying to request access using.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyDisplayName { get; set; }
#nullable restore
#else
        public string PolicyDisplayName { get; set; }
#endif
        /// <summary>The identifier of the policy that these requirements are associated with. This identifier can be used when creating a new assignment request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId { get; set; }
#nullable restore
#else
        public string PolicyId { get; set; }
#endif
        /// <summary>Questions that are configured on the policy. The questions can be required or optional; callers can determine whether a question is required or optional based on the isRequired property on accessPackageQuestion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageQuestion>? Questions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageQuestion> Questions { get; set; }
#endif
        /// <summary>Schedule restrictions enforced, if any.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RequestSchedule? Schedule { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RequestSchedule Schedule { get; set; }
#endif
        /// <summary>The status of the process to process the verifiable credential, if any.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.VerifiableCredentialRequirementStatus? VerifiableCredentialRequirementStatus { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.VerifiableCredentialRequirementStatus VerifiableCredentialRequirementStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AccessPackageAssignmentRequestRequirements"/> and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestRequirements()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AccessPackageAssignmentRequestRequirements"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.AccessPackageAssignmentRequestRequirements CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AccessPackageAssignmentRequestRequirements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "existingAnswers", n => { ExistingAnswers = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageAnswer>(global::ApiSdk.Models.AccessPackageAnswer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isApprovalRequired", n => { IsApprovalRequired = n.GetBoolValue(); } },
                { "isApprovalRequiredForExtension", n => { IsApprovalRequiredForExtension = n.GetBoolValue(); } },
                { "isCustomAssignmentScheduleAllowed", n => { IsCustomAssignmentScheduleAllowed = n.GetBoolValue(); } },
                { "isRequestorJustificationRequired", n => { IsRequestorJustificationRequired = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "policyDescription", n => { PolicyDescription = n.GetStringValue(); } },
                { "policyDisplayName", n => { PolicyDisplayName = n.GetStringValue(); } },
                { "policyId", n => { PolicyId = n.GetStringValue(); } },
                { "questions", n => { Questions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageQuestion>(global::ApiSdk.Models.AccessPackageQuestion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::ApiSdk.Models.RequestSchedule>(global::ApiSdk.Models.RequestSchedule.CreateFromDiscriminatorValue); } },
                { "verifiableCredentialRequirementStatus", n => { VerifiableCredentialRequirementStatus = n.GetObjectValue<global::ApiSdk.Models.VerifiableCredentialRequirementStatus>(global::ApiSdk.Models.VerifiableCredentialRequirementStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageAnswer>("existingAnswers", ExistingAnswers);
            writer.WriteBoolValue("isApprovalRequired", IsApprovalRequired);
            writer.WriteBoolValue("isApprovalRequiredForExtension", IsApprovalRequiredForExtension);
            writer.WriteBoolValue("isCustomAssignmentScheduleAllowed", IsCustomAssignmentScheduleAllowed);
            writer.WriteBoolValue("isRequestorJustificationRequired", IsRequestorJustificationRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyDescription", PolicyDescription);
            writer.WriteStringValue("policyDisplayName", PolicyDisplayName);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<global::ApiSdk.Models.RequestSchedule>("schedule", Schedule);
            writer.WriteObjectValue<global::ApiSdk.Models.VerifiableCredentialRequirementStatus>("verifiableCredentialRequirementStatus", VerifiableCredentialRequirementStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
