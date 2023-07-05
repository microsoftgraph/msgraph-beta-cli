using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class DriveItem : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics { get; set; }
#nullable restore
#else
        public ItemAnalytics Analytics { get; set; }
#endif
        /// <summary>Audio metadata, if the item is an audio file. Read-only. Read-only. Only on OneDrive Personal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Audio? Audio { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Audio Audio { get; set; }
#endif
        /// <summary>Bundle metadata, if the item is a bundle. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Bundle? Bundle { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Bundle Bundle { get; set; }
#endif
        /// <summary>Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? Children { get; set; }
#nullable restore
#else
        public List<DriveItem> Children { get; set; }
#endif
        /// <summary>The content stream, if the item represents a file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content { get; set; }
#nullable restore
#else
        public byte[] Content { get; set; }
#endif
        /// <summary>An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CTag { get; set; }
#nullable restore
#else
        public string CTag { get; set; }
#endif
        /// <summary>Information about the deleted state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Deleted? Deleted { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Deleted Deleted { get; set; }
#endif
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? DriveItemAnalytics { get; set; }
#nullable restore
#else
        public ItemAnalytics DriveItemAnalytics { get; set; }
#endif
        /// <summary>Audio metadata, if the item is an audio file. Read-only. Read-only. Only on OneDrive Personal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Audio? DriveItemAudio { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Audio DriveItemAudio { get; set; }
#endif
        /// <summary>Bundle metadata, if the item is a bundle. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Bundle? DriveItemBundle { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Bundle DriveItemBundle { get; set; }
#endif
        /// <summary>Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? DriveItemChildren { get; set; }
#nullable restore
#else
        public List<DriveItem> DriveItemChildren { get; set; }
#endif
        /// <summary>The content stream, if the item represents a file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? DriveItemContent { get; set; }
#nullable restore
#else
        public byte[] DriveItemContent { get; set; }
#endif
        /// <summary>An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriveItemCTag { get; set; }
#nullable restore
#else
        public string DriveItemCTag { get; set; }
#endif
        /// <summary>Information about the deleted state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Deleted? DriveItemDeleted { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Deleted DriveItemDeleted { get; set; }
#endif
        /// <summary>File metadata, if the item is a file. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.FileObject? DriveItemFile { get; set; }
#nullable restore
#else
        public ApiSdk.Models.FileObject DriveItemFile { get; set; }
#endif
        /// <summary>File system information on client. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.FileSystemInfo? DriveItemFileSystemInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.FileSystemInfo DriveItemFileSystemInfo { get; set; }
#endif
        /// <summary>Folder metadata, if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Folder? DriveItemFolder { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Folder DriveItemFolder { get; set; }
#endif
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Image? DriveItemImage { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Image DriveItemImage { get; set; }
#endif
        /// <summary>For drives in SharePoint, the associated document library list item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ListItem? DriveItemListItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ListItem DriveItemListItem { get; set; }
#endif
        /// <summary>Location metadata, if the item has location data. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GeoCoordinates? DriveItemLocation { get; set; }
#nullable restore
#else
        public GeoCoordinates DriveItemLocation { get; set; }
#endif
        /// <summary>Malware metadata, if the item was detected to contain malware. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Malware? DriveItemMalware { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Malware DriveItemMalware { get; set; }
#endif
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Package? DriveItemPackage { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Package DriveItemPackage { get; set; }
#endif
        /// <summary>If present, indicates that one or more operations that might affect the state of the driveItem are pending completion. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PendingOperations? DriveItemPendingOperations { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PendingOperations DriveItemPendingOperations { get; set; }
#endif
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Permission>? DriveItemPermissions { get; set; }
#nullable restore
#else
        public List<Permission> DriveItemPermissions { get; set; }
#endif
        /// <summary>Photo metadata, if the item is a photo. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Photo? DriveItemPhoto { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Photo DriveItemPhoto { get; set; }
#endif
        /// <summary>Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicationFacet? DriveItemPublication { get; set; }
#nullable restore
#else
        public PublicationFacet DriveItemPublication { get; set; }
#endif
        /// <summary>Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RemoteItem? DriveItemRemoteItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RemoteItem DriveItemRemoteItem { get; set; }
#endif
        /// <summary>If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Root? DriveItemRoot { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Root DriveItemRoot { get; set; }
#endif
        /// <summary>Search metadata, if the item is from a search result. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SearchResult? DriveItemSearchResult { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SearchResult DriveItemSearchResult { get; set; }
#endif
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Shared? DriveItemShared { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Shared DriveItemShared { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SharepointIds? DriveItemSharepointIds { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SharepointIds DriveItemSharepointIds { get; set; }
#endif
        /// <summary>Size of the item in bytes. Read-only.</summary>
        public long? DriveItemSize { get; set; }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SpecialFolder? DriveItemSpecialFolder { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SpecialFolder DriveItemSpecialFolder { get; set; }
#endif
        /// <summary>The set of subscriptions on the item. Only supported on the root of a drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Subscription>? DriveItemSubscriptions { get; set; }
#nullable restore
#else
        public List<Subscription> DriveItemSubscriptions { get; set; }
#endif
        /// <summary>Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ThumbnailSet>? DriveItemThumbnails { get; set; }
#nullable restore
#else
        public List<ThumbnailSet> DriveItemThumbnails { get; set; }
#endif
        /// <summary>The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItemVersion>? DriveItemVersions { get; set; }
#nullable restore
#else
        public List<DriveItemVersion> DriveItemVersions { get; set; }
#endif
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Video? DriveItemVideo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Video DriveItemVideo { get; set; }
#endif
        /// <summary>WebDAV compatible URL for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriveItemWebDavUrl { get; set; }
#nullable restore
#else
        public string DriveItemWebDavUrl { get; set; }
#endif
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Workbook? DriveItemWorkbook { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Workbook DriveItemWorkbook { get; set; }
#endif
        /// <summary>File metadata, if the item is a file. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.FileObject? FileObject { get; set; }
#nullable restore
#else
        public ApiSdk.Models.FileObject FileObject { get; set; }
#endif
        /// <summary>File system information on client. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.FileSystemInfo? FileSystemInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.FileSystemInfo FileSystemInfo { get; set; }
#endif
        /// <summary>Folder metadata, if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Folder? Folder { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Folder Folder { get; set; }
#endif
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Image? Image { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Image Image { get; set; }
#endif
        /// <summary>For drives in SharePoint, the associated document library list item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ListItem? ListItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ListItem ListItem { get; set; }
#endif
        /// <summary>Location metadata, if the item has location data. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GeoCoordinates? Location { get; set; }
#nullable restore
#else
        public GeoCoordinates Location { get; set; }
#endif
        /// <summary>Malware metadata, if the item was detected to contain malware. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Malware? Malware { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Malware Malware { get; set; }
#endif
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Package? Package { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Package Package { get; set; }
#endif
        /// <summary>If present, indicates that one or more operations that might affect the state of the driveItem are pending completion. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PendingOperations? PendingOperations { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PendingOperations PendingOperations { get; set; }
#endif
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Permission>? Permissions { get; set; }
#nullable restore
#else
        public List<Permission> Permissions { get; set; }
#endif
        /// <summary>Photo metadata, if the item is a photo. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Photo? Photo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Photo Photo { get; set; }
#endif
        /// <summary>Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicationFacet? Publication { get; set; }
#nullable restore
#else
        public PublicationFacet Publication { get; set; }
#endif
        /// <summary>Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RemoteItem? RemoteItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RemoteItem RemoteItem { get; set; }
#endif
        /// <summary>If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Root? Root { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Root Root { get; set; }
#endif
        /// <summary>Search metadata, if the item is from a search result. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SearchResult? SearchResult { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SearchResult SearchResult { get; set; }
#endif
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Shared? Shared { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Shared Shared { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>Size of the item in bytes. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SpecialFolder? SpecialFolder { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SpecialFolder SpecialFolder { get; set; }
#endif
        /// <summary>The set of subscriptions on the item. Only supported on the root of a drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Subscription>? Subscriptions { get; set; }
#nullable restore
#else
        public List<Subscription> Subscriptions { get; set; }
#endif
        /// <summary>Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ThumbnailSet>? Thumbnails { get; set; }
#nullable restore
#else
        public List<ThumbnailSet> Thumbnails { get; set; }
#endif
        /// <summary>The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItemVersion>? Versions { get; set; }
#nullable restore
#else
        public List<DriveItemVersion> Versions { get; set; }
#endif
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Video? Video { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Video Video { get; set; }
#endif
        /// <summary>WebDAV compatible URL for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebDavUrl { get; set; }
#nullable restore
#else
        public string WebDavUrl { get; set; }
#endif
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Workbook? Workbook { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Workbook Workbook { get; set; }
#endif
        /// <summary>
        /// Instantiates a new driveItem and sets the default values.
        /// </summary>
        public DriveItem() : base() {
            OdataType = "#microsoft.graph.driveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"audio", n => { Audio = n.GetObjectValue<ApiSdk.Models.Audio>(ApiSdk.Models.Audio.CreateFromDiscriminatorValue); } },
                {"bundle", n => { Bundle = n.GetObjectValue<ApiSdk.Models.Bundle>(ApiSdk.Models.Bundle.CreateFromDiscriminatorValue); } },
                {"children", n => { Children = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"cTag", n => { CTag = n.GetStringValue(); } },
                {"deleted", n => { Deleted = n.GetObjectValue<ApiSdk.Models.Deleted>(ApiSdk.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"analytics", n => { DriveItemAnalytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"audio", n => { DriveItemAudio = n.GetObjectValue<ApiSdk.Models.Audio>(ApiSdk.Models.Audio.CreateFromDiscriminatorValue); } },
                {"bundle", n => { DriveItemBundle = n.GetObjectValue<ApiSdk.Models.Bundle>(ApiSdk.Models.Bundle.CreateFromDiscriminatorValue); } },
                {"children", n => { DriveItemChildren = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { DriveItemContent = n.GetByteArrayValue(); } },
                {"cTag", n => { DriveItemCTag = n.GetStringValue(); } },
                {"deleted", n => { DriveItemDeleted = n.GetObjectValue<ApiSdk.Models.Deleted>(ApiSdk.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"file", n => { DriveItemFile = n.GetObjectValue<ApiSdk.Models.FileObject>(ApiSdk.Models.FileObject.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", n => { DriveItemFileSystemInfo = n.GetObjectValue<ApiSdk.Models.FileSystemInfo>(ApiSdk.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", n => { DriveItemFolder = n.GetObjectValue<ApiSdk.Models.Folder>(ApiSdk.Models.Folder.CreateFromDiscriminatorValue); } },
                {"image", n => { DriveItemImage = n.GetObjectValue<ApiSdk.Models.Image>(ApiSdk.Models.Image.CreateFromDiscriminatorValue); } },
                {"listItem", n => { DriveItemListItem = n.GetObjectValue<ApiSdk.Models.ListItem>(ApiSdk.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"location", n => { DriveItemLocation = n.GetObjectValue<GeoCoordinates>(GeoCoordinates.CreateFromDiscriminatorValue); } },
                {"malware", n => { DriveItemMalware = n.GetObjectValue<ApiSdk.Models.Malware>(ApiSdk.Models.Malware.CreateFromDiscriminatorValue); } },
                {"package", n => { DriveItemPackage = n.GetObjectValue<ApiSdk.Models.Package>(ApiSdk.Models.Package.CreateFromDiscriminatorValue); } },
                {"pendingOperations", n => { DriveItemPendingOperations = n.GetObjectValue<ApiSdk.Models.PendingOperations>(ApiSdk.Models.PendingOperations.CreateFromDiscriminatorValue); } },
                {"permissions", n => { DriveItemPermissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { DriveItemPhoto = n.GetObjectValue<ApiSdk.Models.Photo>(ApiSdk.Models.Photo.CreateFromDiscriminatorValue); } },
                {"publication", n => { DriveItemPublication = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"remoteItem", n => { DriveItemRemoteItem = n.GetObjectValue<ApiSdk.Models.RemoteItem>(ApiSdk.Models.RemoteItem.CreateFromDiscriminatorValue); } },
                {"root", n => { DriveItemRoot = n.GetObjectValue<ApiSdk.Models.Root>(ApiSdk.Models.Root.CreateFromDiscriminatorValue); } },
                {"searchResult", n => { DriveItemSearchResult = n.GetObjectValue<ApiSdk.Models.SearchResult>(ApiSdk.Models.SearchResult.CreateFromDiscriminatorValue); } },
                {"shared", n => { DriveItemShared = n.GetObjectValue<ApiSdk.Models.Shared>(ApiSdk.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { DriveItemSharepointIds = n.GetObjectValue<ApiSdk.Models.SharepointIds>(ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", n => { DriveItemSize = n.GetLongValue(); } },
                {"specialFolder", n => { DriveItemSpecialFolder = n.GetObjectValue<ApiSdk.Models.SpecialFolder>(ApiSdk.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { DriveItemSubscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue)?.ToList(); } },
                {"thumbnails", n => { DriveItemThumbnails = n.GetCollectionOfObjectValues<ThumbnailSet>(ThumbnailSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"versions", n => { DriveItemVersions = n.GetCollectionOfObjectValues<DriveItemVersion>(DriveItemVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"video", n => { DriveItemVideo = n.GetObjectValue<ApiSdk.Models.Video>(ApiSdk.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", n => { DriveItemWebDavUrl = n.GetStringValue(); } },
                {"workbook", n => { DriveItemWorkbook = n.GetObjectValue<ApiSdk.Models.Workbook>(ApiSdk.Models.Workbook.CreateFromDiscriminatorValue); } },
                {"file", n => { FileObject = n.GetObjectValue<ApiSdk.Models.FileObject>(ApiSdk.Models.FileObject.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<ApiSdk.Models.FileSystemInfo>(ApiSdk.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", n => { Folder = n.GetObjectValue<ApiSdk.Models.Folder>(ApiSdk.Models.Folder.CreateFromDiscriminatorValue); } },
                {"image", n => { Image = n.GetObjectValue<ApiSdk.Models.Image>(ApiSdk.Models.Image.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<ApiSdk.Models.ListItem>(ApiSdk.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"location", n => { Location = n.GetObjectValue<GeoCoordinates>(GeoCoordinates.CreateFromDiscriminatorValue); } },
                {"malware", n => { Malware = n.GetObjectValue<ApiSdk.Models.Malware>(ApiSdk.Models.Malware.CreateFromDiscriminatorValue); } },
                {"package", n => { Package = n.GetObjectValue<ApiSdk.Models.Package>(ApiSdk.Models.Package.CreateFromDiscriminatorValue); } },
                {"pendingOperations", n => { PendingOperations = n.GetObjectValue<ApiSdk.Models.PendingOperations>(ApiSdk.Models.PendingOperations.CreateFromDiscriminatorValue); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ApiSdk.Models.Photo>(ApiSdk.Models.Photo.CreateFromDiscriminatorValue); } },
                {"publication", n => { Publication = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"remoteItem", n => { RemoteItem = n.GetObjectValue<ApiSdk.Models.RemoteItem>(ApiSdk.Models.RemoteItem.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<ApiSdk.Models.Root>(ApiSdk.Models.Root.CreateFromDiscriminatorValue); } },
                {"searchResult", n => { SearchResult = n.GetObjectValue<ApiSdk.Models.SearchResult>(ApiSdk.Models.SearchResult.CreateFromDiscriminatorValue); } },
                {"shared", n => { Shared = n.GetObjectValue<ApiSdk.Models.Shared>(ApiSdk.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<ApiSdk.Models.SharepointIds>(ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"specialFolder", n => { SpecialFolder = n.GetObjectValue<ApiSdk.Models.SpecialFolder>(ApiSdk.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue)?.ToList(); } },
                {"thumbnails", n => { Thumbnails = n.GetCollectionOfObjectValues<ThumbnailSet>(ThumbnailSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<DriveItemVersion>(DriveItemVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"video", n => { Video = n.GetObjectValue<ApiSdk.Models.Video>(ApiSdk.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", n => { WebDavUrl = n.GetStringValue(); } },
                {"workbook", n => { Workbook = n.GetObjectValue<ApiSdk.Models.Workbook>(ApiSdk.Models.Workbook.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<ApiSdk.Models.Audio>("audio", Audio);
            writer.WriteObjectValue<ApiSdk.Models.Bundle>("bundle", Bundle);
            writer.WriteCollectionOfObjectValues<DriveItem>("children", Children);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("cTag", CTag);
            writer.WriteObjectValue<ApiSdk.Models.Deleted>("deleted", Deleted);
            writer.WriteObjectValue<ItemAnalytics>("analytics", DriveItemAnalytics);
            writer.WriteObjectValue<ApiSdk.Models.Audio>("audio", DriveItemAudio);
            writer.WriteObjectValue<ApiSdk.Models.Bundle>("bundle", DriveItemBundle);
            writer.WriteCollectionOfObjectValues<DriveItem>("children", DriveItemChildren);
            writer.WriteByteArrayValue("content", DriveItemContent);
            writer.WriteStringValue("cTag", DriveItemCTag);
            writer.WriteObjectValue<ApiSdk.Models.Deleted>("deleted", DriveItemDeleted);
            writer.WriteObjectValue<ApiSdk.Models.FileObject>("file", DriveItemFile);
            writer.WriteObjectValue<ApiSdk.Models.FileSystemInfo>("fileSystemInfo", DriveItemFileSystemInfo);
            writer.WriteObjectValue<ApiSdk.Models.Folder>("folder", DriveItemFolder);
            writer.WriteObjectValue<ApiSdk.Models.Image>("image", DriveItemImage);
            writer.WriteObjectValue<ApiSdk.Models.ListItem>("listItem", DriveItemListItem);
            writer.WriteObjectValue<GeoCoordinates>("location", DriveItemLocation);
            writer.WriteObjectValue<ApiSdk.Models.Malware>("malware", DriveItemMalware);
            writer.WriteObjectValue<ApiSdk.Models.Package>("package", DriveItemPackage);
            writer.WriteObjectValue<ApiSdk.Models.PendingOperations>("pendingOperations", DriveItemPendingOperations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", DriveItemPermissions);
            writer.WriteObjectValue<ApiSdk.Models.Photo>("photo", DriveItemPhoto);
            writer.WriteObjectValue<PublicationFacet>("publication", DriveItemPublication);
            writer.WriteObjectValue<ApiSdk.Models.RemoteItem>("remoteItem", DriveItemRemoteItem);
            writer.WriteObjectValue<ApiSdk.Models.Root>("root", DriveItemRoot);
            writer.WriteObjectValue<ApiSdk.Models.SearchResult>("searchResult", DriveItemSearchResult);
            writer.WriteObjectValue<ApiSdk.Models.Shared>("shared", DriveItemShared);
            writer.WriteObjectValue<ApiSdk.Models.SharepointIds>("sharepointIds", DriveItemSharepointIds);
            writer.WriteLongValue("size", DriveItemSize);
            writer.WriteObjectValue<ApiSdk.Models.SpecialFolder>("specialFolder", DriveItemSpecialFolder);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", DriveItemSubscriptions);
            writer.WriteCollectionOfObjectValues<ThumbnailSet>("thumbnails", DriveItemThumbnails);
            writer.WriteCollectionOfObjectValues<DriveItemVersion>("versions", DriveItemVersions);
            writer.WriteObjectValue<ApiSdk.Models.Video>("video", DriveItemVideo);
            writer.WriteStringValue("webDavUrl", DriveItemWebDavUrl);
            writer.WriteObjectValue<ApiSdk.Models.Workbook>("workbook", DriveItemWorkbook);
            writer.WriteObjectValue<ApiSdk.Models.FileObject>("file", FileObject);
            writer.WriteObjectValue<ApiSdk.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<ApiSdk.Models.Folder>("folder", Folder);
            writer.WriteObjectValue<ApiSdk.Models.Image>("image", Image);
            writer.WriteObjectValue<ApiSdk.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<GeoCoordinates>("location", Location);
            writer.WriteObjectValue<ApiSdk.Models.Malware>("malware", Malware);
            writer.WriteObjectValue<ApiSdk.Models.Package>("package", Package);
            writer.WriteObjectValue<ApiSdk.Models.PendingOperations>("pendingOperations", PendingOperations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<ApiSdk.Models.Photo>("photo", Photo);
            writer.WriteObjectValue<PublicationFacet>("publication", Publication);
            writer.WriteObjectValue<ApiSdk.Models.RemoteItem>("remoteItem", RemoteItem);
            writer.WriteObjectValue<ApiSdk.Models.Root>("root", Root);
            writer.WriteObjectValue<ApiSdk.Models.SearchResult>("searchResult", SearchResult);
            writer.WriteObjectValue<ApiSdk.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<ApiSdk.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteCollectionOfObjectValues<ThumbnailSet>("thumbnails", Thumbnails);
            writer.WriteCollectionOfObjectValues<DriveItemVersion>("versions", Versions);
            writer.WriteObjectValue<ApiSdk.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteObjectValue<ApiSdk.Models.Workbook>("workbook", Workbook);
        }
    }
}
