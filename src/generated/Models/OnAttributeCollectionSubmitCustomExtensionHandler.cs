// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class OnAttributeCollectionSubmitCustomExtensionHandler : OnAttributeCollectionSubmitHandler, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Configuration regarding properties of the custom extension that can be overwritten per event listener.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomExtensionOverwriteConfiguration? Configuration { get; set; }
#nullable restore
#else
        public CustomExtensionOverwriteConfiguration Configuration { get; set; }
#endif
        /// <summary>The customExtension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnAttributeCollectionSubmitCustomExtension? CustomExtension { get; set; }
#nullable restore
#else
        public OnAttributeCollectionSubmitCustomExtension CustomExtension { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="OnAttributeCollectionSubmitCustomExtensionHandler"/> and sets the default values.
        /// </summary>
        public OnAttributeCollectionSubmitCustomExtensionHandler() : base()
        {
            OdataType = "#microsoft.graph.onAttributeCollectionSubmitCustomExtensionHandler";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OnAttributeCollectionSubmitCustomExtensionHandler"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnAttributeCollectionSubmitCustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnAttributeCollectionSubmitCustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<CustomExtensionOverwriteConfiguration>(CustomExtensionOverwriteConfiguration.CreateFromDiscriminatorValue); } },
                { "customExtension", n => { CustomExtension = n.GetObjectValue<OnAttributeCollectionSubmitCustomExtension>(OnAttributeCollectionSubmitCustomExtension.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<CustomExtensionOverwriteConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<OnAttributeCollectionSubmitCustomExtension>("customExtension", CustomExtension);
        }
    }
}
