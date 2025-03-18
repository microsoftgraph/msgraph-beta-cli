// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeCards.Item.StartBreak
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class StartBreakPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The atApprovedLocation property</summary>
        public bool? AtApprovedLocation { get; set; }
        /// <summary>The isAtApprovedLocation property</summary>
        public bool? IsAtApprovedLocation { get; set; }
        /// <summary>The notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemBody? Notes { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemBody Notes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeCards.Item.StartBreak.StartBreakPostRequestBody"/> and sets the default values.
        /// </summary>
        public StartBreakPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeCards.Item.StartBreak.StartBreakPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeCards.Item.StartBreak.StartBreakPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeCards.Item.StartBreak.StartBreakPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "atApprovedLocation", n => { AtApprovedLocation = n.GetBoolValue(); } },
                { "isAtApprovedLocation", n => { IsAtApprovedLocation = n.GetBoolValue(); } },
                { "notes", n => { Notes = n.GetObjectValue<global::ApiSdk.Models.ItemBody>(global::ApiSdk.Models.ItemBody.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("atApprovedLocation", AtApprovedLocation);
            writer.WriteBoolValue("isAtApprovedLocation", IsAtApprovedLocation);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemBody>("notes", Notes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
