// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AzureRoleDefinition : Entity, IParsable 
    {
        /// <summary>Scopes at which the Azure role can be assigned. For more information about common patterns, see Understand Azure role definitions: AssignableScopes. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssignableScopes { get; set; }
#nullable restore
#else
        public List<string> AssignableScopes { get; set; }
#endif
        /// <summary>The azureRoleDefinitionType property</summary>
        public ApiSdk.Models.AzureRoleDefinitionType? AzureRoleDefinitionType { get; set; }
        /// <summary>Name of the Azure role. Supports $filter (eq, contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Identifier of an Azure role defined by Microsoft Azure. Alternate key. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AzureRoleDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AzureRoleDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureRoleDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"assignableScopes", n => { AssignableScopes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"azureRoleDefinitionType", n => { AzureRoleDefinitionType = n.GetEnumValue<AzureRoleDefinitionType>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("assignableScopes", AssignableScopes);
            writer.WriteEnumValue<AzureRoleDefinitionType>("azureRoleDefinitionType", AzureRoleDefinitionType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
        }
    }
}