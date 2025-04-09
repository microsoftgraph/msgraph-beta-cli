// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AlertEvidence : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time when the evidence was created and added to the alert. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Detailed description of the entity role/s in an alert. Values are free-form.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DetailedRoles { get; set; }
#nullable restore
#else
        public List<string> DetailedRoles { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The remediationStatus property</summary>
        public global::ApiSdk.Models.Security.EvidenceRemediationStatus? RemediationStatus { get; set; }
        /// <summary>Details about the remediation status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationStatusDetails { get; set; }
#nullable restore
#else
        public string RemediationStatusDetails { get; set; }
#endif
        /// <summary>The role/s that an evidence entity represents in an alert, for example, an IP address that is associated with an attacker has the evidence role Attacker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.EvidenceRole?>? Roles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.EvidenceRole?> Roles { get; set; }
#endif
        /// <summary>Array of custom tags associated with an evidence instance, for example, to denote a group of devices, high-value assets, etc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The verdict property</summary>
        public global::ApiSdk.Models.Security.EvidenceVerdict? Verdict { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Security.AlertEvidence"/> and sets the default values.
        /// </summary>
        public AlertEvidence()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.AlertEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Security.AlertEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.amazonResourceEvidence" => new global::ApiSdk.Models.Security.AmazonResourceEvidence(),
                "#microsoft.graph.security.analyzedMessageEvidence" => new global::ApiSdk.Models.Security.AnalyzedMessageEvidence(),
                "#microsoft.graph.security.azureResourceEvidence" => new global::ApiSdk.Models.Security.AzureResourceEvidence(),
                "#microsoft.graph.security.blobContainerEvidence" => new global::ApiSdk.Models.Security.BlobContainerEvidence(),
                "#microsoft.graph.security.blobEvidence" => new global::ApiSdk.Models.Security.BlobEvidence(),
                "#microsoft.graph.security.cloudApplicationEvidence" => new global::ApiSdk.Models.Security.CloudApplicationEvidence(),
                "#microsoft.graph.security.cloudLogonRequestEvidence" => new global::ApiSdk.Models.Security.CloudLogonRequestEvidence(),
                "#microsoft.graph.security.cloudLogonSessionEvidence" => new global::ApiSdk.Models.Security.CloudLogonSessionEvidence(),
                "#microsoft.graph.security.containerEvidence" => new global::ApiSdk.Models.Security.ContainerEvidence(),
                "#microsoft.graph.security.containerImageEvidence" => new global::ApiSdk.Models.Security.ContainerImageEvidence(),
                "#microsoft.graph.security.containerRegistryEvidence" => new global::ApiSdk.Models.Security.ContainerRegistryEvidence(),
                "#microsoft.graph.security.deviceEvidence" => new global::ApiSdk.Models.Security.DeviceEvidence(),
                "#microsoft.graph.security.dnsEvidence" => new global::ApiSdk.Models.Security.DnsEvidence(),
                "#microsoft.graph.security.fileEvidence" => new global::ApiSdk.Models.Security.FileEvidence(),
                "#microsoft.graph.security.fileHashEvidence" => new global::ApiSdk.Models.Security.FileHashEvidence(),
                "#microsoft.graph.security.gitHubOrganizationEvidence" => new global::ApiSdk.Models.Security.GitHubOrganizationEvidence(),
                "#microsoft.graph.security.gitHubRepoEvidence" => new global::ApiSdk.Models.Security.GitHubRepoEvidence(),
                "#microsoft.graph.security.gitHubUserEvidence" => new global::ApiSdk.Models.Security.GitHubUserEvidence(),
                "#microsoft.graph.security.googleCloudResourceEvidence" => new global::ApiSdk.Models.Security.GoogleCloudResourceEvidence(),
                "#microsoft.graph.security.hostLogonSessionEvidence" => new global::ApiSdk.Models.Security.HostLogonSessionEvidence(),
                "#microsoft.graph.security.ioTDeviceEvidence" => new global::ApiSdk.Models.Security.IoTDeviceEvidence(),
                "#microsoft.graph.security.ipEvidence" => new global::ApiSdk.Models.Security.IpEvidence(),
                "#microsoft.graph.security.kubernetesClusterEvidence" => new global::ApiSdk.Models.Security.KubernetesClusterEvidence(),
                "#microsoft.graph.security.kubernetesControllerEvidence" => new global::ApiSdk.Models.Security.KubernetesControllerEvidence(),
                "#microsoft.graph.security.kubernetesNamespaceEvidence" => new global::ApiSdk.Models.Security.KubernetesNamespaceEvidence(),
                "#microsoft.graph.security.kubernetesPodEvidence" => new global::ApiSdk.Models.Security.KubernetesPodEvidence(),
                "#microsoft.graph.security.kubernetesSecretEvidence" => new global::ApiSdk.Models.Security.KubernetesSecretEvidence(),
                "#microsoft.graph.security.kubernetesServiceAccountEvidence" => new global::ApiSdk.Models.Security.KubernetesServiceAccountEvidence(),
                "#microsoft.graph.security.kubernetesServiceEvidence" => new global::ApiSdk.Models.Security.KubernetesServiceEvidence(),
                "#microsoft.graph.security.mailboxConfigurationEvidence" => new global::ApiSdk.Models.Security.MailboxConfigurationEvidence(),
                "#microsoft.graph.security.mailboxEvidence" => new global::ApiSdk.Models.Security.MailboxEvidence(),
                "#microsoft.graph.security.mailClusterEvidence" => new global::ApiSdk.Models.Security.MailClusterEvidence(),
                "#microsoft.graph.security.malwareEvidence" => new global::ApiSdk.Models.Security.MalwareEvidence(),
                "#microsoft.graph.security.networkConnectionEvidence" => new global::ApiSdk.Models.Security.NetworkConnectionEvidence(),
                "#microsoft.graph.security.nicEvidence" => new global::ApiSdk.Models.Security.NicEvidence(),
                "#microsoft.graph.security.oauthApplicationEvidence" => new global::ApiSdk.Models.Security.OauthApplicationEvidence(),
                "#microsoft.graph.security.processEvidence" => new global::ApiSdk.Models.Security.ProcessEvidence(),
                "#microsoft.graph.security.registryKeyEvidence" => new global::ApiSdk.Models.Security.RegistryKeyEvidence(),
                "#microsoft.graph.security.registryValueEvidence" => new global::ApiSdk.Models.Security.RegistryValueEvidence(),
                "#microsoft.graph.security.sasTokenEvidence" => new global::ApiSdk.Models.Security.SasTokenEvidence(),
                "#microsoft.graph.security.securityGroupEvidence" => new global::ApiSdk.Models.Security.SecurityGroupEvidence(),
                "#microsoft.graph.security.servicePrincipalEvidence" => new global::ApiSdk.Models.Security.ServicePrincipalEvidence(),
                "#microsoft.graph.security.submissionMailEvidence" => new global::ApiSdk.Models.Security.SubmissionMailEvidence(),
                "#microsoft.graph.security.teamsMessageEvidence" => new global::ApiSdk.Models.Security.TeamsMessageEvidence(),
                "#microsoft.graph.security.urlEvidence" => new global::ApiSdk.Models.Security.UrlEvidence(),
                "#microsoft.graph.security.userEvidence" => new global::ApiSdk.Models.Security.UserEvidence(),
                _ => new global::ApiSdk.Models.Security.AlertEvidence(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "detailedRoles", n => { DetailedRoles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "remediationStatus", n => { RemediationStatus = n.GetEnumValue<global::ApiSdk.Models.Security.EvidenceRemediationStatus>(); } },
                { "remediationStatusDetails", n => { RemediationStatusDetails = n.GetStringValue(); } },
                { "roles", n => { Roles = n.GetCollectionOfEnumValues<global::ApiSdk.Models.Security.EvidenceRole>()?.AsList(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "verdict", n => { Verdict = n.GetEnumValue<global::ApiSdk.Models.Security.EvidenceVerdict>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("detailedRoles", DetailedRoles);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.EvidenceRemediationStatus>("remediationStatus", RemediationStatus);
            writer.WriteStringValue("remediationStatusDetails", RemediationStatusDetails);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.Security.EvidenceRole>("roles", Roles);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.EvidenceVerdict>("verdict", Verdict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
