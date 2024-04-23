// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    public class TenantStatusInformation : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The status of the delegated admin privilege relationship between the managing entity and the managed tenant. Possible values are: none, delegatedAdminPrivileges, unknownFutureValue, granularDelegatedAdminPrivileges, delegatedAndGranularDelegetedAdminPrivileges. You must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: granularDelegatedAdminPrivileges , delegatedAndGranularDelegetedAdminPrivileges. Optional. Read-only.</summary>
        public ApiSdk.Models.ManagedTenants.DelegatedPrivilegeStatus? DelegatedPrivilegeStatus { get; set; }
        /// <summary>The date and time the delegated admin privileges status was updated. Optional. Read-only.</summary>
        public DateTimeOffset? LastDelegatedPrivilegeRefreshDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The identifier for the account that offboarded the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OffboardedByUserId { get; set; }
#nullable restore
#else
        public string OffboardedByUserId { get; set; }
#endif
        /// <summary>The date and time when the managed tenant was offboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OffboardedDateTime { get; set; }
        /// <summary>The identifier for the account that onboarded the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnboardedByUserId { get; set; }
#nullable restore
#else
        public string OnboardedByUserId { get; set; }
#endif
        /// <summary>The date and time when the managed tenant was onboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OnboardedDateTime { get; set; }
        /// <summary>The onboarding status for the managed tenant.. Possible values are: ineligible, inProcess, active, inactive, unknownFutureValue. Optional. Read-only.</summary>
        public TenantOnboardingStatus? OnboardingStatus { get; set; }
        /// <summary>Organization&apos;s onboarding eligibility reason in Microsoft 365 Lighthouse.. Possible values are: none, contractType, delegatedAdminPrivileges,usersCount,license and unknownFutureValue. Optional. Read-only.</summary>
        public ApiSdk.Models.ManagedTenants.TenantOnboardingEligibilityReason? TenantOnboardingEligibilityReason { get; set; }
        /// <summary>The collection of workload statues for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkloadStatus>? WorkloadStatuses { get; set; }
#nullable restore
#else
        public List<WorkloadStatus> WorkloadStatuses { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TenantStatusInformation"/> and sets the default values.
        /// </summary>
        public TenantStatusInformation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TenantStatusInformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantStatusInformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantStatusInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"delegatedPrivilegeStatus", n => { DelegatedPrivilegeStatus = n.GetEnumValue<DelegatedPrivilegeStatus>(); } },
                {"lastDelegatedPrivilegeRefreshDateTime", n => { LastDelegatedPrivilegeRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"offboardedByUserId", n => { OffboardedByUserId = n.GetStringValue(); } },
                {"offboardedDateTime", n => { OffboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardedByUserId", n => { OnboardedByUserId = n.GetStringValue(); } },
                {"onboardedDateTime", n => { OnboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<TenantOnboardingStatus>(); } },
                {"tenantOnboardingEligibilityReason", n => { TenantOnboardingEligibilityReason = n.GetEnumValue<TenantOnboardingEligibilityReason>(); } },
                {"workloadStatuses", n => { WorkloadStatuses = n.GetCollectionOfObjectValues<WorkloadStatus>(WorkloadStatus.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DelegatedPrivilegeStatus>("delegatedPrivilegeStatus", DelegatedPrivilegeStatus);
            writer.WriteDateTimeOffsetValue("lastDelegatedPrivilegeRefreshDateTime", LastDelegatedPrivilegeRefreshDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("offboardedByUserId", OffboardedByUserId);
            writer.WriteDateTimeOffsetValue("offboardedDateTime", OffboardedDateTime);
            writer.WriteStringValue("onboardedByUserId", OnboardedByUserId);
            writer.WriteDateTimeOffsetValue("onboardedDateTime", OnboardedDateTime);
            writer.WriteEnumValue<TenantOnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteEnumValue<TenantOnboardingEligibilityReason>("tenantOnboardingEligibilityReason", TenantOnboardingEligibilityReason);
            writer.WriteCollectionOfObjectValues<WorkloadStatus>("workloadStatuses", WorkloadStatuses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}