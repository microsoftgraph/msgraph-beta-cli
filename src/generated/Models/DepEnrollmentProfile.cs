// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The depEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
    /// </summary>
    public class DepEnrollmentProfile : EnrollmentProfile, IParsable 
    {
        /// <summary>Indicates if Apple id setup pane is disabled</summary>
        public bool? AppleIdDisabled { get; set; }
        /// <summary>Indicates if Apple pay setup pane is disabled</summary>
        public bool? ApplePayDisabled { get; set; }
        /// <summary>Indicates if the device will need to wait for configured confirmation</summary>
        public bool? AwaitDeviceConfiguredConfirmation { get; set; }
        /// <summary>Indicates if diagnostics setup pane is disabled</summary>
        public bool? DiagnosticsDisabled { get; set; }
        /// <summary>This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.</summary>
        public bool? EnableSharedIPad { get; set; }
        /// <summary>Indicates if this is the default profile</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Indicates if the profile is mandatory</summary>
        public bool? IsMandatory { get; set; }
        /// <summary>The iTunesPairingMode property</summary>
        public ApiSdk.Models.ITunesPairingMode? ITunesPairingMode { get; set; }
        /// <summary>Indicates if Location service setup pane is disabled</summary>
        public bool? LocationDisabled { get; set; }
        /// <summary>Indicates if Mac OS file vault is disabled</summary>
        public bool? MacOSFileVaultDisabled { get; set; }
        /// <summary>Indicates if Mac OS registration is disabled</summary>
        public bool? MacOSRegistrationDisabled { get; set; }
        /// <summary>Management certificates for Apple Configurator</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementCertificateWithThumbprint>? ManagementCertificates { get; set; }
#nullable restore
#else
        public List<ManagementCertificateWithThumbprint> ManagementCertificates { get; set; }
#endif
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled { get; set; }
        /// <summary>Indicates if the profile removal option is disabled</summary>
        public bool? ProfileRemovalDisabled { get; set; }
        /// <summary>Indicates if Restore setup pane is blocked</summary>
        public bool? RestoreBlocked { get; set; }
        /// <summary>Indicates if Restore from Android is disabled</summary>
        public bool? RestoreFromAndroidDisabled { get; set; }
        /// <summary>This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.</summary>
        public int? SharedIPadMaximumUserCount { get; set; }
        /// <summary>Indicates if siri setup pane is disabled</summary>
        public bool? SiriDisabled { get; set; }
        /// <summary>Supervised mode, True to enable, false otherwise. See https://learn.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.</summary>
        public bool? SupervisedModeEnabled { get; set; }
        /// <summary>Support department information</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportDepartment { get; set; }
#nullable restore
#else
        public string SupportDepartment { get; set; }
#endif
        /// <summary>Support phone number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportPhoneNumber { get; set; }
#nullable restore
#else
        public string SupportPhoneNumber { get; set; }
#endif
        /// <summary>Indicates if &apos;Terms and Conditions&apos; setup pane is disabled</summary>
        public bool? TermsAndConditionsDisabled { get; set; }
        /// <summary>Indicates if touch id setup pane is disabled</summary>
        public bool? TouchIdDisabled { get; set; }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DepEnrollmentProfile"/> and sets the default values.
        /// </summary>
        public DepEnrollmentProfile() : base()
        {
            OdataType = "#microsoft.graph.depEnrollmentProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DepEnrollmentProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DepEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"appleIdDisabled", n => { AppleIdDisabled = n.GetBoolValue(); } },
                {"applePayDisabled", n => { ApplePayDisabled = n.GetBoolValue(); } },
                {"awaitDeviceConfiguredConfirmation", n => { AwaitDeviceConfiguredConfirmation = n.GetBoolValue(); } },
                {"diagnosticsDisabled", n => { DiagnosticsDisabled = n.GetBoolValue(); } },
                {"enableSharedIPad", n => { EnableSharedIPad = n.GetBoolValue(); } },
                {"iTunesPairingMode", n => { ITunesPairingMode = n.GetEnumValue<ITunesPairingMode>(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isMandatory", n => { IsMandatory = n.GetBoolValue(); } },
                {"locationDisabled", n => { LocationDisabled = n.GetBoolValue(); } },
                {"macOSFileVaultDisabled", n => { MacOSFileVaultDisabled = n.GetBoolValue(); } },
                {"macOSRegistrationDisabled", n => { MacOSRegistrationDisabled = n.GetBoolValue(); } },
                {"managementCertificates", n => { ManagementCertificates = n.GetCollectionOfObjectValues<ManagementCertificateWithThumbprint>(ManagementCertificateWithThumbprint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"profileRemovalDisabled", n => { ProfileRemovalDisabled = n.GetBoolValue(); } },
                {"restoreBlocked", n => { RestoreBlocked = n.GetBoolValue(); } },
                {"restoreFromAndroidDisabled", n => { RestoreFromAndroidDisabled = n.GetBoolValue(); } },
                {"sharedIPadMaximumUserCount", n => { SharedIPadMaximumUserCount = n.GetIntValue(); } },
                {"siriDisabled", n => { SiriDisabled = n.GetBoolValue(); } },
                {"supervisedModeEnabled", n => { SupervisedModeEnabled = n.GetBoolValue(); } },
                {"supportDepartment", n => { SupportDepartment = n.GetStringValue(); } },
                {"supportPhoneNumber", n => { SupportPhoneNumber = n.GetStringValue(); } },
                {"termsAndConditionsDisabled", n => { TermsAndConditionsDisabled = n.GetBoolValue(); } },
                {"touchIdDisabled", n => { TouchIdDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", n => { ZoomDisabled = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("appleIdDisabled", AppleIdDisabled);
            writer.WriteBoolValue("applePayDisabled", ApplePayDisabled);
            writer.WriteBoolValue("awaitDeviceConfiguredConfirmation", AwaitDeviceConfiguredConfirmation);
            writer.WriteBoolValue("diagnosticsDisabled", DiagnosticsDisabled);
            writer.WriteBoolValue("enableSharedIPad", EnableSharedIPad);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isMandatory", IsMandatory);
            writer.WriteEnumValue<ITunesPairingMode>("iTunesPairingMode", ITunesPairingMode);
            writer.WriteBoolValue("locationDisabled", LocationDisabled);
            writer.WriteBoolValue("macOSFileVaultDisabled", MacOSFileVaultDisabled);
            writer.WriteBoolValue("macOSRegistrationDisabled", MacOSRegistrationDisabled);
            writer.WriteCollectionOfObjectValues<ManagementCertificateWithThumbprint>("managementCertificates", ManagementCertificates);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteBoolValue("profileRemovalDisabled", ProfileRemovalDisabled);
            writer.WriteBoolValue("restoreBlocked", RestoreBlocked);
            writer.WriteBoolValue("restoreFromAndroidDisabled", RestoreFromAndroidDisabled);
            writer.WriteIntValue("sharedIPadMaximumUserCount", SharedIPadMaximumUserCount);
            writer.WriteBoolValue("siriDisabled", SiriDisabled);
            writer.WriteBoolValue("supervisedModeEnabled", SupervisedModeEnabled);
            writer.WriteStringValue("supportDepartment", SupportDepartment);
            writer.WriteStringValue("supportPhoneNumber", SupportPhoneNumber);
            writer.WriteBoolValue("termsAndConditionsDisabled", TermsAndConditionsDisabled);
            writer.WriteBoolValue("touchIdDisabled", TouchIdDisabled);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}