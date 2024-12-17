// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Possible values for system scan type.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DefenderScanType
    {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>System scan disabled.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Quick system scan.</summary>
        [EnumMember(Value = "quick")]
        Quick,
        /// <summary>Full system scan.</summary>
        [EnumMember(Value = "full")]
        Full,
    }
}
