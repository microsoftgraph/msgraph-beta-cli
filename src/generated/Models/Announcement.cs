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
    public partial class Announcement : global::ApiSdk.Models.ChangeItemBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Change announcement date. Supports $filter (eq, ne, gt, lt, le and ge on year(), month(), day(), hour(), minute(), and second() built in functions) and $orderby.</summary>
        public DateTimeOffset? AnnouncementDateTime { get; set; }
        /// <summary>The changeType property</summary>
        public global::ApiSdk.Models.ChangeAnnouncementChangeType? ChangeType { get; set; }
        /// <summary>Change impact URL. Supports $filter (eq, ne, in) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImpactLink { get; set; }
#nullable restore
#else
        public string ImpactLink { get; set; }
#endif
        /// <summary>Indicates whether the customer needs to take any action for this change. Supports $filter (eq, ne).</summary>
        public bool? IsCustomerActionRequired { get; set; }
        /// <summary>Date on which the change rolls out. Supports $filter (eq, ne, gt, lt, le and ge on year(), month(), day(), hour(), minute(), and second() built in functions) and $orderby.</summary>
        public DateTimeOffset? TargetDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Announcement"/> and sets the default values.
        /// </summary>
        public Announcement() : base()
        {
            OdataType = "#microsoft.graph.announcement";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Announcement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Announcement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Announcement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "announcementDateTime", n => { AnnouncementDateTime = n.GetDateTimeOffsetValue(); } },
                { "changeType", n => { ChangeType = n.GetEnumValue<global::ApiSdk.Models.ChangeAnnouncementChangeType>(); } },
                { "impactLink", n => { ImpactLink = n.GetStringValue(); } },
                { "isCustomerActionRequired", n => { IsCustomerActionRequired = n.GetBoolValue(); } },
                { "targetDateTime", n => { TargetDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("announcementDateTime", AnnouncementDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.ChangeAnnouncementChangeType>("changeType", ChangeType);
            writer.WriteStringValue("impactLink", ImpactLink);
            writer.WriteBoolValue("isCustomerActionRequired", IsCustomerActionRequired);
            writer.WriteDateTimeOffsetValue("targetDateTime", TargetDateTime);
        }
    }
}
#pragma warning restore CS0618
