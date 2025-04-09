// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Advanced BitLocker State</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum AdvancedBitLockerState
    {
        /// <summary>Advanced BitLocker State Success</summary>
        [EnumMember(Value = "success")]
        Success = 1,
        /// <summary>User never gave consent for Encryption</summary>
        [EnumMember(Value = "noUserConsent")]
        NoUserConsent = 2,
        /// <summary>Un-protected OS Volume was detected</summary>
        [EnumMember(Value = "osVolumeUnprotected")]
        OsVolumeUnprotected = 4,
        /// <summary>TPM not used for protection of OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmRequired")]
        OsVolumeTpmRequired = 8,
        /// <summary>TPM only protection not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmOnlyRequired")]
        OsVolumeTpmOnlyRequired = 16,
        /// <summary>TPM+PIN protection not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmPinRequired")]
        OsVolumeTpmPinRequired = 32,
        /// <summary>TPM+Startup Key protection not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmStartupKeyRequired")]
        OsVolumeTpmStartupKeyRequired = 64,
        /// <summary>TPM+PIN+Startup Key not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmPinStartupKeyRequired")]
        OsVolumeTpmPinStartupKeyRequired = 128,
        /// <summary>Encryption method of OS Volume is different than that set by policy</summary>
        [EnumMember(Value = "osVolumeEncryptionMethodMismatch")]
        OsVolumeEncryptionMethodMismatch = 256,
        /// <summary>Recovery key backup failed</summary>
        [EnumMember(Value = "recoveryKeyBackupFailed")]
        RecoveryKeyBackupFailed = 512,
        /// <summary>Fixed Drive not encrypted</summary>
        [EnumMember(Value = "fixedDriveNotEncrypted")]
        FixedDriveNotEncrypted = 1024,
        /// <summary>Encryption method of Fixed Drive is different than that set by policy</summary>
        [EnumMember(Value = "fixedDriveEncryptionMethodMismatch")]
        FixedDriveEncryptionMethodMismatch = 2048,
        /// <summary>Logged on user is non-admin. This requires “AllowStandardUserEncryption” policy set to 1</summary>
        [EnumMember(Value = "loggedOnUserNonAdmin")]
        LoggedOnUserNonAdmin = 4096,
        /// <summary>WinRE is not configured</summary>
        [EnumMember(Value = "windowsRecoveryEnvironmentNotConfigured")]
        WindowsRecoveryEnvironmentNotConfigured = 8192,
        /// <summary>TPM is not available for BitLocker. This means TPM is not present, or TPM unavailable registry override is set or host OS is on portable/rome-able drive</summary>
        [EnumMember(Value = "tpmNotAvailable")]
        TpmNotAvailable = 16384,
        /// <summary>TPM is not ready for BitLocker</summary>
        [EnumMember(Value = "tpmNotReady")]
        TpmNotReady = 32768,
        /// <summary>Network not available. This is required for recovery key backup. This is reported for Drive Encryption capable devices</summary>
        [EnumMember(Value = "networkError")]
        NetworkError = 65536,
    }
}
