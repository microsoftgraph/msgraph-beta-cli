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
    public partial class DirectoryObject1 : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Conceptual container for user and group directory objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AdministrativeUnit>? AdministrativeUnits { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AdministrativeUnit> AdministrativeUnits { get; set; }
#endif
        /// <summary>Group of related custom security attribute definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AttributeSet>? AttributeSets { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AttributeSet> AttributeSets { get; set; }
#endif
        /// <summary>Exposes the hardware OATH method in the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuthenticationMethodDevice? AuthenticationMethodDevices { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuthenticationMethodDevice AuthenticationMethodDevices { get; set; }
#endif
        /// <summary>Container for certificate authorities-related configurations for applications in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CertificateAuthorityPath? CertificateAuthorities { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CertificateAuthorityPath CertificateAuthorities { get; set; }
#endif
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CustomSecurityAttributeDefinition>? CustomSecurityAttributeDefinitions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions { get; set; }
#endif
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DirectoryObject>? DeletedItems { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DirectoryObject> DeletedItems { get; set; }
#endif
        /// <summary>The credentials of the device&apos;s local administrator account backed up to Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceLocalCredentialInfo>? DeviceLocalCredentials { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceLocalCredentialInfo> DeviceLocalCredentials { get; set; }
#endif
        /// <summary>Collection of external user profiles that represent collaborators in the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ExternalUserProfile>? ExternalUserProfiles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ExternalUserProfile> ExternalUserProfiles { get; set; }
#endif
        /// <summary>The featureRolloutPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.FeatureRolloutPolicy>? FeatureRolloutPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
#endif
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IdentityProviderBase>? FederationConfigurations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IdentityProviderBase> FederationConfigurations { get; set; }
#endif
        /// <summary>The impactedResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ImpactedResource>? ImpactedResources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ImpactedResource> ImpactedResources { get; set; }
#endif
        /// <summary>A collection of external users whose profile data is shared with the Microsoft Entra tenant. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.InboundSharedUserProfile>? InboundSharedUserProfiles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.InboundSharedUserProfile> InboundSharedUserProfiles { get; set; }
#endif
        /// <summary>A container for on-premises directory synchronization functionalities that are available for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.OnPremisesDirectorySynchronization>? OnPremisesSynchronization { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.OnPremisesDirectorySynchronization> OnPremisesSynchronization { get; set; }
#endif
        /// <summary>The outboundSharedUserProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.OutboundSharedUserProfile>? OutboundSharedUserProfiles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.OutboundSharedUserProfile> OutboundSharedUserProfiles { get; set; }
#endif
        /// <summary>Collection of pending external user profiles representing collaborators in the directory that are unredeemed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PendingExternalUserProfile>? PendingExternalUserProfiles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PendingExternalUserProfile> PendingExternalUserProfiles { get; set; }
#endif
        /// <summary>The collection of public key infrastructure instances for the certificate-based authentication feature for users in a Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PublicKeyInfrastructureRoot? PublicKeyInfrastructure { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PublicKeyInfrastructureRoot PublicKeyInfrastructure { get; set; }
#endif
        /// <summary>List of recommended improvements to improve tenant posture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Recommendation>? Recommendations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Recommendation> Recommendations { get; set; }
#endif
        /// <summary>The sharedEmailDomains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SharedEmailDomain>? SharedEmailDomains { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SharedEmailDomain> SharedEmailDomains { get; set; }
#endif
        /// <summary>List of commercial subscriptions that an organization has.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CompanySubscription>? Subscriptions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CompanySubscription> Subscriptions { get; set; }
#endif
        /// <summary>A container for templates, such as device templates used for onboarding devices in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Template? Templates { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Template Templates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DirectoryObject1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DirectoryObject1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DirectoryObject1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AdministrativeUnit>(global::ApiSdk.Models.AdministrativeUnit.CreateFromDiscriminatorValue)?.AsList(); } },
                { "attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AttributeSet>(global::ApiSdk.Models.AttributeSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authenticationMethodDevices", n => { AuthenticationMethodDevices = n.GetObjectValue<global::ApiSdk.Models.AuthenticationMethodDevice>(global::ApiSdk.Models.AuthenticationMethodDevice.CreateFromDiscriminatorValue); } },
                { "certificateAuthorities", n => { CertificateAuthorities = n.GetObjectValue<global::ApiSdk.Models.CertificateAuthorityPath>(global::ApiSdk.Models.CertificateAuthorityPath.CreateFromDiscriminatorValue); } },
                { "customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CustomSecurityAttributeDefinition>(global::ApiSdk.Models.CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DirectoryObject>(global::ApiSdk.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceLocalCredentials", n => { DeviceLocalCredentials = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceLocalCredentialInfo>(global::ApiSdk.Models.DeviceLocalCredentialInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "externalUserProfiles", n => { ExternalUserProfiles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ExternalUserProfile>(global::ApiSdk.Models.ExternalUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.FeatureRolloutPolicy>(global::ApiSdk.Models.FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IdentityProviderBase>(global::ApiSdk.Models.IdentityProviderBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ImpactedResource>(global::ApiSdk.Models.ImpactedResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "inboundSharedUserProfiles", n => { InboundSharedUserProfiles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.InboundSharedUserProfile>(global::ApiSdk.Models.InboundSharedUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onPremisesSynchronization", n => { OnPremisesSynchronization = n.GetCollectionOfObjectValues<global::ApiSdk.Models.OnPremisesDirectorySynchronization>(global::ApiSdk.Models.OnPremisesDirectorySynchronization.CreateFromDiscriminatorValue)?.AsList(); } },
                { "outboundSharedUserProfiles", n => { OutboundSharedUserProfiles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.OutboundSharedUserProfile>(global::ApiSdk.Models.OutboundSharedUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pendingExternalUserProfiles", n => { PendingExternalUserProfiles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PendingExternalUserProfile>(global::ApiSdk.Models.PendingExternalUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "publicKeyInfrastructure", n => { PublicKeyInfrastructure = n.GetObjectValue<global::ApiSdk.Models.PublicKeyInfrastructureRoot>(global::ApiSdk.Models.PublicKeyInfrastructureRoot.CreateFromDiscriminatorValue); } },
                { "recommendations", n => { Recommendations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Recommendation>(global::ApiSdk.Models.Recommendation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sharedEmailDomains", n => { SharedEmailDomains = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SharedEmailDomain>(global::ApiSdk.Models.SharedEmailDomain.CreateFromDiscriminatorValue)?.AsList(); } },
                { "subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CompanySubscription>(global::ApiSdk.Models.CompanySubscription.CreateFromDiscriminatorValue)?.AsList(); } },
                { "templates", n => { Templates = n.GetObjectValue<global::ApiSdk.Models.Template>(global::ApiSdk.Models.Template.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AttributeSet>("attributeSets", AttributeSets);
            writer.WriteObjectValue<global::ApiSdk.Models.AuthenticationMethodDevice>("authenticationMethodDevices", AuthenticationMethodDevices);
            writer.WriteObjectValue<global::ApiSdk.Models.CertificateAuthorityPath>("certificateAuthorities", CertificateAuthorities);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CustomSecurityAttributeDefinition>("customSecurityAttributeDefinitions", CustomSecurityAttributeDefinitions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceLocalCredentialInfo>("deviceLocalCredentials", DeviceLocalCredentials);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ExternalUserProfile>("externalUserProfiles", ExternalUserProfiles);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IdentityProviderBase>("federationConfigurations", FederationConfigurations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ImpactedResource>("impactedResources", ImpactedResources);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.InboundSharedUserProfile>("inboundSharedUserProfiles", InboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.OnPremisesDirectorySynchronization>("onPremisesSynchronization", OnPremisesSynchronization);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.OutboundSharedUserProfile>("outboundSharedUserProfiles", OutboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PendingExternalUserProfile>("pendingExternalUserProfiles", PendingExternalUserProfiles);
            writer.WriteObjectValue<global::ApiSdk.Models.PublicKeyInfrastructureRoot>("publicKeyInfrastructure", PublicKeyInfrastructure);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Recommendation>("recommendations", Recommendations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SharedEmailDomain>("sharedEmailDomains", SharedEmailDomains);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CompanySubscription>("subscriptions", Subscriptions);
            writer.WriteObjectValue<global::ApiSdk.Models.Template>("templates", Templates);
        }
    }
}
#pragma warning restore CS0618
