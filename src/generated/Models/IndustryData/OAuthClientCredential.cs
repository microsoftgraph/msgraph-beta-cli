// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OAuthClientCredential : global::ApiSdk.Models.IndustryData.Credential, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The client identifier of the application that is authenticating.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>The client secret that is used to authenticate (write-only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientSecret { get; set; }
#nullable restore
#else
        public string ClientSecret { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.IndustryData.OAuthClientCredential"/> and sets the default values.
        /// </summary>
        public OAuthClientCredential() : base()
        {
            OdataType = "#microsoft.graph.industryData.oAuthClientCredential";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IndustryData.OAuthClientCredential"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.IndustryData.OAuthClientCredential CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.industryData.oAuth1ClientCredential" => new global::ApiSdk.Models.IndustryData.OAuth1ClientCredential(),
                "#microsoft.graph.industryData.oAuth2ClientCredential" => new global::ApiSdk.Models.IndustryData.OAuth2ClientCredential(),
                _ => new global::ApiSdk.Models.IndustryData.OAuthClientCredential(),
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
                { "clientId", n => { ClientId = n.GetStringValue(); } },
                { "clientSecret", n => { ClientSecret = n.GetStringValue(); } },
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
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
        }
    }
}
#pragma warning restore CS0618
