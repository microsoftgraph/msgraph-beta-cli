// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Company : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The accounts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Account>? Accounts { get; set; }
#nullable restore
#else
        public List<Account> Accounts { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The agedAccountsPayable property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.AgedAccountsPayable>? AgedAccountsPayable { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.AgedAccountsPayable> AgedAccountsPayable { get; set; }
#endif
        /// <summary>The agedAccountsReceivable property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.AgedAccountsReceivable>? AgedAccountsReceivable { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.AgedAccountsReceivable> AgedAccountsReceivable { get; set; }
#endif
        /// <summary>The businessProfileId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessProfileId { get; set; }
#nullable restore
#else
        public string BusinessProfileId { get; set; }
#endif
        /// <summary>The companyInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.CompanyInformation>? CompanyInformation { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.CompanyInformation> CompanyInformation { get; set; }
#endif
        /// <summary>The countriesRegions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CountryRegion>? CountriesRegions { get; set; }
#nullable restore
#else
        public List<CountryRegion> CountriesRegions { get; set; }
#endif
        /// <summary>The currencies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Currency>? Currencies { get; set; }
#nullable restore
#else
        public List<Currency> Currencies { get; set; }
#endif
        /// <summary>The customerPaymentJournals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomerPaymentJournal>? CustomerPaymentJournals { get; set; }
#nullable restore
#else
        public List<CustomerPaymentJournal> CustomerPaymentJournals { get; set; }
#endif
        /// <summary>The customerPayments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomerPayment>? CustomerPayments { get; set; }
#nullable restore
#else
        public List<CustomerPayment> CustomerPayments { get; set; }
#endif
        /// <summary>The customers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Customer>? Customers { get; set; }
#nullable restore
#else
        public List<Customer> Customers { get; set; }
#endif
        /// <summary>The dimensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Dimension>? Dimensions { get; set; }
#nullable restore
#else
        public List<Dimension> Dimensions { get; set; }
#endif
        /// <summary>The dimensionValues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DimensionValue>? DimensionValues { get; set; }
#nullable restore
#else
        public List<DimensionValue> DimensionValues { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The employees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Employee>? Employees { get; set; }
#nullable restore
#else
        public List<Employee> Employees { get; set; }
#endif
        /// <summary>The generalLedgerEntries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GeneralLedgerEntry>? GeneralLedgerEntries { get; set; }
#nullable restore
#else
        public List<GeneralLedgerEntry> GeneralLedgerEntries { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The itemCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ItemCategory>? ItemCategories { get; set; }
#nullable restore
#else
        public List<ItemCategory> ItemCategories { get; set; }
#endif
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Item>? Items { get; set; }
#nullable restore
#else
        public List<Item> Items { get; set; }
#endif
        /// <summary>The journalLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JournalLine>? JournalLines { get; set; }
#nullable restore
#else
        public List<JournalLine> JournalLines { get; set; }
#endif
        /// <summary>The journals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Journal>? Journals { get; set; }
#nullable restore
#else
        public List<Journal> Journals { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The paymentMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PaymentMethod>? PaymentMethods { get; set; }
#nullable restore
#else
        public List<PaymentMethod> PaymentMethods { get; set; }
#endif
        /// <summary>The paymentTerms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PaymentTerm>? PaymentTerms { get; set; }
#nullable restore
#else
        public List<PaymentTerm> PaymentTerms { get; set; }
#endif
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Picture>? Picture { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Picture> Picture { get; set; }
#endif
        /// <summary>The purchaseInvoiceLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PurchaseInvoiceLine>? PurchaseInvoiceLines { get; set; }
#nullable restore
#else
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
#endif
        /// <summary>The purchaseInvoices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PurchaseInvoice>? PurchaseInvoices { get; set; }
#nullable restore
#else
        public List<PurchaseInvoice> PurchaseInvoices { get; set; }
#endif
        /// <summary>The salesCreditMemoLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesCreditMemoLine>? SalesCreditMemoLines { get; set; }
#nullable restore
#else
        public List<SalesCreditMemoLine> SalesCreditMemoLines { get; set; }
#endif
        /// <summary>The salesCreditMemos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesCreditMemo>? SalesCreditMemos { get; set; }
#nullable restore
#else
        public List<SalesCreditMemo> SalesCreditMemos { get; set; }
#endif
        /// <summary>The salesInvoiceLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesInvoiceLine>? SalesInvoiceLines { get; set; }
#nullable restore
#else
        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; }
#endif
        /// <summary>The salesInvoices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesInvoice>? SalesInvoices { get; set; }
#nullable restore
#else
        public List<SalesInvoice> SalesInvoices { get; set; }
#endif
        /// <summary>The salesOrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesOrderLine>? SalesOrderLines { get; set; }
#nullable restore
#else
        public List<SalesOrderLine> SalesOrderLines { get; set; }
#endif
        /// <summary>The salesOrders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesOrder>? SalesOrders { get; set; }
#nullable restore
#else
        public List<SalesOrder> SalesOrders { get; set; }
#endif
        /// <summary>The salesQuoteLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesQuoteLine>? SalesQuoteLines { get; set; }
#nullable restore
#else
        public List<SalesQuoteLine> SalesQuoteLines { get; set; }
#endif
        /// <summary>The salesQuotes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesQuote>? SalesQuotes { get; set; }
#nullable restore
#else
        public List<SalesQuote> SalesQuotes { get; set; }
#endif
        /// <summary>The shipmentMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ShipmentMethod>? ShipmentMethods { get; set; }
#nullable restore
#else
        public List<ShipmentMethod> ShipmentMethods { get; set; }
#endif
        /// <summary>The systemVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemVersion { get; set; }
#nullable restore
#else
        public string SystemVersion { get; set; }
#endif
        /// <summary>The taxAreas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaxArea>? TaxAreas { get; set; }
#nullable restore
#else
        public List<TaxArea> TaxAreas { get; set; }
#endif
        /// <summary>The taxGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaxGroup>? TaxGroups { get; set; }
#nullable restore
#else
        public List<TaxGroup> TaxGroups { get; set; }
#endif
        /// <summary>The unitsOfMeasure property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnitOfMeasure>? UnitsOfMeasure { get; set; }
#nullable restore
#else
        public List<UnitOfMeasure> UnitsOfMeasure { get; set; }
#endif
        /// <summary>The vendors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Vendor>? Vendors { get; set; }
#nullable restore
#else
        public List<Vendor> Vendors { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Company"/> and sets the default values.
        /// </summary>
        public Company()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Company"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Company CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Company();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"accounts", n => { Accounts = n.GetCollectionOfObjectValues<Account>(Account.CreateFromDiscriminatorValue)?.ToList(); } },
                {"agedAccountsPayable", n => { AgedAccountsPayable = n.GetCollectionOfObjectValues<ApiSdk.Models.AgedAccountsPayable>(ApiSdk.Models.AgedAccountsPayable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"agedAccountsReceivable", n => { AgedAccountsReceivable = n.GetCollectionOfObjectValues<ApiSdk.Models.AgedAccountsReceivable>(ApiSdk.Models.AgedAccountsReceivable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessProfileId", n => { BusinessProfileId = n.GetStringValue(); } },
                {"companyInformation", n => { CompanyInformation = n.GetCollectionOfObjectValues<ApiSdk.Models.CompanyInformation>(ApiSdk.Models.CompanyInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"countriesRegions", n => { CountriesRegions = n.GetCollectionOfObjectValues<CountryRegion>(CountryRegion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"currencies", n => { Currencies = n.GetCollectionOfObjectValues<Currency>(Currency.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customerPaymentJournals", n => { CustomerPaymentJournals = n.GetCollectionOfObjectValues<CustomerPaymentJournal>(CustomerPaymentJournal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customerPayments", n => { CustomerPayments = n.GetCollectionOfObjectValues<CustomerPayment>(CustomerPayment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<Customer>(Customer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dimensionValues", n => { DimensionValues = n.GetCollectionOfObjectValues<DimensionValue>(DimensionValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dimensions", n => { Dimensions = n.GetCollectionOfObjectValues<Dimension>(Dimension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"employees", n => { Employees = n.GetCollectionOfObjectValues<Employee>(Employee.CreateFromDiscriminatorValue)?.ToList(); } },
                {"generalLedgerEntries", n => { GeneralLedgerEntries = n.GetCollectionOfObjectValues<GeneralLedgerEntry>(GeneralLedgerEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"itemCategories", n => { ItemCategories = n.GetCollectionOfObjectValues<ItemCategory>(ItemCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<Item>(Item.CreateFromDiscriminatorValue)?.ToList(); } },
                {"journalLines", n => { JournalLines = n.GetCollectionOfObjectValues<JournalLine>(JournalLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"journals", n => { Journals = n.GetCollectionOfObjectValues<Journal>(Journal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"paymentMethods", n => { PaymentMethods = n.GetCollectionOfObjectValues<PaymentMethod>(PaymentMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                {"paymentTerms", n => { PaymentTerms = n.GetCollectionOfObjectValues<PaymentTerm>(PaymentTerm.CreateFromDiscriminatorValue)?.ToList(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<ApiSdk.Models.Picture>(ApiSdk.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                {"purchaseInvoiceLines", n => { PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>(PurchaseInvoiceLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"purchaseInvoices", n => { PurchaseInvoices = n.GetCollectionOfObjectValues<PurchaseInvoice>(PurchaseInvoice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesCreditMemoLines", n => { SalesCreditMemoLines = n.GetCollectionOfObjectValues<SalesCreditMemoLine>(SalesCreditMemoLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesCreditMemos", n => { SalesCreditMemos = n.GetCollectionOfObjectValues<SalesCreditMemo>(SalesCreditMemo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesInvoiceLines", n => { SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>(SalesInvoiceLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesInvoices", n => { SalesInvoices = n.GetCollectionOfObjectValues<SalesInvoice>(SalesInvoice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOrderLines", n => { SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesOrders", n => { SalesOrders = n.GetCollectionOfObjectValues<SalesOrder>(SalesOrder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesQuoteLines", n => { SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>(SalesQuoteLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesQuotes", n => { SalesQuotes = n.GetCollectionOfObjectValues<SalesQuote>(SalesQuote.CreateFromDiscriminatorValue)?.ToList(); } },
                {"shipmentMethods", n => { ShipmentMethods = n.GetCollectionOfObjectValues<ShipmentMethod>(ShipmentMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemVersion", n => { SystemVersion = n.GetStringValue(); } },
                {"taxAreas", n => { TaxAreas = n.GetCollectionOfObjectValues<TaxArea>(TaxArea.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taxGroups", n => { TaxGroups = n.GetCollectionOfObjectValues<TaxGroup>(TaxGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"unitsOfMeasure", n => { UnitsOfMeasure = n.GetCollectionOfObjectValues<UnitOfMeasure>(UnitOfMeasure.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vendors", n => { Vendors = n.GetCollectionOfObjectValues<Vendor>(Vendor.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Account>("accounts", Accounts);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.AgedAccountsPayable>("agedAccountsPayable", AgedAccountsPayable);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.AgedAccountsReceivable>("agedAccountsReceivable", AgedAccountsReceivable);
            writer.WriteStringValue("businessProfileId", BusinessProfileId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.CompanyInformation>("companyInformation", CompanyInformation);
            writer.WriteCollectionOfObjectValues<CountryRegion>("countriesRegions", CountriesRegions);
            writer.WriteCollectionOfObjectValues<Currency>("currencies", Currencies);
            writer.WriteCollectionOfObjectValues<CustomerPaymentJournal>("customerPaymentJournals", CustomerPaymentJournals);
            writer.WriteCollectionOfObjectValues<CustomerPayment>("customerPayments", CustomerPayments);
            writer.WriteCollectionOfObjectValues<Customer>("customers", Customers);
            writer.WriteCollectionOfObjectValues<Dimension>("dimensions", Dimensions);
            writer.WriteCollectionOfObjectValues<DimensionValue>("dimensionValues", DimensionValues);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Employee>("employees", Employees);
            writer.WriteCollectionOfObjectValues<GeneralLedgerEntry>("generalLedgerEntries", GeneralLedgerEntries);
            writer.WriteGuidValue("id", Id);
            writer.WriteCollectionOfObjectValues<ItemCategory>("itemCategories", ItemCategories);
            writer.WriteCollectionOfObjectValues<Item>("items", Items);
            writer.WriteCollectionOfObjectValues<JournalLine>("journalLines", JournalLines);
            writer.WriteCollectionOfObjectValues<Journal>("journals", Journals);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<PaymentMethod>("paymentMethods", PaymentMethods);
            writer.WriteCollectionOfObjectValues<PaymentTerm>("paymentTerms", PaymentTerms);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Picture>("picture", Picture);
            writer.WriteCollectionOfObjectValues<PurchaseInvoiceLine>("purchaseInvoiceLines", PurchaseInvoiceLines);
            writer.WriteCollectionOfObjectValues<PurchaseInvoice>("purchaseInvoices", PurchaseInvoices);
            writer.WriteCollectionOfObjectValues<SalesCreditMemoLine>("salesCreditMemoLines", SalesCreditMemoLines);
            writer.WriteCollectionOfObjectValues<SalesCreditMemo>("salesCreditMemos", SalesCreditMemos);
            writer.WriteCollectionOfObjectValues<SalesInvoiceLine>("salesInvoiceLines", SalesInvoiceLines);
            writer.WriteCollectionOfObjectValues<SalesInvoice>("salesInvoices", SalesInvoices);
            writer.WriteCollectionOfObjectValues<SalesOrderLine>("salesOrderLines", SalesOrderLines);
            writer.WriteCollectionOfObjectValues<SalesOrder>("salesOrders", SalesOrders);
            writer.WriteCollectionOfObjectValues<SalesQuoteLine>("salesQuoteLines", SalesQuoteLines);
            writer.WriteCollectionOfObjectValues<SalesQuote>("salesQuotes", SalesQuotes);
            writer.WriteCollectionOfObjectValues<ShipmentMethod>("shipmentMethods", ShipmentMethods);
            writer.WriteStringValue("systemVersion", SystemVersion);
            writer.WriteCollectionOfObjectValues<TaxArea>("taxAreas", TaxAreas);
            writer.WriteCollectionOfObjectValues<TaxGroup>("taxGroups", TaxGroups);
            writer.WriteCollectionOfObjectValues<UnitOfMeasure>("unitsOfMeasure", UnitsOfMeasure);
            writer.WriteCollectionOfObjectValues<Vendor>("vendors", Vendors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}