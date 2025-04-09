// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Apple device features configuration profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EasEmailProfileConfigurationBase : global::ApiSdk.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Custom domain name value used while generating an email profile before installing on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDomainName { get; set; }
#nullable restore
#else
        public string CustomDomainName { get; set; }
#endif
        /// <summary>UserDomainname attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: fullDomainName, netBiosDomainName.</summary>
        public global::ApiSdk.Models.DomainNameSource? UserDomainNameSource { get; set; }
        /// <summary>Name of the AAD field, that will be used to retrieve UserName for email profile. Possible values are: userPrincipalName, primarySmtpAddress, samAccountName.</summary>
        public global::ApiSdk.Models.UsernameSource? UsernameAADSource { get; set; }
        /// <summary>Possible values for username source or email source.</summary>
        public global::ApiSdk.Models.UserEmailSource? UsernameSource { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.EasEmailProfileConfigurationBase"/> and sets the default values.
        /// </summary>
        public EasEmailProfileConfigurationBase() : base()
        {
            OdataType = "#microsoft.graph.easEmailProfileConfigurationBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EasEmailProfileConfigurationBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.EasEmailProfileConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.iosEasEmailProfileConfiguration" => new global::ApiSdk.Models.IosEasEmailProfileConfiguration(),
                "#microsoft.graph.windows10EasEmailProfileConfiguration" => new global::ApiSdk.Models.Windows10EasEmailProfileConfiguration(),
                "#microsoft.graph.windowsPhoneEASEmailProfileConfiguration" => new global::ApiSdk.Models.WindowsPhoneEASEmailProfileConfiguration(),
                _ => new global::ApiSdk.Models.EasEmailProfileConfigurationBase(),
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
                { "customDomainName", n => { CustomDomainName = n.GetStringValue(); } },
                { "userDomainNameSource", n => { UserDomainNameSource = n.GetEnumValue<global::ApiSdk.Models.DomainNameSource>(); } },
                { "usernameAADSource", n => { UsernameAADSource = n.GetEnumValue<global::ApiSdk.Models.UsernameSource>(); } },
                { "usernameSource", n => { UsernameSource = n.GetEnumValue<global::ApiSdk.Models.UserEmailSource>(); } },
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
            writer.WriteStringValue("customDomainName", CustomDomainName);
            writer.WriteEnumValue<global::ApiSdk.Models.DomainNameSource>("userDomainNameSource", UserDomainNameSource);
            writer.WriteEnumValue<global::ApiSdk.Models.UsernameSource>("usernameAADSource", UsernameAADSource);
            writer.WriteEnumValue<global::ApiSdk.Models.UserEmailSource>("usernameSource", UsernameSource);
        }
    }
}
#pragma warning restore CS0618
