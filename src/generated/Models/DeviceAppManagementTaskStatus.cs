// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Device app management task status.</summary>
    public enum DeviceAppManagementTaskStatus
    {
        /// <summary>State is undefined.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The task is ready for review.</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>The task has been accepted and is being worked on.</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>The work is complete.</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>The task was rejected.</summary>
        [EnumMember(Value = "rejected")]
        Rejected,
    }
}