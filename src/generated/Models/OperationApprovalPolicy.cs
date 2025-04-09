// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// The OperationApprovalPolicy entity allows an administrator to configure which operations require admin approval and the set of admins who can perform that approval. Creating a policy enables the multiple admin approval service to catch requests which are targeted by the specific policy type defined.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OperationApprovalPolicy : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The Microsoft Entra ID (Azure AD) security group IDs for the approvers for the policy. This property is required when the policy is created, and is defined by the IT Admins to define the possible approvers for the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApproverGroupIds { get; set; }
#nullable restore
#else
        public List<string> ApproverGroupIds { get; set; }
#endif
        /// <summary>Indicates the description of the policy. Maximum length of the description is 1024 characters. This property is not required, but can be used by the IT Admin to describe the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Indicates the display name of the policy. Maximum length of the display name is 128 characters. This property is required when the policy is created, and is defined by the IT Admins to identify the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicates the last DateTime that the policy was modified. The value cannot be modified and is automatically populated whenever values in the request are updated. For example, when the &apos;policyType&apos; property changes from apps to scripts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>The set of available platforms for the OperationApprovalPolicy. Allows configuration of a policy to specific platform(s) for approval. If no specific platform is required or applicable, the platform is `notApplicable`.</summary>
        public global::ApiSdk.Models.OperationApprovalPolicyPlatform? PolicyPlatform { get; set; }
        /// <summary>Indicates areas of the Intune UX that could support MAA UX for the current logged in IT Admin. This property is required, and is defined by the IT Admins in order to correctly show the expected experience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OperationApprovalPolicySet? PolicySet { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OperationApprovalPolicySet PolicySet { get; set; }
#endif
        /// <summary>The set of available policy types that can be configured for approval. The policy type must always be defined in an OperationApprovalRequest.</summary>
        public global::ApiSdk.Models.OperationApprovalPolicyType? PolicyType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.OperationApprovalPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.OperationApprovalPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.OperationApprovalPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "approverGroupIds", n => { ApproverGroupIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "policyPlatform", n => { PolicyPlatform = n.GetEnumValue<global::ApiSdk.Models.OperationApprovalPolicyPlatform>(); } },
                { "policySet", n => { PolicySet = n.GetObjectValue<global::ApiSdk.Models.OperationApprovalPolicySet>(global::ApiSdk.Models.OperationApprovalPolicySet.CreateFromDiscriminatorValue); } },
                { "policyType", n => { PolicyType = n.GetEnumValue<global::ApiSdk.Models.OperationApprovalPolicyType>(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("approverGroupIds", ApproverGroupIds);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::ApiSdk.Models.OperationApprovalPolicyPlatform>("policyPlatform", PolicyPlatform);
            writer.WriteObjectValue<global::ApiSdk.Models.OperationApprovalPolicySet>("policySet", PolicySet);
            writer.WriteEnumValue<global::ApiSdk.Models.OperationApprovalPolicyType>("policyType", PolicyType);
        }
    }
}
#pragma warning restore CS0618
