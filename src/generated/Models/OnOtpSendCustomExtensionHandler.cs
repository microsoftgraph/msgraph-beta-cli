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
    public partial class OnOtpSendCustomExtensionHandler : global::ApiSdk.Models.OnOtpSendHandler, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Configuration regarding properties of the custom extension that are can be overwritten for the onEmailOtpSendListener event listener.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomExtensionOverwriteConfiguration? Configuration { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomExtensionOverwriteConfiguration Configuration { get; set; }
#endif
        /// <summary>The customExtension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OnOtpSendCustomExtension? CustomExtension { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OnOtpSendCustomExtension CustomExtension { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.OnOtpSendCustomExtensionHandler"/> and sets the default values.
        /// </summary>
        public OnOtpSendCustomExtensionHandler() : base()
        {
            OdataType = "#microsoft.graph.onOtpSendCustomExtensionHandler";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.OnOtpSendCustomExtensionHandler"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.OnOtpSendCustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.OnOtpSendCustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<global::ApiSdk.Models.CustomExtensionOverwriteConfiguration>(global::ApiSdk.Models.CustomExtensionOverwriteConfiguration.CreateFromDiscriminatorValue); } },
                { "customExtension", n => { CustomExtension = n.GetObjectValue<global::ApiSdk.Models.OnOtpSendCustomExtension>(global::ApiSdk.Models.OnOtpSendCustomExtension.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.CustomExtensionOverwriteConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<global::ApiSdk.Models.OnOtpSendCustomExtension>("customExtension", CustomExtension);
        }
    }
}
#pragma warning restore CS0618