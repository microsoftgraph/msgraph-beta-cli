// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AuthenticationStrength : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifier of the authentication strength.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationStrengthId { get; set; }
#nullable restore
#else
        public string AuthenticationStrengthId { get; set; }
#endif
        /// <summary>The result of the authentication strength. The possible values are: notSet, skippedForProofUp, satisfied, singleChallengeRequired, multipleChallengesRequired, singleRegistrationRequired, multipleRegistrationsRequired, cannotSatisfyDueToCombinationConfiguration, cannotSatisfy, unknownFutureValue.</summary>
        public ApiSdk.Models.AuthenticationStrengthResult? AuthenticationStrengthResult { get; set; }
        /// <summary>The name of the authentication strength.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationStrength"/> and sets the default values.
        /// </summary>
        public AuthenticationStrength()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AuthenticationStrength"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationStrength CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationStrength();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authenticationStrengthId", n => { AuthenticationStrengthId = n.GetStringValue(); } },
                { "authenticationStrengthResult", n => { AuthenticationStrengthResult = n.GetEnumValue<AuthenticationStrengthResult>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authenticationStrengthId", AuthenticationStrengthId);
            writer.WriteEnumValue<AuthenticationStrengthResult>("authenticationStrengthResult", AuthenticationStrengthResult);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
