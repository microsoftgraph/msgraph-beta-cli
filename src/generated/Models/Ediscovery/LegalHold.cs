// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Ediscovery
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class LegalHold : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>KQL query that specifies content to be held in the specified locations. To learn more, see Keyword queries and search conditions for Content Search and eDiscovery.  To hold all content in the specified locations, leave contentQuery blank.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentQuery { get; set; }
#nullable restore
#else
        public string ContentQuery { get; set; }
#endif
        /// <summary>The user who created the legal hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The date and time the legal hold was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The legal hold description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the legal hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Lists any errors that happened while placing the hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Errors { get; set; }
#nullable restore
#else
        public List<string> Errors { get; set; }
#endif
        /// <summary>Indicates whether the hold is enabled and actively holding content.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>the user who last modified the legal hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The date and time the legal hold was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Data source entity for SharePoint sites associated with the legal hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Ediscovery.SiteSource>? SiteSources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Ediscovery.SiteSource> SiteSources { get; set; }
#endif
        /// <summary>The status of the legal hold. Possible values are: Pending, Error, Success, UnknownFutureValue.</summary>
        public global::ApiSdk.Models.Ediscovery.LegalHoldStatus? Status { get; set; }
        /// <summary>The unifiedGroupSources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Ediscovery.UnifiedGroupSource>? UnifiedGroupSources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Ediscovery.UnifiedGroupSource> UnifiedGroupSources { get; set; }
#endif
        /// <summary>Data source entity for a the legal hold. This is the container for a mailbox and OneDrive for Business site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Ediscovery.UserSource>? UserSources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Ediscovery.UserSource> UserSources { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Ediscovery.LegalHold"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Ediscovery.LegalHold CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Ediscovery.LegalHold();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contentQuery", n => { ContentQuery = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "errors", n => { Errors = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Ediscovery.SiteSource>(global::ApiSdk.Models.Ediscovery.SiteSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.Ediscovery.LegalHoldStatus>(); } },
                { "unifiedGroupSources", n => { UnifiedGroupSources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Ediscovery.UnifiedGroupSource>(global::ApiSdk.Models.Ediscovery.UnifiedGroupSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userSources", n => { UserSources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Ediscovery.UserSource>(global::ApiSdk.Models.Ediscovery.UserSource.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("errors", Errors);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Ediscovery.SiteSource>("siteSources", SiteSources);
            writer.WriteEnumValue<global::ApiSdk.Models.Ediscovery.LegalHoldStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Ediscovery.UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Ediscovery.UserSource>("userSources", UserSources);
        }
    }
}
#pragma warning restore CS0618
