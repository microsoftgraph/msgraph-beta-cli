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
    public partial class Call : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of active modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Modality?>? ActiveModalities { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Modality?> ActiveModalities { get; set; }
#endif
        /// <summary>The participant that answered the call. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ParticipantInfo? AnsweredBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ParticipantInfo AnsweredBy { get; set; }
#endif
        /// <summary>The audioRoutingGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AudioRoutingGroup>? AudioRoutingGroups { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AudioRoutingGroup> AudioRoutingGroups { get; set; }
#endif
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallbackUri { get; set; }
#nullable restore
#else
        public string CallbackUri { get; set; }
#endif
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallChainId { get; set; }
#nullable restore
#else
        public string CallChainId { get; set; }
#endif
        /// <summary>Contains the optional features for the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CallOptions? CallOptions { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CallOptions CallOptions { get; set; }
#endif
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CallRoute>? CallRoutes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CallRoute> CallRoutes { get; set; }
#endif
        /// <summary>The chat information. Required information for meeting scenarios.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ChatInfo? ChatInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ChatInfo ChatInfo { get; set; }
#endif
        /// <summary>The contentSharingSessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ContentSharingSession>? ContentSharingSessions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ContentSharingSession> ContentSharingSessions { get; set; }
#endif
        /// <summary>The direction of the call. The possible values are incoming or outgoing. Read-only.</summary>
        public global::ApiSdk.Models.CallDirection? Direction { get; set; }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IncomingContext? IncomingContext { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IncomingContext IncomingContext { get; set; }
#endif
        /// <summary>The media configuration. Required information for creating peer to peer calls or joining meetings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MediaConfig? MediaConfig { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MediaConfig MediaConfig { get; set; }
#endif
        /// <summary>Read-only. The call media state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CallMediaState? MediaState { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CallMediaState MediaState { get; set; }
#endif
        /// <summary>Contains the capabilities of a meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MeetingCapability? MeetingCapability { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MeetingCapability MeetingCapability { get; set; }
#endif
        /// <summary>The meeting information. Required information for meeting scenarios.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MeetingInfo? MeetingInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MeetingInfo MeetingInfo { get; set; }
#endif
        /// <summary>The myParticipantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MyParticipantId { get; set; }
#nullable restore
#else
        public string MyParticipantId { get; set; }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CommsOperation>? Operations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CommsOperation> Operations { get; set; }
#endif
        /// <summary>The participants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Participant>? Participants { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Participant> Participants { get; set; }
#endif
        /// <summary>The list of requested modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Modality?>? RequestedModalities { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Modality?> RequestedModalities { get; set; }
#endif
        /// <summary>The result information. For example, the result can hold termination reason. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ResultInfo? ResultInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ResultInfo ResultInfo { get; set; }
#endif
        /// <summary>Ringing timeout in seconds for outgoing peer to peer calls. The max value for this attribute is 115 seconds.</summary>
        public int? RingingTimeoutInSeconds { get; set; }
        /// <summary>This property is applicable for peer to peer calls only. Possible values are: none, noMissedCall, disableForwardingExceptPhone, disableForwarding, preferSkypeForBusiness, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.RoutingPolicy?>? RoutingPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.RoutingPolicy?> RoutingPolicies { get; set; }
#endif
        /// <summary>The originator of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ParticipantInfo? Source { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ParticipantInfo Source { get; set; }
#endif
        /// <summary>The call state. Possible values are: incoming, establishing, ringing, established, hold, transferring, transferAccepted, redirecting, terminating, terminated. Read-only.</summary>
        public global::ApiSdk.Models.CallState? State { get; set; }
        /// <summary>The subject of the conversation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The targets of the call. Required information for creating peer to peer call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.InvitationParticipantInfo>? Targets { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.InvitationParticipantInfo> Targets { get; set; }
#endif
        /// <summary>Read-only. tenantId in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The terminationReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TerminationReason { get; set; }
#nullable restore
#else
        public string TerminationReason { get; set; }
#endif
        /// <summary>The toneInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ToneInfo? ToneInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ToneInfo ToneInfo { get; set; }
#endif
        /// <summary>The transcription information for the call. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CallTranscriptionInfo? Transcription { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CallTranscriptionInfo Transcription { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Call"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Call CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Call();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeModalities", n => { ActiveModalities = n.GetCollectionOfEnumValues<global::ApiSdk.Models.Modality>()?.AsList(); } },
                { "answeredBy", n => { AnsweredBy = n.GetObjectValue<global::ApiSdk.Models.ParticipantInfo>(global::ApiSdk.Models.ParticipantInfo.CreateFromDiscriminatorValue); } },
                { "audioRoutingGroups", n => { AudioRoutingGroups = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AudioRoutingGroup>(global::ApiSdk.Models.AudioRoutingGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "callChainId", n => { CallChainId = n.GetStringValue(); } },
                { "callOptions", n => { CallOptions = n.GetObjectValue<global::ApiSdk.Models.CallOptions>(global::ApiSdk.Models.CallOptions.CreateFromDiscriminatorValue); } },
                { "callRoutes", n => { CallRoutes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CallRoute>(global::ApiSdk.Models.CallRoute.CreateFromDiscriminatorValue)?.AsList(); } },
                { "callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                { "chatInfo", n => { ChatInfo = n.GetObjectValue<global::ApiSdk.Models.ChatInfo>(global::ApiSdk.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                { "contentSharingSessions", n => { ContentSharingSessions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ContentSharingSession>(global::ApiSdk.Models.ContentSharingSession.CreateFromDiscriminatorValue)?.AsList(); } },
                { "direction", n => { Direction = n.GetEnumValue<global::ApiSdk.Models.CallDirection>(); } },
                { "incomingContext", n => { IncomingContext = n.GetObjectValue<global::ApiSdk.Models.IncomingContext>(global::ApiSdk.Models.IncomingContext.CreateFromDiscriminatorValue); } },
                { "mediaConfig", n => { MediaConfig = n.GetObjectValue<global::ApiSdk.Models.MediaConfig>(global::ApiSdk.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                { "mediaState", n => { MediaState = n.GetObjectValue<global::ApiSdk.Models.CallMediaState>(global::ApiSdk.Models.CallMediaState.CreateFromDiscriminatorValue); } },
                { "meetingCapability", n => { MeetingCapability = n.GetObjectValue<global::ApiSdk.Models.MeetingCapability>(global::ApiSdk.Models.MeetingCapability.CreateFromDiscriminatorValue); } },
                { "meetingInfo", n => { MeetingInfo = n.GetObjectValue<global::ApiSdk.Models.MeetingInfo>(global::ApiSdk.Models.MeetingInfo.CreateFromDiscriminatorValue); } },
                { "myParticipantId", n => { MyParticipantId = n.GetStringValue(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CommsOperation>(global::ApiSdk.Models.CommsOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "participants", n => { Participants = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Participant>(global::ApiSdk.Models.Participant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requestedModalities", n => { RequestedModalities = n.GetCollectionOfEnumValues<global::ApiSdk.Models.Modality>()?.AsList(); } },
                { "resultInfo", n => { ResultInfo = n.GetObjectValue<global::ApiSdk.Models.ResultInfo>(global::ApiSdk.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                { "ringingTimeoutInSeconds", n => { RingingTimeoutInSeconds = n.GetIntValue(); } },
                { "routingPolicies", n => { RoutingPolicies = n.GetCollectionOfEnumValues<global::ApiSdk.Models.RoutingPolicy>()?.AsList(); } },
                { "source", n => { Source = n.GetObjectValue<global::ApiSdk.Models.ParticipantInfo>(global::ApiSdk.Models.ParticipantInfo.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.CallState>(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "targets", n => { Targets = n.GetCollectionOfObjectValues<global::ApiSdk.Models.InvitationParticipantInfo>(global::ApiSdk.Models.InvitationParticipantInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "terminationReason", n => { TerminationReason = n.GetStringValue(); } },
                { "toneInfo", n => { ToneInfo = n.GetObjectValue<global::ApiSdk.Models.ToneInfo>(global::ApiSdk.Models.ToneInfo.CreateFromDiscriminatorValue); } },
                { "transcription", n => { Transcription = n.GetObjectValue<global::ApiSdk.Models.CallTranscriptionInfo>(global::ApiSdk.Models.CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.Modality>("activeModalities", ActiveModalities);
            writer.WriteObjectValue<global::ApiSdk.Models.ParticipantInfo>("answeredBy", AnsweredBy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AudioRoutingGroup>("audioRoutingGroups", AudioRoutingGroups);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteObjectValue<global::ApiSdk.Models.CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<global::ApiSdk.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ContentSharingSession>("contentSharingSessions", ContentSharingSessions);
            writer.WriteEnumValue<global::ApiSdk.Models.CallDirection>("direction", Direction);
            writer.WriteObjectValue<global::ApiSdk.Models.IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<global::ApiSdk.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<global::ApiSdk.Models.CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<global::ApiSdk.Models.MeetingCapability>("meetingCapability", MeetingCapability);
            writer.WriteObjectValue<global::ApiSdk.Models.MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Participant>("participants", Participants);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.Modality>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<global::ApiSdk.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteIntValue("ringingTimeoutInSeconds", RingingTimeoutInSeconds);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.RoutingPolicy>("routingPolicies", RoutingPolicies);
            writer.WriteObjectValue<global::ApiSdk.Models.ParticipantInfo>("source", Source);
            writer.WriteEnumValue<global::ApiSdk.Models.CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("terminationReason", TerminationReason);
            writer.WriteObjectValue<global::ApiSdk.Models.ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<global::ApiSdk.Models.CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
#pragma warning restore CS0618
