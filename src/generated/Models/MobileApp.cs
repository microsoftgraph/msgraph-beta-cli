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
    /// An abstract class containing the base properties for Intune mobile apps. Note: Listing mobile apps with `$expand=assignments` has been deprecated. Instead get the list of apps without the `$expand` query on `assignments`. Then, perform the expansion on individual applications.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MobileApp : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The list of group assignments for this mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MobileAppAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MobileAppAssignment> Assignments { get; set; }
#endif
        /// <summary>The list of categories for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MobileAppCategory>? Categories { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MobileAppCategory> Categories { get; set; }
#endif
        /// <summary>The date and time the app was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>The total number of dependencies the child app has. This property is read-only.</summary>
        public int? DependentAppCount { get; private set; }
        /// <summary>The description of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The developer of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Developer { get; set; }
#nullable restore
#else
        public string Developer { get; set; }
#endif
        /// <summary>The admin provided or imported title of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The more information Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InformationUrl { get; set; }
#nullable restore
#else
        public string InformationUrl { get; set; }
#endif
        /// <summary>The value indicating whether the app is assigned to at least one group. This property is read-only.</summary>
        public bool? IsAssigned { get; private set; }
        /// <summary>The value indicating whether the app is marked as featured by the admin.</summary>
        public bool? IsFeatured { get; set; }
        /// <summary>The large icon, to be displayed in the app details and used for upload of the icon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MimeContent? LargeIcon { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MimeContent LargeIcon { get; set; }
#endif
        /// <summary>The date and time the app was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>Notes for the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>The owner of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner { get; set; }
#nullable restore
#else
        public string Owner { get; set; }
#endif
        /// <summary>The privacy statement Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyInformationUrl { get; set; }
#nullable restore
#else
        public string PrivacyInformationUrl { get; set; }
#endif
        /// <summary>The publisher of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher { get; set; }
#nullable restore
#else
        public string Publisher { get; set; }
#endif
        /// <summary>Indicates the publishing state of an app.</summary>
        public global::ApiSdk.Models.MobileAppPublishingState? PublishingState { get; set; }
        /// <summary>The set of direct relationships for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MobileAppRelationship>? Relationships { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MobileAppRelationship> Relationships { get; set; }
#endif
        /// <summary>List of scope tag ids for this mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>The total number of apps this app is directly or indirectly superseded by. This property is read-only.</summary>
        public int? SupersededAppCount { get; private set; }
        /// <summary>The total number of apps this app directly or indirectly supersedes. This property is read-only.</summary>
        public int? SupersedingAppCount { get; private set; }
        /// <summary>The upload state. Possible values are: 0 - Not Ready, 1 - Ready, 2 - Processing. This property is read-only.</summary>
        public int? UploadState { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.MobileApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.MobileApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidForWorkApp" => new global::ApiSdk.Models.AndroidForWorkApp(),
                "#microsoft.graph.androidLobApp" => new global::ApiSdk.Models.AndroidLobApp(),
                "#microsoft.graph.androidManagedStoreApp" => new global::ApiSdk.Models.AndroidManagedStoreApp(),
                "#microsoft.graph.androidManagedStoreWebApp" => new global::ApiSdk.Models.AndroidManagedStoreWebApp(),
                "#microsoft.graph.androidStoreApp" => new global::ApiSdk.Models.AndroidStoreApp(),
                "#microsoft.graph.iosiPadOSWebClip" => new global::ApiSdk.Models.IosiPadOSWebClip(),
                "#microsoft.graph.iosLobApp" => new global::ApiSdk.Models.IosLobApp(),
                "#microsoft.graph.iosStoreApp" => new global::ApiSdk.Models.IosStoreApp(),
                "#microsoft.graph.iosVppApp" => new global::ApiSdk.Models.IosVppApp(),
                "#microsoft.graph.macOSDmgApp" => new global::ApiSdk.Models.MacOSDmgApp(),
                "#microsoft.graph.macOSLobApp" => new global::ApiSdk.Models.MacOSLobApp(),
                "#microsoft.graph.macOSMicrosoftDefenderApp" => new global::ApiSdk.Models.MacOSMicrosoftDefenderApp(),
                "#microsoft.graph.macOSMicrosoftEdgeApp" => new global::ApiSdk.Models.MacOSMicrosoftEdgeApp(),
                "#microsoft.graph.macOSOfficeSuiteApp" => new global::ApiSdk.Models.MacOSOfficeSuiteApp(),
                "#microsoft.graph.macOSPkgApp" => new global::ApiSdk.Models.MacOSPkgApp(),
                "#microsoft.graph.macOsVppApp" => new global::ApiSdk.Models.MacOsVppApp(),
                "#microsoft.graph.macOSWebClip" => new global::ApiSdk.Models.MacOSWebClip(),
                "#microsoft.graph.managedAndroidLobApp" => new global::ApiSdk.Models.ManagedAndroidLobApp(),
                "#microsoft.graph.managedAndroidStoreApp" => new global::ApiSdk.Models.ManagedAndroidStoreApp(),
                "#microsoft.graph.managedApp" => new global::ApiSdk.Models.ManagedApp(),
                "#microsoft.graph.managedIOSLobApp" => new global::ApiSdk.Models.ManagedIOSLobApp(),
                "#microsoft.graph.managedIOSStoreApp" => new global::ApiSdk.Models.ManagedIOSStoreApp(),
                "#microsoft.graph.managedMobileLobApp" => new global::ApiSdk.Models.ManagedMobileLobApp(),
                "#microsoft.graph.microsoftStoreForBusinessApp" => new global::ApiSdk.Models.MicrosoftStoreForBusinessApp(),
                "#microsoft.graph.mobileLobApp" => new global::ApiSdk.Models.MobileLobApp(),
                "#microsoft.graph.officeSuiteApp" => new global::ApiSdk.Models.OfficeSuiteApp(),
                "#microsoft.graph.webApp" => new global::ApiSdk.Models.WebApp(),
                "#microsoft.graph.win32CatalogApp" => new global::ApiSdk.Models.Win32CatalogApp(),
                "#microsoft.graph.win32LobApp" => new global::ApiSdk.Models.Win32LobApp(),
                "#microsoft.graph.windowsAppX" => new global::ApiSdk.Models.WindowsAppX(),
                "#microsoft.graph.windowsMicrosoftEdgeApp" => new global::ApiSdk.Models.WindowsMicrosoftEdgeApp(),
                "#microsoft.graph.windowsMobileMSI" => new global::ApiSdk.Models.WindowsMobileMSI(),
                "#microsoft.graph.windowsPhone81AppX" => new global::ApiSdk.Models.WindowsPhone81AppX(),
                "#microsoft.graph.windowsPhone81AppXBundle" => new global::ApiSdk.Models.WindowsPhone81AppXBundle(),
                "#microsoft.graph.windowsPhone81StoreApp" => new global::ApiSdk.Models.WindowsPhone81StoreApp(),
                "#microsoft.graph.windowsPhoneXAP" => new global::ApiSdk.Models.WindowsPhoneXAP(),
                "#microsoft.graph.windowsStoreApp" => new global::ApiSdk.Models.WindowsStoreApp(),
                "#microsoft.graph.windowsUniversalAppX" => new global::ApiSdk.Models.WindowsUniversalAppX(),
                "#microsoft.graph.windowsWebApp" => new global::ApiSdk.Models.WindowsWebApp(),
                "#microsoft.graph.winGetApp" => new global::ApiSdk.Models.WinGetApp(),
                _ => new global::ApiSdk.Models.MobileApp(),
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
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MobileAppAssignment>(global::ApiSdk.Models.MobileAppAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MobileAppCategory>(global::ApiSdk.Models.MobileAppCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "dependentAppCount", n => { DependentAppCount = n.GetIntValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "developer", n => { Developer = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "informationUrl", n => { InformationUrl = n.GetStringValue(); } },
                { "isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                { "isFeatured", n => { IsFeatured = n.GetBoolValue(); } },
                { "largeIcon", n => { LargeIcon = n.GetObjectValue<global::ApiSdk.Models.MimeContent>(global::ApiSdk.Models.MimeContent.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetStringValue(); } },
                { "privacyInformationUrl", n => { PrivacyInformationUrl = n.GetStringValue(); } },
                { "publisher", n => { Publisher = n.GetStringValue(); } },
                { "publishingState", n => { PublishingState = n.GetEnumValue<global::ApiSdk.Models.MobileAppPublishingState>(); } },
                { "relationships", n => { Relationships = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MobileAppRelationship>(global::ApiSdk.Models.MobileAppRelationship.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "supersededAppCount", n => { SupersededAppCount = n.GetIntValue(); } },
                { "supersedingAppCount", n => { SupersedingAppCount = n.GetIntValue(); } },
                { "uploadState", n => { UploadState = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MobileAppAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MobileAppCategory>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("developer", Developer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteBoolValue("isFeatured", IsFeatured);
            writer.WriteObjectValue<global::ApiSdk.Models.MimeContent>("largeIcon", LargeIcon);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteEnumValue<global::ApiSdk.Models.MobileAppPublishingState>("publishingState", PublishingState);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MobileAppRelationship>("relationships", Relationships);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
#pragma warning restore CS0618
