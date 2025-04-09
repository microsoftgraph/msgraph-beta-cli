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
    public partial class AddContentFooterAction : global::ApiSdk.Models.InformationProtectionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alignment property</summary>
        public global::ApiSdk.Models.ContentAlignment? Alignment { get; set; }
        /// <summary>Color of the font to use for the footer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FontColor { get; set; }
#nullable restore
#else
        public string FontColor { get; set; }
#endif
        /// <summary>Name of the font to use for the footer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FontName { get; set; }
#nullable restore
#else
        public string FontName { get; set; }
#endif
        /// <summary>Font size to use for the footer.</summary>
        public int? FontSize { get; set; }
        /// <summary>The margin of the header from the bottom of the document.</summary>
        public int? Margin { get; set; }
        /// <summary>The contents of the footer itself.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The name of the UI element where the footer should be placed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UiElementName { get; set; }
#nullable restore
#else
        public string UiElementName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AddContentFooterAction"/> and sets the default values.
        /// </summary>
        public AddContentFooterAction() : base()
        {
            OdataType = "#microsoft.graph.addContentFooterAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AddContentFooterAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AddContentFooterAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AddContentFooterAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alignment", n => { Alignment = n.GetEnumValue<global::ApiSdk.Models.ContentAlignment>(); } },
                { "fontColor", n => { FontColor = n.GetStringValue(); } },
                { "fontName", n => { FontName = n.GetStringValue(); } },
                { "fontSize", n => { FontSize = n.GetIntValue(); } },
                { "margin", n => { Margin = n.GetIntValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "uiElementName", n => { UiElementName = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.ContentAlignment>("alignment", Alignment);
            writer.WriteStringValue("fontColor", FontColor);
            writer.WriteStringValue("fontName", FontName);
            writer.WriteIntValue("fontSize", FontSize);
            writer.WriteIntValue("margin", Margin);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("uiElementName", UiElementName);
        }
    }
}
#pragma warning restore CS0618
