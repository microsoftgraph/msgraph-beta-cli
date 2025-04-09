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
    public partial class SignInFrequencySessionControl : global::ApiSdk.Models.ConditionalAccessSessionControl, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The possible values are primaryAndSecondaryAuthentication, secondaryAuthentication, unknownFutureValue. This property isn&apos;t required when using frequencyInterval with the value of timeBased.</summary>
        public global::ApiSdk.Models.SignInFrequencyAuthenticationType? AuthenticationType { get; set; }
        /// <summary>The possible values are timeBased, everyTime, unknownFutureValue. Sign-in frequency of everyTime is available for risky users, risky sign-ins, Intune device enrollment, any application, authentication context, and user actions. For more information, see Require reauthentication every time.</summary>
        public global::ApiSdk.Models.SignInFrequencyInterval? FrequencyInterval { get; set; }
        /// <summary>Possible values are: days, hours, or null if frequencyInterval is everyTime .</summary>
        public global::ApiSdk.Models.SigninFrequencyType? Type { get; set; }
        /// <summary>The number of days or hours.</summary>
        public int? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SignInFrequencySessionControl"/> and sets the default values.
        /// </summary>
        public SignInFrequencySessionControl() : base()
        {
            OdataType = "#microsoft.graph.signInFrequencySessionControl";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SignInFrequencySessionControl"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.SignInFrequencySessionControl CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.SignInFrequencySessionControl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationType", n => { AuthenticationType = n.GetEnumValue<global::ApiSdk.Models.SignInFrequencyAuthenticationType>(); } },
                { "frequencyInterval", n => { FrequencyInterval = n.GetEnumValue<global::ApiSdk.Models.SignInFrequencyInterval>(); } },
                { "type", n => { Type = n.GetEnumValue<global::ApiSdk.Models.SigninFrequencyType>(); } },
                { "value", n => { Value = n.GetIntValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.SignInFrequencyAuthenticationType>("authenticationType", AuthenticationType);
            writer.WriteEnumValue<global::ApiSdk.Models.SignInFrequencyInterval>("frequencyInterval", FrequencyInterval);
            writer.WriteEnumValue<global::ApiSdk.Models.SigninFrequencyType>("type", Type);
            writer.WriteIntValue("value", Value);
        }
    }
}
#pragma warning restore CS0618
