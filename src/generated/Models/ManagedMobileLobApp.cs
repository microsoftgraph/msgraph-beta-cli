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
    /// An abstract base class containing properties for all managed mobile line of business apps.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedMobileLobApp : global::ApiSdk.Models.ManagedApp, IParsable
    {
        /// <summary>The internal committed content version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommittedContentVersion { get; set; }
#nullable restore
#else
        public string CommittedContentVersion { get; set; }
#endif
        /// <summary>The list of content versions for this app. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MobileAppContent>? ContentVersions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MobileAppContent> ContentVersions { get; set; }
#endif
        /// <summary>The name of the main Lob application file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The total size, including all uploaded files. This property is read-only.</summary>
        public long? Size { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ManagedMobileLobApp"/> and sets the default values.
        /// </summary>
        public ManagedMobileLobApp() : base()
        {
            OdataType = "#microsoft.graph.managedMobileLobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedMobileLobApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ManagedMobileLobApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.managedAndroidLobApp" => new global::ApiSdk.Models.ManagedAndroidLobApp(),
                "#microsoft.graph.managedIOSLobApp" => new global::ApiSdk.Models.ManagedIOSLobApp(),
                _ => new global::ApiSdk.Models.ManagedMobileLobApp(),
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
                { "committedContentVersion", n => { CommittedContentVersion = n.GetStringValue(); } },
                { "contentVersions", n => { ContentVersions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MobileAppContent>(global::ApiSdk.Models.MobileAppContent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "size", n => { Size = n.GetLongValue(); } },
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
            writer.WriteStringValue("committedContentVersion", CommittedContentVersion);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MobileAppContent>("contentVersions", ContentVersions);
            writer.WriteStringValue("fileName", FileName);
        }
    }
}
#pragma warning restore CS0618
