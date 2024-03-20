// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SharedEmailDomainInvitation : Entity, IParsable 
    {
        /// <summary>The expiryTime property</summary>
        public DateTimeOffset? ExpiryTime { get; set; }
        /// <summary>The invitationDomain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvitationDomain { get; set; }
#nullable restore
#else
        public string InvitationDomain { get; set; }
#endif
        /// <summary>The invitationStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvitationStatus { get; set; }
#nullable restore
#else
        public string InvitationStatus { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SharedEmailDomainInvitation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharedEmailDomainInvitation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedEmailDomainInvitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"expiryTime", n => { ExpiryTime = n.GetDateTimeOffsetValue(); } },
                {"invitationDomain", n => { InvitationDomain = n.GetStringValue(); } },
                {"invitationStatus", n => { InvitationStatus = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("expiryTime", ExpiryTime);
            writer.WriteStringValue("invitationDomain", InvitationDomain);
            writer.WriteStringValue("invitationStatus", InvitationStatus);
        }
    }
}