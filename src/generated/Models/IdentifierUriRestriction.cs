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
    public partial class IdentifierUriRestriction : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Collection of custom security attribute exemptions. If an actor user or service principal has the custom security attribute, they&apos;re exempted from the restriction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AppManagementPolicyActorExemptions? ExcludeActors { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AppManagementPolicyActorExemptions ExcludeActors { get; set; }
#endif
        /// <summary>If true, the restriction isn&apos;t enforced for applications that are configured to receive V2 tokens in Microsoft Entra ID; else, the restriction isn&apos;t enforced for those applications.</summary>
        public bool? ExcludeAppsReceivingV2Tokens { get; set; }
        /// <summary>If true, the restriction isn&apos;t enforced for SAML applications in Microsoft Entra ID; else, the restriction is enforced for those applications.</summary>
        public bool? ExcludeSaml { get; set; }
        /// <summary>If true, Microsoft sets the identifierUriRestriction state. If false, the tenant modifies the identifierUriRestriction state. Read-only.</summary>
        public bool? IsStateSetByMicrosoft { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies the date from which the policy restriction applies to newly created applications. For existing applications, the enforcement date can be retroactively applied.</summary>
        public DateTimeOffset? RestrictForAppsCreatedAfterDateTime { get; set; }
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.AppManagementRestrictionState? State { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.IdentifierUriRestriction"/> and sets the default values.
        /// </summary>
        public IdentifierUriRestriction()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IdentifierUriRestriction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.IdentifierUriRestriction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.IdentifierUriRestriction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "excludeActors", n => { ExcludeActors = n.GetObjectValue<global::ApiSdk.Models.AppManagementPolicyActorExemptions>(global::ApiSdk.Models.AppManagementPolicyActorExemptions.CreateFromDiscriminatorValue); } },
                { "excludeAppsReceivingV2Tokens", n => { ExcludeAppsReceivingV2Tokens = n.GetBoolValue(); } },
                { "excludeSaml", n => { ExcludeSaml = n.GetBoolValue(); } },
                { "isStateSetByMicrosoft", n => { IsStateSetByMicrosoft = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "restrictForAppsCreatedAfterDateTime", n => { RestrictForAppsCreatedAfterDateTime = n.GetDateTimeOffsetValue(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.AppManagementRestrictionState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.AppManagementPolicyActorExemptions>("excludeActors", ExcludeActors);
            writer.WriteBoolValue("excludeAppsReceivingV2Tokens", ExcludeAppsReceivingV2Tokens);
            writer.WriteBoolValue("excludeSaml", ExcludeSaml);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("restrictForAppsCreatedAfterDateTime", RestrictForAppsCreatedAfterDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.AppManagementRestrictionState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
