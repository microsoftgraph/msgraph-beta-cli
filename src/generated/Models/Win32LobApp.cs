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
    /// Contains properties and inherited properties for Win32 apps.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Win32LobApp : global::ApiSdk.Models.MobileLobApp, IParsable
    {
        /// <summary>When TRUE, indicates that uninstall is supported from the company portal for the Windows app (Win32) with an Available assignment. When FALSE, indicates that uninstall is not supported for the Windows app (Win32) with an Available assignment. Default value is FALSE.</summary>
        public bool? AllowAvailableUninstall { get; set; }
        /// <summary>Contains properties for Windows architecture.</summary>
        public global::ApiSdk.Models.WindowsArchitecture? ApplicableArchitectures { get; set; }
        /// <summary>The detection rules to detect Win32 Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Win32LobAppDetection>? DetectionRules { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Win32LobAppDetection> DetectionRules { get; set; }
#endif
        /// <summary>The version displayed in the UX for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayVersion { get; set; }
#nullable restore
#else
        public string DisplayVersion { get; set; }
#endif
        /// <summary>The command line to install this app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstallCommandLine { get; set; }
#nullable restore
#else
        public string InstallCommandLine { get; set; }
#endif
        /// <summary>The install experience for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Win32LobAppInstallExperience? InstallExperience { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Win32LobAppInstallExperience InstallExperience { get; set; }
#endif
        /// <summary>The value for the minimum CPU speed which is required to install this app.</summary>
        public int? MinimumCpuSpeedInMHz { get; set; }
        /// <summary>The value for the minimum free disk space which is required to install this app.</summary>
        public int? MinimumFreeDiskSpaceInMB { get; set; }
        /// <summary>The value for the minimum physical memory which is required to install this app.</summary>
        public int? MinimumMemoryInMB { get; set; }
        /// <summary>The value for the minimum number of processors which is required to install this app.</summary>
        public int? MinimumNumberOfProcessors { get; set; }
        /// <summary>The value for the minimum applicable operating system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WindowsMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
#endif
        /// <summary>The value for the minimum supported windows release.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumSupportedWindowsRelease { get; set; }
#nullable restore
#else
        public string MinimumSupportedWindowsRelease { get; set; }
#endif
        /// <summary>The MSI details if this Win32 app is an MSI app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Win32LobAppMsiInformation? MsiInformation { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Win32LobAppMsiInformation MsiInformation { get; set; }
#endif
        /// <summary>The requirement rules to detect Win32 Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Win32LobAppRequirement>? RequirementRules { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Win32LobAppRequirement> RequirementRules { get; set; }
#endif
        /// <summary>The return codes for post installation behavior.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Win32LobAppReturnCode>? ReturnCodes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Win32LobAppReturnCode> ReturnCodes { get; set; }
#endif
        /// <summary>The detection and requirement rules for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Win32LobAppRule>? Rules { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Win32LobAppRule> Rules { get; set; }
#endif
        /// <summary>The relative path of the setup file in the encrypted Win32LobApp package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SetupFilePath { get; set; }
#nullable restore
#else
        public string SetupFilePath { get; set; }
#endif
        /// <summary>The command line to uninstall this app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UninstallCommandLine { get; set; }
#nullable restore
#else
        public string UninstallCommandLine { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Win32LobApp"/> and sets the default values.
        /// </summary>
        public Win32LobApp() : base()
        {
            OdataType = "#microsoft.graph.win32LobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Win32LobApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Win32LobApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.win32CatalogApp" => new global::ApiSdk.Models.Win32CatalogApp(),
                _ => new global::ApiSdk.Models.Win32LobApp(),
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
                { "allowAvailableUninstall", n => { AllowAvailableUninstall = n.GetBoolValue(); } },
                { "applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<global::ApiSdk.Models.WindowsArchitecture>(); } },
                { "detectionRules", n => { DetectionRules = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppDetection>(global::ApiSdk.Models.Win32LobAppDetection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayVersion", n => { DisplayVersion = n.GetStringValue(); } },
                { "installCommandLine", n => { InstallCommandLine = n.GetStringValue(); } },
                { "installExperience", n => { InstallExperience = n.GetObjectValue<global::ApiSdk.Models.Win32LobAppInstallExperience>(global::ApiSdk.Models.Win32LobAppInstallExperience.CreateFromDiscriminatorValue); } },
                { "minimumCpuSpeedInMHz", n => { MinimumCpuSpeedInMHz = n.GetIntValue(); } },
                { "minimumFreeDiskSpaceInMB", n => { MinimumFreeDiskSpaceInMB = n.GetIntValue(); } },
                { "minimumMemoryInMB", n => { MinimumMemoryInMB = n.GetIntValue(); } },
                { "minimumNumberOfProcessors", n => { MinimumNumberOfProcessors = n.GetIntValue(); } },
                { "minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<global::ApiSdk.Models.WindowsMinimumOperatingSystem>(global::ApiSdk.Models.WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                { "minimumSupportedWindowsRelease", n => { MinimumSupportedWindowsRelease = n.GetStringValue(); } },
                { "msiInformation", n => { MsiInformation = n.GetObjectValue<global::ApiSdk.Models.Win32LobAppMsiInformation>(global::ApiSdk.Models.Win32LobAppMsiInformation.CreateFromDiscriminatorValue); } },
                { "requirementRules", n => { RequirementRules = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppRequirement>(global::ApiSdk.Models.Win32LobAppRequirement.CreateFromDiscriminatorValue)?.AsList(); } },
                { "returnCodes", n => { ReturnCodes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppReturnCode>(global::ApiSdk.Models.Win32LobAppReturnCode.CreateFromDiscriminatorValue)?.AsList(); } },
                { "rules", n => { Rules = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppRule>(global::ApiSdk.Models.Win32LobAppRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "setupFilePath", n => { SetupFilePath = n.GetStringValue(); } },
                { "uninstallCommandLine", n => { UninstallCommandLine = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowAvailableUninstall", AllowAvailableUninstall);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsArchitecture>("applicableArchitectures", ApplicableArchitectures);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppDetection>("detectionRules", DetectionRules);
            writer.WriteStringValue("displayVersion", DisplayVersion);
            writer.WriteStringValue("installCommandLine", InstallCommandLine);
            writer.WriteObjectValue<global::ApiSdk.Models.Win32LobAppInstallExperience>("installExperience", InstallExperience);
            writer.WriteIntValue("minimumCpuSpeedInMHz", MinimumCpuSpeedInMHz);
            writer.WriteIntValue("minimumFreeDiskSpaceInMB", MinimumFreeDiskSpaceInMB);
            writer.WriteIntValue("minimumMemoryInMB", MinimumMemoryInMB);
            writer.WriteIntValue("minimumNumberOfProcessors", MinimumNumberOfProcessors);
            writer.WriteObjectValue<global::ApiSdk.Models.WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("minimumSupportedWindowsRelease", MinimumSupportedWindowsRelease);
            writer.WriteObjectValue<global::ApiSdk.Models.Win32LobAppMsiInformation>("msiInformation", MsiInformation);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppRequirement>("requirementRules", RequirementRules);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppReturnCode>("returnCodes", ReturnCodes);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Win32LobAppRule>("rules", Rules);
            writer.WriteStringValue("setupFilePath", SetupFilePath);
            writer.WriteStringValue("uninstallCommandLine", UninstallCommandLine);
        }
    }
}
#pragma warning restore CS0618
