using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum PstnCallDurationSource {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "operator")]
        Operator,
    }
}