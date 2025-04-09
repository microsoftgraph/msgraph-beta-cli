// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>The set of available policy types that can be configured for approval. The policy type must always be defined in an OperationApprovalRequest.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum OperationApprovalPolicyType
    {
        /// <summary>Default. Indicates that the configured policy type is unknown. Not a valid policy type in an OperationApprovalPolicy.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the configured policy type is an application type, such as mobile apps or built-in apps.</summary>
        [EnumMember(Value = "app")]
        App,
        /// <summary>Indicates that the configured policy type is a script type, such as Powershell scripts or remediation scripts.</summary>
        [EnumMember(Value = "script")]
        Script,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
