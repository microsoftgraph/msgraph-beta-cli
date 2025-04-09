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
    /// Represents per-process privacy preferences.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MacOSPrivacyAccessControlItem : IAdditionalDataHolder, IParsable
    {
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? Accessibility { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? AddressBook { get; set; }
        /// <summary>Allow or deny the app or process to send a restricted Apple event to another app or process. You will need to know the identifier, identifier type, and code requirement of the receiving app or process. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MacOSAppleEventReceiver>? AppleEventsAllowedReceivers { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MacOSAppleEventReceiver> AppleEventsAllowedReceivers { get; set; }
#endif
        /// <summary>Block access to camera app.</summary>
        public bool? BlockCamera { get; set; }
        /// <summary>Block the app or process from listening to events from input devices such as mouse, keyboard, and trackpad.Requires macOS 10.15 or later.</summary>
        public bool? BlockListenEvent { get; set; }
        /// <summary>Block access to microphone.</summary>
        public bool? BlockMicrophone { get; set; }
        /// <summary>Block app from capturing contents of system display. Requires macOS 10.15 or later.</summary>
        public bool? BlockScreenCapture { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? Calendar { get; set; }
        /// <summary>Enter the code requirement, which can be obtained with the command &apos;codesign –display -r –&apos; in the Terminal app. Include everything after &apos;=&gt;&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CodeRequirement { get; set; }
#nullable restore
#else
        public string CodeRequirement { get; set; }
#endif
        /// <summary>The display name of the app, process, or executable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? FileProviderPresence { get; set; }
        /// <summary>The bundle ID or path of the app, process, or executable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier { get; set; }
#nullable restore
#else
        public string Identifier { get; set; }
#endif
        /// <summary>Process identifier types for MacOS Privacy Preferences</summary>
        public global::ApiSdk.Models.MacOSProcessIdentifierType? IdentifierType { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? MediaLibrary { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? Photos { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? PostEvent { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? Reminders { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SpeechRecognition { get; set; }
        /// <summary>Statically validates the code requirement. Use this setting if the process invalidates its dynamic code signature.</summary>
        public bool? StaticCodeValidation { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SystemPolicyAllFiles { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SystemPolicyDesktopFolder { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SystemPolicyDocumentsFolder { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SystemPolicyDownloadsFolder { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SystemPolicyNetworkVolumes { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SystemPolicyRemovableVolumes { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SystemPolicySystemAdminFiles { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.MacOSPrivacyAccessControlItem"/> and sets the default values.
        /// </summary>
        public MacOSPrivacyAccessControlItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.MacOSPrivacyAccessControlItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.MacOSPrivacyAccessControlItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.MacOSPrivacyAccessControlItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessibility", n => { Accessibility = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "addressBook", n => { AddressBook = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "appleEventsAllowedReceivers", n => { AppleEventsAllowedReceivers = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MacOSAppleEventReceiver>(global::ApiSdk.Models.MacOSAppleEventReceiver.CreateFromDiscriminatorValue)?.AsList(); } },
                { "blockCamera", n => { BlockCamera = n.GetBoolValue(); } },
                { "blockListenEvent", n => { BlockListenEvent = n.GetBoolValue(); } },
                { "blockMicrophone", n => { BlockMicrophone = n.GetBoolValue(); } },
                { "blockScreenCapture", n => { BlockScreenCapture = n.GetBoolValue(); } },
                { "calendar", n => { Calendar = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "codeRequirement", n => { CodeRequirement = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "fileProviderPresence", n => { FileProviderPresence = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "identifier", n => { Identifier = n.GetStringValue(); } },
                { "identifierType", n => { IdentifierType = n.GetEnumValue<global::ApiSdk.Models.MacOSProcessIdentifierType>(); } },
                { "mediaLibrary", n => { MediaLibrary = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "photos", n => { Photos = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "postEvent", n => { PostEvent = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "reminders", n => { Reminders = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "speechRecognition", n => { SpeechRecognition = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "staticCodeValidation", n => { StaticCodeValidation = n.GetBoolValue(); } },
                { "systemPolicyAllFiles", n => { SystemPolicyAllFiles = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "systemPolicyDesktopFolder", n => { SystemPolicyDesktopFolder = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "systemPolicyDocumentsFolder", n => { SystemPolicyDocumentsFolder = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "systemPolicyDownloadsFolder", n => { SystemPolicyDownloadsFolder = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "systemPolicyNetworkVolumes", n => { SystemPolicyNetworkVolumes = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "systemPolicyRemovableVolumes", n => { SystemPolicyRemovableVolumes = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "systemPolicySystemAdminFiles", n => { SystemPolicySystemAdminFiles = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("accessibility", Accessibility);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("addressBook", AddressBook);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MacOSAppleEventReceiver>("appleEventsAllowedReceivers", AppleEventsAllowedReceivers);
            writer.WriteBoolValue("blockCamera", BlockCamera);
            writer.WriteBoolValue("blockListenEvent", BlockListenEvent);
            writer.WriteBoolValue("blockMicrophone", BlockMicrophone);
            writer.WriteBoolValue("blockScreenCapture", BlockScreenCapture);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("calendar", Calendar);
            writer.WriteStringValue("codeRequirement", CodeRequirement);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("fileProviderPresence", FileProviderPresence);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteEnumValue<global::ApiSdk.Models.MacOSProcessIdentifierType>("identifierType", IdentifierType);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("mediaLibrary", MediaLibrary);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("photos", Photos);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("postEvent", PostEvent);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("reminders", Reminders);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("speechRecognition", SpeechRecognition);
            writer.WriteBoolValue("staticCodeValidation", StaticCodeValidation);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("systemPolicyAllFiles", SystemPolicyAllFiles);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("systemPolicyDesktopFolder", SystemPolicyDesktopFolder);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("systemPolicyDocumentsFolder", SystemPolicyDocumentsFolder);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("systemPolicyDownloadsFolder", SystemPolicyDownloadsFolder);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("systemPolicyNetworkVolumes", SystemPolicyNetworkVolumes);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("systemPolicyRemovableVolumes", SystemPolicyRemovableVolumes);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("systemPolicySystemAdminFiles", SystemPolicySystemAdminFiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
