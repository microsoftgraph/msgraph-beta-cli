// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// MacOS extensions configuration profile.
    /// </summary>
    public class MacOSExtensionsConfiguration : DeviceConfiguration, IParsable 
    {
        /// <summary>All kernel extensions validly signed by the team identifiers in this list will be allowed to load.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? KernelExtensionAllowedTeamIdentifiers { get; set; }
#nullable restore
#else
        public List<string> KernelExtensionAllowedTeamIdentifiers { get; set; }
#endif
        /// <summary>If set to true, users can approve additional kernel extensions not explicitly allowed by configurations profiles.</summary>
        public bool? KernelExtensionOverridesAllowed { get; set; }
        /// <summary>A list of kernel extensions that will be allowed to load. . This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSKernelExtension>? KernelExtensionsAllowed { get; set; }
#nullable restore
#else
        public List<MacOSKernelExtension> KernelExtensionsAllowed { get; set; }
#endif
        /// <summary>Gets or sets a list of allowed macOS system extensions. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSSystemExtension>? SystemExtensionsAllowed { get; set; }
#nullable restore
#else
        public List<MacOSSystemExtension> SystemExtensionsAllowed { get; set; }
#endif
        /// <summary>Gets or sets a list of allowed team identifiers. Any system extension signed with any of the specified team identifiers will be approved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemExtensionsAllowedTeamIdentifiers { get; set; }
#nullable restore
#else
        public List<string> SystemExtensionsAllowedTeamIdentifiers { get; set; }
#endif
        /// <summary>Gets or sets a list of allowed macOS system extension types. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSSystemExtensionTypeMapping>? SystemExtensionsAllowedTypes { get; set; }
#nullable restore
#else
        public List<MacOSSystemExtensionTypeMapping> SystemExtensionsAllowedTypes { get; set; }
#endif
        /// <summary>Gets or sets whether to allow the user to approve additional system extensions not explicitly allowed by configuration profiles.</summary>
        public bool? SystemExtensionsBlockOverride { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="MacOSExtensionsConfiguration"/> and sets the default values.
        /// </summary>
        public MacOSExtensionsConfiguration() : base()
        {
            OdataType = "#microsoft.graph.macOSExtensionsConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MacOSExtensionsConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSExtensionsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSExtensionsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"kernelExtensionAllowedTeamIdentifiers", n => { KernelExtensionAllowedTeamIdentifiers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"kernelExtensionOverridesAllowed", n => { KernelExtensionOverridesAllowed = n.GetBoolValue(); } },
                {"kernelExtensionsAllowed", n => { KernelExtensionsAllowed = n.GetCollectionOfObjectValues<MacOSKernelExtension>(MacOSKernelExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemExtensionsAllowed", n => { SystemExtensionsAllowed = n.GetCollectionOfObjectValues<MacOSSystemExtension>(MacOSSystemExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemExtensionsAllowedTeamIdentifiers", n => { SystemExtensionsAllowedTeamIdentifiers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"systemExtensionsAllowedTypes", n => { SystemExtensionsAllowedTypes = n.GetCollectionOfObjectValues<MacOSSystemExtensionTypeMapping>(MacOSSystemExtensionTypeMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemExtensionsBlockOverride", n => { SystemExtensionsBlockOverride = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("kernelExtensionAllowedTeamIdentifiers", KernelExtensionAllowedTeamIdentifiers);
            writer.WriteBoolValue("kernelExtensionOverridesAllowed", KernelExtensionOverridesAllowed);
            writer.WriteCollectionOfObjectValues<MacOSKernelExtension>("kernelExtensionsAllowed", KernelExtensionsAllowed);
            writer.WriteCollectionOfObjectValues<MacOSSystemExtension>("systemExtensionsAllowed", SystemExtensionsAllowed);
            writer.WriteCollectionOfPrimitiveValues<string>("systemExtensionsAllowedTeamIdentifiers", SystemExtensionsAllowedTeamIdentifiers);
            writer.WriteCollectionOfObjectValues<MacOSSystemExtensionTypeMapping>("systemExtensionsAllowedTypes", SystemExtensionsAllowedTypes);
            writer.WriteBoolValue("systemExtensionsBlockOverride", SystemExtensionsBlockOverride);
        }
    }
}