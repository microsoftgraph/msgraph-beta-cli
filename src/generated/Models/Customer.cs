// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Customer : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? Address { get; set; }
#nullable restore
#else
        public PostalAddressType Address { get; set; }
#endif
        /// <summary>The blocked property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Blocked { get; set; }
#nullable restore
#else
        public string Blocked { get; set; }
#endif
        /// <summary>The currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Currency? Currency { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Currency Currency { get; set; }
#endif
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The currencyId property</summary>
        public Guid? CurrencyId { get; set; }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number { get; set; }
#nullable restore
#else
        public string Number { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The paymentMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PaymentMethod? PaymentMethod { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PaymentMethod PaymentMethod { get; set; }
#endif
        /// <summary>The paymentMethodId property</summary>
        public Guid? PaymentMethodId { get; set; }
        /// <summary>The paymentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PaymentTerm? PaymentTerm { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PaymentTerm PaymentTerm { get; set; }
#endif
        /// <summary>The paymentTermsId property</summary>
        public Guid? PaymentTermsId { get; set; }
        /// <summary>The phoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Picture>? Picture { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Picture> Picture { get; set; }
#endif
        /// <summary>The shipmentMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ShipmentMethod? ShipmentMethod { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ShipmentMethod ShipmentMethod { get; set; }
#endif
        /// <summary>The shipmentMethodId property</summary>
        public Guid? ShipmentMethodId { get; set; }
        /// <summary>The taxAreaDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxAreaDisplayName { get; set; }
#nullable restore
#else
        public string TaxAreaDisplayName { get; set; }
#endif
        /// <summary>The taxAreaId property</summary>
        public Guid? TaxAreaId { get; set; }
        /// <summary>The taxLiable property</summary>
        public bool? TaxLiable { get; set; }
        /// <summary>The taxRegistrationNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxRegistrationNumber { get; set; }
#nullable restore
#else
        public string TaxRegistrationNumber { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The website property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Customer"/> and sets the default values.
        /// </summary>
        public Customer()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Customer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"address", n => { Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"blocked", n => { Blocked = n.GetStringValue(); } },
                {"currency", n => { Currency = n.GetObjectValue<ApiSdk.Models.Currency>(ApiSdk.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetGuidValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"paymentMethod", n => { PaymentMethod = n.GetObjectValue<ApiSdk.Models.PaymentMethod>(ApiSdk.Models.PaymentMethod.CreateFromDiscriminatorValue); } },
                {"paymentMethodId", n => { PaymentMethodId = n.GetGuidValue(); } },
                {"paymentTerm", n => { PaymentTerm = n.GetObjectValue<ApiSdk.Models.PaymentTerm>(ApiSdk.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", n => { PaymentTermsId = n.GetGuidValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<ApiSdk.Models.Picture>(ApiSdk.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                {"shipmentMethod", n => { ShipmentMethod = n.GetObjectValue<ApiSdk.Models.ShipmentMethod>(ApiSdk.Models.ShipmentMethod.CreateFromDiscriminatorValue); } },
                {"shipmentMethodId", n => { ShipmentMethodId = n.GetGuidValue(); } },
                {"taxAreaDisplayName", n => { TaxAreaDisplayName = n.GetStringValue(); } },
                {"taxAreaId", n => { TaxAreaId = n.GetGuidValue(); } },
                {"taxLiable", n => { TaxLiable = n.GetBoolValue(); } },
                {"taxRegistrationNumber", n => { TaxRegistrationNumber = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PostalAddressType>("address", Address);
            writer.WriteStringValue("blocked", Blocked);
            writer.WriteObjectValue<ApiSdk.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteGuidValue("currencyId", CurrencyId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ApiSdk.Models.PaymentMethod>("paymentMethod", PaymentMethod);
            writer.WriteGuidValue("paymentMethodId", PaymentMethodId);
            writer.WriteObjectValue<ApiSdk.Models.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteGuidValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Picture>("picture", Picture);
            writer.WriteObjectValue<ApiSdk.Models.ShipmentMethod>("shipmentMethod", ShipmentMethod);
            writer.WriteGuidValue("shipmentMethodId", ShipmentMethodId);
            writer.WriteStringValue("taxAreaDisplayName", TaxAreaDisplayName);
            writer.WriteGuidValue("taxAreaId", TaxAreaId);
            writer.WriteBoolValue("taxLiable", TaxLiable);
            writer.WriteStringValue("taxRegistrationNumber", TaxRegistrationNumber);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}