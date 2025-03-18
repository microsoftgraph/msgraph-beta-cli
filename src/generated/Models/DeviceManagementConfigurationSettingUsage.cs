// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Supported setting types</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum DeviceManagementConfigurationSettingUsage
    {
        /// <summary>Default. No setting type specified.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Configuration setting type.</summary>
        [EnumMember(Value = "configuration")]
        Configuration = 2,
        /// <summary>Compliance setting type.</summary>
        [EnumMember(Value = "compliance")]
        Compliance = 4,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 8,
    }
}
