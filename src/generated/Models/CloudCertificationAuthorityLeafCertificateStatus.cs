// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Enum type of possible leaf certificate statuses. These statuses indicate whether certificates are active and usable or unusable if they have been revoked or expired.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum CloudCertificationAuthorityLeafCertificateStatus
    {
        /// <summary>Default. Unknown or invalid status.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Certificate is active, indicating it is in its validity period and not revoked.</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>Certificate has been revoked by its issuing certification authority.</summary>
        [EnumMember(Value = "revoked")]
        Revoked,
        /// <summary>Certificate has expired.</summary>
        [EnumMember(Value = "expired")]
        Expired,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
