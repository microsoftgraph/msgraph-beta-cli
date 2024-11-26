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
    public partial class RestoreArtifactsBulkRequestBase : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The destinationType property</summary>
        public global::ApiSdk.Models.DestinationType? DestinationType { get; set; }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PublicError? Error { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PublicError Error { get; set; }
#endif
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
        /// <summary>The protectionTimePeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TimePeriod? ProtectionTimePeriod { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TimePeriod ProtectionTimePeriod { get; set; }
#endif
        /// <summary>The protectionUnitIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProtectionUnitIds { get; set; }
#nullable restore
#else
        public List<string> ProtectionUnitIds { get; set; }
#endif
        /// <summary>The restorePointPreference property</summary>
        public global::ApiSdk.Models.RestorePointPreference? RestorePointPreference { get; set; }
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.RestoreArtifactsBulkRequestStatus? Status { get; set; }
        /// <summary>The tags property</summary>
        public global::ApiSdk.Models.RestorePointTags? Tags { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RestoreArtifactsBulkRequestBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.RestoreArtifactsBulkRequestBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.driveRestoreArtifactsBulkAdditionRequest" => new global::ApiSdk.Models.DriveRestoreArtifactsBulkAdditionRequest(),
                "#microsoft.graph.mailboxRestoreArtifactsBulkAdditionRequest" => new global::ApiSdk.Models.MailboxRestoreArtifactsBulkAdditionRequest(),
                "#microsoft.graph.siteRestoreArtifactsBulkAdditionRequest" => new global::ApiSdk.Models.SiteRestoreArtifactsBulkAdditionRequest(),
                _ => new global::ApiSdk.Models.RestoreArtifactsBulkRequestBase(),
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
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "destinationType", n => { DestinationType = n.GetEnumValue<global::ApiSdk.Models.DestinationType>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "error", n => { Error = n.GetObjectValue<global::ApiSdk.Models.PublicError>(global::ApiSdk.Models.PublicError.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "protectionTimePeriod", n => { ProtectionTimePeriod = n.GetObjectValue<global::ApiSdk.Models.TimePeriod>(global::ApiSdk.Models.TimePeriod.CreateFromDiscriminatorValue); } },
                { "protectionUnitIds", n => { ProtectionUnitIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "restorePointPreference", n => { RestorePointPreference = n.GetEnumValue<global::ApiSdk.Models.RestorePointPreference>(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.RestoreArtifactsBulkRequestStatus>(); } },
                { "tags", n => { Tags = n.GetEnumValue<global::ApiSdk.Models.RestorePointTags>(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.DestinationType>("destinationType", DestinationType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::ApiSdk.Models.PublicError>("error", Error);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.TimePeriod>("protectionTimePeriod", ProtectionTimePeriod);
            writer.WriteCollectionOfPrimitiveValues<string>("protectionUnitIds", ProtectionUnitIds);
            writer.WriteEnumValue<global::ApiSdk.Models.RestorePointPreference>("restorePointPreference", RestorePointPreference);
            writer.WriteEnumValue<global::ApiSdk.Models.RestoreArtifactsBulkRequestStatus>("status", Status);
            writer.WriteEnumValue<global::ApiSdk.Models.RestorePointTags>("tags", Tags);
        }
    }
}
#pragma warning restore CS0618