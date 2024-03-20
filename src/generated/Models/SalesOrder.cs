// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SalesOrder : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The billingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? BillingPostalAddress { get; set; }
#nullable restore
#else
        public PostalAddressType BillingPostalAddress { get; set; }
#endif
        /// <summary>The billToCustomerId property</summary>
        public Guid? BillToCustomerId { get; set; }
        /// <summary>The billToCustomerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillToCustomerNumber { get; set; }
#nullable restore
#else
        public string BillToCustomerNumber { get; set; }
#endif
        /// <summary>The billToName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillToName { get; set; }
#nullable restore
#else
        public string BillToName { get; set; }
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
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Customer? Customer { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Customer Customer { get; set; }
#endif
        /// <summary>The customerId property</summary>
        public Guid? CustomerId { get; set; }
        /// <summary>The customerName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerName { get; set; }
#nullable restore
#else
        public string CustomerName { get; set; }
#endif
        /// <summary>The customerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNumber { get; set; }
#nullable restore
#else
        public string CustomerNumber { get; set; }
#endif
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount { get; set; }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax { get; set; }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The externalDocumentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalDocumentNumber { get; set; }
#nullable restore
#else
        public string ExternalDocumentNumber { get; set; }
#endif
        /// <summary>The fullyShipped property</summary>
        public bool? FullyShipped { get; set; }
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
        /// <summary>The orderDate property</summary>
        public Date? OrderDate { get; set; }
        /// <summary>The partialShipping property</summary>
        public bool? PartialShipping { get; set; }
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
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax { get; set; }
        /// <summary>The requestedDeliveryDate property</summary>
        public Date? RequestedDeliveryDate { get; set; }
        /// <summary>The salesOrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesOrderLine>? SalesOrderLines { get; set; }
#nullable restore
#else
        public List<SalesOrderLine> SalesOrderLines { get; set; }
#endif
        /// <summary>The salesperson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Salesperson { get; set; }
#nullable restore
#else
        public string Salesperson { get; set; }
#endif
        /// <summary>The sellingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? SellingPostalAddress { get; set; }
#nullable restore
#else
        public PostalAddressType SellingPostalAddress { get; set; }
#endif
        /// <summary>The shippingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? ShippingPostalAddress { get; set; }
#nullable restore
#else
        public PostalAddressType ShippingPostalAddress { get; set; }
#endif
        /// <summary>The shipToContact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShipToContact { get; set; }
#nullable restore
#else
        public string ShipToContact { get; set; }
#endif
        /// <summary>The shipToName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShipToName { get; set; }
#nullable restore
#else
        public string ShipToName { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The totalAmountExcludingTax property</summary>
        public decimal? TotalAmountExcludingTax { get; set; }
        /// <summary>The totalAmountIncludingTax property</summary>
        public decimal? TotalAmountIncludingTax { get; set; }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="SalesOrder"/> and sets the default values.
        /// </summary>
        public SalesOrder()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SalesOrder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SalesOrder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesOrder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"billToCustomerId", n => { BillToCustomerId = n.GetGuidValue(); } },
                {"billToCustomerNumber", n => { BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", n => { BillToName = n.GetStringValue(); } },
                {"billingPostalAddress", n => { BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"currency", n => { Currency = n.GetObjectValue<ApiSdk.Models.Currency>(ApiSdk.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetGuidValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<ApiSdk.Models.Customer>(ApiSdk.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", n => { CustomerId = n.GetGuidValue(); } },
                {"customerName", n => { CustomerName = n.GetStringValue(); } },
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"externalDocumentNumber", n => { ExternalDocumentNumber = n.GetStringValue(); } },
                {"fullyShipped", n => { FullyShipped = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"orderDate", n => { OrderDate = n.GetDateValue(); } },
                {"partialShipping", n => { PartialShipping = n.GetBoolValue(); } },
                {"paymentTerm", n => { PaymentTerm = n.GetObjectValue<ApiSdk.Models.PaymentTerm>(ApiSdk.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", n => { PaymentTermsId = n.GetGuidValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", n => { PricesIncludeTax = n.GetBoolValue(); } },
                {"requestedDeliveryDate", n => { RequestedDeliveryDate = n.GetDateValue(); } },
                {"salesOrderLines", n => { SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesperson", n => { Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", n => { SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipToContact", n => { ShipToContact = n.GetStringValue(); } },
                {"shipToName", n => { ShipToName = n.GetStringValue(); } },
                {"shippingPostalAddress", n => { ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", n => { TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", n => { TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PostalAddressType>("billingPostalAddress", BillingPostalAddress);
            writer.WriteGuidValue("billToCustomerId", BillToCustomerId);
            writer.WriteStringValue("billToCustomerNumber", BillToCustomerNumber);
            writer.WriteStringValue("billToName", BillToName);
            writer.WriteObjectValue<ApiSdk.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteGuidValue("currencyId", CurrencyId);
            writer.WriteObjectValue<ApiSdk.Models.Customer>("customer", Customer);
            writer.WriteGuidValue("customerId", CustomerId);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteBoolValue("fullyShipped", FullyShipped);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateValue("orderDate", OrderDate);
            writer.WriteBoolValue("partialShipping", PartialShipping);
            writer.WriteObjectValue<ApiSdk.Models.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteGuidValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteDateValue("requestedDeliveryDate", RequestedDeliveryDate);
            writer.WriteCollectionOfObjectValues<SalesOrderLine>("salesOrderLines", SalesOrderLines);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteObjectValue<PostalAddressType>("shippingPostalAddress", ShippingPostalAddress);
            writer.WriteStringValue("shipToContact", ShipToContact);
            writer.WriteStringValue("shipToName", ShipToName);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}