// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Users.Item.Authentication.HardwareOathMethods.AssignAndActivate
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AssignAndActivatePostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The device property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice? Device { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice Device { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The verificationCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationCode { get; set; }
#nullable restore
#else
        public string VerificationCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Authentication.HardwareOathMethods.AssignAndActivate.AssignAndActivatePostRequestBody"/> and sets the default values.
        /// </summary>
        public AssignAndActivatePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Users.Item.Authentication.HardwareOathMethods.AssignAndActivate.AssignAndActivatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Users.Item.Authentication.HardwareOathMethods.AssignAndActivate.AssignAndActivatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Users.Item.Authentication.HardwareOathMethods.AssignAndActivate.AssignAndActivatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "device", n => { Device = n.GetObjectValue<global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice>(global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "verificationCode", n => { VerificationCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice>("device", Device);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("verificationCode", VerificationCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618