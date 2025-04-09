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
    /// This entity provides descriptions of the declared methods, properties and relationships exposed by the kiosk resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsKioskConfiguration : global::ApiSdk.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Enable public browsing kiosk mode for the Microsoft Edge browser. The Default is false.</summary>
        public bool? EdgeKioskEnablePublicBrowsing { get; set; }
        /// <summary>Specify URLs that the kiosk browser is allowed to navigate to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? KioskBrowserBlockedUrlExceptions { get; set; }
#nullable restore
#else
        public List<string> KioskBrowserBlockedUrlExceptions { get; set; }
#endif
        /// <summary>Specify URLs that the kiosk browsers should not navigate to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? KioskBrowserBlockedURLs { get; set; }
#nullable restore
#else
        public List<string> KioskBrowserBlockedURLs { get; set; }
#endif
        /// <summary>Specify the default URL the browser should navigate to on launch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskBrowserDefaultUrl { get; set; }
#nullable restore
#else
        public string KioskBrowserDefaultUrl { get; set; }
#endif
        /// <summary>Enable the kiosk browser&apos;s end session button. By default, the end session button is disabled.</summary>
        public bool? KioskBrowserEnableEndSessionButton { get; set; }
        /// <summary>Enable the kiosk browser&apos;s home button. By default, the home button is disabled.</summary>
        public bool? KioskBrowserEnableHomeButton { get; set; }
        /// <summary>Enable the kiosk browser&apos;s navigation buttons(forward/back). By default, the navigation buttons are disabled.</summary>
        public bool? KioskBrowserEnableNavigationButtons { get; set; }
        /// <summary>Specify the number of minutes the session is idle until the kiosk browser restarts in a fresh state.  Valid values are 1-1440. Valid values 1 to 1440</summary>
        public int? KioskBrowserRestartOnIdleTimeInMinutes { get; set; }
        /// <summary>This policy setting allows to define a list of Kiosk profiles for a Kiosk configuration. This collection can contain a maximum of 3 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsKioskProfile>? KioskProfiles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsKioskProfile> KioskProfiles { get; set; }
#endif
        /// <summary>force update schedule for Kiosk devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WindowsKioskForceUpdateSchedule? WindowsKioskForceUpdateSchedule { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WindowsKioskForceUpdateSchedule WindowsKioskForceUpdateSchedule { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsKioskConfiguration"/> and sets the default values.
        /// </summary>
        public WindowsKioskConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windowsKioskConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsKioskConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsKioskConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsKioskConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "edgeKioskEnablePublicBrowsing", n => { EdgeKioskEnablePublicBrowsing = n.GetBoolValue(); } },
                { "kioskBrowserBlockedURLs", n => { KioskBrowserBlockedURLs = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "kioskBrowserBlockedUrlExceptions", n => { KioskBrowserBlockedUrlExceptions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "kioskBrowserDefaultUrl", n => { KioskBrowserDefaultUrl = n.GetStringValue(); } },
                { "kioskBrowserEnableEndSessionButton", n => { KioskBrowserEnableEndSessionButton = n.GetBoolValue(); } },
                { "kioskBrowserEnableHomeButton", n => { KioskBrowserEnableHomeButton = n.GetBoolValue(); } },
                { "kioskBrowserEnableNavigationButtons", n => { KioskBrowserEnableNavigationButtons = n.GetBoolValue(); } },
                { "kioskBrowserRestartOnIdleTimeInMinutes", n => { KioskBrowserRestartOnIdleTimeInMinutes = n.GetIntValue(); } },
                { "kioskProfiles", n => { KioskProfiles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsKioskProfile>(global::ApiSdk.Models.WindowsKioskProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "windowsKioskForceUpdateSchedule", n => { WindowsKioskForceUpdateSchedule = n.GetObjectValue<global::ApiSdk.Models.WindowsKioskForceUpdateSchedule>(global::ApiSdk.Models.WindowsKioskForceUpdateSchedule.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("edgeKioskEnablePublicBrowsing", EdgeKioskEnablePublicBrowsing);
            writer.WriteCollectionOfPrimitiveValues<string>("kioskBrowserBlockedUrlExceptions", KioskBrowserBlockedUrlExceptions);
            writer.WriteCollectionOfPrimitiveValues<string>("kioskBrowserBlockedURLs", KioskBrowserBlockedURLs);
            writer.WriteStringValue("kioskBrowserDefaultUrl", KioskBrowserDefaultUrl);
            writer.WriteBoolValue("kioskBrowserEnableEndSessionButton", KioskBrowserEnableEndSessionButton);
            writer.WriteBoolValue("kioskBrowserEnableHomeButton", KioskBrowserEnableHomeButton);
            writer.WriteBoolValue("kioskBrowserEnableNavigationButtons", KioskBrowserEnableNavigationButtons);
            writer.WriteIntValue("kioskBrowserRestartOnIdleTimeInMinutes", KioskBrowserRestartOnIdleTimeInMinutes);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsKioskProfile>("kioskProfiles", KioskProfiles);
            writer.WriteObjectValue<global::ApiSdk.Models.WindowsKioskForceUpdateSchedule>("windowsKioskForceUpdateSchedule", WindowsKioskForceUpdateSchedule);
        }
    }
}
#pragma warning restore CS0618
