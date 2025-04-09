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
    /// Contains properties and inherited properties for Windows Phone 8.1 AppX Line Of Business apps. Inherits from graph.mobileLobApp. Will be deprecated in February 2023.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsPhone81AppX : global::ApiSdk.Models.MobileLobApp, IParsable
    {
        /// <summary>Contains properties for Windows architecture.</summary>
        public global::ApiSdk.Models.WindowsArchitecture? ApplicableArchitectures { get; set; }
        /// <summary>The Identity Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityName { get; set; }
#nullable restore
#else
        public string IdentityName { get; set; }
#endif
        /// <summary>The Identity Publisher Hash.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityPublisherHash { get; set; }
#nullable restore
#else
        public string IdentityPublisherHash { get; set; }
#endif
        /// <summary>The Identity Resource Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityResourceIdentifier { get; set; }
#nullable restore
#else
        public string IdentityResourceIdentifier { get; set; }
#endif
        /// <summary>The identity version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityVersion { get; set; }
#nullable restore
#else
        public string IdentityVersion { get; set; }
#endif
        /// <summary>The minimum operating system required for a Windows mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WindowsMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
#endif
        /// <summary>The Phone Product Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneProductIdentifier { get; set; }
#nullable restore
#else
        public string PhoneProductIdentifier { get; set; }
#endif
        /// <summary>The Phone Publisher Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhonePublisherId { get; set; }
#nullable restore
#else
        public string PhonePublisherId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsPhone81AppX"/> and sets the default values.
        /// </summary>
        public WindowsPhone81AppX() : base()
        {
            OdataType = "#microsoft.graph.windowsPhone81AppX";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsPhone81AppX"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsPhone81AppX CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.windowsPhone81AppXBundle" => new global::ApiSdk.Models.WindowsPhone81AppXBundle(),
                _ => new global::ApiSdk.Models.WindowsPhone81AppX(),
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
                { "applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<global::ApiSdk.Models.WindowsArchitecture>(); } },
                { "identityName", n => { IdentityName = n.GetStringValue(); } },
                { "identityPublisherHash", n => { IdentityPublisherHash = n.GetStringValue(); } },
                { "identityResourceIdentifier", n => { IdentityResourceIdentifier = n.GetStringValue(); } },
                { "identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                { "minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<global::ApiSdk.Models.WindowsMinimumOperatingSystem>(global::ApiSdk.Models.WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                { "phoneProductIdentifier", n => { PhoneProductIdentifier = n.GetStringValue(); } },
                { "phonePublisherId", n => { PhonePublisherId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsArchitecture>("applicableArchitectures", ApplicableArchitectures);
            writer.WriteStringValue("identityName", IdentityName);
            writer.WriteStringValue("identityPublisherHash", IdentityPublisherHash);
            writer.WriteStringValue("identityResourceIdentifier", IdentityResourceIdentifier);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteObjectValue<global::ApiSdk.Models.WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("phoneProductIdentifier", PhoneProductIdentifier);
            writer.WriteStringValue("phonePublisherId", PhonePublisherId);
        }
    }
}
#pragma warning restore CS0618
