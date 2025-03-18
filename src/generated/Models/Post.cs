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
    public partial class Post : global::ApiSdk.Models.OutlookItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Attachment>? Attachments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Attachment> Attachments { get; set; }
#endif
        /// <summary>The contents of the post. This is a default property. This property can be null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemBody? Body { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemBody Body { get; set; }
#endif
        /// <summary>Unique ID of the conversation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationId { get; set; }
#nullable restore
#else
        public string ConversationId { get; set; }
#endif
        /// <summary>Unique ID of the conversation thread. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationThreadId { get; set; }
#nullable restore
#else
        public string ConversationThreadId { get; set; }
#endif
        /// <summary>The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Extension> Extensions { get; set; }
#endif
        /// <summary>The from property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Recipient? From { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Recipient From { get; set; }
#endif
        /// <summary>Indicates whether the post has at least one attachment. This is a default property.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>The importance of a group post: low, normal, high.</summary>
        public global::ApiSdk.Models.Importance? Importance { get; set; }
        /// <summary>The earlier post that this post is replying to in the conversationThread. Read-only. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Post? InReplyTo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Post InReplyTo { get; set; }
#endif
        /// <summary>The mentions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Mention>? Mentions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Mention> Mentions { get; set; }
#endif
        /// <summary>The collection of multi-value extended properties defined for the post. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
#endif
        /// <summary>Conversation participants that were added to the thread as part of this post.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Recipient>? NewParticipants { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Recipient> NewParticipants { get; set; }
#endif
        /// <summary>Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>Contains the address of the sender. The value of Sender is assumed to be the address of the authenticated user in the case when Sender is not specified. This is a default property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Recipient? Sender { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Recipient Sender { get; set; }
#endif
        /// <summary>The collection of single-value extended properties defined for the post. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Post"/> and sets the default values.
        /// </summary>
        public Post() : base()
        {
            OdataType = "#microsoft.graph.post";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Post"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Post CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Post();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Attachment>(global::ApiSdk.Models.Attachment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "body", n => { Body = n.GetObjectValue<global::ApiSdk.Models.ItemBody>(global::ApiSdk.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "conversationId", n => { ConversationId = n.GetStringValue(); } },
                { "conversationThreadId", n => { ConversationThreadId = n.GetStringValue(); } },
                { "extensions", n => { Extensions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Extension>(global::ApiSdk.Models.Extension.CreateFromDiscriminatorValue)?.AsList(); } },
                { "from", n => { From = n.GetObjectValue<global::ApiSdk.Models.Recipient>(global::ApiSdk.Models.Recipient.CreateFromDiscriminatorValue); } },
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "importance", n => { Importance = n.GetEnumValue<global::ApiSdk.Models.Importance>(); } },
                { "inReplyTo", n => { InReplyTo = n.GetObjectValue<global::ApiSdk.Models.Post>(global::ApiSdk.Models.Post.CreateFromDiscriminatorValue); } },
                { "mentions", n => { Mentions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Mention>(global::ApiSdk.Models.Mention.CreateFromDiscriminatorValue)?.AsList(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>(global::ApiSdk.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "newParticipants", n => { NewParticipants = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Recipient>(global::ApiSdk.Models.Recipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                { "sender", n => { Sender = n.GetObjectValue<global::ApiSdk.Models.Recipient>(global::ApiSdk.Models.Recipient.CreateFromDiscriminatorValue); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>(global::ApiSdk.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Attachment>("attachments", Attachments);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemBody>("body", Body);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Extension>("extensions", Extensions);
            writer.WriteObjectValue<global::ApiSdk.Models.Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<global::ApiSdk.Models.Importance>("importance", Importance);
            writer.WriteObjectValue<global::ApiSdk.Models.Post>("inReplyTo", InReplyTo);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Mention>("mentions", Mentions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Recipient>("newParticipants", NewParticipants);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.Recipient>("sender", Sender);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
#pragma warning restore CS0618
