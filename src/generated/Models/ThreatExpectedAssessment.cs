using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ThreatExpectedAssessment {
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "unblock")]
        Unblock,
    }
}