// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CustomClaimsPolicy : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If specified, it overrides the content of the audience claim for WS-Federation and SAML2 protocols. A custom signing key must be used for audienceOverride to be applied, otherwise, the audienceOverride value is ignored. The value provided must be in the format of an absolute URI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudienceOverride { get; set; }
#nullable restore
#else
        public string AudienceOverride { get; set; }
#endif
        /// <summary>Defines which claims are present in the tokens affected by the policy, in addition to the basic claim and the core claim set. Inherited from customclaimbase.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomClaimBase>? Claims { get; set; }
#nullable restore
#else
        public List<CustomClaimBase> Claims { get; set; }
#endif
        /// <summary>Indicates whether the application ID is added to the claim. It is relevant only for SAML2.0 and if a custom signing key is used. the default value is true. Optional.</summary>
        public bool? IncludeApplicationIdInIssuer { get; set; }
        /// <summary>Determines whether the basic claim set is included in tokens affected by this policy. If set to true, all claims in the basic claim set are emitted in tokens affected by the policy. By default the basic claim set isn&apos;t in the tokens unless they&apos;re explicitly configured in this policy.</summary>
        public bool? IncludeBasicClaimSet { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomClaimsPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomClaimsPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomClaimsPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audienceOverride", n => { AudienceOverride = n.GetStringValue(); } },
                { "claims", n => { Claims = n.GetCollectionOfObjectValues<CustomClaimBase>(CustomClaimBase.CreateFromDiscriminatorValue)?.ToList(); } },
                { "includeApplicationIdInIssuer", n => { IncludeApplicationIdInIssuer = n.GetBoolValue(); } },
                { "includeBasicClaimSet", n => { IncludeBasicClaimSet = n.GetBoolValue(); } },
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
            writer.WriteStringValue("audienceOverride", AudienceOverride);
            writer.WriteCollectionOfObjectValues<CustomClaimBase>("claims", Claims);
            writer.WriteBoolValue("includeApplicationIdInIssuer", IncludeApplicationIdInIssuer);
            writer.WriteBoolValue("includeBasicClaimSet", IncludeBasicClaimSet);
        }
    }
}