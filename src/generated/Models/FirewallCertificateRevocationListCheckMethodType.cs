using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for firewallCertificateRevocationListCheckMethod</summary>
    public enum FirewallCertificateRevocationListCheckMethodType {
        /// <summary>No value configured by Intune, do not override the user-configured device default value</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Do not check certificate revocation list</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Attempt CRL check and allow a certificate only if the certificate is confirmed by the check</summary>
        [EnumMember(Value = "attempt")]
        Attempt,
        /// <summary>Require a successful CRL check before allowing a certificate</summary>
        [EnumMember(Value = "require")]
        Require,
    }
}