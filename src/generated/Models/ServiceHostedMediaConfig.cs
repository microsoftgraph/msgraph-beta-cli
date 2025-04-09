// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ServiceHostedMediaConfig : global::ApiSdk.Models.MediaConfig, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The liveCaptionOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LiveCaptionOptions? LiveCaptionOptions { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LiveCaptionOptions LiveCaptionOptions { get; set; }
#endif
        /// <summary>The list of media to prefetch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MediaInfo>? PreFetchMedia { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MediaInfo> PreFetchMedia { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ServiceHostedMediaConfig"/> and sets the default values.
        /// </summary>
        public ServiceHostedMediaConfig() : base()
        {
            OdataType = "#microsoft.graph.serviceHostedMediaConfig";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ServiceHostedMediaConfig"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ServiceHostedMediaConfig CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ServiceHostedMediaConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "liveCaptionOptions", n => { LiveCaptionOptions = n.GetObjectValue<global::ApiSdk.Models.LiveCaptionOptions>(global::ApiSdk.Models.LiveCaptionOptions.CreateFromDiscriminatorValue); } },
                { "preFetchMedia", n => { PreFetchMedia = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MediaInfo>(global::ApiSdk.Models.MediaInfo.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.LiveCaptionOptions>("liveCaptionOptions", LiveCaptionOptions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MediaInfo>("preFetchMedia", PreFetchMedia);
        }
    }
}
#pragma warning restore CS0618
