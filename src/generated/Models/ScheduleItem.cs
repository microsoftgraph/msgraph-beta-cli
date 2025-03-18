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
    public partial class ScheduleItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date, time, and time zone that the corresponding event ends.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DateTimeTimeZone? End { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DateTimeTimeZone End { get; set; }
#endif
        /// <summary>The sensitivity of the corresponding event. True if the event is marked private, false otherwise. Optional.</summary>
        public bool? IsPrivate { get; set; }
        /// <summary>The location where the corresponding event is held or attended from. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The date, time, and time zone that the corresponding event starts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DateTimeTimeZone? Start { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DateTimeTimeZone Start { get; set; }
#endif
        /// <summary>The availability status of the user or resource during the corresponding event. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public global::ApiSdk.Models.FreeBusyStatus? Status { get; set; }
        /// <summary>The corresponding event&apos;s subject line. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ScheduleItem"/> and sets the default values.
        /// </summary>
        public ScheduleItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ScheduleItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ScheduleItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ScheduleItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "end", n => { End = n.GetObjectValue<global::ApiSdk.Models.DateTimeTimeZone>(global::ApiSdk.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "isPrivate", n => { IsPrivate = n.GetBoolValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "start", n => { Start = n.GetObjectValue<global::ApiSdk.Models.DateTimeTimeZone>(global::ApiSdk.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.FreeBusyStatus>(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.DateTimeTimeZone>("end", End);
            writer.WriteBoolValue("isPrivate", IsPrivate);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::ApiSdk.Models.DateTimeTimeZone>("start", Start);
            writer.WriteEnumValue<global::ApiSdk.Models.FreeBusyStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
