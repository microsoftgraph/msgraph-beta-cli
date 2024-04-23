// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ITunesPairingMode
    {
        /// <summary>Pairing is not allowed</summary>
        [EnumMember(Value = "disallow")]
        Disallow,
        /// <summary>Pairing allowed</summary>
        [EnumMember(Value = "allow")]
        Allow,
        /// <summary>Certificate required to pair with iTunes</summary>
        [EnumMember(Value = "requiresCertificate")]
        RequiresCertificate,
    }
}