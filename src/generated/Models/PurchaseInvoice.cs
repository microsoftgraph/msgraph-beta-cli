// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PurchaseInvoice : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The buyFromAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PostalAddressType? BuyFromAddress { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PostalAddressType BuyFromAddress { get; set; }
#endif
        /// <summary>The currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Currency? Currency { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Currency Currency { get; set; }
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
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount { get; set; }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax { get; set; }
        /// <summary>The dueDate property</summary>
        public Date? DueDate { get; set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The invoiceDate property</summary>
        public Date? InvoiceDate { get; set; }
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
        /// <summary>The payToAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PostalAddressType? PayToAddress { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PostalAddressType PayToAddress { get; set; }
#endif
        /// <summary>The payToContact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayToContact { get; set; }
#nullable restore
#else
        public string PayToContact { get; set; }
#endif
        /// <summary>The payToName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayToName { get; set; }
#nullable restore
#else
        public string PayToName { get; set; }
#endif
        /// <summary>The payToVendorId property</summary>
        public Guid? PayToVendorId { get; set; }
        /// <summary>The payToVendorNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayToVendorNumber { get; set; }
#nullable restore
#else
        public string PayToVendorNumber { get; set; }
#endif
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax { get; set; }
        /// <summary>The purchaseInvoiceLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PurchaseInvoiceLine>? PurchaseInvoiceLines { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
#endif
        /// <summary>The shipToAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PostalAddressType? ShipToAddress { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PostalAddressType ShipToAddress { get; set; }
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
        /// <summary>The vendor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Vendor? Vendor { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Vendor Vendor { get; set; }
#endif
        /// <summary>The vendorId property</summary>
        public Guid? VendorId { get; set; }
        /// <summary>The vendorInvoiceNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorInvoiceNumber { get; set; }
#nullable restore
#else
        public string VendorInvoiceNumber { get; set; }
#endif
        /// <summary>The vendorName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorName { get; set; }
#nullable restore
#else
        public string VendorName { get; set; }
#endif
        /// <summary>The vendorNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorNumber { get; set; }
#nullable restore
#else
        public string VendorNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PurchaseInvoice"/> and sets the default values.
        /// </summary>
        public PurchaseInvoice()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PurchaseInvoice"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PurchaseInvoice CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PurchaseInvoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "buyFromAddress", n => { BuyFromAddress = n.GetObjectValue<global::ApiSdk.Models.PostalAddressType>(global::ApiSdk.Models.PostalAddressType.CreateFromDiscriminatorValue); } },
                { "currency", n => { Currency = n.GetObjectValue<global::ApiSdk.Models.Currency>(global::ApiSdk.Models.Currency.CreateFromDiscriminatorValue); } },
                { "currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                { "currencyId", n => { CurrencyId = n.GetGuidValue(); } },
                { "discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                { "discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                { "dueDate", n => { DueDate = n.GetDateValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "invoiceDate", n => { InvoiceDate = n.GetDateValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "number", n => { Number = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "payToAddress", n => { PayToAddress = n.GetObjectValue<global::ApiSdk.Models.PostalAddressType>(global::ApiSdk.Models.PostalAddressType.CreateFromDiscriminatorValue); } },
                { "payToContact", n => { PayToContact = n.GetStringValue(); } },
                { "payToName", n => { PayToName = n.GetStringValue(); } },
                { "payToVendorId", n => { PayToVendorId = n.GetGuidValue(); } },
                { "payToVendorNumber", n => { PayToVendorNumber = n.GetStringValue(); } },
                { "pricesIncludeTax", n => { PricesIncludeTax = n.GetBoolValue(); } },
                { "purchaseInvoiceLines", n => { PurchaseInvoiceLines = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PurchaseInvoiceLine>(global::ApiSdk.Models.PurchaseInvoiceLine.CreateFromDiscriminatorValue)?.AsList(); } },
                { "shipToAddress", n => { ShipToAddress = n.GetObjectValue<global::ApiSdk.Models.PostalAddressType>(global::ApiSdk.Models.PostalAddressType.CreateFromDiscriminatorValue); } },
                { "shipToContact", n => { ShipToContact = n.GetStringValue(); } },
                { "shipToName", n => { ShipToName = n.GetStringValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "totalAmountExcludingTax", n => { TotalAmountExcludingTax = n.GetDecimalValue(); } },
                { "totalAmountIncludingTax", n => { TotalAmountIncludingTax = n.GetDecimalValue(); } },
                { "totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
                { "vendor", n => { Vendor = n.GetObjectValue<global::ApiSdk.Models.Vendor>(global::ApiSdk.Models.Vendor.CreateFromDiscriminatorValue); } },
                { "vendorId", n => { VendorId = n.GetGuidValue(); } },
                { "vendorInvoiceNumber", n => { VendorInvoiceNumber = n.GetStringValue(); } },
                { "vendorName", n => { VendorName = n.GetStringValue(); } },
                { "vendorNumber", n => { VendorNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.PostalAddressType>("buyFromAddress", BuyFromAddress);
            writer.WriteObjectValue<global::ApiSdk.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteGuidValue("currencyId", CurrencyId);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateValue("invoiceDate", InvoiceDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::ApiSdk.Models.PostalAddressType>("payToAddress", PayToAddress);
            writer.WriteStringValue("payToContact", PayToContact);
            writer.WriteStringValue("payToName", PayToName);
            writer.WriteGuidValue("payToVendorId", PayToVendorId);
            writer.WriteStringValue("payToVendorNumber", PayToVendorNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PurchaseInvoiceLine>("purchaseInvoiceLines", PurchaseInvoiceLines);
            writer.WriteObjectValue<global::ApiSdk.Models.PostalAddressType>("shipToAddress", ShipToAddress);
            writer.WriteStringValue("shipToContact", ShipToContact);
            writer.WriteStringValue("shipToName", ShipToName);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteObjectValue<global::ApiSdk.Models.Vendor>("vendor", Vendor);
            writer.WriteGuidValue("vendorId", VendorId);
            writer.WriteStringValue("vendorInvoiceNumber", VendorInvoiceNumber);
            writer.WriteStringValue("vendorName", VendorName);
            writer.WriteStringValue("vendorNumber", VendorNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
