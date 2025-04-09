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
    public partial class CustomSecurityAttributeAudit : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activityDateTime property</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>The activityDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityDisplayName { get; set; }
#nullable restore
#else
        public string ActivityDisplayName { get; set; }
#endif
        /// <summary>The additionalDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.KeyValue>? AdditionalDetails { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.KeyValue> AdditionalDetails { get; set; }
#endif
        /// <summary>The category property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>The correlationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId { get; set; }
#nullable restore
#else
        public string CorrelationId { get; set; }
#endif
        /// <summary>The initiatedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuditActivityInitiator? InitiatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuditActivityInitiator InitiatedBy { get; set; }
#endif
        /// <summary>The loggedByService property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoggedByService { get; set; }
#nullable restore
#else
        public string LoggedByService { get; set; }
#endif
        /// <summary>The operationType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperationType { get; set; }
#nullable restore
#else
        public string OperationType { get; set; }
#endif
        /// <summary>The result property</summary>
        public global::ApiSdk.Models.OperationResult? Result { get; set; }
        /// <summary>The resultReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultReason { get; set; }
#nullable restore
#else
        public string ResultReason { get; set; }
#endif
        /// <summary>The targetResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TargetResource>? TargetResources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TargetResource> TargetResources { get; set; }
#endif
        /// <summary>The userAgent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserAgent { get; set; }
#nullable restore
#else
        public string UserAgent { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CustomSecurityAttributeAudit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CustomSecurityAttributeAudit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CustomSecurityAttributeAudit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "activityDisplayName", n => { ActivityDisplayName = n.GetStringValue(); } },
                { "additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<global::ApiSdk.Models.KeyValue>(global::ApiSdk.Models.KeyValue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "category", n => { Category = n.GetStringValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "initiatedBy", n => { InitiatedBy = n.GetObjectValue<global::ApiSdk.Models.AuditActivityInitiator>(global::ApiSdk.Models.AuditActivityInitiator.CreateFromDiscriminatorValue); } },
                { "loggedByService", n => { LoggedByService = n.GetStringValue(); } },
                { "operationType", n => { OperationType = n.GetStringValue(); } },
                { "result", n => { Result = n.GetEnumValue<global::ApiSdk.Models.OperationResult>(); } },
                { "resultReason", n => { ResultReason = n.GetStringValue(); } },
                { "targetResources", n => { TargetResources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TargetResource>(global::ApiSdk.Models.TargetResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userAgent", n => { UserAgent = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityDisplayName", ActivityDisplayName);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteObjectValue<global::ApiSdk.Models.AuditActivityInitiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("loggedByService", LoggedByService);
            writer.WriteStringValue("operationType", OperationType);
            writer.WriteEnumValue<global::ApiSdk.Models.OperationResult>("result", Result);
            writer.WriteStringValue("resultReason", ResultReason);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TargetResource>("targetResources", TargetResources);
            writer.WriteStringValue("userAgent", UserAgent);
        }
    }
}
#pragma warning restore CS0618
