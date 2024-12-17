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
    /// The base class for a type of apps
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsKioskAppBase : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of Windows kiosk app.</summary>
        public global::ApiSdk.Models.WindowsKioskAppType? AppType { get; set; }
        /// <summary>Allow the app to be auto-launched in multi-app kiosk mode</summary>
        public bool? AutoLaunch { get; set; }
        /// <summary>Represents the friendly name of an app</summary>
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
        /// <summary>The tile size of Windows app in the start layout.</summary>
        public global::ApiSdk.Models.WindowsAppStartLayoutTileSize? StartLayoutTileSize { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsKioskAppBase"/> and sets the default values.
        /// </summary>
        public WindowsKioskAppBase()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsKioskAppBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.WindowsKioskAppBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.windowsKioskDesktopApp" => new global::ApiSdk.Models.WindowsKioskDesktopApp(),
                "#microsoft.graph.windowsKioskUWPApp" => new global::ApiSdk.Models.WindowsKioskUWPApp(),
                "#microsoft.graph.windowsKioskWin32App" => new global::ApiSdk.Models.WindowsKioskWin32App(),
                _ => new global::ApiSdk.Models.WindowsKioskAppBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appType", n => { AppType = n.GetEnumValue<global::ApiSdk.Models.WindowsKioskAppType>(); } },
                { "autoLaunch", n => { AutoLaunch = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "startLayoutTileSize", n => { StartLayoutTileSize = n.GetEnumValue<global::ApiSdk.Models.WindowsAppStartLayoutTileSize>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsKioskAppType>("appType", AppType);
            writer.WriteBoolValue("autoLaunch", AutoLaunch);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::ApiSdk.Models.WindowsAppStartLayoutTileSize>("startLayoutTileSize", StartLayoutTileSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
