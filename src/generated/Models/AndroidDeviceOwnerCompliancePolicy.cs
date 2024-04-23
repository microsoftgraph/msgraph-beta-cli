// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the AndroidDeviceOwnerCompliancePolicy resource.
    /// </summary>
    public class AndroidDeviceOwnerCompliancePolicy : DeviceCompliancePolicy, IParsable 
    {
        /// <summary>MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel { get; set; }
        /// <summary>Require that devices have enabled device threat protection.</summary>
        public bool? DeviceThreatProtectionEnabled { get; set; }
        /// <summary>Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
        /// <summary>Minimum Android security patch level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinAndroidSecurityPatchLevel { get; set; }
#nullable restore
#else
        public string MinAndroidSecurityPatchLevel { get; set; }
#endif
        /// <summary>Maximum Android version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMaximumVersion { get; set; }
#nullable restore
#else
        public string OsMaximumVersion { get; set; }
#endif
        /// <summary>Minimum Android version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMinimumVersion { get; set; }
#nullable restore
#else
        public string OsMinimumVersion { get; set; }
#endif
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays { get; set; }
        /// <summary>Minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>Indicates the minimum number of letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumLetterCharacters { get; set; }
        /// <summary>Indicates the minimum number of lower case characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumLowerCaseCharacters { get; set; }
        /// <summary>Indicates the minimum number of non-letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumNonLetterCharacters { get; set; }
        /// <summary>Indicates the minimum number of numeric characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumNumericCharacters { get; set; }
        /// <summary>Indicates the minimum number of symbol characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumSymbolCharacters { get; set; }
        /// <summary>Indicates the minimum number of upper case letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumUpperCaseCharacters { get; set; }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock { get; set; }
        /// <summary>Number of previous passwords to block. Valid values 1 to 24</summary>
        public int? PasswordPreviousPasswordCountToBlock { get; set; }
        /// <summary>Require a password to unlock device.</summary>
        public bool? PasswordRequired { get; set; }
        /// <summary>Type of characters in password. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType { get; set; }
        /// <summary>Require device to have no pending Android system updates.</summary>
        public bool? RequireNoPendingSystemUpdates { get; set; }
        /// <summary>Require a specific Play Integrity evaluation type for compliance. Possible values are: basic, hardwareBacked.</summary>
        public AndroidSafetyNetEvaluationType? SecurityRequiredAndroidSafetyNetEvaluationType { get; set; }
        /// <summary>If setting is set to true, checks that the Intune app installed on fully managed, dedicated, or corporate-owned work profile Android Enterprise enrolled devices, is the one provided by Microsoft from the Managed Google Playstore. If the check fails, the device will be reported as non-compliant.</summary>
        public bool? SecurityRequireIntuneAppIntegrity { get; set; }
        /// <summary>Require the device to pass the Play Integrity basic integrity check.</summary>
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity { get; set; }
        /// <summary>Require the device to pass the Play Integrity device integrity check.</summary>
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice { get; set; }
        /// <summary>Require encryption on Android devices.</summary>
        public bool? StorageRequireEncryption { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AndroidDeviceOwnerCompliancePolicy"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerCompliancePolicy() : base()
        {
            OdataType = "#microsoft.graph.androidDeviceOwnerCompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidDeviceOwnerCompliancePolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"advancedThreatProtectionRequiredSecurityLevel", n => { AdvancedThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"minAndroidSecurityPatchLevel", n => { MinAndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinimumLetterCharacters", n => { PasswordMinimumLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumLowerCaseCharacters", n => { PasswordMinimumLowerCaseCharacters = n.GetIntValue(); } },
                {"passwordMinimumNonLetterCharacters", n => { PasswordMinimumNonLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumNumericCharacters", n => { PasswordMinimumNumericCharacters = n.GetIntValue(); } },
                {"passwordMinimumSymbolCharacters", n => { PasswordMinimumSymbolCharacters = n.GetIntValue(); } },
                {"passwordMinimumUpperCaseCharacters", n => { PasswordMinimumUpperCaseCharacters = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordCountToBlock", n => { PasswordPreviousPasswordCountToBlock = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"requireNoPendingSystemUpdates", n => { RequireNoPendingSystemUpdates = n.GetBoolValue(); } },
                {"securityRequireIntuneAppIntegrity", n => { SecurityRequireIntuneAppIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationBasicIntegrity", n => { SecurityRequireSafetyNetAttestationBasicIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationCertifiedDevice", n => { SecurityRequireSafetyNetAttestationCertifiedDevice = n.GetBoolValue(); } },
                {"securityRequiredAndroidSafetyNetEvaluationType", n => { SecurityRequiredAndroidSafetyNetEvaluationType = n.GetEnumValue<AndroidSafetyNetEvaluationType>(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("advancedThreatProtectionRequiredSecurityLevel", AdvancedThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteStringValue("minAndroidSecurityPatchLevel", MinAndroidSecurityPatchLevel);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinimumLetterCharacters", PasswordMinimumLetterCharacters);
            writer.WriteIntValue("passwordMinimumLowerCaseCharacters", PasswordMinimumLowerCaseCharacters);
            writer.WriteIntValue("passwordMinimumNonLetterCharacters", PasswordMinimumNonLetterCharacters);
            writer.WriteIntValue("passwordMinimumNumericCharacters", PasswordMinimumNumericCharacters);
            writer.WriteIntValue("passwordMinimumSymbolCharacters", PasswordMinimumSymbolCharacters);
            writer.WriteIntValue("passwordMinimumUpperCaseCharacters", PasswordMinimumUpperCaseCharacters);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordCountToBlock", PasswordPreviousPasswordCountToBlock);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("requireNoPendingSystemUpdates", RequireNoPendingSystemUpdates);
            writer.WriteEnumValue<AndroidSafetyNetEvaluationType>("securityRequiredAndroidSafetyNetEvaluationType", SecurityRequiredAndroidSafetyNetEvaluationType);
            writer.WriteBoolValue("securityRequireIntuneAppIntegrity", SecurityRequireIntuneAppIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationBasicIntegrity", SecurityRequireSafetyNetAttestationBasicIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationCertifiedDevice", SecurityRequireSafetyNetAttestationCertifiedDevice);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}