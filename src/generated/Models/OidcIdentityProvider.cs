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
    public partial class OidcIdentityProvider : global::ApiSdk.Models.IdentityProviderBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The clientAuthentication property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OidcClientAuthentication? ClientAuthentication { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OidcClientAuthentication ClientAuthentication { get; set; }
#endif
        /// <summary>The client ID for the application obtained when registering the application with the identity provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>After the OIDC provider sends an ID token back to Microsoft Entra External ID, Microsoft Entra External ID needs to be able to map the claims from the received token to the claims that Microsoft Entra ID recognizes and uses. This complex type captures that mapping.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OidcInboundClaimMappingOverride? InboundClaimMapping { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OidcInboundClaimMappingOverride InboundClaimMapping { get; set; }
#endif
        /// <summary>The issuer URI. Issuer URI is a case-sensitive URL using https scheme contains scheme, host, and optionally, port number and path components and no query or fragment components. Note: Configuring other Microsoft Entra tenants as an external identity provider is currently not supported. As a result, the microsoftonline.com domain in the issuer URI is not accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer { get; set; }
#nullable restore
#else
        public string Issuer { get; set; }
#endif
        /// <summary>The responseType property</summary>
        public global::ApiSdk.Models.OidcResponseType? ResponseType { get; set; }
        /// <summary>Scope defines the information and permissions you are looking to gather from your custom identity provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope { get; set; }
#nullable restore
#else
        public string Scope { get; set; }
#endif
        /// <summary>The URL for the metadata document of the OpenID Connect identity provider. Every OpenID Connect identity provider describes a metadata document that contains most of the information required to perform sign-in. This includes information such as the URLs to use and the location of the service&apos;s public signing keys. The OpenID Connect metadata document is always located at an endpoint that ends in .well-known/openid-configuration. Note: The metadata document should, at minimum, contain the following properties: issuer, authorizationendpoint, tokenendpoint, tokenendpointauthmethodssupported, responsetypessupported, subjecttypessupported and jwks_uri. Visit OpenID Connect Discovery specifications for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WellKnownEndpoint { get; set; }
#nullable restore
#else
        public string WellKnownEndpoint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.OidcIdentityProvider"/> and sets the default values.
        /// </summary>
        public OidcIdentityProvider() : base()
        {
            OdataType = "#microsoft.graph.oidcIdentityProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.OidcIdentityProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.OidcIdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.OidcIdentityProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "clientAuthentication", n => { ClientAuthentication = n.GetObjectValue<global::ApiSdk.Models.OidcClientAuthentication>(global::ApiSdk.Models.OidcClientAuthentication.CreateFromDiscriminatorValue); } },
                { "clientId", n => { ClientId = n.GetStringValue(); } },
                { "inboundClaimMapping", n => { InboundClaimMapping = n.GetObjectValue<global::ApiSdk.Models.OidcInboundClaimMappingOverride>(global::ApiSdk.Models.OidcInboundClaimMappingOverride.CreateFromDiscriminatorValue); } },
                { "issuer", n => { Issuer = n.GetStringValue(); } },
                { "responseType", n => { ResponseType = n.GetEnumValue<global::ApiSdk.Models.OidcResponseType>(); } },
                { "scope", n => { Scope = n.GetStringValue(); } },
                { "wellKnownEndpoint", n => { WellKnownEndpoint = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.OidcClientAuthentication>("clientAuthentication", ClientAuthentication);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteObjectValue<global::ApiSdk.Models.OidcInboundClaimMappingOverride>("inboundClaimMapping", InboundClaimMapping);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteEnumValue<global::ApiSdk.Models.OidcResponseType>("responseType", ResponseType);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("wellKnownEndpoint", WellKnownEndpoint);
        }
    }
}
#pragma warning restore CS0618
