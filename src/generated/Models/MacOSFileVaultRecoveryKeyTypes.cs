// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Recovery key types for macOS FileVault</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum MacOSFileVaultRecoveryKeyTypes
    {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured = 1,
        /// <summary>An institutional recovery key is like a “master” recovery key that can be used to unlock any device whose password has been lost.</summary>
        [EnumMember(Value = "institutionalRecoveryKey")]
        InstitutionalRecoveryKey = 2,
        /// <summary>A personal recovery key is a unique code that can be used to unlock the user’s device, even if the password to the device is lost.</summary>
        [EnumMember(Value = "personalRecoveryKey")]
        PersonalRecoveryKey = 4,
    }
}
