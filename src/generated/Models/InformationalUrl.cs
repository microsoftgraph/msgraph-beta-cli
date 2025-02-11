// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class InformationalUrl : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>CDN URL to the application&apos;s logo, Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogoUrl { get; set; }
#nullable restore
#else
        public string LogoUrl { get; set; }
#endif
        /// <summary>Link to the application&apos;s marketing page. For example, https://www.contoso.com/app/marketing</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MarketingUrl { get; set; }
#nullable restore
#else
        public string MarketingUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Link to the application&apos;s privacy statement. For example, https://www.contoso.com/app/privacy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyStatementUrl { get; set; }
#nullable restore
#else
        public string PrivacyStatementUrl { get; set; }
#endif
        /// <summary>Link to the application&apos;s support page. For example, https://www.contoso.com/app/support</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportUrl { get; set; }
#nullable restore
#else
        public string SupportUrl { get; set; }
#endif
        /// <summary>Link to the application&apos;s terms of service statement. For example, https://www.contoso.com/app/termsofservice</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TermsOfServiceUrl { get; set; }
#nullable restore
#else
        public string TermsOfServiceUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.InformationalUrl"/> and sets the default values.
        /// </summary>
        public InformationalUrl()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.InformationalUrl"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.InformationalUrl CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.InformationalUrl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "logoUrl", n => { LogoUrl = n.GetStringValue(); } },
                { "marketingUrl", n => { MarketingUrl = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "privacyStatementUrl", n => { PrivacyStatementUrl = n.GetStringValue(); } },
                { "supportUrl", n => { SupportUrl = n.GetStringValue(); } },
                { "termsOfServiceUrl", n => { TermsOfServiceUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("logoUrl", LogoUrl);
            writer.WriteStringValue("marketingUrl", MarketingUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("privacyStatementUrl", PrivacyStatementUrl);
            writer.WriteStringValue("supportUrl", SupportUrl);
            writer.WriteStringValue("termsOfServiceUrl", TermsOfServiceUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
