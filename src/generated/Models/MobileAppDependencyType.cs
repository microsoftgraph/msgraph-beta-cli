// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates the dependency type associated with a relationship between two mobile apps.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum MobileAppDependencyType
    {
        /// <summary>Indicates that the child app should be detected before installing the parent app.</summary>
        [EnumMember(Value = "detect")]
        Detect,
        /// <summary>Indicates that the child app should be installed before installing the parent app.</summary>
        [EnumMember(Value = "autoInstall")]
        AutoInstall,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
