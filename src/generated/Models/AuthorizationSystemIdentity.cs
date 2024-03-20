// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AuthorizationSystemIdentity : Entity, IParsable 
    {
        /// <summary>Navigation to the authorizationSystem object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AuthorizationSystem? AuthorizationSystem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AuthorizationSystem AuthorizationSystem { get; set; }
#endif
        /// <summary>The name of the identity. Read-only. Supports $filter and (eq,contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Unique ID of the identity within the external system. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>Represents details of the source of the identity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemIdentitySource? Source { get; set; }
#nullable restore
#else
        public AuthorizationSystemIdentitySource Source { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AuthorizationSystemIdentity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthorizationSystemIdentity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.awsAccessKey" => new AwsAccessKey(),
                "#microsoft.graph.awsEc2Instance" => new AwsEc2Instance(),
                "#microsoft.graph.awsGroup" => new AwsGroup(),
                "#microsoft.graph.awsIdentity" => new AwsIdentity(),
                "#microsoft.graph.awsLambda" => new AwsLambda(),
                "#microsoft.graph.awsRole" => new AwsRole(),
                "#microsoft.graph.awsUser" => new AwsUser(),
                "#microsoft.graph.azureGroup" => new AzureGroup(),
                "#microsoft.graph.azureIdentity" => new AzureIdentity(),
                "#microsoft.graph.azureManagedIdentity" => new AzureManagedIdentity(),
                "#microsoft.graph.azureServerlessFunction" => new AzureServerlessFunction(),
                "#microsoft.graph.azureServicePrincipal" => new AzureServicePrincipal(),
                "#microsoft.graph.azureUser" => new AzureUser(),
                "#microsoft.graph.gcpCloudFunction" => new GcpCloudFunction(),
                "#microsoft.graph.gcpGroup" => new GcpGroup(),
                "#microsoft.graph.gcpIdentity" => new GcpIdentity(),
                "#microsoft.graph.gcpServiceAccount" => new GcpServiceAccount(),
                "#microsoft.graph.gcpUser" => new GcpUser(),
                _ => new AuthorizationSystemIdentity(),
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
                {"authorizationSystem", n => { AuthorizationSystem = n.GetObjectValue<ApiSdk.Models.AuthorizationSystem>(ApiSdk.Models.AuthorizationSystem.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"source", n => { Source = n.GetObjectValue<AuthorizationSystemIdentitySource>(AuthorizationSystemIdentitySource.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.AuthorizationSystem>("authorizationSystem", AuthorizationSystem);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<AuthorizationSystemIdentitySource>("source", Source);
        }
    }
}