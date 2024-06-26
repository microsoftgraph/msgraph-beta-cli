// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Mention : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the application where the mention is created. Optional. Not used and defaulted as null for message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Application { get; set; }
#nullable restore
#else
        public string Application { get; set; }
#endif
        /// <summary>A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientReference { get; set; }
#nullable restore
#else
        public string ClientReference { get; set; }
#endif
        /// <summary>The email information of the user who made the mention.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailAddress? CreatedBy { get; set; }
#nullable restore
#else
        public EmailAddress CreatedBy { get; set; }
#endif
        /// <summary>The date and time that the mention is created on the client.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeepLink { get; set; }
#nullable restore
#else
        public string DeepLink { get; set; }
#endif
        /// <summary>The mentioned property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailAddress? Mentioned { get; set; }
#nullable restore
#else
        public EmailAddress Mentioned { get; set; }
#endif
        /// <summary>Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MentionText { get; set; }
#nullable restore
#else
        public string MentionText { get; set; }
#endif
        /// <summary>The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.</summary>
        public DateTimeOffset? ServerCreatedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Mention"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Mention CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Mention();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "application", n => { Application = n.GetStringValue(); } },
                { "clientReference", n => { ClientReference = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deepLink", n => { DeepLink = n.GetStringValue(); } },
                { "mentionText", n => { MentionText = n.GetStringValue(); } },
                { "mentioned", n => { Mentioned = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                { "serverCreatedDateTime", n => { ServerCreatedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("application", Application);
            writer.WriteStringValue("clientReference", ClientReference);
            writer.WriteObjectValue<EmailAddress>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deepLink", DeepLink);
            writer.WriteObjectValue<EmailAddress>("mentioned", Mentioned);
            writer.WriteStringValue("mentionText", MentionText);
            writer.WriteDateTimeOffsetValue("serverCreatedDateTime", ServerCreatedDateTime);
        }
    }
}
