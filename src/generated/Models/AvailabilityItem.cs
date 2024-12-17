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
    public partial class AvailabilityItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The endDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DateTimeTimeZone? EndDateTime { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DateTimeTimeZone EndDateTime { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates the service ID for 1:n appointments. If the appointment is of type 1:n, this field is present, otherwise, null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId { get; set; }
#nullable restore
#else
        public string ServiceId { get; set; }
#endif
        /// <summary>The startDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DateTimeTimeZone? StartDateTime { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DateTimeTimeZone StartDateTime { get; set; }
#endif
        /// <summary>The status of the staff member. Possible values are: available, busy, slotsAvailable, outOfOffice, unknownFutureValue.</summary>
        public global::ApiSdk.Models.BookingsAvailabilityStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AvailabilityItem"/> and sets the default values.
        /// </summary>
        public AvailabilityItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AvailabilityItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.AvailabilityItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AvailabilityItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "endDateTime", n => { EndDateTime = n.GetObjectValue<global::ApiSdk.Models.DateTimeTimeZone>(global::ApiSdk.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "serviceId", n => { ServiceId = n.GetStringValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetObjectValue<global::ApiSdk.Models.DateTimeTimeZone>(global::ApiSdk.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.BookingsAvailabilityStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteObjectValue<global::ApiSdk.Models.DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.BookingsAvailabilityStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
