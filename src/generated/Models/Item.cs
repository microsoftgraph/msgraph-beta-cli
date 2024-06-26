// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Item : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The baseUnitOfMeasureId property</summary>
        public Guid? BaseUnitOfMeasureId { get; set; }
        /// <summary>The blocked property</summary>
        public bool? Blocked { get; set; }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The gtin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gtin { get; set; }
#nullable restore
#else
        public string Gtin { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The inventory property</summary>
        public decimal? Inventory { get; set; }
        /// <summary>The itemCategory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ItemCategory? ItemCategory { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ItemCategory ItemCategory { get; set; }
#endif
        /// <summary>The itemCategoryCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemCategoryCode { get; set; }
#nullable restore
#else
        public string ItemCategoryCode { get; set; }
#endif
        /// <summary>The itemCategoryId property</summary>
        public Guid? ItemCategoryId { get; set; }
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
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Picture>? Picture { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Picture> Picture { get; set; }
#endif
        /// <summary>The priceIncludesTax property</summary>
        public bool? PriceIncludesTax { get; set; }
        /// <summary>The taxGroupCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxGroupCode { get; set; }
#nullable restore
#else
        public string TaxGroupCode { get; set; }
#endif
        /// <summary>The taxGroupId property</summary>
        public Guid? TaxGroupId { get; set; }
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The unitCost property</summary>
        public decimal? UnitCost { get; set; }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Item"/> and sets the default values.
        /// </summary>
        public Item()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Item"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Item CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "baseUnitOfMeasureId", n => { BaseUnitOfMeasureId = n.GetGuidValue(); } },
                { "blocked", n => { Blocked = n.GetBoolValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "gtin", n => { Gtin = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "inventory", n => { Inventory = n.GetDecimalValue(); } },
                { "itemCategory", n => { ItemCategory = n.GetObjectValue<ApiSdk.Models.ItemCategory>(ApiSdk.Models.ItemCategory.CreateFromDiscriminatorValue); } },
                { "itemCategoryCode", n => { ItemCategoryCode = n.GetStringValue(); } },
                { "itemCategoryId", n => { ItemCategoryId = n.GetGuidValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "number", n => { Number = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "picture", n => { Picture = n.GetCollectionOfObjectValues<ApiSdk.Models.Picture>(ApiSdk.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                { "priceIncludesTax", n => { PriceIncludesTax = n.GetBoolValue(); } },
                { "taxGroupCode", n => { TaxGroupCode = n.GetStringValue(); } },
                { "taxGroupId", n => { TaxGroupId = n.GetGuidValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "unitCost", n => { UnitCost = n.GetDecimalValue(); } },
                { "unitPrice", n => { UnitPrice = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("baseUnitOfMeasureId", BaseUnitOfMeasureId);
            writer.WriteBoolValue("blocked", Blocked);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("gtin", Gtin);
            writer.WriteGuidValue("id", Id);
            writer.WriteDecimalValue("inventory", Inventory);
            writer.WriteObjectValue<ApiSdk.Models.ItemCategory>("itemCategory", ItemCategory);
            writer.WriteStringValue("itemCategoryCode", ItemCategoryCode);
            writer.WriteGuidValue("itemCategoryId", ItemCategoryId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Picture>("picture", Picture);
            writer.WriteBoolValue("priceIncludesTax", PriceIncludesTax);
            writer.WriteStringValue("taxGroupCode", TaxGroupCode);
            writer.WriteGuidValue("taxGroupId", TaxGroupId);
            writer.WriteStringValue("type", Type);
            writer.WriteDecimalValue("unitCost", UnitCost);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
