// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum SingleSignOnMode
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "onPremisesKerberos")]
        #pragma warning disable CS1591
        OnPremisesKerberos,
        #pragma warning restore CS1591
        [EnumMember(Value = "saml")]
        #pragma warning disable CS1591
        Saml,
        #pragma warning restore CS1591
        [EnumMember(Value = "pingHeaderBased")]
        #pragma warning disable CS1591
        PingHeaderBased,
        #pragma warning restore CS1591
        [EnumMember(Value = "aadHeaderBased")]
        #pragma warning disable CS1591
        AadHeaderBased,
        #pragma warning restore CS1591
        [EnumMember(Value = "oAuthToken")]
        #pragma warning disable CS1591
        OAuthToken,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
    }
}
