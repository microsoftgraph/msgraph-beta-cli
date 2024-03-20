// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>An enum type to represent approval status of a driver.</summary>
    public enum DriverApprovalStatus
    {
        /// <summary>This indicates a driver needs IT admin&apos;s review.</summary>
        [EnumMember(Value = "needsReview")]
        NeedsReview,
        /// <summary>This indicates IT admin has declined a driver.</summary>
        [EnumMember(Value = "declined")]
        Declined,
        /// <summary>This indicates IT admin has approved a driver.</summary>
        [EnumMember(Value = "approved")]
        Approved,
        /// <summary>This indicates IT admin has suspended a driver.</summary>
        [EnumMember(Value = "suspended")]
        Suspended,
    }
}