// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    #pragma warning disable CS1591
    public enum ForceUserPasswordResetEntityIdentifier
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "accountSid")]
        #pragma warning disable CS1591
        AccountSid = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "initiatingProcessAccountSid")]
        #pragma warning disable CS1591
        InitiatingProcessAccountSid = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "requestAccountSid")]
        #pragma warning disable CS1591
        RequestAccountSid = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "onPremSid")]
        #pragma warning disable CS1591
        OnPremSid = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 16,
        #pragma warning restore CS1591
    }
}
