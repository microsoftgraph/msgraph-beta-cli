// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates the device licensing status after Windows device based subscription has been enabled.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceLicensingStatus
    {
        /// <summary>Default. Set to unknown when status cannot be determined.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>This status is set when the license refresh is started.</summary>
        [EnumMember(Value = "licenseRefreshStarted")]
        LicenseRefreshStarted,
        /// <summary>This status is set when the license refresh is pending.</summary>
        [EnumMember(Value = "licenseRefreshPending")]
        LicenseRefreshPending,
        /// <summary>This status is set when the device is not joined to Azure Active Directory.</summary>
        [EnumMember(Value = "deviceIsNotAzureActiveDirectoryJoined")]
        DeviceIsNotAzureActiveDirectoryJoined,
        /// <summary>This status is set when the Microsoft device identity is being verified.</summary>
        [EnumMember(Value = "verifyingMicrosoftDeviceIdentity")]
        VerifyingMicrosoftDeviceIdentity,
        /// <summary>This status is set when the Microsoft device identity verification fails.</summary>
        [EnumMember(Value = "deviceIdentityVerificationFailed")]
        DeviceIdentityVerificationFailed,
        /// <summary>This status is set when the Microsoft account identity is being verified.</summary>
        [EnumMember(Value = "verifyingMicrosoftAccountIdentity")]
        VerifyingMicrosoftAccountIdentity,
        /// <summary>This status is set when the Microsoft account identity verification fails.</summary>
        [EnumMember(Value = "microsoftAccountVerificationFailed")]
        MicrosoftAccountVerificationFailed,
        /// <summary>This status is set when the device license is being acquired.</summary>
        [EnumMember(Value = "acquiringDeviceLicense")]
        AcquiringDeviceLicense,
        /// <summary>This status is set when the device license is being refreshed.</summary>
        [EnumMember(Value = "refreshingDeviceLicense")]
        RefreshingDeviceLicense,
        /// <summary>This status is set when the device license refresh succeeds.</summary>
        [EnumMember(Value = "deviceLicenseRefreshSucceed")]
        DeviceLicenseRefreshSucceed,
        /// <summary>This status is set when the device license refresh fails.</summary>
        [EnumMember(Value = "deviceLicenseRefreshFailed")]
        DeviceLicenseRefreshFailed,
        /// <summary>This status is set when the device license is being removed.</summary>
        [EnumMember(Value = "removingDeviceLicense")]
        RemovingDeviceLicense,
        /// <summary>This status is set when the device license removing succeeds.</summary>
        [EnumMember(Value = "deviceLicenseRemoveSucceed")]
        DeviceLicenseRemoveSucceed,
        /// <summary>This status is set when the device license removing fails.</summary>
        [EnumMember(Value = "deviceLicenseRemoveFailed")]
        DeviceLicenseRemoveFailed,
        /// <summary>This is put here as a place holder for future extension.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
