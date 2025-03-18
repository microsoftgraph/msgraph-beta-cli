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
    /// Contains properties and inherited properties for Windows Phone 8.1 AppX Bundle Line Of Business apps. Inherits from graph.windowsPhone81AppX (which is also to be deprecated at the same time). Will be deprecated in February 2023.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsPhone81AppXBundle : global::ApiSdk.Models.WindowsPhone81AppX, IParsable
    {
        /// <summary>The list of AppX Package Information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsPackageInformation>? AppXPackageInformationList { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsPackageInformation> AppXPackageInformationList { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsPhone81AppXBundle"/> and sets the default values.
        /// </summary>
        public WindowsPhone81AppXBundle() : base()
        {
            OdataType = "#microsoft.graph.windowsPhone81AppXBundle";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsPhone81AppXBundle"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsPhone81AppXBundle CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsPhone81AppXBundle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appXPackageInformationList", n => { AppXPackageInformationList = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsPackageInformation>(global::ApiSdk.Models.WindowsPackageInformation.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsPackageInformation>("appXPackageInformationList", AppXPackageInformationList);
        }
    }
}
#pragma warning restore CS0618
