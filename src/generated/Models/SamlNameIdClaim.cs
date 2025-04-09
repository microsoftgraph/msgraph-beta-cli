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
    public partial class SamlNameIdClaim : global::ApiSdk.Models.CustomClaimBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The nameIdFormat property</summary>
        public global::ApiSdk.Models.SamlNameIDFormat? NameIdFormat { get; set; }
        /// <summary>Allows the specification of a service provider name qualifier reflected in the sAML response. The value provided must match one of the service provider names configured for the application and is only applicable for IdP-initiated applications (the sign-on URL should be empty for the IdP-initiated applications), in all other cases this value is ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceProviderNameQualifier { get; set; }
#nullable restore
#else
        public string ServiceProviderNameQualifier { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SamlNameIdClaim"/> and sets the default values.
        /// </summary>
        public SamlNameIdClaim() : base()
        {
            OdataType = "#microsoft.graph.samlNameIdClaim";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SamlNameIdClaim"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.SamlNameIdClaim CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.SamlNameIdClaim();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "nameIdFormat", n => { NameIdFormat = n.GetEnumValue<global::ApiSdk.Models.SamlNameIDFormat>(); } },
                { "serviceProviderNameQualifier", n => { ServiceProviderNameQualifier = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.SamlNameIDFormat>("nameIdFormat", NameIdFormat);
            writer.WriteStringValue("serviceProviderNameQualifier", ServiceProviderNameQualifier);
        }
    }
}
#pragma warning restore CS0618
