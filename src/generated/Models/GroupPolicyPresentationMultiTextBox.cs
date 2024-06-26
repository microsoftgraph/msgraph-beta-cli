// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Represents an ADMX multiTextBox element and an ADMX multiText element.
    /// </summary>
    public class GroupPolicyPresentationMultiTextBox : GroupPolicyUploadedPresentation, IParsable
    {
        /// <summary>An unsigned integer that specifies the maximum number of text characters. Default value is 1023.</summary>
        public long? MaxLength { get; set; }
        /// <summary>An unsigned integer that specifies the maximum number of strings. Default value is 0.</summary>
        public long? MaxStrings { get; set; }
        /// <summary>Requirement to enter a value in the text box. Default value is false.</summary>
        public bool? Required { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="GroupPolicyPresentationMultiTextBox"/> and sets the default values.
        /// </summary>
        public GroupPolicyPresentationMultiTextBox() : base()
        {
            OdataType = "#microsoft.graph.groupPolicyPresentationMultiTextBox";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GroupPolicyPresentationMultiTextBox"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyPresentationMultiTextBox CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationMultiTextBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "maxLength", n => { MaxLength = n.GetLongValue(); } },
                { "maxStrings", n => { MaxStrings = n.GetLongValue(); } },
                { "required", n => { Required = n.GetBoolValue(); } },
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
            writer.WriteLongValue("maxLength", MaxLength);
            writer.WriteLongValue("maxStrings", MaxStrings);
            writer.WriteBoolValue("required", Required);
        }
    }
}
