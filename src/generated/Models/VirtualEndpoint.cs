// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class VirtualEndpoint : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Cloud PC audit event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcAuditEvent>? AuditEvents { get; set; }
#nullable restore
#else
        public List<CloudPcAuditEvent> AuditEvents { get; set; }
#endif
        /// <summary>Bulk actions applied to a Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcBulkAction>? BulkActions { get; set; }
#nullable restore
#else
        public List<CloudPcBulkAction> BulkActions { get; set; }
#endif
        /// <summary>Cloud managed virtual desktops.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPC>? CloudPCs { get; set; }
#nullable restore
#else
        public List<CloudPC> CloudPCs { get; set; }
#endif
        /// <summary>Cloud PC organization mapping between public and US Government Community Cloud (GCC) organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcCrossCloudGovernmentOrganizationMapping? CrossCloudGovernmentOrganizationMapping { get; set; }
#nullable restore
#else
        public CloudPcCrossCloudGovernmentOrganizationMapping CrossCloudGovernmentOrganizationMapping { get; set; }
#endif
        /// <summary>The image resource on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcDeviceImage>? DeviceImages { get; set; }
#nullable restore
#else
        public List<CloudPcDeviceImage> DeviceImages { get; set; }
#endif
        /// <summary>The external partner settings on a Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcExternalPartnerSetting>? ExternalPartnerSettings { get; set; }
#nullable restore
#else
        public List<CloudPcExternalPartnerSetting> ExternalPartnerSettings { get; set; }
#endif
        /// <summary>Front-line service plans for a Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcFrontLineServicePlan>? FrontLineServicePlans { get; set; }
#nullable restore
#else
        public List<CloudPcFrontLineServicePlan> FrontLineServicePlans { get; set; }
#endif
        /// <summary>The gallery image resource on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcGalleryImage>? GalleryImages { get; set; }
#nullable restore
#else
        public List<CloudPcGalleryImage> GalleryImages { get; set; }
#endif
        /// <summary>A defined collection of Azure resource information that can be used to establish on-premises network connectivity for Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcOnPremisesConnection>? OnPremisesConnections { get; set; }
#nullable restore
#else
        public List<CloudPcOnPremisesConnection> OnPremisesConnections { get; set; }
#endif
        /// <summary>The Cloud PC organization settings for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcOrganizationSettings? OrganizationSettings { get; set; }
#nullable restore
#else
        public CloudPcOrganizationSettings OrganizationSettings { get; set; }
#endif
        /// <summary>Cloud PC provisioning policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcProvisioningPolicy>? ProvisioningPolicies { get; set; }
#nullable restore
#else
        public List<CloudPcProvisioningPolicy> ProvisioningPolicies { get; set; }
#endif
        /// <summary>Cloud PC related reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcReports? Reports { get; set; }
#nullable restore
#else
        public CloudPcReports Reports { get; set; }
#endif
        /// <summary>Cloud PC service plans.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcServicePlan>? ServicePlans { get; set; }
#nullable restore
#else
        public List<CloudPcServicePlan> ServicePlans { get; set; }
#endif
        /// <summary>Cloud PC shared-use service plans. The sharedUseServicePlans relationship is deprecated and stopped returning data on October 8, 2023. Going forward, use the frontLineServicePlans relationship.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcSharedUseServicePlan>? SharedUseServicePlans { get; set; }
#nullable restore
#else
        public List<CloudPcSharedUseServicePlan> SharedUseServicePlans { get; set; }
#endif
        /// <summary>Cloud PC snapshots.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcSnapshot>? Snapshots { get; set; }
#nullable restore
#else
        public List<CloudPcSnapshot> Snapshots { get; set; }
#endif
        /// <summary>Cloud PC supported regions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcSupportedRegion>? SupportedRegions { get; set; }
#nullable restore
#else
        public List<CloudPcSupportedRegion> SupportedRegions { get; set; }
#endif
        /// <summary>Cloud PC user settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcUserSetting>? UserSettings { get; set; }
#nullable restore
#else
        public List<CloudPcUserSetting> UserSettings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VirtualEndpoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEndpoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<CloudPcAuditEvent>(CloudPcAuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                { "bulkActions", n => { BulkActions = n.GetCollectionOfObjectValues<CloudPcBulkAction>(CloudPcBulkAction.CreateFromDiscriminatorValue)?.ToList(); } },
                { "cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<CloudPC>(CloudPC.CreateFromDiscriminatorValue)?.ToList(); } },
                { "crossCloudGovernmentOrganizationMapping", n => { CrossCloudGovernmentOrganizationMapping = n.GetObjectValue<CloudPcCrossCloudGovernmentOrganizationMapping>(CloudPcCrossCloudGovernmentOrganizationMapping.CreateFromDiscriminatorValue); } },
                { "deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<CloudPcDeviceImage>(CloudPcDeviceImage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "externalPartnerSettings", n => { ExternalPartnerSettings = n.GetCollectionOfObjectValues<CloudPcExternalPartnerSetting>(CloudPcExternalPartnerSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                { "frontLineServicePlans", n => { FrontLineServicePlans = n.GetCollectionOfObjectValues<CloudPcFrontLineServicePlan>(CloudPcFrontLineServicePlan.CreateFromDiscriminatorValue)?.ToList(); } },
                { "galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<CloudPcGalleryImage>(CloudPcGalleryImage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnection>(CloudPcOnPremisesConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                { "organizationSettings", n => { OrganizationSettings = n.GetObjectValue<CloudPcOrganizationSettings>(CloudPcOrganizationSettings.CreateFromDiscriminatorValue); } },
                { "provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicy>(CloudPcProvisioningPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                { "reports", n => { Reports = n.GetObjectValue<CloudPcReports>(CloudPcReports.CreateFromDiscriminatorValue); } },
                { "servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<CloudPcServicePlan>(CloudPcServicePlan.CreateFromDiscriminatorValue)?.ToList(); } },
                { "sharedUseServicePlans", n => { SharedUseServicePlans = n.GetCollectionOfObjectValues<CloudPcSharedUseServicePlan>(CloudPcSharedUseServicePlan.CreateFromDiscriminatorValue)?.ToList(); } },
                { "snapshots", n => { Snapshots = n.GetCollectionOfObjectValues<CloudPcSnapshot>(CloudPcSnapshot.CreateFromDiscriminatorValue)?.ToList(); } },
                { "supportedRegions", n => { SupportedRegions = n.GetCollectionOfObjectValues<CloudPcSupportedRegion>(CloudPcSupportedRegion.CreateFromDiscriminatorValue)?.ToList(); } },
                { "userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<CloudPcUserSetting>(CloudPcUserSetting.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<CloudPcAuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<CloudPcBulkAction>("bulkActions", BulkActions);
            writer.WriteCollectionOfObjectValues<CloudPC>("cloudPCs", CloudPCs);
            writer.WriteObjectValue<CloudPcCrossCloudGovernmentOrganizationMapping>("crossCloudGovernmentOrganizationMapping", CrossCloudGovernmentOrganizationMapping);
            writer.WriteCollectionOfObjectValues<CloudPcDeviceImage>("deviceImages", DeviceImages);
            writer.WriteCollectionOfObjectValues<CloudPcExternalPartnerSetting>("externalPartnerSettings", ExternalPartnerSettings);
            writer.WriteCollectionOfObjectValues<CloudPcFrontLineServicePlan>("frontLineServicePlans", FrontLineServicePlans);
            writer.WriteCollectionOfObjectValues<CloudPcGalleryImage>("galleryImages", GalleryImages);
            writer.WriteCollectionOfObjectValues<CloudPcOnPremisesConnection>("onPremisesConnections", OnPremisesConnections);
            writer.WriteObjectValue<CloudPcOrganizationSettings>("organizationSettings", OrganizationSettings);
            writer.WriteCollectionOfObjectValues<CloudPcProvisioningPolicy>("provisioningPolicies", ProvisioningPolicies);
            writer.WriteObjectValue<CloudPcReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<CloudPcServicePlan>("servicePlans", ServicePlans);
            writer.WriteCollectionOfObjectValues<CloudPcSharedUseServicePlan>("sharedUseServicePlans", SharedUseServicePlans);
            writer.WriteCollectionOfObjectValues<CloudPcSnapshot>("snapshots", Snapshots);
            writer.WriteCollectionOfObjectValues<CloudPcSupportedRegion>("supportedRegions", SupportedRegions);
            writer.WriteCollectionOfObjectValues<CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
