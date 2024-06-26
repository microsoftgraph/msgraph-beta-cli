// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ExternalConnectors
{
    #pragma warning disable CS1591
    public class ExternalConnection : ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collects configurable settings related to activities involving connector content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ExternalConnectors.ActivitySettings? ActivitySettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ExternalConnectors.ActivitySettings ActivitySettings { get; set; }
#endif
        /// <summary>The complianceSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ExternalConnectors.ComplianceSettings? ComplianceSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ExternalConnectors.ComplianceSettings ComplianceSettings { get; set; }
#endif
        /// <summary>Specifies additional application IDs that are allowed to manage the connection and to index content in the connection. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ExternalConnectors.Configuration? Configuration { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ExternalConnectors.Configuration Configuration { get; set; }
#endif
        /// <summary>The Teams App ID. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorId { get; set; }
#nullable restore
#else
        public string ConnectorId { get; set; }
#endif
        /// <summary>Description of the connection displayed in the Microsoft 365 admin center. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The list of content experiences the connection will participate in. Possible values are search.</summary>
        public ContentExperienceType? EnabledContentExperiences { get; set; }
        /// <summary>The groups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExternalGroup>? Groups { get; set; }
#nullable restore
#else
        public List<ExternalGroup> Groups { get; set; }
#endif
        /// <summary>The number of items ingested into a connection. This value is refreshed every 15 minutes. If the connection state is draft, then ingestedItemsCount will be null.</summary>
        public long? IngestedItemsCount { get; set; }
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExternalItem>? Items { get; set; }
#nullable restore
#else
        public List<ExternalItem> Items { get; set; }
#endif
        /// <summary>The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConnectionOperation>? Operations { get; set; }
#nullable restore
#else
        public List<ConnectionOperation> Operations { get; set; }
#endif
        /// <summary>The quota property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConnectionQuota? Quota { get; set; }
#nullable restore
#else
        public ConnectionQuota Quota { get; set; }
#endif
        /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ExternalConnectors.Schema? Schema { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ExternalConnectors.Schema Schema { get; set; }
#endif
        /// <summary>The settings configuring the search experience for content in this connection, such as the display templates for search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ExternalConnectors.SearchSettings? SearchSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ExternalConnectors.SearchSettings SearchSettings { get; set; }
#endif
        /// <summary>Indicates the current state of the connection. Possible values are draft, ready, obsolete, and limitExceeded. Required.</summary>
        public ConnectionState? State { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternalConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalConnection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activitySettings", n => { ActivitySettings = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.ActivitySettings>(ApiSdk.Models.ExternalConnectors.ActivitySettings.CreateFromDiscriminatorValue); } },
                { "complianceSettings", n => { ComplianceSettings = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.ComplianceSettings>(ApiSdk.Models.ExternalConnectors.ComplianceSettings.CreateFromDiscriminatorValue); } },
                { "configuration", n => { Configuration = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.Configuration>(ApiSdk.Models.ExternalConnectors.Configuration.CreateFromDiscriminatorValue); } },
                { "connectorId", n => { ConnectorId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "enabledContentExperiences", n => { EnabledContentExperiences = n.GetEnumValue<ContentExperienceType>(); } },
                { "groups", n => { Groups = n.GetCollectionOfObjectValues<ExternalGroup>(ExternalGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                { "ingestedItemsCount", n => { IngestedItemsCount = n.GetLongValue(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<ExternalItem>(ExternalItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<ConnectionOperation>(ConnectionOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "quota", n => { Quota = n.GetObjectValue<ConnectionQuota>(ConnectionQuota.CreateFromDiscriminatorValue); } },
                { "schema", n => { Schema = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.Schema>(ApiSdk.Models.ExternalConnectors.Schema.CreateFromDiscriminatorValue); } },
                { "searchSettings", n => { SearchSettings = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.SearchSettings>(ApiSdk.Models.ExternalConnectors.SearchSettings.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<ConnectionState>(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.ActivitySettings>("activitySettings", ActivitySettings);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.ComplianceSettings>("complianceSettings", ComplianceSettings);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.Configuration>("configuration", Configuration);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ContentExperienceType>("enabledContentExperiences", EnabledContentExperiences);
            writer.WriteCollectionOfObjectValues<ExternalGroup>("groups", Groups);
            writer.WriteLongValue("ingestedItemsCount", IngestedItemsCount);
            writer.WriteCollectionOfObjectValues<ExternalItem>("items", Items);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ConnectionOperation>("operations", Operations);
            writer.WriteObjectValue<ConnectionQuota>("quota", Quota);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.Schema>("schema", Schema);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.SearchSettings>("searchSettings", SearchSettings);
        }
    }
}
