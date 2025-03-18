// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Possible values for email sync duration.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum EmailSyncDuration
    {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Sync one day of email.</summary>
        [EnumMember(Value = "oneDay")]
        OneDay,
        /// <summary>Sync three days of email.</summary>
        [EnumMember(Value = "threeDays")]
        ThreeDays,
        /// <summary>Sync one week of email.</summary>
        [EnumMember(Value = "oneWeek")]
        OneWeek,
        /// <summary>Sync two weeks of email.</summary>
        [EnumMember(Value = "twoWeeks")]
        TwoWeeks,
        /// <summary>Sync one month of email.</summary>
        [EnumMember(Value = "oneMonth")]
        OneMonth,
        /// <summary>Sync an unlimited duration of email.</summary>
        [EnumMember(Value = "unlimited")]
        Unlimited,
    }
}
