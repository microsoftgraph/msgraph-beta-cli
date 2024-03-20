// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PrivilegeEscalationFinding : Finding, IParsable 
    {
        /// <summary>The identity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemIdentity? Identity { get; set; }
#nullable restore
#else
        public AuthorizationSystemIdentity Identity { get; set; }
#endif
        /// <summary>An identity&apos;s information details. Inherited from finding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentityDetails? IdentityDetails { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentityDetails IdentityDetails { get; set; }
#endif
        /// <summary>The permissionsCreepIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PermissionsCreepIndex? PermissionsCreepIndex { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PermissionsCreepIndex PermissionsCreepIndex { get; set; }
#endif
        /// <summary>The list of escalations that the identity is capable of performing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrivilegeEscalation>? PrivilegeEscalationDetails { get; set; }
#nullable restore
#else
        public List<PrivilegeEscalation> PrivilegeEscalationDetails { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivilegeEscalationFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegeEscalationFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.privilegeEscalationAwsResourceFinding" => new PrivilegeEscalationAwsResourceFinding(),
                "#microsoft.graph.privilegeEscalationAwsRoleFinding" => new PrivilegeEscalationAwsRoleFinding(),
                "#microsoft.graph.privilegeEscalationGcpServiceAccountFinding" => new PrivilegeEscalationGcpServiceAccountFinding(),
                "#microsoft.graph.privilegeEscalationUserFinding" => new PrivilegeEscalationUserFinding(),
                _ => new PrivilegeEscalationFinding(),
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
                {"identity", n => { Identity = n.GetObjectValue<AuthorizationSystemIdentity>(AuthorizationSystemIdentity.CreateFromDiscriminatorValue); } },
                {"identityDetails", n => { IdentityDetails = n.GetObjectValue<ApiSdk.Models.IdentityDetails>(ApiSdk.Models.IdentityDetails.CreateFromDiscriminatorValue); } },
                {"permissionsCreepIndex", n => { PermissionsCreepIndex = n.GetObjectValue<ApiSdk.Models.PermissionsCreepIndex>(ApiSdk.Models.PermissionsCreepIndex.CreateFromDiscriminatorValue); } },
                {"privilegeEscalationDetails", n => { PrivilegeEscalationDetails = n.GetCollectionOfObjectValues<PrivilegeEscalation>(PrivilegeEscalation.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<AuthorizationSystemIdentity>("identity", Identity);
            writer.WriteObjectValue<ApiSdk.Models.IdentityDetails>("identityDetails", IdentityDetails);
            writer.WriteObjectValue<ApiSdk.Models.PermissionsCreepIndex>("permissionsCreepIndex", PermissionsCreepIndex);
            writer.WriteCollectionOfObjectValues<PrivilegeEscalation>("privilegeEscalationDetails", PrivilegeEscalationDetails);
        }
    }
}