using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible statuses associated with a generated report</summary>
    public enum DeviceManagementReportStatus {
        /// <summary>Report generation status is unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Report generation has not started</summary>
        [EnumMember(Value = "notStarted")]
        NotStarted,
        /// <summary>Report generation is in progress</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>Report generation is completed</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Report generation has failed</summary>
        [EnumMember(Value = "failed")]
        Failed,
    }
}