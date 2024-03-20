// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CloudPcGalleryImage : Entity, IParsable 
    {
        /// <summary>The display name of this gallery image. For example, Windows 11 Enterprise + Microsoft 365 Apps 22H2. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The date when the status of image becomes supportedWithWarning. Users can still provision new Cloud PCs if the current time is later than endDate and earlier than expirationDate. For example, assume the endDate of a gallery image is 2023-9-14 and expirationDate is 2024-3-14, users are able to provision new Cloud PCs if today is 2023-10-01. Read-only.</summary>
        public Date? EndDate { get; set; }
        /// <summary>The date when the image is no longer available. Users are unable to provision new Cloud PCs if the current time is later than expirationDate. The value is usually endDate plus six months. For example, if the startDate is 2025-10-14, the expirationDate is usually 2026-04-14. Read-only.</summary>
        public Date? ExpirationDate { get; set; }
        /// <summary>The offer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Offer { get; set; }
#nullable restore
#else
        public string Offer { get; set; }
#endif
        /// <summary>The offerDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfferDisplayName { get; set; }
#nullable restore
#else
        public string OfferDisplayName { get; set; }
#endif
        /// <summary>The offer name of this gallery image that is passed to ARM to retrieve the image resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfferName { get; set; }
#nullable restore
#else
        public string OfferName { get; set; }
#endif
        /// <summary>The publisher property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher { get; set; }
#nullable restore
#else
        public string Publisher { get; set; }
#endif
        /// <summary>The publisher name of this gallery image that is passed to ARM to retrieve the image resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherName { get; set; }
#nullable restore
#else
        public string PublisherName { get; set; }
#endif
        /// <summary>The recommendedSku property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendedSku { get; set; }
#nullable restore
#else
        public string RecommendedSku { get; set; }
#endif
        /// <summary>Indicates the size of this image in gigabytes. For example, 64. Read-only.</summary>
        public int? SizeInGB { get; set; }
        /// <summary>The sku property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sku { get; set; }
#nullable restore
#else
        public string Sku { get; set; }
#endif
        /// <summary>The skuDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuDisplayName { get; set; }
#nullable restore
#else
        public string SkuDisplayName { get; set; }
#endif
        /// <summary>The SKU name of this image that is passed to ARM to retrieve the image resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuName { get; set; }
#nullable restore
#else
        public string SkuName { get; set; }
#endif
        /// <summary>The date when the Cloud PC image is available for provisioning new Cloud PCs. For example, 2022-09-20. Read-only.</summary>
        public Date? StartDate { get; set; }
        /// <summary>The status of the gallery image on the Cloud PC. Possible values are: supported, supportedWithWarning, notSupported, unknownFutureValue. The default value is supported. Read-only.</summary>
        public CloudPcGalleryImageStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcGalleryImage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcGalleryImage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcGalleryImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDate", n => { EndDate = n.GetDateValue(); } },
                {"expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                {"offer", n => { Offer = n.GetStringValue(); } },
                {"offerDisplayName", n => { OfferDisplayName = n.GetStringValue(); } },
                {"offerName", n => { OfferName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"publisherName", n => { PublisherName = n.GetStringValue(); } },
                {"recommendedSku", n => { RecommendedSku = n.GetStringValue(); } },
                {"sizeInGB", n => { SizeInGB = n.GetIntValue(); } },
                {"sku", n => { Sku = n.GetStringValue(); } },
                {"skuDisplayName", n => { SkuDisplayName = n.GetStringValue(); } },
                {"skuName", n => { SkuName = n.GetStringValue(); } },
                {"startDate", n => { StartDate = n.GetDateValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcGalleryImageStatus>(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteStringValue("offer", Offer);
            writer.WriteStringValue("offerDisplayName", OfferDisplayName);
            writer.WriteStringValue("offerName", OfferName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("recommendedSku", RecommendedSku);
            writer.WriteIntValue("sizeInGB", SizeInGB);
            writer.WriteStringValue("sku", Sku);
            writer.WriteStringValue("skuDisplayName", SkuDisplayName);
            writer.WriteStringValue("skuName", SkuName);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteEnumValue<CloudPcGalleryImageStatus>("status", Status);
        }
    }
}