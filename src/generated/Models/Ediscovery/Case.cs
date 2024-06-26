// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Ediscovery
{
    #pragma warning disable CS1591
    public class Case : ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The user who closed the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentitySet? ClosedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentitySet ClosedBy { get; set; }
#endif
        /// <summary>The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ClosedDateTime { get; set; }
        /// <summary>The date and time when the entity was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Returns a list of case custodian objects for this case.  Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Custodian>? Custodians { get; set; }
#nullable restore
#else
        public List<Custodian> Custodians { get; set; }
#endif
        /// <summary>The case description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The case name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The external case number for customer reference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The last user who modified the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The latest date and time when the case was modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Returns a list of case legalHold objects for this case.  Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LegalHold>? LegalHolds { get; set; }
#nullable restore
#else
        public List<LegalHold> LegalHolds { get; set; }
#endif
        /// <summary>Returns a list of case noncustodialDataSource objects for this case.  Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NoncustodialDataSource>? NoncustodialDataSources { get; set; }
#nullable restore
#else
        public List<NoncustodialDataSource> NoncustodialDataSources { get; set; }
#endif
        /// <summary>Returns a list of case operation objects for this case. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CaseOperation>? Operations { get; set; }
#nullable restore
#else
        public List<CaseOperation> Operations { get; set; }
#endif
        /// <summary>Returns a list of reviewSet objects in the case. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ReviewSet>? ReviewSets { get; set; }
#nullable restore
#else
        public List<ReviewSet> ReviewSets { get; set; }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CaseSettings? Settings { get; set; }
#nullable restore
#else
        public CaseSettings Settings { get; set; }
#endif
        /// <summary>Returns a list of sourceCollection objects associated with this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SourceCollection>? SourceCollections { get; set; }
#nullable restore
#else
        public List<SourceCollection> SourceCollections { get; set; }
#endif
        /// <summary>The case status. Possible values are unknown, active, pendingDelete, closing, closed, and closedWithError. For details, see the following table.</summary>
        public CaseStatus? Status { get; set; }
        /// <summary>Returns a list of tag objects associated to this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Tag>? Tags { get; set; }
#nullable restore
#else
        public List<Tag> Tags { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Case"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Case CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Case();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "closedBy", n => { ClosedBy = n.GetObjectValue<ApiSdk.Models.IdentitySet>(ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "custodians", n => { Custodians = n.GetCollectionOfObjectValues<Custodian>(Custodian.CreateFromDiscriminatorValue)?.ToList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<ApiSdk.Models.IdentitySet>(ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "legalHolds", n => { LegalHolds = n.GetCollectionOfObjectValues<LegalHold>(LegalHold.CreateFromDiscriminatorValue)?.ToList(); } },
                { "noncustodialDataSources", n => { NoncustodialDataSources = n.GetCollectionOfObjectValues<NoncustodialDataSource>(NoncustodialDataSource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<CaseOperation>(CaseOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "reviewSets", n => { ReviewSets = n.GetCollectionOfObjectValues<ReviewSet>(ReviewSet.CreateFromDiscriminatorValue)?.ToList(); } },
                { "settings", n => { Settings = n.GetObjectValue<CaseSettings>(CaseSettings.CreateFromDiscriminatorValue); } },
                { "sourceCollections", n => { SourceCollections = n.GetCollectionOfObjectValues<SourceCollection>(SourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                { "status", n => { Status = n.GetEnumValue<CaseStatus>(); } },
                { "tags", n => { Tags = n.GetCollectionOfObjectValues<Tag>(Tag.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.IdentitySet>("closedBy", ClosedBy);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<Custodian>("custodians", Custodians);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<ApiSdk.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LegalHold>("legalHolds", LegalHolds);
            writer.WriteCollectionOfObjectValues<NoncustodialDataSource>("noncustodialDataSources", NoncustodialDataSources);
            writer.WriteCollectionOfObjectValues<CaseOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ReviewSet>("reviewSets", ReviewSets);
            writer.WriteObjectValue<CaseSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<SourceCollection>("sourceCollections", SourceCollections);
            writer.WriteEnumValue<CaseStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<Tag>("tags", Tags);
        }
    }
}
