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
    public partial class AiInteraction : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The data source for Copilot data. For example, IPM.SkypeTeams.Message.Copilot.Excel or IPM.SkypeTeams.Message.Copilot.Loop.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppClass { get; set; }
#nullable restore
#else
        public string AppClass { get; set; }
#endif
        /// <summary>The collection of documents attached to the interaction, such as cards and images.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AiInteractionAttachment>? Attachments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AiInteractionAttachment> Attachments { get; set; }
#endif
        /// <summary>The body of the message, including the text of the body and its body type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemBody? Body { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemBody Body { get; set; }
#endif
        /// <summary>The identifer that maps to all contexts associated with an interaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AiInteractionContext>? Contexts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AiInteractionContext> Contexts { get; set; }
#endif
        /// <summary>The type of the conversation. For example, appchat or bizchat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationType { get; set; }
#nullable restore
#else
        public string ConversationType { get; set; }
#endif
        /// <summary>The time when the interaction was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The timestamp of when the interaction was last modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag { get; set; }
#nullable restore
#else
        public string Etag { get; set; }
#endif
        /// <summary>The from property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? From { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet From { get; set; }
#endif
        /// <summary>The interactionType property</summary>
        public global::ApiSdk.Models.AiInteractionType? InteractionType { get; set; }
        /// <summary>The collection of links that appear in the interaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AiInteractionLink>? Links { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AiInteractionLink> Links { get; set; }
#endif
        /// <summary>The locale of the sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale { get; set; }
#nullable restore
#else
        public string Locale { get; set; }
#endif
        /// <summary>The collection of the entities that were mentioned in the interaction, including users, bots, and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AiInteractionMention>? Mentions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AiInteractionMention> Mentions { get; set; }
#endif
        /// <summary>The identifier that groups a user prompt with its Copilot response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestId { get; set; }
#nullable restore
#else
        public string RequestId { get; set; }
#endif
        /// <summary>The thread ID or conversation identifier that maps to all Copilot sessions for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionId { get; set; }
#nullable restore
#else
        public string SessionId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AiInteraction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AiInteraction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AiInteraction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appClass", n => { AppClass = n.GetStringValue(); } },
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionAttachment>(global::ApiSdk.Models.AiInteractionAttachment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "body", n => { Body = n.GetObjectValue<global::ApiSdk.Models.ItemBody>(global::ApiSdk.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "contexts", n => { Contexts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionContext>(global::ApiSdk.Models.AiInteractionContext.CreateFromDiscriminatorValue)?.AsList(); } },
                { "conversationType", n => { ConversationType = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "etag", n => { Etag = n.GetStringValue(); } },
                { "from", n => { From = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "interactionType", n => { InteractionType = n.GetEnumValue<global::ApiSdk.Models.AiInteractionType>(); } },
                { "links", n => { Links = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionLink>(global::ApiSdk.Models.AiInteractionLink.CreateFromDiscriminatorValue)?.AsList(); } },
                { "locale", n => { Locale = n.GetStringValue(); } },
                { "mentions", n => { Mentions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionMention>(global::ApiSdk.Models.AiInteractionMention.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requestId", n => { RequestId = n.GetStringValue(); } },
                { "sessionId", n => { SessionId = n.GetStringValue(); } },
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
            writer.WriteStringValue("appClass", AppClass);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionAttachment>("attachments", Attachments);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemBody>("body", Body);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionContext>("contexts", Contexts);
            writer.WriteStringValue("conversationType", ConversationType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("etag", Etag);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("from", From);
            writer.WriteEnumValue<global::ApiSdk.Models.AiInteractionType>("interactionType", InteractionType);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionLink>("links", Links);
            writer.WriteStringValue("locale", Locale);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AiInteractionMention>("mentions", Mentions);
            writer.WriteStringValue("requestId", RequestId);
            writer.WriteStringValue("sessionId", SessionId);
        }
    }
}
#pragma warning restore CS0618
