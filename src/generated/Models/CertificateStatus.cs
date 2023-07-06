using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum CertificateStatus {
        [EnumMember(Value = "notProvisioned")]
        NotProvisioned,
        [EnumMember(Value = "provisioned")]
        Provisioned,
    }
}