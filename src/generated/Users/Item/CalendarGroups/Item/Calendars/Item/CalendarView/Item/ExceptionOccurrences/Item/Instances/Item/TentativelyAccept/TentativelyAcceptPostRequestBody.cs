// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.CalendarView.Item.ExceptionOccurrences.Item.Instances.Item.TentativelyAccept
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TentativelyAcceptPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The ProposedNewTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TimeSlot? ProposedNewTime { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TimeSlot ProposedNewTime { get; set; }
#endif
        /// <summary>The SendResponse property</summary>
        public bool? SendResponse { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.CalendarView.Item.ExceptionOccurrences.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody"/> and sets the default values.
        /// </summary>
        public TentativelyAcceptPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.CalendarView.Item.ExceptionOccurrences.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.CalendarView.Item.ExceptionOccurrences.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.CalendarView.Item.ExceptionOccurrences.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Comment", n => { Comment = n.GetStringValue(); } },
                { "ProposedNewTime", n => { ProposedNewTime = n.GetObjectValue<global::ApiSdk.Models.TimeSlot>(global::ApiSdk.Models.TimeSlot.CreateFromDiscriminatorValue); } },
                { "SendResponse", n => { SendResponse = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Comment", Comment);
            writer.WriteObjectValue<global::ApiSdk.Models.TimeSlot>("ProposedNewTime", ProposedNewTime);
            writer.WriteBoolValue("SendResponse", SendResponse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
