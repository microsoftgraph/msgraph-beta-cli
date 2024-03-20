// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PlatformCredentialAuthenticationMethod : AuthenticationMethod, IParsable 
    {
        /// <summary>The date and time that this Platform Credential Key was registered.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The registered device on which this Platform Credential resides. Supports $expand. When you get a user&apos;s Platform Credential registration information, this property is returned only on a single GET and when you specify ?$expand. For example, GET /users/admin@contoso.com/authentication/platformCredentialAuthenticationMethod/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Device? Device { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Device Device { get; set; }
#endif
        /// <summary>The name of the device on which Platform Credential is registered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Key strength of this Platform Credential key. Possible values are: normal, weak, unknown.</summary>
        public AuthenticationMethodKeyStrength? KeyStrength { get; set; }
        /// <summary>Platform on which this Platform Credential key is present. Possible values are: unknown, windows, macOS,iOS, android, linux.</summary>
        public AuthenticationMethodPlatform? Platform { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PlatformCredentialAuthenticationMethod"/> and sets the default values.
        /// </summary>
        public PlatformCredentialAuthenticationMethod() : base()
        {
            OdataType = "#microsoft.graph.platformCredentialAuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PlatformCredentialAuthenticationMethod"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlatformCredentialAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlatformCredentialAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", n => { Device = n.GetObjectValue<ApiSdk.Models.Device>(ApiSdk.Models.Device.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"keyStrength", n => { KeyStrength = n.GetEnumValue<AuthenticationMethodKeyStrength>(); } },
                {"platform", n => { Platform = n.GetEnumValue<AuthenticationMethodPlatform>(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Device>("device", Device);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<AuthenticationMethodKeyStrength>("keyStrength", KeyStrength);
            writer.WriteEnumValue<AuthenticationMethodPlatform>("platform", Platform);
        }
    }
}