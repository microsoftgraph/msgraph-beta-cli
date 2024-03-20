// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AuthenticationBehaviors : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The blockAzureADGraphAccess property</summary>
        public bool? BlockAzureADGraphAccess { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Removes the email claim from tokens sent to an application when the email address&apos;s domain can&apos;t be verified.</summary>
        public bool? RemoveUnverifiedEmailClaim { get; set; }
        /// <summary>Requires multitenant applications to have a service principal in the resource tenant as part of authorization checks before they&apos;re granted access tokens. This property is only modifiable for multi-tenant resource applications that rely on access from clients without a service principal and had this behavior as set to false by Microsoft. Tenant administrators should respond to security advisories sent through Azure Health Service events and the Microsoft 365 message center.</summary>
        public bool? RequireClientServicePrincipal { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationBehaviors"/> and sets the default values.
        /// </summary>
        public AuthenticationBehaviors()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AuthenticationBehaviors"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationBehaviors CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationBehaviors();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"blockAzureADGraphAccess", n => { BlockAzureADGraphAccess = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"removeUnverifiedEmailClaim", n => { RemoveUnverifiedEmailClaim = n.GetBoolValue(); } },
                {"requireClientServicePrincipal", n => { RequireClientServicePrincipal = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("blockAzureADGraphAccess", BlockAzureADGraphAccess);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("removeUnverifiedEmailClaim", RemoveUnverifiedEmailClaim);
            writer.WriteBoolValue("requireClientServicePrincipal", RequireClientServicePrincipal);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}