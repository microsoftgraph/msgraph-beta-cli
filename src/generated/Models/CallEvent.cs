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
    public partial class CallEvent : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The callEventType property</summary>
        public global::ApiSdk.Models.CallEventType? CallEventType { get; set; }
        /// <summary>The eventDateTime property</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>The participants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Participant>? Participants { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Participant> Participants { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CallEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CallEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.emergencyCallEvent" => new global::ApiSdk.Models.EmergencyCallEvent(),
                _ => new global::ApiSdk.Models.CallEvent(),
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
                { "callEventType", n => { CallEventType = n.GetEnumValue<global::ApiSdk.Models.CallEventType>(); } },
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "participants", n => { Participants = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Participant>(global::ApiSdk.Models.Participant.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.CallEventType>("callEventType", CallEventType);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Participant>("participants", Participants);
        }
    }
}
#pragma warning restore CS0618
