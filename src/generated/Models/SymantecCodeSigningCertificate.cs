// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SymantecCodeSigningCertificate : Entity, IParsable 
    {
        /// <summary>The Windows Symantec Code-Signing Certificate in the raw data format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content { get; set; }
#nullable restore
#else
        public byte[] Content { get; set; }
#endif
        /// <summary>The Cert Expiration Date.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The Issuer value for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer { get; set; }
#nullable restore
#else
        public string Issuer { get; set; }
#endif
        /// <summary>The Issuer Name for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerName { get; set; }
#nullable restore
#else
        public string IssuerName { get; set; }
#endif
        /// <summary>The Password required for .pfx file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>The status property</summary>
        public CertificateStatus? Status { get; set; }
        /// <summary>The Subject value for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The Subject Name for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectName { get; set; }
#nullable restore
#else
        public string SubjectName { get; set; }
#endif
        /// <summary>The Type of the CodeSigning Cert as Symantec Cert.</summary>
        public DateTimeOffset? UploadDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SymantecCodeSigningCertificate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SymantecCodeSigningCertificate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SymantecCodeSigningCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"issuerName", n => { IssuerName = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CertificateStatus>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"subjectName", n => { SubjectName = n.GetStringValue(); } },
                {"uploadDateTime", n => { UploadDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteByteArrayValue("content", Content);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("issuerName", IssuerName);
            writer.WriteStringValue("password", Password);
            writer.WriteEnumValue<CertificateStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteDateTimeOffsetValue("uploadDateTime", UploadDateTime);
        }
    }
}