using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum CaseStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "pendingDelete")]
        PendingDelete,
        [EnumMember(Value = "closing")]
        Closing,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "closedWithError")]
        ClosedWithError,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}