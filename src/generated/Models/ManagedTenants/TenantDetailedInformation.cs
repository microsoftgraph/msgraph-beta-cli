// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.ManagedTenants
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TenantDetailedInformation : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The city where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>The code for the country where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The name for the country where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryName { get; set; }
#nullable restore
#else
        public string CountryName { get; set; }
#endif
        /// <summary>The default domain name for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDomainName { get; set; }
#nullable restore
#else
        public string DefaultDomainName { get; set; }
#endif
        /// <summary>The display name for the managed tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The business industry associated with the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndustryName { get; set; }
#nullable restore
#else
        public string IndustryName { get; set; }
#endif
        /// <summary>The region where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>The business segment associated with the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SegmentName { get; set; }
#nullable restore
#else
        public string SegmentName { get; set; }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The vertical associated with the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerticalName { get; set; }
#nullable restore
#else
        public string VerticalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "city", n => { City = n.GetStringValue(); } },
                { "countryCode", n => { CountryCode = n.GetStringValue(); } },
                { "countryName", n => { CountryName = n.GetStringValue(); } },
                { "defaultDomainName", n => { DefaultDomainName = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "industryName", n => { IndustryName = n.GetStringValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "segmentName", n => { SegmentName = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "verticalName", n => { VerticalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteStringValue("countryName", CountryName);
            writer.WriteStringValue("defaultDomainName", DefaultDomainName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("industryName", IndustryName);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("segmentName", SegmentName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("verticalName", VerticalName);
        }
    }
}
#pragma warning restore CS0618
