// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum SubmissionResultCategory
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "notJunk")]
        #pragma warning disable CS1591
        NotJunk,
        #pragma warning restore CS1591
        [EnumMember(Value = "spam")]
        #pragma warning disable CS1591
        Spam,
        #pragma warning restore CS1591
        [EnumMember(Value = "phishing")]
        #pragma warning disable CS1591
        Phishing,
        #pragma warning restore CS1591
        [EnumMember(Value = "malware")]
        #pragma warning disable CS1591
        Malware,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByPolicy")]
        #pragma warning disable CS1591
        AllowedByPolicy,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedByPolicy")]
        #pragma warning disable CS1591
        BlockedByPolicy,
        #pragma warning restore CS1591
        [EnumMember(Value = "spoof")]
        #pragma warning disable CS1591
        Spoof,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknown")]
        #pragma warning disable CS1591
        Unknown,
        #pragma warning restore CS1591
        [EnumMember(Value = "noResultAvailable")]
        #pragma warning disable CS1591
        NoResultAvailable,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
        [EnumMember(Value = "beingAnalyzed")]
        #pragma warning disable CS1591
        BeingAnalyzed,
        #pragma warning restore CS1591
        [EnumMember(Value = "notSubmittedToMicrosoft")]
        #pragma warning disable CS1591
        NotSubmittedToMicrosoft,
        #pragma warning restore CS1591
        [EnumMember(Value = "phishingSimulation")]
        #pragma warning disable CS1591
        PhishingSimulation,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedDueToOrganizationOverride")]
        #pragma warning disable CS1591
        AllowedDueToOrganizationOverride,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedDueToOrganizationOverride")]
        #pragma warning disable CS1591
        BlockedDueToOrganizationOverride,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedDueToUserOverride")]
        #pragma warning disable CS1591
        AllowedDueToUserOverride,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedDueToUserOverride")]
        #pragma warning disable CS1591
        BlockedDueToUserOverride,
        #pragma warning restore CS1591
        [EnumMember(Value = "itemNotfound")]
        #pragma warning disable CS1591
        ItemNotfound,
        #pragma warning restore CS1591
        [EnumMember(Value = "threatsFound")]
        #pragma warning disable CS1591
        ThreatsFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "noThreatsFound")]
        #pragma warning disable CS1591
        NoThreatsFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "domainImpersonation")]
        #pragma warning disable CS1591
        DomainImpersonation,
        #pragma warning restore CS1591
        [EnumMember(Value = "userImpersonation")]
        #pragma warning disable CS1591
        UserImpersonation,
        #pragma warning restore CS1591
        [EnumMember(Value = "brandImpersonation")]
        #pragma warning disable CS1591
        BrandImpersonation,
        #pragma warning restore CS1591
        [EnumMember(Value = "authenticationFailure")]
        #pragma warning disable CS1591
        AuthenticationFailure,
        #pragma warning restore CS1591
        [EnumMember(Value = "spoofedBlocked")]
        #pragma warning disable CS1591
        SpoofedBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "spoofedAllowed")]
        #pragma warning disable CS1591
        SpoofedAllowed,
        #pragma warning restore CS1591
        [EnumMember(Value = "reasonLostInTransit")]
        #pragma warning disable CS1591
        ReasonLostInTransit,
        #pragma warning restore CS1591
        [EnumMember(Value = "bulk")]
        #pragma warning disable CS1591
        Bulk,
        #pragma warning restore CS1591
    }
}
