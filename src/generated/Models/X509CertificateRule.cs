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
    public partial class X509CertificateRule : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier of the X.509 certificate. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier { get; set; }
#nullable restore
#else
        public string Identifier { get; set; }
#endif
        /// <summary>The identifier of the certificate issuer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerSubjectIdentifier { get; set; }
#nullable restore
#else
        public string IssuerSubjectIdentifier { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The identifier of the X.509 certificate policyOID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyOidIdentifier { get; set; }
#nullable restore
#else
        public string PolicyOidIdentifier { get; set; }
#endif
        /// <summary>The type of strong authentication mode. The possible values are: x509CertificateSingleFactor, x509CertificateMultiFactor, unknownFutureValue. Required.</summary>
        public global::ApiSdk.Models.X509CertificateAuthenticationMode? X509CertificateAuthenticationMode { get; set; }
        /// <summary>The possible values are: low, high, unknownFutureValue.</summary>
        public global::ApiSdk.Models.X509CertificateAffinityLevel? X509CertificateRequiredAffinityLevel { get; set; }
        /// <summary>The type of the X.509 certificate mode configuration rule. The possible values are: issuerSubject, policyOID, unknownFutureValue, issuerSubjectAndPolicyOID. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: issuerSubjectAndPolicyOID. Required.</summary>
        public global::ApiSdk.Models.X509CertificateRuleType? X509CertificateRuleType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.X509CertificateRule"/> and sets the default values.
        /// </summary>
        public X509CertificateRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.X509CertificateRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.X509CertificateRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.X509CertificateRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "identifier", n => { Identifier = n.GetStringValue(); } },
                { "issuerSubjectIdentifier", n => { IssuerSubjectIdentifier = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "policyOidIdentifier", n => { PolicyOidIdentifier = n.GetStringValue(); } },
                { "x509CertificateAuthenticationMode", n => { X509CertificateAuthenticationMode = n.GetEnumValue<global::ApiSdk.Models.X509CertificateAuthenticationMode>(); } },
                { "x509CertificateRequiredAffinityLevel", n => { X509CertificateRequiredAffinityLevel = n.GetEnumValue<global::ApiSdk.Models.X509CertificateAffinityLevel>(); } },
                { "x509CertificateRuleType", n => { X509CertificateRuleType = n.GetEnumValue<global::ApiSdk.Models.X509CertificateRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteStringValue("issuerSubjectIdentifier", IssuerSubjectIdentifier);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyOidIdentifier", PolicyOidIdentifier);
            writer.WriteEnumValue<global::ApiSdk.Models.X509CertificateAuthenticationMode>("x509CertificateAuthenticationMode", X509CertificateAuthenticationMode);
            writer.WriteEnumValue<global::ApiSdk.Models.X509CertificateAffinityLevel>("x509CertificateRequiredAffinityLevel", X509CertificateRequiredAffinityLevel);
            writer.WriteEnumValue<global::ApiSdk.Models.X509CertificateRuleType>("x509CertificateRuleType", X509CertificateRuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
