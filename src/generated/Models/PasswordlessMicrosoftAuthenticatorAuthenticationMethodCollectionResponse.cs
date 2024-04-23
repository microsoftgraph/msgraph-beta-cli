// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PasswordlessMicrosoftAuthenticatorAuthenticationMethodCollectionResponse : BaseCollectionPaginationCountResponse, IParsable 
    {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>? Value { get; set; }
#nullable restore
#else
        public List<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PasswordlessMicrosoftAuthenticatorAuthenticationMethodCollectionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PasswordlessMicrosoftAuthenticatorAuthenticationMethodCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordlessMicrosoftAuthenticatorAuthenticationMethodCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"value", n => { Value = n.GetCollectionOfObjectValues<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>(PasswordlessMicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>("value", Value);
        }
    }
}