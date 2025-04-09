// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.TermStore;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Site : global::ApiSdk.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Analytics about the view activities that took place on this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemAnalytics? Analytics { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemAnalytics Analytics { get; set; }
#endif
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ColumnDefinition>? Columns { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ColumnDefinition> Columns { get; set; }
#endif
        /// <summary>The collection of content models applied to this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ContentModel>? ContentModels { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ContentModel> ContentModels { get; set; }
#endif
        /// <summary>The collection of content types defined for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ContentType>? ContentTypes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ContentType> ContentTypes { get; set; }
#endif
        /// <summary>The deleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Deleted? Deleted { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Deleted Deleted { get; set; }
#endif
        /// <summary>The full title for the site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The document processing jobs running on this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DocumentProcessingJob>? DocumentProcessingJobs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DocumentProcessingJob> DocumentProcessingJobs { get; set; }
#endif
        /// <summary>The default drive (document library) for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Drive? Drive { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Drive Drive { get; set; }
#endif
        /// <summary>The collection of drives (document libraries) under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Drive>? Drives { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Drive> Drives { get; set; }
#endif
        /// <summary>The collection of column definitions available in the site that is referenced from the sites in the parent hierarchy of the current site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ColumnDefinition>? ExternalColumns { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ColumnDefinition> ExternalColumns { get; set; }
#endif
        /// <summary>The informationProtection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.InformationProtection? InformationProtection { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.InformationProtection InformationProtection { get; set; }
#endif
        /// <summary>The isPersonalSite property</summary>
        public bool? IsPersonalSite { get; set; }
        /// <summary>Used to address any item contained in this site. This collection can&apos;t be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BaseItem>? Items { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BaseItem> Items { get; set; }
#endif
        /// <summary>The collection of lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.List>? Lists { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.List> Lists { get; set; }
#endif
        /// <summary>The onenote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Onenote? Onenote { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Onenote Onenote { get; set; }
#endif
        /// <summary>The collection of long running operations for the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.RichLongRunningOperation>? Operations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.RichLongRunningOperation> Operations { get; set; }
#endif
        /// <summary>The collection of pages in the baseSitePages list on this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BaseSitePage>? Pages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BaseSitePage> Pages { get; set; }
#endif
        /// <summary>The collection of page templates on this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PageTemplate>? PageTemplates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PageTemplate> PageTemplates { get; set; }
#endif
        /// <summary>The permissions associated with the site. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Permission>? Permissions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Permission> Permissions { get; set; }
#endif
        /// <summary>A container for a collection of recycleBinItem resources in this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RecycleBin? RecycleBin { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RecycleBin RecycleBin { get; set; }
#endif
        /// <summary>If present, provides the root site in the site collection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Root? Root { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Root Root { get; set; }
#endif
        /// <summary>The settings on this site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SiteSettings? Settings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SiteSettings Settings { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>Provides details about the site&apos;s site collection. Available only on the root site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SiteCollection? SiteCollection { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SiteCollection SiteCollection { get; set; }
#endif
        /// <summary>The collection of the sub-sites under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Site>? Sites { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Site> Sites { get; set; }
#endif
        /// <summary>The termStore under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TermStore.Store? TermStore { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TermStore.Store TermStore { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Site"/> and sets the default values.
        /// </summary>
        public Site() : base()
        {
            OdataType = "#microsoft.graph.site";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Site"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Site CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Site();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "analytics", n => { Analytics = n.GetObjectValue<global::ApiSdk.Models.ItemAnalytics>(global::ApiSdk.Models.ItemAnalytics.CreateFromDiscriminatorValue); } },
                { "columns", n => { Columns = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>(global::ApiSdk.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "contentModels", n => { ContentModels = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ContentModel>(global::ApiSdk.Models.ContentModel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ContentType>(global::ApiSdk.Models.ContentType.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deleted", n => { Deleted = n.GetObjectValue<global::ApiSdk.Models.Deleted>(global::ApiSdk.Models.Deleted.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "documentProcessingJobs", n => { DocumentProcessingJobs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DocumentProcessingJob>(global::ApiSdk.Models.DocumentProcessingJob.CreateFromDiscriminatorValue)?.AsList(); } },
                { "drive", n => { Drive = n.GetObjectValue<global::ApiSdk.Models.Drive>(global::ApiSdk.Models.Drive.CreateFromDiscriminatorValue); } },
                { "drives", n => { Drives = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Drive>(global::ApiSdk.Models.Drive.CreateFromDiscriminatorValue)?.AsList(); } },
                { "externalColumns", n => { ExternalColumns = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>(global::ApiSdk.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "informationProtection", n => { InformationProtection = n.GetObjectValue<global::ApiSdk.Models.InformationProtection>(global::ApiSdk.Models.InformationProtection.CreateFromDiscriminatorValue); } },
                { "isPersonalSite", n => { IsPersonalSite = n.GetBoolValue(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BaseItem>(global::ApiSdk.Models.BaseItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lists", n => { Lists = n.GetCollectionOfObjectValues<global::ApiSdk.Models.List>(global::ApiSdk.Models.List.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onenote", n => { Onenote = n.GetObjectValue<global::ApiSdk.Models.Onenote>(global::ApiSdk.Models.Onenote.CreateFromDiscriminatorValue); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.RichLongRunningOperation>(global::ApiSdk.Models.RichLongRunningOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pageTemplates", n => { PageTemplates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PageTemplate>(global::ApiSdk.Models.PageTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pages", n => { Pages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BaseSitePage>(global::ApiSdk.Models.BaseSitePage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "permissions", n => { Permissions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Permission>(global::ApiSdk.Models.Permission.CreateFromDiscriminatorValue)?.AsList(); } },
                { "recycleBin", n => { RecycleBin = n.GetObjectValue<global::ApiSdk.Models.RecycleBin>(global::ApiSdk.Models.RecycleBin.CreateFromDiscriminatorValue); } },
                { "root", n => { Root = n.GetObjectValue<global::ApiSdk.Models.Root>(global::ApiSdk.Models.Root.CreateFromDiscriminatorValue); } },
                { "settings", n => { Settings = n.GetObjectValue<global::ApiSdk.Models.SiteSettings>(global::ApiSdk.Models.SiteSettings.CreateFromDiscriminatorValue); } },
                { "sharepointIds", n => { SharepointIds = n.GetObjectValue<global::ApiSdk.Models.SharepointIds>(global::ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "siteCollection", n => { SiteCollection = n.GetObjectValue<global::ApiSdk.Models.SiteCollection>(global::ApiSdk.Models.SiteCollection.CreateFromDiscriminatorValue); } },
                { "sites", n => { Sites = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Site>(global::ApiSdk.Models.Site.CreateFromDiscriminatorValue)?.AsList(); } },
                { "termStore", n => { TermStore = n.GetObjectValue<global::ApiSdk.Models.TermStore.Store>(global::ApiSdk.Models.TermStore.Store.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ItemAnalytics>("analytics", Analytics);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ContentModel>("contentModels", ContentModels);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ContentType>("contentTypes", ContentTypes);
            writer.WriteObjectValue<global::ApiSdk.Models.Deleted>("deleted", Deleted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DocumentProcessingJob>("documentProcessingJobs", DocumentProcessingJobs);
            writer.WriteObjectValue<global::ApiSdk.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteObjectValue<global::ApiSdk.Models.InformationProtection>("informationProtection", InformationProtection);
            writer.WriteBoolValue("isPersonalSite", IsPersonalSite);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.List>("lists", Lists);
            writer.WriteObjectValue<global::ApiSdk.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BaseSitePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PageTemplate>("pageTemplates", PageTemplates);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Permission>("permissions", Permissions);
            writer.WriteObjectValue<global::ApiSdk.Models.RecycleBin>("recycleBin", RecycleBin);
            writer.WriteObjectValue<global::ApiSdk.Models.Root>("root", Root);
            writer.WriteObjectValue<global::ApiSdk.Models.SiteSettings>("settings", Settings);
            writer.WriteObjectValue<global::ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<global::ApiSdk.Models.SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Site>("sites", Sites);
            writer.WriteObjectValue<global::ApiSdk.Models.TermStore.Store>("termStore", TermStore);
        }
    }
}
#pragma warning restore CS0618
