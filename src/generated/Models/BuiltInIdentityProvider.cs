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
    public partial class BuiltInIdentityProvider : global::ApiSdk.Models.IdentityProviderBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identity provider type. For a B2B scenario, possible values: AADSignup, MicrosoftAccount, EmailOTP. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProviderType { get; set; }
#nullable restore
#else
        public string IdentityProviderType { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.IdentityProviderState? State { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.BuiltInIdentityProvider"/> and sets the default values.
        /// </summary>
        public BuiltInIdentityProvider() : base()
        {
            OdataType = "#microsoft.graph.builtInIdentityProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.BuiltInIdentityProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.BuiltInIdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.BuiltInIdentityProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "identityProviderType", n => { IdentityProviderType = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.IdentityProviderState>(); } },
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
            writer.WriteStringValue("identityProviderType", IdentityProviderType);
            writer.WriteEnumValue<global::ApiSdk.Models.IdentityProviderState>("state", State);
        }
    }
}
#pragma warning restore CS0618
