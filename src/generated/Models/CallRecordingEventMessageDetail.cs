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
    public partial class CallRecordingEventMessageDetail : global::ApiSdk.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unique identifier of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId { get; set; }
#nullable restore
#else
        public string CallId { get; set; }
#endif
        /// <summary>Display name for the call recording.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallRecordingDisplayName { get; set; }
#nullable restore
#else
        public string CallRecordingDisplayName { get; set; }
#endif
        /// <summary>Duration of the call recording.</summary>
        public TimeSpan? CallRecordingDuration { get; set; }
        /// <summary>Status of the call recording. Possible values are: success, failure, initial, chunkFinished, unknownFutureValue.</summary>
        public global::ApiSdk.Models.CallRecordingStatus? CallRecordingStatus { get; set; }
        /// <summary>Call recording URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallRecordingUrl { get; set; }
#nullable restore
#else
        public string CallRecordingUrl { get; set; }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? Initiator { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet Initiator { get; set; }
#endif
        /// <summary>Organizer of the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? MeetingOrganizer { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet MeetingOrganizer { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CallRecordingEventMessageDetail"/> and sets the default values.
        /// </summary>
        public CallRecordingEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.callRecordingEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CallRecordingEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CallRecordingEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CallRecordingEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callId", n => { CallId = n.GetStringValue(); } },
                { "callRecordingDisplayName", n => { CallRecordingDisplayName = n.GetStringValue(); } },
                { "callRecordingDuration", n => { CallRecordingDuration = n.GetTimeSpanValue(); } },
                { "callRecordingStatus", n => { CallRecordingStatus = n.GetEnumValue<global::ApiSdk.Models.CallRecordingStatus>(); } },
                { "callRecordingUrl", n => { CallRecordingUrl = n.GetStringValue(); } },
                { "initiator", n => { Initiator = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callRecordingDisplayName", CallRecordingDisplayName);
            writer.WriteTimeSpanValue("callRecordingDuration", CallRecordingDuration);
            writer.WriteEnumValue<global::ApiSdk.Models.CallRecordingStatus>("callRecordingStatus", CallRecordingStatus);
            writer.WriteStringValue("callRecordingUrl", CallRecordingUrl);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("initiator", Initiator);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("meetingOrganizer", MeetingOrganizer);
        }
    }
}
#pragma warning restore CS0618
