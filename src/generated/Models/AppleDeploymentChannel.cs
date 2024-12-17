// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates the channel used to deploy the configuration profile. Available choices are DeviceChannel, UserChannel</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AppleDeploymentChannel
    {
        /// <summary>Send payload down over Device Channel.</summary>
        [EnumMember(Value = "deviceChannel")]
        DeviceChannel,
        /// <summary>Send payload down over User Channel.</summary>
        [EnumMember(Value = "userChannel")]
        UserChannel,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
