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
    public partial class AddHeader : global::ApiSdk.Models.MarkContent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alignment property</summary>
        public global::ApiSdk.Models.Alignment? Alignment { get; set; }
        /// <summary>The margin property</summary>
        public int? Margin { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AddHeader"/> and sets the default values.
        /// </summary>
        public AddHeader() : base()
        {
            OdataType = "#microsoft.graph.addHeader";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AddHeader"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AddHeader CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AddHeader();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alignment", n => { Alignment = n.GetEnumValue<global::ApiSdk.Models.Alignment>(); } },
                { "margin", n => { Margin = n.GetIntValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.Alignment>("alignment", Alignment);
            writer.WriteIntValue("margin", Margin);
        }
    }
}
#pragma warning restore CS0618
