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
    public partial class SamlOrWsFedProvider : global::ApiSdk.Models.IdentityProviderBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Issuer URI of the federation server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerUri { get; set; }
#nullable restore
#else
        public string IssuerUri { get; set; }
#endif
        /// <summary>URI of the metadata exchange endpoint used for authentication from rich client applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MetadataExchangeUri { get; set; }
#nullable restore
#else
        public string MetadataExchangeUri { get; set; }
#endif
        /// <summary>URI that web-based clients are directed to when signing in to Microsoft Entra services.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PassiveSignInUri { get; set; }
#nullable restore
#else
        public string PassiveSignInUri { get; set; }
#endif
        /// <summary>Preferred authentication protocol. Supported values include saml or wsfed.</summary>
        public global::ApiSdk.Models.AuthenticationProtocol? PreferredAuthenticationProtocol { get; set; }
        /// <summary>Current certificate used to sign tokens passed to the Microsoft identity platform. The certificate is formatted as a Base64 encoded string of the public portion of the federated IdP&apos;s token signing certificate and must be compatible with the X509Certificate2 class.   This property is used in the following scenarios:  if a rollover is required outside of the autorollover update a new federation service is being set up  if the new token signing certificate isn&apos;t present in the federation properties after the federation service certificate has been updated.   Microsoft Entra ID updates certificates via an autorollover process in which it attempts to retrieve a new certificate from the federation service metadata, 30 days before expiry of the current certificate. If a new certificate isn&apos;t available, Microsoft Entra ID monitors the metadata daily and will update the federation settings for the domain when a new certificate is available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SigningCertificate { get; set; }
#nullable restore
#else
        public string SigningCertificate { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SamlOrWsFedProvider"/> and sets the default values.
        /// </summary>
        public SamlOrWsFedProvider() : base()
        {
            OdataType = "#microsoft.graph.samlOrWsFedProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SamlOrWsFedProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.SamlOrWsFedProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.internalDomainFederation" => new global::ApiSdk.Models.InternalDomainFederation(),
                "#microsoft.graph.samlOrWsFedExternalDomainFederation" => new global::ApiSdk.Models.SamlOrWsFedExternalDomainFederation(),
                _ => new global::ApiSdk.Models.SamlOrWsFedProvider(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "issuerUri", n => { IssuerUri = n.GetStringValue(); } },
                { "metadataExchangeUri", n => { MetadataExchangeUri = n.GetStringValue(); } },
                { "passiveSignInUri", n => { PassiveSignInUri = n.GetStringValue(); } },
                { "preferredAuthenticationProtocol", n => { PreferredAuthenticationProtocol = n.GetEnumValue<global::ApiSdk.Models.AuthenticationProtocol>(); } },
                { "signingCertificate", n => { SigningCertificate = n.GetStringValue(); } },
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
            writer.WriteStringValue("issuerUri", IssuerUri);
            writer.WriteStringValue("metadataExchangeUri", MetadataExchangeUri);
            writer.WriteStringValue("passiveSignInUri", PassiveSignInUri);
            writer.WriteEnumValue<global::ApiSdk.Models.AuthenticationProtocol>("preferredAuthenticationProtocol", PreferredAuthenticationProtocol);
            writer.WriteStringValue("signingCertificate", SigningCertificate);
        }
    }
}
#pragma warning restore CS0618
