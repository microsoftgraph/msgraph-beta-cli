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
    public partial class IdentityUserFlowAttributeAssignment : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the identityUserFlowAttribute within a user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Determines whether the identityUserFlowAttribute is optional. true means the user doesn&apos;t have to provide a value. false means the user can&apos;t complete sign-up without providing a value.</summary>
        public bool? IsOptional { get; set; }
        /// <summary>Determines whether the identityUserFlowAttribute requires verification. This is only used for verifying the user&apos;s phone number or email address.</summary>
        public bool? RequiresVerification { get; set; }
        /// <summary>The user attribute that you want to add to your user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentityUserFlowAttribute? UserAttribute { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentityUserFlowAttribute UserAttribute { get; set; }
#endif
        /// <summary>The input options for the user flow attribute. Only applicable when the userInputType is radioSingleSelect, dropdownSingleSelect, or checkboxMultiSelect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UserAttributeValuesItem>? UserAttributeValues { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UserAttributeValuesItem> UserAttributeValues { get; set; }
#endif
        /// <summary>The userInputType property</summary>
        public global::ApiSdk.Models.IdentityUserFlowAttributeInputType? UserInputType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IdentityUserFlowAttributeAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.IdentityUserFlowAttributeAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.IdentityUserFlowAttributeAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isOptional", n => { IsOptional = n.GetBoolValue(); } },
                { "requiresVerification", n => { RequiresVerification = n.GetBoolValue(); } },
                { "userAttribute", n => { UserAttribute = n.GetObjectValue<global::ApiSdk.Models.IdentityUserFlowAttribute>(global::ApiSdk.Models.IdentityUserFlowAttribute.CreateFromDiscriminatorValue); } },
                { "userAttributeValues", n => { UserAttributeValues = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UserAttributeValuesItem>(global::ApiSdk.Models.UserAttributeValuesItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userInputType", n => { UserInputType = n.GetEnumValue<global::ApiSdk.Models.IdentityUserFlowAttributeInputType>(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteBoolValue("requiresVerification", RequiresVerification);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentityUserFlowAttribute>("userAttribute", UserAttribute);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UserAttributeValuesItem>("userAttributeValues", UserAttributeValues);
            writer.WriteEnumValue<global::ApiSdk.Models.IdentityUserFlowAttributeInputType>("userInputType", UserInputType);
        }
    }
}
#pragma warning restore CS0618
