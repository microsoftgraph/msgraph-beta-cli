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
    public partial class VirtualEndpoint : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Cloud PC audit event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcAuditEvent>? AuditEvents { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcAuditEvent> AuditEvents { get; set; }
#endif
        /// <summary>Bulk actions applied to a Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcBulkAction>? BulkActions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcBulkAction> BulkActions { get; set; }
#endif
        /// <summary>Cloud managed virtual desktops.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPC>? CloudPCs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPC> CloudPCs { get; set; }
#endif
        /// <summary>Cloud PC organization mapping between public and US Government Community Cloud (GCC) organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CloudPcCrossCloudGovernmentOrganizationMapping? CrossCloudGovernmentOrganizationMapping { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CloudPcCrossCloudGovernmentOrganizationMapping CrossCloudGovernmentOrganizationMapping { get; set; }
#endif
        /// <summary>The image resource on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcDeviceImage>? DeviceImages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcDeviceImage> DeviceImages { get; set; }
#endif
        /// <summary>The external partner settings on a Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcExternalPartnerSetting>? ExternalPartnerSettings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcExternalPartnerSetting> ExternalPartnerSettings { get; set; }
#endif
        /// <summary>Front-line service plans for a Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcFrontLineServicePlan>? FrontLineServicePlans { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcFrontLineServicePlan> FrontLineServicePlans { get; set; }
#endif
        /// <summary>The gallery image resource on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcGalleryImage>? GalleryImages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcGalleryImage> GalleryImages { get; set; }
#endif
        /// <summary>A defined collection of Azure resource information that can be used to establish on-premises network connectivity for Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcOnPremisesConnection>? OnPremisesConnections { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcOnPremisesConnection> OnPremisesConnections { get; set; }
#endif
        /// <summary>The Cloud PC organization settings for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CloudPcOrganizationSettings? OrganizationSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CloudPcOrganizationSettings OrganizationSettings { get; set; }
#endif
        /// <summary>Cloud PC provisioning policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcProvisioningPolicy>? ProvisioningPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcProvisioningPolicy> ProvisioningPolicies { get; set; }
#endif
        /// <summary>Cloud PC related reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CloudPcReports? Reports { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CloudPcReports Reports { get; set; }
#endif
        /// <summary>Cloud PC service plans.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcServicePlan>? ServicePlans { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcServicePlan> ServicePlans { get; set; }
#endif
        /// <summary>Cloud PC snapshots.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcSnapshot>? Snapshots { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcSnapshot> Snapshots { get; set; }
#endif
        /// <summary>Cloud PC supported regions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcSupportedRegion>? SupportedRegions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcSupportedRegion> SupportedRegions { get; set; }
#endif
        /// <summary>Cloud PC user settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcUserSetting>? UserSettings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcUserSetting> UserSettings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.VirtualEndpoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.VirtualEndpoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.VirtualEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcAuditEvent>(global::ApiSdk.Models.CloudPcAuditEvent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "bulkActions", n => { BulkActions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcBulkAction>(global::ApiSdk.Models.CloudPcBulkAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPC>(global::ApiSdk.Models.CloudPC.CreateFromDiscriminatorValue)?.AsList(); } },
                { "crossCloudGovernmentOrganizationMapping", n => { CrossCloudGovernmentOrganizationMapping = n.GetObjectValue<global::ApiSdk.Models.CloudPcCrossCloudGovernmentOrganizationMapping>(global::ApiSdk.Models.CloudPcCrossCloudGovernmentOrganizationMapping.CreateFromDiscriminatorValue); } },
                { "deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcDeviceImage>(global::ApiSdk.Models.CloudPcDeviceImage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "externalPartnerSettings", n => { ExternalPartnerSettings = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcExternalPartnerSetting>(global::ApiSdk.Models.CloudPcExternalPartnerSetting.CreateFromDiscriminatorValue)?.AsList(); } },
                { "frontLineServicePlans", n => { FrontLineServicePlans = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcFrontLineServicePlan>(global::ApiSdk.Models.CloudPcFrontLineServicePlan.CreateFromDiscriminatorValue)?.AsList(); } },
                { "galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcGalleryImage>(global::ApiSdk.Models.CloudPcGalleryImage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcOnPremisesConnection>(global::ApiSdk.Models.CloudPcOnPremisesConnection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "organizationSettings", n => { OrganizationSettings = n.GetObjectValue<global::ApiSdk.Models.CloudPcOrganizationSettings>(global::ApiSdk.Models.CloudPcOrganizationSettings.CreateFromDiscriminatorValue); } },
                { "provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcProvisioningPolicy>(global::ApiSdk.Models.CloudPcProvisioningPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "reports", n => { Reports = n.GetObjectValue<global::ApiSdk.Models.CloudPcReports>(global::ApiSdk.Models.CloudPcReports.CreateFromDiscriminatorValue); } },
                { "servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcServicePlan>(global::ApiSdk.Models.CloudPcServicePlan.CreateFromDiscriminatorValue)?.AsList(); } },
                { "snapshots", n => { Snapshots = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcSnapshot>(global::ApiSdk.Models.CloudPcSnapshot.CreateFromDiscriminatorValue)?.AsList(); } },
                { "supportedRegions", n => { SupportedRegions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcSupportedRegion>(global::ApiSdk.Models.CloudPcSupportedRegion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcUserSetting>(global::ApiSdk.Models.CloudPcUserSetting.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcAuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcBulkAction>("bulkActions", BulkActions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPC>("cloudPCs", CloudPCs);
            writer.WriteObjectValue<global::ApiSdk.Models.CloudPcCrossCloudGovernmentOrganizationMapping>("crossCloudGovernmentOrganizationMapping", CrossCloudGovernmentOrganizationMapping);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcDeviceImage>("deviceImages", DeviceImages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcExternalPartnerSetting>("externalPartnerSettings", ExternalPartnerSettings);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcFrontLineServicePlan>("frontLineServicePlans", FrontLineServicePlans);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcGalleryImage>("galleryImages", GalleryImages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcOnPremisesConnection>("onPremisesConnections", OnPremisesConnections);
            writer.WriteObjectValue<global::ApiSdk.Models.CloudPcOrganizationSettings>("organizationSettings", OrganizationSettings);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcProvisioningPolicy>("provisioningPolicies", ProvisioningPolicies);
            writer.WriteObjectValue<global::ApiSdk.Models.CloudPcReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcServicePlan>("servicePlans", ServicePlans);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcSnapshot>("snapshots", Snapshots);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcSupportedRegion>("supportedRegions", SupportedRegions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
#pragma warning restore CS0618
