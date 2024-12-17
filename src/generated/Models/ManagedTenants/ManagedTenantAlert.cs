// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.ManagedTenants
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ManagedTenantAlert : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alertData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ManagedTenants.AlertData? AlertData { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ManagedTenants.AlertData AlertData { get; set; }
#endif
        /// <summary>The alertDataReferenceStrings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.AlertDataReferenceString>? AlertDataReferenceStrings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.AlertDataReferenceString> AlertDataReferenceStrings { get; set; }
#endif
        /// <summary>The alertLogs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog>? AlertLogs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog> AlertLogs { get; set; }
#endif
        /// <summary>The alertRule property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule? AlertRule { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule AlertRule { get; set; }
#endif
        /// <summary>The alertRuleDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertRuleDisplayName { get; set; }
#nullable restore
#else
        public string AlertRuleDisplayName { get; set; }
#endif
        /// <summary>The apiNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification>? ApiNotifications { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification> ApiNotifications { get; set; }
#endif
        /// <summary>The assignedToUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedToUserId { get; set; }
#nullable restore
#else
        public string AssignedToUserId { get; set; }
#endif
        /// <summary>The correlationCount property</summary>
        public int? CorrelationCount { get; set; }
        /// <summary>The correlationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId { get; set; }
#nullable restore
#else
        public string CorrelationId { get; set; }
#endif
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId { get; set; }
#nullable restore
#else
        public string CreatedByUserId { get; set; }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The emailNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification>? EmailNotifications { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification> EmailNotifications { get; set; }
#endif
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId { get; set; }
#nullable restore
#else
        public string LastActionByUserId { get; set; }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The severity property</summary>
        public global::ApiSdk.Models.ManagedTenants.AlertSeverity? Severity { get; set; }
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.ManagedTenants.AlertStatus? Status { get; set; }
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The title property</summary>
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
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alertData", n => { AlertData = n.GetObjectValue<global::ApiSdk.Models.ManagedTenants.AlertData>(global::ApiSdk.Models.ManagedTenants.AlertData.CreateFromDiscriminatorValue); } },
                { "alertDataReferenceStrings", n => { AlertDataReferenceStrings = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AlertDataReferenceString>(global::ApiSdk.Models.ManagedTenants.AlertDataReferenceString.CreateFromDiscriminatorValue)?.AsList(); } },
                { "alertLogs", n => { AlertLogs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog>(global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog.CreateFromDiscriminatorValue)?.AsList(); } },
                { "alertRule", n => { AlertRule = n.GetObjectValue<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule>(global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule.CreateFromDiscriminatorValue); } },
                { "alertRuleDisplayName", n => { AlertRuleDisplayName = n.GetStringValue(); } },
                { "apiNotifications", n => { ApiNotifications = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification>(global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignedToUserId", n => { AssignedToUserId = n.GetStringValue(); } },
                { "correlationCount", n => { CorrelationCount = n.GetIntValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "emailNotifications", n => { EmailNotifications = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification>(global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                { "lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::ApiSdk.Models.ManagedTenants.AlertSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.ManagedTenants.AlertStatus>(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ManagedTenants.AlertData>("alertData", AlertData);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AlertDataReferenceString>("alertDataReferenceStrings", AlertDataReferenceStrings);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog>("alertLogs", AlertLogs);
            writer.WriteObjectValue<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule>("alertRule", AlertRule);
            writer.WriteStringValue("alertRuleDisplayName", AlertRuleDisplayName);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification>("apiNotifications", ApiNotifications);
            writer.WriteStringValue("assignedToUserId", AssignedToUserId);
            writer.WriteIntValue("correlationCount", CorrelationCount);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification>("emailNotifications", EmailNotifications);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteEnumValue<global::ApiSdk.Models.ManagedTenants.AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<global::ApiSdk.Models.ManagedTenants.AlertStatus>("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
