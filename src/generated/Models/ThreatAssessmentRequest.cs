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
    public partial class ThreatAssessmentRequest : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The category property</summary>
        public global::ApiSdk.Models.ThreatCategory? Category { get; set; }
        /// <summary>The content type of threat assessment. Possible values are: mail, url, file.</summary>
        public global::ApiSdk.Models.ThreatAssessmentContentType? ContentType { get; set; }
        /// <summary>The threat assessment request creator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The expectedAssessment property</summary>
        public global::ApiSdk.Models.ThreatExpectedAssessment? ExpectedAssessment { get; set; }
        /// <summary>The source of the threat assessment request. Possible values are: user, administrator.</summary>
        public global::ApiSdk.Models.ThreatAssessmentRequestSource? RequestSource { get; set; }
        /// <summary>A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ThreatAssessmentResult>? Results { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ThreatAssessmentResult> Results { get; set; }
#endif
        /// <summary>The assessment process status. Possible values are: pending, completed.</summary>
        public global::ApiSdk.Models.ThreatAssessmentStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ThreatAssessmentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ThreatAssessmentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.emailFileAssessmentRequest" => new global::ApiSdk.Models.EmailFileAssessmentRequest(),
                "#microsoft.graph.fileAssessmentRequest" => new global::ApiSdk.Models.FileAssessmentRequest(),
                "#microsoft.graph.mailAssessmentRequest" => new global::ApiSdk.Models.MailAssessmentRequest(),
                "#microsoft.graph.urlAssessmentRequest" => new global::ApiSdk.Models.UrlAssessmentRequest(),
                _ => new global::ApiSdk.Models.ThreatAssessmentRequest(),
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
                { "category", n => { Category = n.GetEnumValue<global::ApiSdk.Models.ThreatCategory>(); } },
                { "contentType", n => { ContentType = n.GetEnumValue<global::ApiSdk.Models.ThreatAssessmentContentType>(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "expectedAssessment", n => { ExpectedAssessment = n.GetEnumValue<global::ApiSdk.Models.ThreatExpectedAssessment>(); } },
                { "requestSource", n => { RequestSource = n.GetEnumValue<global::ApiSdk.Models.ThreatAssessmentRequestSource>(); } },
                { "results", n => { Results = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ThreatAssessmentResult>(global::ApiSdk.Models.ThreatAssessmentResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.ThreatAssessmentStatus>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.ThreatCategory>("category", Category);
            writer.WriteEnumValue<global::ApiSdk.Models.ThreatAssessmentContentType>("contentType", ContentType);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.ThreatExpectedAssessment>("expectedAssessment", ExpectedAssessment);
            writer.WriteEnumValue<global::ApiSdk.Models.ThreatAssessmentRequestSource>("requestSource", RequestSource);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ThreatAssessmentResult>("results", Results);
            writer.WriteEnumValue<global::ApiSdk.Models.ThreatAssessmentStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
