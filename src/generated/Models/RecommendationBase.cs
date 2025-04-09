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
    public partial class RecommendationBase : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of actions to take to complete a recommendation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ActionStep>? ActionSteps { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ActionStep> ActionSteps { get; set; }
#endif
        /// <summary>An explanation of why completing the recommendation will benefit you. Corresponds to the Value section of a recommendation shown in the Microsoft Entra admin center.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Benefits { get; set; }
#nullable restore
#else
        public string Benefits { get; set; }
#endif
        /// <summary>The category property</summary>
        public global::ApiSdk.Models.RecommendationCategory? Category { get; set; }
        /// <summary>The date and time when the recommendation was detected as applicable to your directory.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The number of points the tenant has attained. Only applies to recommendations with category set to identitySecureScore.</summary>
        public double? CurrentScore { get; set; }
        /// <summary>The title of the recommendation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The directory feature that the recommendation is related to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.RecommendationFeatureAreas?>? FeatureAreas { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.RecommendationFeatureAreas?> FeatureAreas { get; set; }
#endif
        /// <summary>The list of directory objects associated with the recommendation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ImpactedResource>? ImpactedResources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ImpactedResource> ImpactedResources { get; set; }
#endif
        /// <summary>The future date and time when a recommendation should be completed.</summary>
        public DateTimeOffset? ImpactStartDateTime { get; set; }
        /// <summary>Indicates the scope of impact of a recommendation. Tenant level indicates that the recommendation impacts the whole tenant. Other possible values include users, applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImpactType { get; set; }
#nullable restore
#else
        public string ImpactType { get; set; }
#endif
        /// <summary>Describes why a recommendation uniquely applies to your directory. Corresponds to the Description section of a recommendation shown in the Microsoft Entra admin center.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Insights { get; set; }
#nullable restore
#else
        public string Insights { get; set; }
#endif
        /// <summary>The most recent date and time a recommendation was deemed applicable to your directory.</summary>
        public DateTimeOffset? LastCheckedDateTime { get; set; }
        /// <summary>Name of the user who last updated the status of the recommendation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy { get; set; }
#nullable restore
#else
        public string LastModifiedBy { get; set; }
#endif
        /// <summary>The date and time the status of a recommendation was last updated.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The maximum number of points attainable. Only applies to recommendations with category set to identitySecureScore.</summary>
        public double? MaxScore { get; set; }
        /// <summary>The future date and time when the status of a postponed recommendation will be active again.</summary>
        public DateTimeOffset? PostponeUntilDateTime { get; set; }
        /// <summary>The priority property</summary>
        public global::ApiSdk.Models.RecommendationPriority? Priority { get; set; }
        /// <summary>Friendly shortname to identify the recommendation. The possible values are: adfsAppsMigration, enableDesktopSSO, enablePHS, enableProvisioning, switchFromPerUserMFA, tenantMFA, thirdPartyApps, turnOffPerUserMFA, useAuthenticatorApp, useMyApps, staleApps, staleAppCreds, applicationCredentialExpiry, servicePrincipalKeyExpiry, adminMFAV2, blockLegacyAuthentication, integratedApps, mfaRegistrationV2, pwagePolicyNew, passwordHashSync, oneAdmin, roleOverlap, selfServicePasswordReset, signinRiskPolicy, userRiskPolicy, verifyAppPublisher, privateLinkForAAD, appRoleAssignmentsGroups, appRoleAssignmentsUsers, managedIdentity, overprivilegedApps, unknownFutureValue, longLivedCredentials, aadConnectDeprecated, adalToMsalMigration, ownerlessApps, inactiveGuests, aadGraphDeprecationApplication, aadGraphDeprecationServicePrincipal, mfaServerDeprecation. Use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: longLivedCredentials , aadConnectDeprecated , adalToMsalMigration , ownerlessApps , inactiveGuests , aadGraphDeprecationApplication , aadGraphDeprecationServicePrincipal , mfaServerDeprecation.</summary>
        public global::ApiSdk.Models.RecommendationType? RecommendationType { get; set; }
        /// <summary>The current release type of the recommendation. The possible values are: preview, generallyAvailable, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReleaseType { get; set; }
#nullable restore
#else
        public string ReleaseType { get; set; }
#endif
        /// <summary>Description of the impact on users of the remediation. Only applies to recommendations with category set to identitySecureScore.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationImpact { get; set; }
#nullable restore
#else
        public string RemediationImpact { get; set; }
#endif
        /// <summary>The required licenses to view the recommendation. The possible values are: notApplicable, microsoftEntraIdFree, microsoftEntraIdP1, microsoftEntraIdP2, microsoftEntraIdGovernance, microsoftEntraWorkloadId, unknownFutureValue.</summary>
        public global::ApiSdk.Models.RequiredLicenses? RequiredLicenses { get; set; }
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.RecommendationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RecommendationBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.RecommendationBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.recommendation" => new global::ApiSdk.Models.Recommendation(),
                _ => new global::ApiSdk.Models.RecommendationBase(),
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
                { "actionSteps", n => { ActionSteps = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ActionStep>(global::ApiSdk.Models.ActionStep.CreateFromDiscriminatorValue)?.AsList(); } },
                { "benefits", n => { Benefits = n.GetStringValue(); } },
                { "category", n => { Category = n.GetEnumValue<global::ApiSdk.Models.RecommendationCategory>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "currentScore", n => { CurrentScore = n.GetDoubleValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "featureAreas", n => { FeatureAreas = n.GetCollectionOfEnumValues<global::ApiSdk.Models.RecommendationFeatureAreas>()?.AsList(); } },
                { "impactStartDateTime", n => { ImpactStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "impactType", n => { ImpactType = n.GetStringValue(); } },
                { "impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ImpactedResource>(global::ApiSdk.Models.ImpactedResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "insights", n => { Insights = n.GetStringValue(); } },
                { "lastCheckedDateTime", n => { LastCheckedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "maxScore", n => { MaxScore = n.GetDoubleValue(); } },
                { "postponeUntilDateTime", n => { PostponeUntilDateTime = n.GetDateTimeOffsetValue(); } },
                { "priority", n => { Priority = n.GetEnumValue<global::ApiSdk.Models.RecommendationPriority>(); } },
                { "recommendationType", n => { RecommendationType = n.GetEnumValue<global::ApiSdk.Models.RecommendationType>(); } },
                { "releaseType", n => { ReleaseType = n.GetStringValue(); } },
                { "remediationImpact", n => { RemediationImpact = n.GetStringValue(); } },
                { "requiredLicenses", n => { RequiredLicenses = n.GetEnumValue<global::ApiSdk.Models.RequiredLicenses>(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.RecommendationStatus>(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ActionStep>("actionSteps", ActionSteps);
            writer.WriteStringValue("benefits", Benefits);
            writer.WriteEnumValue<global::ApiSdk.Models.RecommendationCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDoubleValue("currentScore", CurrentScore);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.RecommendationFeatureAreas>("featureAreas", FeatureAreas);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ImpactedResource>("impactedResources", ImpactedResources);
            writer.WriteDateTimeOffsetValue("impactStartDateTime", ImpactStartDateTime);
            writer.WriteStringValue("impactType", ImpactType);
            writer.WriteStringValue("insights", Insights);
            writer.WriteDateTimeOffsetValue("lastCheckedDateTime", LastCheckedDateTime);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDoubleValue("maxScore", MaxScore);
            writer.WriteDateTimeOffsetValue("postponeUntilDateTime", PostponeUntilDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.RecommendationPriority>("priority", Priority);
            writer.WriteEnumValue<global::ApiSdk.Models.RecommendationType>("recommendationType", RecommendationType);
            writer.WriteStringValue("releaseType", ReleaseType);
            writer.WriteStringValue("remediationImpact", RemediationImpact);
            writer.WriteEnumValue<global::ApiSdk.Models.RequiredLicenses>("requiredLicenses", RequiredLicenses);
            writer.WriteEnumValue<global::ApiSdk.Models.RecommendationStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
