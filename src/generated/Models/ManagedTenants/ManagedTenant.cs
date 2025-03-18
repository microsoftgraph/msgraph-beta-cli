// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.ManagedTenants
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ManagedTenant : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Aggregate view of device compliance policies across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.AggregatedPolicyCompliance>? AggregatedPolicyCompliances { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.AggregatedPolicyCompliance> AggregatedPolicyCompliances { get; set; }
#endif
        /// <summary>The appPerformances property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.AppPerformance>? AppPerformances { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.AppPerformance> AppPerformances { get; set; }
#endif
        /// <summary>The collection of audit events across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.AuditEvent>? AuditEvents { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.AuditEvent> AuditEvents { get; set; }
#endif
        /// <summary>The collection of cloud PC connections across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.CloudPcConnection>? CloudPcConnections { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.CloudPcConnection> CloudPcConnections { get; set; }
#endif
        /// <summary>The collection of cloud PC devices across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.CloudPcDevice>? CloudPcDevices { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.CloudPcDevice> CloudPcDevices { get; set; }
#endif
        /// <summary>Overview of cloud PC information across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.CloudPcOverview>? CloudPcsOverview { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.CloudPcOverview> CloudPcsOverview { get; set; }
#endif
        /// <summary>Aggregate view of conditional access policy coverage across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ConditionalAccessPolicyCoverage>? ConditionalAccessPolicyCoverages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ConditionalAccessPolicyCoverage> ConditionalAccessPolicyCoverages { get; set; }
#endif
        /// <summary>Summary information for user registration for multi-factor authentication and self service password reset across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.CredentialUserRegistrationsSummary>? CredentialUserRegistrationsSummaries { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.CredentialUserRegistrationsSummary> CredentialUserRegistrationsSummaries { get; set; }
#endif
        /// <summary>The deviceAppPerformances property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.DeviceAppPerformance>? DeviceAppPerformances { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.DeviceAppPerformance> DeviceAppPerformances { get; set; }
#endif
        /// <summary>Summary information for device compliance policy setting states across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.DeviceCompliancePolicySettingStateSummary>? DeviceCompliancePolicySettingStateSummaries { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries { get; set; }
#endif
        /// <summary>The deviceHealthStatuses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.DeviceHealthStatus>? DeviceHealthStatuses { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.DeviceHealthStatus> DeviceHealthStatuses { get; set; }
#endif
        /// <summary>The collection of compliance for managed devices across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedDeviceCompliance>? ManagedDeviceCompliances { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedDeviceCompliance> ManagedDeviceCompliances { get; set; }
#endif
        /// <summary>Trend insights for device compliance across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedDeviceComplianceTrend>? ManagedDeviceComplianceTrends { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedDeviceComplianceTrend> ManagedDeviceComplianceTrends { get; set; }
#endif
        /// <summary>The managedTenantAlertLogs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog>? ManagedTenantAlertLogs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog> ManagedTenantAlertLogs { get; set; }
#endif
        /// <summary>The managedTenantAlertRuleDefinitions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRuleDefinition>? ManagedTenantAlertRuleDefinitions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRuleDefinition> ManagedTenantAlertRuleDefinitions { get; set; }
#endif
        /// <summary>The managedTenantAlertRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule>? ManagedTenantAlertRules { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule> ManagedTenantAlertRules { get; set; }
#endif
        /// <summary>The managedTenantAlerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert>? ManagedTenantAlerts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert> ManagedTenantAlerts { get; set; }
#endif
        /// <summary>The managedTenantApiNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification>? ManagedTenantApiNotifications { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification> ManagedTenantApiNotifications { get; set; }
#endif
        /// <summary>The managedTenantEmailNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification>? ManagedTenantEmailNotifications { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification> ManagedTenantEmailNotifications { get; set; }
#endif
        /// <summary>The managedTenantTicketingEndpoints property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantTicketingEndpoint>? ManagedTenantTicketingEndpoints { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagedTenantTicketingEndpoint> ManagedTenantTicketingEndpoints { get; set; }
#endif
        /// <summary>The collection of baseline management actions across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementAction>? ManagementActions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementAction> ManagementActions { get; set; }
#endif
        /// <summary>The tenant level status of management actions across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementActionTenantDeploymentStatus>? ManagementActionTenantDeploymentStatuses { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementActionTenantDeploymentStatus> ManagementActionTenantDeploymentStatuses { get; set; }
#endif
        /// <summary>The collection of baseline management intents across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementIntent>? ManagementIntents { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementIntent> ManagementIntents { get; set; }
#endif
        /// <summary>The managementTemplateCollections property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollection>? ManagementTemplateCollections { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollection> ManagementTemplateCollections { get; set; }
#endif
        /// <summary>The managementTemplateCollectionTenantSummaries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollectionTenantSummary>? ManagementTemplateCollectionTenantSummaries { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollectionTenantSummary> ManagementTemplateCollectionTenantSummaries { get; set; }
#endif
        /// <summary>The collection of baseline management templates across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplate>? ManagementTemplates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplate> ManagementTemplates { get; set; }
#endif
        /// <summary>The managementTemplateSteps property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStep>? ManagementTemplateSteps { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStep> ManagementTemplateSteps { get; set; }
#endif
        /// <summary>The managementTemplateStepTenantSummaries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepTenantSummary>? ManagementTemplateStepTenantSummaries { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepTenantSummary> ManagementTemplateStepTenantSummaries { get; set; }
#endif
        /// <summary>The managementTemplateStepVersions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepVersion>? ManagementTemplateStepVersions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepVersion> ManagementTemplateStepVersions { get; set; }
#endif
        /// <summary>The collection of role assignments to a signed-in user for a managed tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.MyRole>? MyRoles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.MyRole> MyRoles { get; set; }
#endif
        /// <summary>The collection of a logical grouping of managed tenants used by the multi-tenant management platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.TenantGroup>? TenantGroups { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.TenantGroup> TenantGroups { get; set; }
#endif
        /// <summary>The collection of tenants associated with the managing entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.Tenant>? Tenants { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.Tenant> Tenants { get; set; }
#endif
        /// <summary>The collection of tenant level customized information across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.TenantCustomizedInformation>? TenantsCustomizedInformation { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.TenantCustomizedInformation> TenantsCustomizedInformation { get; set; }
#endif
        /// <summary>The collection tenant level detailed information across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation>? TenantsDetailedInformation { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation> TenantsDetailedInformation { get; set; }
#endif
        /// <summary>The collection of tenant tags across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.TenantTag>? TenantTags { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.TenantTag> TenantTags { get; set; }
#endif
        /// <summary>The state of malware for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.WindowsDeviceMalwareState>? WindowsDeviceMalwareStates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.WindowsDeviceMalwareState> WindowsDeviceMalwareStates { get; set; }
#endif
        /// <summary>The protection state for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.WindowsProtectionState>? WindowsProtectionStates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.WindowsProtectionState> WindowsProtectionStates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedTenants.ManagedTenant"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ManagedTenants.ManagedTenant CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ManagedTenants.ManagedTenant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "aggregatedPolicyCompliances", n => { AggregatedPolicyCompliances = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AggregatedPolicyCompliance>(global::ApiSdk.Models.ManagedTenants.AggregatedPolicyCompliance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "appPerformances", n => { AppPerformances = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AppPerformance>(global::ApiSdk.Models.ManagedTenants.AppPerformance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AuditEvent>(global::ApiSdk.Models.ManagedTenants.AuditEvent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cloudPcConnections", n => { CloudPcConnections = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CloudPcConnection>(global::ApiSdk.Models.ManagedTenants.CloudPcConnection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cloudPcDevices", n => { CloudPcDevices = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CloudPcDevice>(global::ApiSdk.Models.ManagedTenants.CloudPcDevice.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cloudPcsOverview", n => { CloudPcsOverview = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CloudPcOverview>(global::ApiSdk.Models.ManagedTenants.CloudPcOverview.CreateFromDiscriminatorValue)?.AsList(); } },
                { "conditionalAccessPolicyCoverages", n => { ConditionalAccessPolicyCoverages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ConditionalAccessPolicyCoverage>(global::ApiSdk.Models.ManagedTenants.ConditionalAccessPolicyCoverage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "credentialUserRegistrationsSummaries", n => { CredentialUserRegistrationsSummaries = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CredentialUserRegistrationsSummary>(global::ApiSdk.Models.ManagedTenants.CredentialUserRegistrationsSummary.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceAppPerformances", n => { DeviceAppPerformances = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.DeviceAppPerformance>(global::ApiSdk.Models.ManagedTenants.DeviceAppPerformance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.DeviceCompliancePolicySettingStateSummary>(global::ApiSdk.Models.ManagedTenants.DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceHealthStatuses", n => { DeviceHealthStatuses = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.DeviceHealthStatus>(global::ApiSdk.Models.ManagedTenants.DeviceHealthStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedDeviceComplianceTrends", n => { ManagedDeviceComplianceTrends = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedDeviceComplianceTrend>(global::ApiSdk.Models.ManagedTenants.ManagedDeviceComplianceTrend.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedDeviceCompliances", n => { ManagedDeviceCompliances = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedDeviceCompliance>(global::ApiSdk.Models.ManagedTenants.ManagedDeviceCompliance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedTenantAlertLogs", n => { ManagedTenantAlertLogs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog>(global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedTenantAlertRuleDefinitions", n => { ManagedTenantAlertRuleDefinitions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRuleDefinition>(global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRuleDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedTenantAlertRules", n => { ManagedTenantAlertRules = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule>(global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedTenantAlerts", n => { ManagedTenantAlerts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert>(global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedTenantApiNotifications", n => { ManagedTenantApiNotifications = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification>(global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedTenantEmailNotifications", n => { ManagedTenantEmailNotifications = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification>(global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedTenantTicketingEndpoints", n => { ManagedTenantTicketingEndpoints = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantTicketingEndpoint>(global::ApiSdk.Models.ManagedTenants.ManagedTenantTicketingEndpoint.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementActionTenantDeploymentStatuses", n => { ManagementActionTenantDeploymentStatuses = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementActionTenantDeploymentStatus>(global::ApiSdk.Models.ManagedTenants.ManagementActionTenantDeploymentStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementActions", n => { ManagementActions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementAction>(global::ApiSdk.Models.ManagedTenants.ManagementAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementIntents", n => { ManagementIntents = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementIntent>(global::ApiSdk.Models.ManagedTenants.ManagementIntent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementTemplateCollectionTenantSummaries", n => { ManagementTemplateCollectionTenantSummaries = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollectionTenantSummary>(global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollectionTenantSummary.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementTemplateCollections", n => { ManagementTemplateCollections = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollection>(global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementTemplateStepTenantSummaries", n => { ManagementTemplateStepTenantSummaries = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepTenantSummary>(global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepTenantSummary.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementTemplateStepVersions", n => { ManagementTemplateStepVersions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepVersion>(global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepVersion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementTemplateSteps", n => { ManagementTemplateSteps = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStep>(global::ApiSdk.Models.ManagedTenants.ManagementTemplateStep.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplate>(global::ApiSdk.Models.ManagedTenants.ManagementTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "myRoles", n => { MyRoles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.MyRole>(global::ApiSdk.Models.ManagedTenants.MyRole.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantGroups", n => { TenantGroups = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantGroup>(global::ApiSdk.Models.ManagedTenants.TenantGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantTags", n => { TenantTags = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantTag>(global::ApiSdk.Models.ManagedTenants.TenantTag.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenants", n => { Tenants = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.Tenant>(global::ApiSdk.Models.ManagedTenants.Tenant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantsCustomizedInformation", n => { TenantsCustomizedInformation = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantCustomizedInformation>(global::ApiSdk.Models.ManagedTenants.TenantCustomizedInformation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantsDetailedInformation", n => { TenantsDetailedInformation = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation>(global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "windowsDeviceMalwareStates", n => { WindowsDeviceMalwareStates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.WindowsDeviceMalwareState>(global::ApiSdk.Models.ManagedTenants.WindowsDeviceMalwareState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "windowsProtectionStates", n => { WindowsProtectionStates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.WindowsProtectionState>(global::ApiSdk.Models.ManagedTenants.WindowsProtectionState.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AggregatedPolicyCompliance>("aggregatedPolicyCompliances", AggregatedPolicyCompliances);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AppPerformance>("appPerformances", AppPerformances);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CloudPcConnection>("cloudPcConnections", CloudPcConnections);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CloudPcDevice>("cloudPcDevices", CloudPcDevices);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CloudPcOverview>("cloudPcsOverview", CloudPcsOverview);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ConditionalAccessPolicyCoverage>("conditionalAccessPolicyCoverages", ConditionalAccessPolicyCoverages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.CredentialUserRegistrationsSummary>("credentialUserRegistrationsSummaries", CredentialUserRegistrationsSummaries);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.DeviceAppPerformance>("deviceAppPerformances", DeviceAppPerformances);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.DeviceHealthStatus>("deviceHealthStatuses", DeviceHealthStatuses);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedDeviceCompliance>("managedDeviceCompliances", ManagedDeviceCompliances);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedDeviceComplianceTrend>("managedDeviceComplianceTrends", ManagedDeviceComplianceTrends);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertLog>("managedTenantAlertLogs", ManagedTenantAlertLogs);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRuleDefinition>("managedTenantAlertRuleDefinitions", ManagedTenantAlertRuleDefinitions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlertRule>("managedTenantAlertRules", ManagedTenantAlertRules);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantAlert>("managedTenantAlerts", ManagedTenantAlerts);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantApiNotification>("managedTenantApiNotifications", ManagedTenantApiNotifications);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantEmailNotification>("managedTenantEmailNotifications", ManagedTenantEmailNotifications);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagedTenantTicketingEndpoint>("managedTenantTicketingEndpoints", ManagedTenantTicketingEndpoints);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementAction>("managementActions", ManagementActions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementActionTenantDeploymentStatus>("managementActionTenantDeploymentStatuses", ManagementActionTenantDeploymentStatuses);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementIntent>("managementIntents", ManagementIntents);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollection>("managementTemplateCollections", ManagementTemplateCollections);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateCollectionTenantSummary>("managementTemplateCollectionTenantSummaries", ManagementTemplateCollectionTenantSummaries);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplate>("managementTemplates", ManagementTemplates);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStep>("managementTemplateSteps", ManagementTemplateSteps);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepTenantSummary>("managementTemplateStepTenantSummaries", ManagementTemplateStepTenantSummaries);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateStepVersion>("managementTemplateStepVersions", ManagementTemplateStepVersions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.MyRole>("myRoles", MyRoles);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantGroup>("tenantGroups", TenantGroups);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.Tenant>("tenants", Tenants);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantCustomizedInformation>("tenantsCustomizedInformation", TenantsCustomizedInformation);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantDetailedInformation>("tenantsDetailedInformation", TenantsDetailedInformation);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.TenantTag>("tenantTags", TenantTags);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.WindowsDeviceMalwareState>("windowsDeviceMalwareStates", WindowsDeviceMalwareStates);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.WindowsProtectionState>("windowsProtectionStates", WindowsProtectionStates);
        }
    }
}
#pragma warning restore CS0618
