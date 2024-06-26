// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AppCredentialSignInActivity : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The globally unique appId (also called client ID on the Microsoft Entra admin center) of the credential application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>The ID of the credential application instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppObjectId { get; set; }
#nullable restore
#else
        public string AppObjectId { get; set; }
#endif
        /// <summary>The date and time when the credential was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The credentialOrigin property</summary>
        public ApplicationKeyOrigin? CredentialOrigin { get; set; }
        /// <summary>The date and time when the credential is set to expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The key ID of the credential.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>Specifies the key type. The possible values are: clientSecret, certificate, unknownFutureValue.</summary>
        public ApplicationKeyType? KeyType { get; set; }
        /// <summary>Specifies what the key was used for. The possible values are: sign, verify, unknownFutureValue.</summary>
        public ApplicationKeyUsage? KeyUsage { get; set; }
        /// <summary>The ID of the accessed resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId { get; set; }
#nullable restore
#else
        public string ResourceId { get; set; }
#endif
        /// <summary>The ID of the service principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalObjectId { get; set; }
#nullable restore
#else
        public string ServicePrincipalObjectId { get; set; }
#endif
        /// <summary>The signInActivity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SignInActivity? SignInActivity { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SignInActivity SignInActivity { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AppCredentialSignInActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppCredentialSignInActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppCredentialSignInActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "appObjectId", n => { AppObjectId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "credentialOrigin", n => { CredentialOrigin = n.GetEnumValue<ApplicationKeyOrigin>(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "keyId", n => { KeyId = n.GetStringValue(); } },
                { "keyType", n => { KeyType = n.GetEnumValue<ApplicationKeyType>(); } },
                { "keyUsage", n => { KeyUsage = n.GetEnumValue<ApplicationKeyUsage>(); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
                { "servicePrincipalObjectId", n => { ServicePrincipalObjectId = n.GetStringValue(); } },
                { "signInActivity", n => { SignInActivity = n.GetObjectValue<ApiSdk.Models.SignInActivity>(ApiSdk.Models.SignInActivity.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("appObjectId", AppObjectId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<ApplicationKeyOrigin>("credentialOrigin", CredentialOrigin);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("keyId", KeyId);
            writer.WriteEnumValue<ApplicationKeyType>("keyType", KeyType);
            writer.WriteEnumValue<ApplicationKeyUsage>("keyUsage", KeyUsage);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("servicePrincipalObjectId", ServicePrincipalObjectId);
            writer.WriteObjectValue<ApiSdk.Models.SignInActivity>("signInActivity", SignInActivity);
        }
    }
}
