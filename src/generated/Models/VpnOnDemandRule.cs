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
    /// VPN On-Demand Rule definition.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class VpnOnDemandRule : IAdditionalDataHolder, IParsable
    {
        /// <summary>VPN On-Demand Rule Connection Action.</summary>
        public global::ApiSdk.Models.VpnOnDemandRuleConnectionAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>DNS Search Domains.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DnsSearchDomains { get; set; }
#nullable restore
#else
        public List<string> DnsSearchDomains { get; set; }
#endif
        /// <summary>DNS Search Server Address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DnsServerAddressMatch { get; set; }
#nullable restore
#else
        public List<string> DnsServerAddressMatch { get; set; }
#endif
        /// <summary>VPN On-Demand Rule Connection Domain Action.</summary>
        public global::ApiSdk.Models.VpnOnDemandRuleConnectionDomainAction? DomainAction { get; set; }
        /// <summary>Domains (Only applicable when Action is evaluate connection).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Domains { get; set; }
#nullable restore
#else
        public List<string> Domains { get; set; }
#endif
        /// <summary>VPN On-Demand Rule Connection network interface type.</summary>
        public global::ApiSdk.Models.VpnOnDemandRuleInterfaceTypeMatch? InterfaceTypeMatch { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Probe Required Url (Only applicable when Action is evaluate connection and DomainAction is connect if needed).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProbeRequiredUrl { get; set; }
#nullable restore
#else
        public string ProbeRequiredUrl { get; set; }
#endif
        /// <summary>A URL to probe. If this URL is successfully fetched (returning a 200 HTTP status code) without redirection, this rule matches.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProbeUrl { get; set; }
#nullable restore
#else
        public string ProbeUrl { get; set; }
#endif
        /// <summary>Network Service Set Identifiers (SSIDs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ssids { get; set; }
#nullable restore
#else
        public List<string> Ssids { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.VpnOnDemandRule"/> and sets the default values.
        /// </summary>
        public VpnOnDemandRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.VpnOnDemandRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.VpnOnDemandRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.VpnOnDemandRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::ApiSdk.Models.VpnOnDemandRuleConnectionAction>(); } },
                { "dnsSearchDomains", n => { DnsSearchDomains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "dnsServerAddressMatch", n => { DnsServerAddressMatch = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "domainAction", n => { DomainAction = n.GetEnumValue<global::ApiSdk.Models.VpnOnDemandRuleConnectionDomainAction>(); } },
                { "domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "interfaceTypeMatch", n => { InterfaceTypeMatch = n.GetEnumValue<global::ApiSdk.Models.VpnOnDemandRuleInterfaceTypeMatch>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "probeRequiredUrl", n => { ProbeRequiredUrl = n.GetStringValue(); } },
                { "probeUrl", n => { ProbeUrl = n.GetStringValue(); } },
                { "ssids", n => { Ssids = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.VpnOnDemandRuleConnectionAction>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsSearchDomains", DnsSearchDomains);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsServerAddressMatch", DnsServerAddressMatch);
            writer.WriteEnumValue<global::ApiSdk.Models.VpnOnDemandRuleConnectionDomainAction>("domainAction", DomainAction);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteEnumValue<global::ApiSdk.Models.VpnOnDemandRuleInterfaceTypeMatch>("interfaceTypeMatch", InterfaceTypeMatch);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("probeRequiredUrl", ProbeRequiredUrl);
            writer.WriteStringValue("probeUrl", ProbeUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("ssids", Ssids);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
