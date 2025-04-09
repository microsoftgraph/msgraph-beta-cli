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
    public partial class CallEndedEventMessageDetail : global::ApiSdk.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Duration of the call.</summary>
        public TimeSpan? CallDuration { get; set; }
        /// <summary>Represents the call event type. Possible values are: call, meeting, screenShare, unknownFutureValue.</summary>
        public global::ApiSdk.Models.TeamworkCallEventType? CallEventType { get; set; }
        /// <summary>Unique identifier of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId { get; set; }
#nullable restore
#else
        public string CallId { get; set; }
#endif
        /// <summary>List of call participants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CallParticipantInfo>? CallParticipants { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CallParticipantInfo> CallParticipants { get; set; }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? Initiator { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet Initiator { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CallEndedEventMessageDetail"/> and sets the default values.
        /// </summary>
        public CallEndedEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.callEndedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CallEndedEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CallEndedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CallEndedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callDuration", n => { CallDuration = n.GetTimeSpanValue(); } },
                { "callEventType", n => { CallEventType = n.GetEnumValue<global::ApiSdk.Models.TeamworkCallEventType>(); } },
                { "callId", n => { CallId = n.GetStringValue(); } },
                { "callParticipants", n => { CallParticipants = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CallParticipantInfo>(global::ApiSdk.Models.CallParticipantInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "initiator", n => { Initiator = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteTimeSpanValue("callDuration", CallDuration);
            writer.WriteEnumValue<global::ApiSdk.Models.TeamworkCallEventType>("callEventType", CallEventType);
            writer.WriteStringValue("callId", CallId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CallParticipantInfo>("callParticipants", CallParticipants);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("initiator", Initiator);
        }
    }
}
#pragma warning restore CS0618
