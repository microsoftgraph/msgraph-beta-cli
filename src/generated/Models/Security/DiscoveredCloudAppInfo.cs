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
    public partial class DiscoveredCloudAppInfo : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The csaStarLevel property</summary>
        public global::ApiSdk.Models.Security.AppInfoCsaStarLevel? CsaStarLevel { get; set; }
        /// <summary>The dataAtRestEncryptionMethod property</summary>
        public global::ApiSdk.Models.Security.AppInfoDataAtRestEncryptionMethod? DataAtRestEncryptionMethod { get; set; }
        /// <summary>Indicates the countries or regions in which your data center resides.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataCenter { get; set; }
#nullable restore
#else
        public string DataCenter { get; set; }
#endif
        /// <summary>The dataRetentionPolicy property</summary>
        public global::ApiSdk.Models.Security.AppInfoDataRetentionPolicy? DataRetentionPolicy { get; set; }
        /// <summary>Indicates the data types that an end user can upload to the app. The possible values are: documents, mediaFiles, codingFiles, creditCards, databaseFiles, none, unknown, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.AppInfoUploadedDataTypes?>? DataTypes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.AppInfoUploadedDataTypes?> DataTypes { get; set; }
#endif
        /// <summary>Indicates the date when the app domain was registered.</summary>
        public DateTimeOffset? DomainRegistrationDateTime { get; set; }
        /// <summary>The encryptionProtocol property</summary>
        public global::ApiSdk.Models.Security.AppInfoEncryptionProtocol? EncryptionProtocol { get; set; }
        /// <summary>The fedRampLevel property</summary>
        public global::ApiSdk.Models.Security.AppInfoFedRampLevel? FedRampLevel { get; set; }
        /// <summary>Indicates the year that the specific app vendor was established.</summary>
        public int? Founded { get; set; }
        /// <summary>Indicates the GDPR readiness of the app in relation to policies app provides to safeguard personal user data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GdprReadinessStatement { get; set; }
#nullable restore
#else
        public string GdprReadinessStatement { get; set; }
#endif
        /// <summary>Indicates the location of the headquarters of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Headquarters { get; set; }
#nullable restore
#else
        public string Headquarters { get; set; }
#endif
        /// <summary>The holding property</summary>
        public global::ApiSdk.Models.Security.AppInfoHolding? Holding { get; set; }
        /// <summary>Indicates the company name that provides hosting services for the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostingCompany { get; set; }
#nullable restore
#else
        public string HostingCompany { get; set; }
#endif
        /// <summary>The isAdminAuditTrail property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsAdminAuditTrail { get; set; }
        /// <summary>The isCobitCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsCobitCompliant { get; set; }
        /// <summary>The isCoppaCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsCoppaCompliant { get; set; }
        /// <summary>The isDataAuditTrail property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsDataAuditTrail { get; set; }
        /// <summary>The isDataClassification property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsDataClassification { get; set; }
        /// <summary>The isDataOwnership property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsDataOwnership { get; set; }
        /// <summary>The isDisasterRecoveryPlan property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsDisasterRecoveryPlan { get; set; }
        /// <summary>The isDmca property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsDmca { get; set; }
        /// <summary>The isFerpaCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsFerpaCompliant { get; set; }
        /// <summary>The isFfiecCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsFfiecCompliant { get; set; }
        /// <summary>The isFileSharing property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsFileSharing { get; set; }
        /// <summary>The isFinraCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsFinraCompliant { get; set; }
        /// <summary>The isFismaCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsFismaCompliant { get; set; }
        /// <summary>The isGaapCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGaapCompliant { get; set; }
        /// <summary>The isGdprDataProtectionImpactAssessment property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprDataProtectionImpactAssessment { get; set; }
        /// <summary>The isGdprDataProtectionOfficer property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprDataProtectionOfficer { get; set; }
        /// <summary>The isGdprDataProtectionSecureCrossBorderDataTransfer property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprDataProtectionSecureCrossBorderDataTransfer { get; set; }
        /// <summary>The isGdprImpactAssessment property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprImpactAssessment { get; set; }
        /// <summary>The isGdprLawfulBasisForProcessing property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprLawfulBasisForProcessing { get; set; }
        /// <summary>The isGdprReportDataBreaches property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprReportDataBreaches { get; set; }
        /// <summary>The isGdprRightsRelatedToAutomatedDecisionMaking property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightsRelatedToAutomatedDecisionMaking { get; set; }
        /// <summary>The isGdprRightToAccess property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightToAccess { get; set; }
        /// <summary>The isGdprRightToBeInformed property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightToBeInformed { get; set; }
        /// <summary>The isGdprRightToDataPortablility property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightToDataPortablility { get; set; }
        /// <summary>The isGdprRightToErasure property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightToErasure { get; set; }
        /// <summary>The isGdprRightToObject property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightToObject { get; set; }
        /// <summary>The isGdprRightToRectification property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightToRectification { get; set; }
        /// <summary>The isGdprRightToRestrictionOfProcessing property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprRightToRestrictionOfProcessing { get; set; }
        /// <summary>The isGdprSecureCrossBorderDataControl property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGdprSecureCrossBorderDataControl { get; set; }
        /// <summary>The isGlbaCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsGlbaCompliant { get; set; }
        /// <summary>The isHipaaCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsHipaaCompliant { get; set; }
        /// <summary>The isHitrustCsfCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsHitrustCsfCompliant { get; set; }
        /// <summary>The isHttpSecurityHeadersContentSecurityPolicy property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsHttpSecurityHeadersContentSecurityPolicy { get; set; }
        /// <summary>The isHttpSecurityHeadersStrictTransportSecurity property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsHttpSecurityHeadersStrictTransportSecurity { get; set; }
        /// <summary>The isHttpSecurityHeadersXContentTypeOptions property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsHttpSecurityHeadersXContentTypeOptions { get; set; }
        /// <summary>The isHttpSecurityHeadersXFrameOptions property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsHttpSecurityHeadersXFrameOptions { get; set; }
        /// <summary>The isHttpSecurityHeadersXXssProtection property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsHttpSecurityHeadersXXssProtection { get; set; }
        /// <summary>The isIpAddressRestriction property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsIpAddressRestriction { get; set; }
        /// <summary>The isIsae3402Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsIsae3402Compliant { get; set; }
        /// <summary>The isIso27001Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsIso27001Compliant { get; set; }
        /// <summary>The isIso27017Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsIso27017Compliant { get; set; }
        /// <summary>The isIso27018Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsIso27018Compliant { get; set; }
        /// <summary>The isItarCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsItarCompliant { get; set; }
        /// <summary>The isMultiFactorAuthentication property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsMultiFactorAuthentication { get; set; }
        /// <summary>The isPasswordPolicy property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPasswordPolicy { get; set; }
        /// <summary>The isPasswordPolicyChangePasswordPeriod property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPasswordPolicyChangePasswordPeriod { get; set; }
        /// <summary>The isPasswordPolicyCharacterCombination property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPasswordPolicyCharacterCombination { get; set; }
        /// <summary>The isPasswordPolicyPasswordHistoryAndReuse property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPasswordPolicyPasswordHistoryAndReuse { get; set; }
        /// <summary>The isPasswordPolicyPasswordLengthLimit property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPasswordPolicyPasswordLengthLimit { get; set; }
        /// <summary>The isPasswordPolicyPersonalInformationUse property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPasswordPolicyPersonalInformationUse { get; set; }
        /// <summary>The isPenetrationTesting property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPenetrationTesting { get; set; }
        /// <summary>The isPrivacyShieldCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsPrivacyShieldCompliant { get; set; }
        /// <summary>The isRememberPassword property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsRememberPassword { get; set; }
        /// <summary>The isRequiresUserAuthentication property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsRequiresUserAuthentication { get; set; }
        /// <summary>The isSoc1Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsSoc1Compliant { get; set; }
        /// <summary>The isSoc2Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsSoc2Compliant { get; set; }
        /// <summary>The isSoc3Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsSoc3Compliant { get; set; }
        /// <summary>The isSoxCompliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsSoxCompliant { get; set; }
        /// <summary>The isSp80053Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsSp80053Compliant { get; set; }
        /// <summary>The isSsae16Compliant property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsSsae16Compliant { get; set; }
        /// <summary>The isSupportsSaml property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsSupportsSaml { get; set; }
        /// <summary>The isTrustedCertificate property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsTrustedCertificate { get; set; }
        /// <summary>The isUserAuditTrail property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsUserAuditTrail { get; set; }
        /// <summary>The isUserCanUploadData property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsUserCanUploadData { get; set; }
        /// <summary>The isUserRolesSupport property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsUserRolesSupport { get; set; }
        /// <summary>The isValidCertificateName property</summary>
        public global::ApiSdk.Models.Security.CloudAppInfoState? IsValidCertificateName { get; set; }
        /// <summary>Indicates the last date of the data breach for the company.</summary>
        public DateTimeOffset? LatestBreachDateTime { get; set; }
        /// <summary>Indicates the URL that users can use to sign into the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LogonUrls { get; set; }
#nullable restore
#else
        public List<string> LogonUrls { get; set; }
#endif
        /// <summary>The pciDssVersion property</summary>
        public global::ApiSdk.Models.Security.AppInfoPciDssVersion? PciDssVersion { get; set; }
        /// <summary>Indicates the app vendor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Vendor { get; set; }
#nullable restore
#else
        public string Vendor { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.DiscoveredCloudAppInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Security.DiscoveredCloudAppInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.DiscoveredCloudAppInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "csaStarLevel", n => { CsaStarLevel = n.GetEnumValue<global::ApiSdk.Models.Security.AppInfoCsaStarLevel>(); } },
                { "dataAtRestEncryptionMethod", n => { DataAtRestEncryptionMethod = n.GetEnumValue<global::ApiSdk.Models.Security.AppInfoDataAtRestEncryptionMethod>(); } },
                { "dataCenter", n => { DataCenter = n.GetStringValue(); } },
                { "dataRetentionPolicy", n => { DataRetentionPolicy = n.GetEnumValue<global::ApiSdk.Models.Security.AppInfoDataRetentionPolicy>(); } },
                { "dataTypes", n => { DataTypes = n.GetCollectionOfEnumValues<global::ApiSdk.Models.Security.AppInfoUploadedDataTypes>()?.AsList(); } },
                { "domainRegistrationDateTime", n => { DomainRegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                { "encryptionProtocol", n => { EncryptionProtocol = n.GetEnumValue<global::ApiSdk.Models.Security.AppInfoEncryptionProtocol>(); } },
                { "fedRampLevel", n => { FedRampLevel = n.GetEnumValue<global::ApiSdk.Models.Security.AppInfoFedRampLevel>(); } },
                { "founded", n => { Founded = n.GetIntValue(); } },
                { "gdprReadinessStatement", n => { GdprReadinessStatement = n.GetStringValue(); } },
                { "headquarters", n => { Headquarters = n.GetStringValue(); } },
                { "holding", n => { Holding = n.GetEnumValue<global::ApiSdk.Models.Security.AppInfoHolding>(); } },
                { "hostingCompany", n => { HostingCompany = n.GetStringValue(); } },
                { "isAdminAuditTrail", n => { IsAdminAuditTrail = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isCobitCompliant", n => { IsCobitCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isCoppaCompliant", n => { IsCoppaCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isDataAuditTrail", n => { IsDataAuditTrail = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isDataClassification", n => { IsDataClassification = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isDataOwnership", n => { IsDataOwnership = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isDisasterRecoveryPlan", n => { IsDisasterRecoveryPlan = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isDmca", n => { IsDmca = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isFerpaCompliant", n => { IsFerpaCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isFfiecCompliant", n => { IsFfiecCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isFileSharing", n => { IsFileSharing = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isFinraCompliant", n => { IsFinraCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isFismaCompliant", n => { IsFismaCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGaapCompliant", n => { IsGaapCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprDataProtectionImpactAssessment", n => { IsGdprDataProtectionImpactAssessment = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprDataProtectionOfficer", n => { IsGdprDataProtectionOfficer = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprDataProtectionSecureCrossBorderDataTransfer", n => { IsGdprDataProtectionSecureCrossBorderDataTransfer = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprImpactAssessment", n => { IsGdprImpactAssessment = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprLawfulBasisForProcessing", n => { IsGdprLawfulBasisForProcessing = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprReportDataBreaches", n => { IsGdprReportDataBreaches = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightToAccess", n => { IsGdprRightToAccess = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightToBeInformed", n => { IsGdprRightToBeInformed = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightToDataPortablility", n => { IsGdprRightToDataPortablility = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightToErasure", n => { IsGdprRightToErasure = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightToObject", n => { IsGdprRightToObject = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightToRectification", n => { IsGdprRightToRectification = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightToRestrictionOfProcessing", n => { IsGdprRightToRestrictionOfProcessing = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprRightsRelatedToAutomatedDecisionMaking", n => { IsGdprRightsRelatedToAutomatedDecisionMaking = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGdprSecureCrossBorderDataControl", n => { IsGdprSecureCrossBorderDataControl = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isGlbaCompliant", n => { IsGlbaCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isHipaaCompliant", n => { IsHipaaCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isHitrustCsfCompliant", n => { IsHitrustCsfCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isHttpSecurityHeadersContentSecurityPolicy", n => { IsHttpSecurityHeadersContentSecurityPolicy = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isHttpSecurityHeadersStrictTransportSecurity", n => { IsHttpSecurityHeadersStrictTransportSecurity = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isHttpSecurityHeadersXContentTypeOptions", n => { IsHttpSecurityHeadersXContentTypeOptions = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isHttpSecurityHeadersXFrameOptions", n => { IsHttpSecurityHeadersXFrameOptions = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isHttpSecurityHeadersXXssProtection", n => { IsHttpSecurityHeadersXXssProtection = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isIpAddressRestriction", n => { IsIpAddressRestriction = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isIsae3402Compliant", n => { IsIsae3402Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isIso27001Compliant", n => { IsIso27001Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isIso27017Compliant", n => { IsIso27017Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isIso27018Compliant", n => { IsIso27018Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isItarCompliant", n => { IsItarCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isMultiFactorAuthentication", n => { IsMultiFactorAuthentication = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPasswordPolicy", n => { IsPasswordPolicy = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPasswordPolicyChangePasswordPeriod", n => { IsPasswordPolicyChangePasswordPeriod = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPasswordPolicyCharacterCombination", n => { IsPasswordPolicyCharacterCombination = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPasswordPolicyPasswordHistoryAndReuse", n => { IsPasswordPolicyPasswordHistoryAndReuse = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPasswordPolicyPasswordLengthLimit", n => { IsPasswordPolicyPasswordLengthLimit = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPasswordPolicyPersonalInformationUse", n => { IsPasswordPolicyPersonalInformationUse = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPenetrationTesting", n => { IsPenetrationTesting = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isPrivacyShieldCompliant", n => { IsPrivacyShieldCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isRememberPassword", n => { IsRememberPassword = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isRequiresUserAuthentication", n => { IsRequiresUserAuthentication = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isSoc1Compliant", n => { IsSoc1Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isSoc2Compliant", n => { IsSoc2Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isSoc3Compliant", n => { IsSoc3Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isSoxCompliant", n => { IsSoxCompliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isSp80053Compliant", n => { IsSp80053Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isSsae16Compliant", n => { IsSsae16Compliant = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isSupportsSaml", n => { IsSupportsSaml = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isTrustedCertificate", n => { IsTrustedCertificate = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isUserAuditTrail", n => { IsUserAuditTrail = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isUserCanUploadData", n => { IsUserCanUploadData = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isUserRolesSupport", n => { IsUserRolesSupport = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "isValidCertificateName", n => { IsValidCertificateName = n.GetEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>(); } },
                { "latestBreachDateTime", n => { LatestBreachDateTime = n.GetDateTimeOffsetValue(); } },
                { "logonUrls", n => { LogonUrls = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "pciDssVersion", n => { PciDssVersion = n.GetEnumValue<global::ApiSdk.Models.Security.AppInfoPciDssVersion>(); } },
                { "vendor", n => { Vendor = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AppInfoCsaStarLevel>("csaStarLevel", CsaStarLevel);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AppInfoDataAtRestEncryptionMethod>("dataAtRestEncryptionMethod", DataAtRestEncryptionMethod);
            writer.WriteStringValue("dataCenter", DataCenter);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AppInfoDataRetentionPolicy>("dataRetentionPolicy", DataRetentionPolicy);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.Security.AppInfoUploadedDataTypes>("dataTypes", DataTypes);
            writer.WriteDateTimeOffsetValue("domainRegistrationDateTime", DomainRegistrationDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AppInfoEncryptionProtocol>("encryptionProtocol", EncryptionProtocol);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AppInfoFedRampLevel>("fedRampLevel", FedRampLevel);
            writer.WriteIntValue("founded", Founded);
            writer.WriteStringValue("gdprReadinessStatement", GdprReadinessStatement);
            writer.WriteStringValue("headquarters", Headquarters);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AppInfoHolding>("holding", Holding);
            writer.WriteStringValue("hostingCompany", HostingCompany);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isAdminAuditTrail", IsAdminAuditTrail);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isCobitCompliant", IsCobitCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isCoppaCompliant", IsCoppaCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isDataAuditTrail", IsDataAuditTrail);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isDataClassification", IsDataClassification);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isDataOwnership", IsDataOwnership);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isDisasterRecoveryPlan", IsDisasterRecoveryPlan);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isDmca", IsDmca);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isFerpaCompliant", IsFerpaCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isFfiecCompliant", IsFfiecCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isFileSharing", IsFileSharing);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isFinraCompliant", IsFinraCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isFismaCompliant", IsFismaCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGaapCompliant", IsGaapCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprDataProtectionImpactAssessment", IsGdprDataProtectionImpactAssessment);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprDataProtectionOfficer", IsGdprDataProtectionOfficer);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprDataProtectionSecureCrossBorderDataTransfer", IsGdprDataProtectionSecureCrossBorderDataTransfer);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprImpactAssessment", IsGdprImpactAssessment);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprLawfulBasisForProcessing", IsGdprLawfulBasisForProcessing);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprReportDataBreaches", IsGdprReportDataBreaches);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightsRelatedToAutomatedDecisionMaking", IsGdprRightsRelatedToAutomatedDecisionMaking);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightToAccess", IsGdprRightToAccess);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightToBeInformed", IsGdprRightToBeInformed);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightToDataPortablility", IsGdprRightToDataPortablility);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightToErasure", IsGdprRightToErasure);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightToObject", IsGdprRightToObject);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightToRectification", IsGdprRightToRectification);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprRightToRestrictionOfProcessing", IsGdprRightToRestrictionOfProcessing);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGdprSecureCrossBorderDataControl", IsGdprSecureCrossBorderDataControl);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isGlbaCompliant", IsGlbaCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isHipaaCompliant", IsHipaaCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isHitrustCsfCompliant", IsHitrustCsfCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isHttpSecurityHeadersContentSecurityPolicy", IsHttpSecurityHeadersContentSecurityPolicy);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isHttpSecurityHeadersStrictTransportSecurity", IsHttpSecurityHeadersStrictTransportSecurity);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isHttpSecurityHeadersXContentTypeOptions", IsHttpSecurityHeadersXContentTypeOptions);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isHttpSecurityHeadersXFrameOptions", IsHttpSecurityHeadersXFrameOptions);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isHttpSecurityHeadersXXssProtection", IsHttpSecurityHeadersXXssProtection);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isIpAddressRestriction", IsIpAddressRestriction);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isIsae3402Compliant", IsIsae3402Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isIso27001Compliant", IsIso27001Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isIso27017Compliant", IsIso27017Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isIso27018Compliant", IsIso27018Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isItarCompliant", IsItarCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isMultiFactorAuthentication", IsMultiFactorAuthentication);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPasswordPolicy", IsPasswordPolicy);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPasswordPolicyChangePasswordPeriod", IsPasswordPolicyChangePasswordPeriod);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPasswordPolicyCharacterCombination", IsPasswordPolicyCharacterCombination);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPasswordPolicyPasswordHistoryAndReuse", IsPasswordPolicyPasswordHistoryAndReuse);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPasswordPolicyPasswordLengthLimit", IsPasswordPolicyPasswordLengthLimit);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPasswordPolicyPersonalInformationUse", IsPasswordPolicyPersonalInformationUse);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPenetrationTesting", IsPenetrationTesting);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isPrivacyShieldCompliant", IsPrivacyShieldCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isRememberPassword", IsRememberPassword);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isRequiresUserAuthentication", IsRequiresUserAuthentication);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isSoc1Compliant", IsSoc1Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isSoc2Compliant", IsSoc2Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isSoc3Compliant", IsSoc3Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isSoxCompliant", IsSoxCompliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isSp80053Compliant", IsSp80053Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isSsae16Compliant", IsSsae16Compliant);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isSupportsSaml", IsSupportsSaml);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isTrustedCertificate", IsTrustedCertificate);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isUserAuditTrail", IsUserAuditTrail);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isUserCanUploadData", IsUserCanUploadData);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isUserRolesSupport", IsUserRolesSupport);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.CloudAppInfoState>("isValidCertificateName", IsValidCertificateName);
            writer.WriteDateTimeOffsetValue("latestBreachDateTime", LatestBreachDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("logonUrls", LogonUrls);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AppInfoPciDssVersion>("pciDssVersion", PciDssVersion);
            writer.WriteStringValue("vendor", Vendor);
        }
    }
}
#pragma warning restore CS0618
