// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.CallRecords
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SmsLogRow : global::ApiSdk.Models.CallRecords.CallLogRow, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Amount of money or cost of the SMS that is charged.</summary>
        public decimal? CallCharge { get; set; }
        /// <summary>Currency used to calculate the cost of the call. For details, see ISO 4217.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Indicates whether the SMS was Domestic (within a country or region) or International (outside a country or region) based on the user&apos;s location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationContext { get; set; }
#nullable restore
#else
        public string DestinationContext { get; set; }
#endif
        /// <summary>Country or region of a phone number that received the SMS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationName { get; set; }
#nullable restore
#else
        public string DestinationName { get; set; }
#endif
        /// <summary>Partially obfuscated phone number that received the SMS. For details, see E.164.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationNumber { get; set; }
#nullable restore
#else
        public string DestinationNumber { get; set; }
#endif
        /// <summary>The license used for the SMS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseCapability { get; set; }
#nullable restore
#else
        public string LicenseCapability { get; set; }
#endif
        /// <summary>The date and time when the SMS was sent.</summary>
        public DateTimeOffset? SentDateTime { get; set; }
        /// <summary>SMS identifier. Not guaranteed to be unique.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SmsId { get; set; }
#nullable restore
#else
        public string SmsId { get; set; }
#endif
        /// <summary>Type of SMS such as outbound or inbound.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SmsType { get; set; }
#nullable restore
#else
        public string SmsType { get; set; }
#endif
        /// <summary>Number of SMS units sent/received.</summary>
        public int? SmsUnits { get; set; }
        /// <summary>Partially obfuscated phone number that sent the SMS. For details, see E.164.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceNumber { get; set; }
#nullable restore
#else
        public string SourceNumber { get; set; }
#endif
        /// <summary>Country code of the tenant. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantCountryCode { get; set; }
#nullable restore
#else
        public string TenantCountryCode { get; set; }
#endif
        /// <summary>Country code of the user. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserCountryCode { get; set; }
#nullable restore
#else
        public string UserCountryCode { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CallRecords.SmsLogRow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CallRecords.SmsLogRow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CallRecords.SmsLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callCharge", n => { CallCharge = n.GetDecimalValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "destinationContext", n => { DestinationContext = n.GetStringValue(); } },
                { "destinationName", n => { DestinationName = n.GetStringValue(); } },
                { "destinationNumber", n => { DestinationNumber = n.GetStringValue(); } },
                { "licenseCapability", n => { LicenseCapability = n.GetStringValue(); } },
                { "sentDateTime", n => { SentDateTime = n.GetDateTimeOffsetValue(); } },
                { "smsId", n => { SmsId = n.GetStringValue(); } },
                { "smsType", n => { SmsType = n.GetStringValue(); } },
                { "smsUnits", n => { SmsUnits = n.GetIntValue(); } },
                { "sourceNumber", n => { SourceNumber = n.GetStringValue(); } },
                { "tenantCountryCode", n => { TenantCountryCode = n.GetStringValue(); } },
                { "userCountryCode", n => { UserCountryCode = n.GetStringValue(); } },
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
            writer.WriteDecimalValue("callCharge", CallCharge);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("destinationContext", DestinationContext);
            writer.WriteStringValue("destinationName", DestinationName);
            writer.WriteStringValue("destinationNumber", DestinationNumber);
            writer.WriteStringValue("licenseCapability", LicenseCapability);
            writer.WriteDateTimeOffsetValue("sentDateTime", SentDateTime);
            writer.WriteStringValue("smsId", SmsId);
            writer.WriteStringValue("smsType", SmsType);
            writer.WriteIntValue("smsUnits", SmsUnits);
            writer.WriteStringValue("sourceNumber", SourceNumber);
            writer.WriteStringValue("tenantCountryCode", TenantCountryCode);
            writer.WriteStringValue("userCountryCode", UserCountryCode);
        }
    }
}
#pragma warning restore CS0618
