// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ThreatSubmission : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the admin review property that constitutes of who reviewed the user submission, when and what was it identified as.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.SubmissionAdminReview? AdminReview { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.SubmissionAdminReview AdminReview { get; set; }
#endif
        /// <summary>The category property</summary>
        public global::ApiSdk.Models.Security.SubmissionCategory? Category { get; set; }
        /// <summary>Specifies the source of the submission. The possible values are: microsoft, other, and unkownFutureValue.</summary>
        public global::ApiSdk.Models.Security.SubmissionClientSource? ClientSource { get; set; }
        /// <summary>Specifies the type of content being submitted. The possible values are: email, url, file, app, and unkownFutureValue.</summary>
        public global::ApiSdk.Models.Security.SubmissionContentType? ContentType { get; set; }
        /// <summary>Specifies who submitted the email as a threat. Supports $filter = createdBy/email eq &apos;value&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.SubmissionUserIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.SubmissionUserIdentity CreatedBy { get; set; }
#endif
        /// <summary>Specifies when the threat submission was created. Supports $filter = createdDateTime ge 2022-01-01T00:00:00Z and createdDateTime lt 2022-01-02T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Specifies the result of the analysis performed by Microsoft.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.SubmissionResult? Result { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.SubmissionResult Result { get; set; }
#endif
        /// <summary>Specifies the role of the submitter. Supports $filter = source eq &apos;value&apos;. The possible values are: administrator,  user, and unkownFutureValue.</summary>
        public global::ApiSdk.Models.Security.SubmissionSource? Source { get; set; }
        /// <summary>Indicates whether the threat submission has been analyzed by Microsoft. Supports $filter = status eq &apos;value&apos;. The possible values are: notStarted, running, succeeded, failed, skipped, and unkownFutureValue.</summary>
        public global::ApiSdk.Models.Security.LongRunningOperationStatus? Status { get; set; }
        /// <summary>Indicates the tenant id of the submitter. Not required when created using a POST operation. It&apos;s extracted from the token of the post API call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.ThreatSubmission"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Security.ThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.emailContentThreatSubmission" => new global::ApiSdk.Models.Security.EmailContentThreatSubmission(),
                "#microsoft.graph.security.emailThreatSubmission" => new global::ApiSdk.Models.Security.EmailThreatSubmission(),
                "#microsoft.graph.security.emailUrlThreatSubmission" => new global::ApiSdk.Models.Security.EmailUrlThreatSubmission(),
                "#microsoft.graph.security.fileContentThreatSubmission" => new global::ApiSdk.Models.Security.FileContentThreatSubmission(),
                "#microsoft.graph.security.fileThreatSubmission" => new global::ApiSdk.Models.Security.FileThreatSubmission(),
                "#microsoft.graph.security.fileUrlThreatSubmission" => new global::ApiSdk.Models.Security.FileUrlThreatSubmission(),
                "#microsoft.graph.security.urlThreatSubmission" => new global::ApiSdk.Models.Security.UrlThreatSubmission(),
                _ => new global::ApiSdk.Models.Security.ThreatSubmission(),
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
                { "adminReview", n => { AdminReview = n.GetObjectValue<global::ApiSdk.Models.Security.SubmissionAdminReview>(global::ApiSdk.Models.Security.SubmissionAdminReview.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetEnumValue<global::ApiSdk.Models.Security.SubmissionCategory>(); } },
                { "clientSource", n => { ClientSource = n.GetEnumValue<global::ApiSdk.Models.Security.SubmissionClientSource>(); } },
                { "contentType", n => { ContentType = n.GetEnumValue<global::ApiSdk.Models.Security.SubmissionContentType>(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.Security.SubmissionUserIdentity>(global::ApiSdk.Models.Security.SubmissionUserIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "result", n => { Result = n.GetObjectValue<global::ApiSdk.Models.Security.SubmissionResult>(global::ApiSdk.Models.Security.SubmissionResult.CreateFromDiscriminatorValue); } },
                { "source", n => { Source = n.GetEnumValue<global::ApiSdk.Models.Security.SubmissionSource>(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.Security.LongRunningOperationStatus>(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.Security.SubmissionAdminReview>("adminReview", AdminReview);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.SubmissionCategory>("category", Category);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.SubmissionClientSource>("clientSource", ClientSource);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.SubmissionContentType>("contentType", ContentType);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.SubmissionUserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.SubmissionResult>("result", Result);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.SubmissionSource>("source", Source);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.LongRunningOperationStatus>("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
#pragma warning restore CS0618
