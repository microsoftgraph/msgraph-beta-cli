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
    public partial class RemoteItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identity of the user, device, and application which created the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Indicates that the remote item is a file. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.FileObject? File { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.FileObject File { get; set; }
#endif
        /// <summary>Information about the remote item from the local file system. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.FileSystemInfo? FileSystemInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.FileSystemInfo FileSystemInfo { get; set; }
#endif
        /// <summary>Indicates that the remote item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Folder? Folder { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Folder Folder { get; set; }
#endif
        /// <summary>Unique identifier for the remote item in its drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Image? Image { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Image Image { get; set; }
#endif
        /// <summary>Identity of the user, device, and application which last modified the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>Date and time the item was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Optional. Filename of the remote item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Package? Package { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Package Package { get; set; }
#endif
        /// <summary>Properties of the parent of the remote item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemReference? ParentReference { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemReference ParentReference { get; set; }
#endif
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Shared? Shared { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Shared Shared { get; set; }
#endif
        /// <summary>Provides interop between items in OneDrive for Business and SharePoint with the full set of item identifiers. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>Size of the remote item. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>The specialFolder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SpecialFolder? SpecialFolder { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SpecialFolder SpecialFolder { get; set; }
#endif
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Video? Video { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Video Video { get; set; }
#endif
        /// <summary>DAV compatible URL for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebDavUrl { get; set; }
#nullable restore
#else
        public string WebDavUrl { get; set; }
#endif
        /// <summary>URL that displays the resource in the browser. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.RemoteItem"/> and sets the default values.
        /// </summary>
        public RemoteItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RemoteItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.RemoteItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.RemoteItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "file", n => { File = n.GetObjectValue<global::ApiSdk.Models.FileObject>(global::ApiSdk.Models.FileObject.CreateFromDiscriminatorValue); } },
                { "fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<global::ApiSdk.Models.FileSystemInfo>(global::ApiSdk.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                { "folder", n => { Folder = n.GetObjectValue<global::ApiSdk.Models.Folder>(global::ApiSdk.Models.Folder.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "image", n => { Image = n.GetObjectValue<global::ApiSdk.Models.Image>(global::ApiSdk.Models.Image.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "package", n => { Package = n.GetObjectValue<global::ApiSdk.Models.Package>(global::ApiSdk.Models.Package.CreateFromDiscriminatorValue); } },
                { "parentReference", n => { ParentReference = n.GetObjectValue<global::ApiSdk.Models.ItemReference>(global::ApiSdk.Models.ItemReference.CreateFromDiscriminatorValue); } },
                { "shared", n => { Shared = n.GetObjectValue<global::ApiSdk.Models.Shared>(global::ApiSdk.Models.Shared.CreateFromDiscriminatorValue); } },
                { "sharepointIds", n => { SharepointIds = n.GetObjectValue<global::ApiSdk.Models.SharepointIds>(global::ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "size", n => { Size = n.GetLongValue(); } },
                { "specialFolder", n => { SpecialFolder = n.GetObjectValue<global::ApiSdk.Models.SpecialFolder>(global::ApiSdk.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                { "video", n => { Video = n.GetObjectValue<global::ApiSdk.Models.Video>(global::ApiSdk.Models.Video.CreateFromDiscriminatorValue); } },
                { "webDavUrl", n => { WebDavUrl = n.GetStringValue(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.FileObject>("file", File);
            writer.WriteObjectValue<global::ApiSdk.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<global::ApiSdk.Models.Folder>("folder", Folder);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<global::ApiSdk.Models.Image>("image", Image);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::ApiSdk.Models.Package>("package", Package);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemReference>("parentReference", ParentReference);
            writer.WriteObjectValue<global::ApiSdk.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<global::ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<global::ApiSdk.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteObjectValue<global::ApiSdk.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
