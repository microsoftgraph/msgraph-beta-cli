// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Contains properties for a single installer file that is associated with a given mobileAppContent version.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MobileAppContentFile : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Indicates the Azure Storage URI that the file is uploaded to. Created by the service upon receiving a valid mobileAppContentFile. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureStorageUri { get; private set; }
#nullable restore
#else
        public string AzureStorageUri { get; private set; }
#endif
        /// <summary>Indicates the date and time when the Azure storage URI expires, in ISO 8601 format. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Read-only. This property is read-only.</summary>
        public DateTimeOffset? AzureStorageUriExpirationDateTime { get; private set; }
        /// <summary>Indicates created date and time associated with app content file, in ISO 8601 format. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Read-only. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>A value indicating whether the file is committed. A committed app content file has been fully uploaded and validated by the Intune service. TRUE means that app content file is committed, FALSE means that app content file is not committed. Defaults to FALSE. Read-only. This property is read-only.</summary>
        public bool? IsCommitted { get; private set; }
        /// <summary>Indicates whether this content file is a dependency for the main content file. TRUE means that the content file is a dependency, FALSE means that the content file is not a dependency and is the main content file. Defaults to FALSE.</summary>
        public bool? IsDependency { get; set; }
        /// <summary>A value indicating whether the file is a framework file. To be deprecated.</summary>
        public bool? IsFrameworkFile { get; set; }
        /// <summary>Indicates the manifest information, containing file metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Manifest { get; set; }
#nullable restore
#else
        public byte[] Manifest { get; set; }
#endif
        /// <summary>Indicates the name of the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Indicates the original size of the file, in bytes.</summary>
        public long? Size { get; set; }
        /// <summary>Indicates the size of the file after encryption, in bytes.</summary>
        public long? SizeEncrypted { get; set; }
        /// <summary>Contains properties for upload request states.</summary>
        public global::ApiSdk.Models.MobileAppContentFileUploadState? UploadState { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.MobileAppContentFile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.MobileAppContentFile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.MobileAppContentFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "azureStorageUri", n => { AzureStorageUri = n.GetStringValue(); } },
                { "azureStorageUriExpirationDateTime", n => { AzureStorageUriExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "isCommitted", n => { IsCommitted = n.GetBoolValue(); } },
                { "isDependency", n => { IsDependency = n.GetBoolValue(); } },
                { "isFrameworkFile", n => { IsFrameworkFile = n.GetBoolValue(); } },
                { "manifest", n => { Manifest = n.GetByteArrayValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "size", n => { Size = n.GetLongValue(); } },
                { "sizeEncrypted", n => { SizeEncrypted = n.GetLongValue(); } },
                { "uploadState", n => { UploadState = n.GetEnumValue<global::ApiSdk.Models.MobileAppContentFileUploadState>(); } },
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
            writer.WriteBoolValue("isDependency", IsDependency);
            writer.WriteBoolValue("isFrameworkFile", IsFrameworkFile);
            writer.WriteByteArrayValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("size", Size);
            writer.WriteLongValue("sizeEncrypted", SizeEncrypted);
            writer.WriteEnumValue<global::ApiSdk.Models.MobileAppContentFileUploadState>("uploadState", UploadState);
        }
    }
}
#pragma warning restore CS0618
