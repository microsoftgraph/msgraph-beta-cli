// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
    public enum AndroidManagedAppSafetyNetAppsVerificationType
    {
        /// <summary>no requirement set</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>require that Android device has SafetyNet Apps Verification enabled</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
    }
}