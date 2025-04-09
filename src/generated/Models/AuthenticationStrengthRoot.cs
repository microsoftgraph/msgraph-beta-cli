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
    public partial class AuthenticationStrengthRoot : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of all valid authentication method combinations in the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AuthenticationMethodModes?>? AuthenticationCombinations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AuthenticationMethodModes?> AuthenticationCombinations { get; set; }
#endif
        /// <summary>Names and descriptions of all valid authentication method modes in the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AuthenticationMethodModeDetail>? AuthenticationMethodModes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AuthenticationMethodModeDetail> AuthenticationMethodModes { get; set; }
#endif
        /// <summary>The combinations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AuthenticationMethodModes?>? Combinations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AuthenticationMethodModes?> Combinations { get; set; }
#endif
        /// <summary>A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AuthenticationStrengthPolicy>? Policies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AuthenticationStrengthPolicy> Policies { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AuthenticationStrengthRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AuthenticationStrengthRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AuthenticationStrengthRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationCombinations", n => { AuthenticationCombinations = n.GetCollectionOfEnumValues<global::ApiSdk.Models.AuthenticationMethodModes>()?.AsList(); } },
                { "authenticationMethodModes", n => { AuthenticationMethodModes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationMethodModeDetail>(global::ApiSdk.Models.AuthenticationMethodModeDetail.CreateFromDiscriminatorValue)?.AsList(); } },
                { "combinations", n => { Combinations = n.GetCollectionOfEnumValues<global::ApiSdk.Models.AuthenticationMethodModes>()?.AsList(); } },
                { "policies", n => { Policies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationStrengthPolicy>(global::ApiSdk.Models.AuthenticationStrengthPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.AuthenticationMethodModes>("authenticationCombinations", AuthenticationCombinations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationMethodModeDetail>("authenticationMethodModes", AuthenticationMethodModes);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.AuthenticationMethodModes>("combinations", Combinations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationStrengthPolicy>("policies", Policies);
        }
    }
}
#pragma warning restore CS0618
