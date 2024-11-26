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
    public partial class WebauthnAuthenticatorSelectionCriteria : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Microsoft Entra ID-preferred attachment modality. For more information, see Authenticator Attachment Modality</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticatorAttachment { get; set; }
#nullable restore
#else
        public string AuthenticatorAttachment { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Microsoft Entra ID-preferred client-side credential discoverability. Currently always true. The WebAuthn authenticator must store the credential identifier on the authenticator.</summary>
        public bool? RequireResidentKey { get; set; }
        /// <summary>Microsoft Entra ID requirement to verify the user is present during credential provisioning. Currently always required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserVerification { get; set; }
#nullable restore
#else
        public string UserVerification { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WebauthnAuthenticatorSelectionCriteria"/> and sets the default values.
        /// </summary>
        public WebauthnAuthenticatorSelectionCriteria()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WebauthnAuthenticatorSelectionCriteria"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.WebauthnAuthenticatorSelectionCriteria CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WebauthnAuthenticatorSelectionCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authenticatorAttachment", n => { AuthenticatorAttachment = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "requireResidentKey", n => { RequireResidentKey = n.GetBoolValue(); } },
                { "userVerification", n => { UserVerification = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authenticatorAttachment", AuthenticatorAttachment);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("requireResidentKey", RequireResidentKey);
            writer.WriteStringValue("userVerification", UserVerification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618