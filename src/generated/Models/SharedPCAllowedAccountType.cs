// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Type of accounts that are allowed to share the PC.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum SharedPCAllowedAccountType
    {
        /// <summary>Not configured. Default value.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured = 1,
        /// <summary>Only guest accounts.</summary>
        [EnumMember(Value = "guest")]
        Guest = 2,
        /// <summary>Only domain-joined accounts.</summary>
        [EnumMember(Value = "domain")]
        Domain = 4,
    }
}
