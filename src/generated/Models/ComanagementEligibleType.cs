// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum ComanagementEligibleType
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "comanaged")]
        #pragma warning disable CS1591
        Comanaged,
        #pragma warning restore CS1591
        [EnumMember(Value = "eligible")]
        #pragma warning disable CS1591
        Eligible,
        #pragma warning restore CS1591
        [EnumMember(Value = "eligibleButNotAzureAdJoined")]
        #pragma warning disable CS1591
        EligibleButNotAzureAdJoined,
        #pragma warning restore CS1591
        [EnumMember(Value = "needsOsUpdate")]
        #pragma warning disable CS1591
        NeedsOsUpdate,
        #pragma warning restore CS1591
        [EnumMember(Value = "ineligible")]
        #pragma warning disable CS1591
        Ineligible,
        #pragma warning restore CS1591
        /// <summary>Devices scheduled for Co-Management enrollment</summary>
        [EnumMember(Value = "scheduledForEnrollment")]
        ScheduledForEnrollment,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
