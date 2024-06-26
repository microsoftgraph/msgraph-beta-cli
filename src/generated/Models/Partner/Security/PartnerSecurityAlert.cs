// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Partner.Security
{
    #pragma warning disable CS1591
    public class PartnerSecurityAlert : ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the activity by a partner and includes details of state transitions, who performed them, and when they occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ActivityLog>? ActivityLogs { get; set; }
#nullable restore
#else
        public List<ActivityLog> ActivityLogs { get; set; }
#endif
        /// <summary>A bag of name-value pairs that contain more details about an alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdditionalDataDictionary? AdditionalDetails { get; set; }
#nullable restore
#else
        public AdditionalDataDictionary AdditionalDetails { get; set; }
#endif
        /// <summary>Contains details of the resources affected by the security alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AffectedResource>? AffectedResources { get; set; }
#nullable restore
#else
        public List<AffectedResource> AffectedResources { get; set; }
#endif
        /// <summary>The type of vulnerability that impacts the customer due to this alert. For more information, see Security alerts reference guide.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertType { get; set; }
#nullable restore
#else
        public string AlertType { get; set; }
#endif
        /// <summary>The modern offer category ID of the subscription.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogOfferId { get; set; }
#nullable restore
#else
        public string CatalogOfferId { get; set; }
#endif
        /// <summary>The confidenceLevel property</summary>
        public SecurityAlertConfidence? ConfidenceLevel { get; set; }
        /// <summary>The impacted customer tenant associated with the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerTenantId { get; set; }
#nullable restore
#else
        public string CustomerTenantId { get; set; }
#endif
        /// <summary>The description for each alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Time when the alert was detected or created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DetectedDateTime { get; set; }
        /// <summary>The display name of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Time of the first activity associated with the alert. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstObservedDateTime { get; set; }
        /// <summary>Indicates whether an alert is a test alert.</summary>
        public bool? IsTest { get; set; }
        /// <summary>Time of the latest activity associated with the alert. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastObservedDateTime { get; set; }
        /// <summary>The UPN of the partner user who resolved the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResolvedBy { get; set; }
#nullable restore
#else
        public string ResolvedBy { get; set; }
#endif
        /// <summary>Time when the alert was resolved. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ResolvedOnDateTime { get; set; }
        /// <summary>The reason provided by the partner for addressing the alert. The possible values are: legitimate, ignore, fraud, unknownFutureValue.</summary>
        public SecurityAlertResolvedReason? ResolvedReason { get; set; }
        /// <summary>The severity property</summary>
        public SecurityAlertSeverity? Severity { get; set; }
        /// <summary>The status property</summary>
        public SecurityAlertStatus? Status { get; set; }
        /// <summary>The subscription associated with the alert for the customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId { get; set; }
#nullable restore
#else
        public string SubscriptionId { get; set; }
#endif
        /// <summary>The value-added reseller tenant associated with the partner tenant and customer tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueAddedResellerTenantId { get; set; }
#nullable restore
#else
        public string ValueAddedResellerTenantId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PartnerSecurityAlert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PartnerSecurityAlert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PartnerSecurityAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activityLogs", n => { ActivityLogs = n.GetCollectionOfObjectValues<ActivityLog>(ActivityLog.CreateFromDiscriminatorValue)?.ToList(); } },
                { "additionalDetails", n => { AdditionalDetails = n.GetObjectValue<AdditionalDataDictionary>(AdditionalDataDictionary.CreateFromDiscriminatorValue); } },
                { "affectedResources", n => { AffectedResources = n.GetCollectionOfObjectValues<AffectedResource>(AffectedResource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "alertType", n => { AlertType = n.GetStringValue(); } },
                { "catalogOfferId", n => { CatalogOfferId = n.GetStringValue(); } },
                { "confidenceLevel", n => { ConfidenceLevel = n.GetEnumValue<SecurityAlertConfidence>(); } },
                { "customerTenantId", n => { CustomerTenantId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detectedDateTime", n => { DetectedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "firstObservedDateTime", n => { FirstObservedDateTime = n.GetDateTimeOffsetValue(); } },
                { "isTest", n => { IsTest = n.GetBoolValue(); } },
                { "lastObservedDateTime", n => { LastObservedDateTime = n.GetDateTimeOffsetValue(); } },
                { "resolvedBy", n => { ResolvedBy = n.GetStringValue(); } },
                { "resolvedOnDateTime", n => { ResolvedOnDateTime = n.GetDateTimeOffsetValue(); } },
                { "resolvedReason", n => { ResolvedReason = n.GetEnumValue<SecurityAlertResolvedReason>(); } },
                { "severity", n => { Severity = n.GetEnumValue<SecurityAlertSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<SecurityAlertStatus>(); } },
                { "subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                { "valueAddedResellerTenantId", n => { ValueAddedResellerTenantId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<ActivityLog>("activityLogs", ActivityLogs);
            writer.WriteObjectValue<AdditionalDataDictionary>("additionalDetails", AdditionalDetails);
            writer.WriteCollectionOfObjectValues<AffectedResource>("affectedResources", AffectedResources);
            writer.WriteStringValue("alertType", AlertType);
            writer.WriteStringValue("catalogOfferId", CatalogOfferId);
            writer.WriteEnumValue<SecurityAlertConfidence>("confidenceLevel", ConfidenceLevel);
            writer.WriteStringValue("customerTenantId", CustomerTenantId);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("detectedDateTime", DetectedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("firstObservedDateTime", FirstObservedDateTime);
            writer.WriteBoolValue("isTest", IsTest);
            writer.WriteDateTimeOffsetValue("lastObservedDateTime", LastObservedDateTime);
            writer.WriteStringValue("resolvedBy", ResolvedBy);
            writer.WriteDateTimeOffsetValue("resolvedOnDateTime", ResolvedOnDateTime);
            writer.WriteEnumValue<SecurityAlertResolvedReason>("resolvedReason", ResolvedReason);
            writer.WriteEnumValue<SecurityAlertSeverity>("severity", Severity);
            writer.WriteEnumValue<SecurityAlertStatus>("status", Status);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("valueAddedResellerTenantId", ValueAddedResellerTenantId);
        }
    }
}
