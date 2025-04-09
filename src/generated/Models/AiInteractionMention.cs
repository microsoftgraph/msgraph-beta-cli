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
    public partial class AiInteractionMention : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The entity mentioned in the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AiInteractionMentionedIdentitySet? Mentioned { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AiInteractionMentionedIdentitySet Mentioned { get; set; }
#endif
        /// <summary>The identifier for the mention.</summary>
        public int? MentionId { get; set; }
        /// <summary>The text mentioned in the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MentionText { get; set; }
#nullable restore
#else
        public string MentionText { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AiInteractionMention"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AiInteractionMention CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AiInteractionMention();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "mentionId", n => { MentionId = n.GetIntValue(); } },
                { "mentionText", n => { MentionText = n.GetStringValue(); } },
                { "mentioned", n => { Mentioned = n.GetObjectValue<global::ApiSdk.Models.AiInteractionMentionedIdentitySet>(global::ApiSdk.Models.AiInteractionMentionedIdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.AiInteractionMentionedIdentitySet>("mentioned", Mentioned);
            writer.WriteIntValue("mentionId", MentionId);
            writer.WriteStringValue("mentionText", MentionText);
        }
    }
}
#pragma warning restore CS0618
