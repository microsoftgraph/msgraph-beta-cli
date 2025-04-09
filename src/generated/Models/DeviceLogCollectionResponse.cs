// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Windows Log Collection request entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceLogCollectionResponse : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The User Principal Name (UPN) of the user that enrolled the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrolledByUser { get; set; }
#nullable restore
#else
        public string EnrolledByUser { get; set; }
#endif
        /// <summary>The error code, if any. Valid values -9.22337203685478E+18 to 9.22337203685478E+18</summary>
        public long? ErrorCode { get; set; }
        /// <summary>The DateTime of the expiration of the logs.</summary>
        public DateTimeOffset? ExpirationDateTimeUTC { get; set; }
        /// <summary>The UPN for who initiated the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedByUserPrincipalName { get; set; }
#nullable restore
#else
        public string InitiatedByUserPrincipalName { get; set; }
#endif
        /// <summary>Indicates Intune device unique identifier.</summary>
        public Guid? ManagedDeviceId { get; set; }
        /// <summary>The DateTime the request was received.</summary>
        public DateTimeOffset? ReceivedDateTimeUTC { get; set; }
        /// <summary>The DateTime of the request.</summary>
        public DateTimeOffset? RequestedDateTimeUTC { get; set; }
        /// <summary>The size of the logs. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? Size { get; set; }
        /// <summary>The size of the logs in KB. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? SizeInKB { get; set; }
        /// <summary>AppLogUploadStatus</summary>
        public global::ApiSdk.Models.AppLogUploadState? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceLogCollectionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceLogCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceLogCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enrolledByUser", n => { EnrolledByUser = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetLongValue(); } },
                { "expirationDateTimeUTC", n => { ExpirationDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "initiatedByUserPrincipalName", n => { InitiatedByUserPrincipalName = n.GetStringValue(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetGuidValue(); } },
                { "receivedDateTimeUTC", n => { ReceivedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "requestedDateTimeUTC", n => { RequestedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "size", n => { Size = n.GetDoubleValue(); } },
                { "sizeInKB", n => { SizeInKB = n.GetDoubleValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.AppLogUploadState>(); } },
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
            writer.WriteStringValue("enrolledByUser", EnrolledByUser);
            writer.WriteLongValue("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("expirationDateTimeUTC", ExpirationDateTimeUTC);
            writer.WriteStringValue("initiatedByUserPrincipalName", InitiatedByUserPrincipalName);
            writer.WriteGuidValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("receivedDateTimeUTC", ReceivedDateTimeUTC);
            writer.WriteDateTimeOffsetValue("requestedDateTimeUTC", RequestedDateTimeUTC);
            writer.WriteDoubleValue("size", Size);
            writer.WriteDoubleValue("sizeInKB", SizeInKB);
            writer.WriteEnumValue<global::ApiSdk.Models.AppLogUploadState>("status", Status);
        }
    }
}
#pragma warning restore CS0618
