// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Contains properties and inherited properties for the MacOSPkgApp.
    /// </summary>
    public class MacOSPkgApp : MobileLobApp, IParsable
    {
        /// <summary>When TRUE, indicates that the app&apos;s version will NOT be used to detect if the app is installed on a device. When FALSE, indicates that the app&apos;s version will be used to detect if the app is installed on a device. Set this to true for apps that use a self update feature. The default value is FALSE.</summary>
        public bool? IgnoreVersionDetection { get; set; }
        /// <summary>The list of apps expected to be installed by the PKG. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSIncludedApp>? IncludedApps { get; set; }
#nullable restore
#else
        public List<MacOSIncludedApp> IncludedApps { get; set; }
#endif
        /// <summary>ComplexType macOSMinimumOperatingSystem that indicates the minimum operating system applicable for the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MacOSMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
#nullable restore
#else
        public MacOSMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
#endif
        /// <summary>ComplexType macOSAppScript the contains the post-install script for the app. This will execute on the macOS device after the app is installed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MacOSAppScript? PostInstallScript { get; set; }
#nullable restore
#else
        public MacOSAppScript PostInstallScript { get; set; }
#endif
        /// <summary>ComplexType macOSAppScript the contains the post-install script for the app. This will execute on the macOS device after the app is installed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MacOSAppScript? PreInstallScript { get; set; }
#nullable restore
#else
        public MacOSAppScript PreInstallScript { get; set; }
#endif
        /// <summary>The bundleId of the primary app in the PKG. This maps to the CFBundleIdentifier in the app&apos;s bundle configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryBundleId { get; set; }
#nullable restore
#else
        public string PrimaryBundleId { get; set; }
#endif
        /// <summary>The version of the primary app in the PKG. This maps to the CFBundleShortVersion in the app&apos;s bundle configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryBundleVersion { get; set; }
#nullable restore
#else
        public string PrimaryBundleVersion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MacOSPkgApp"/> and sets the default values.
        /// </summary>
        public MacOSPkgApp() : base()
        {
            OdataType = "#microsoft.graph.macOSPkgApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MacOSPkgApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSPkgApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSPkgApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                { "includedApps", n => { IncludedApps = n.GetCollectionOfObjectValues<MacOSIncludedApp>(MacOSIncludedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                { "minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<MacOSMinimumOperatingSystem>(MacOSMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                { "postInstallScript", n => { PostInstallScript = n.GetObjectValue<MacOSAppScript>(MacOSAppScript.CreateFromDiscriminatorValue); } },
                { "preInstallScript", n => { PreInstallScript = n.GetObjectValue<MacOSAppScript>(MacOSAppScript.CreateFromDiscriminatorValue); } },
                { "primaryBundleId", n => { PrimaryBundleId = n.GetStringValue(); } },
                { "primaryBundleVersion", n => { PrimaryBundleVersion = n.GetStringValue(); } },
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
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteCollectionOfObjectValues<MacOSIncludedApp>("includedApps", IncludedApps);
            writer.WriteObjectValue<MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteObjectValue<MacOSAppScript>("postInstallScript", PostInstallScript);
            writer.WriteObjectValue<MacOSAppScript>("preInstallScript", PreInstallScript);
            writer.WriteStringValue("primaryBundleId", PrimaryBundleId);
            writer.WriteStringValue("primaryBundleVersion", PrimaryBundleVersion);
        }
    }
}
