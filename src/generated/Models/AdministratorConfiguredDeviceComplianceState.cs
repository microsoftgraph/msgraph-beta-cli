// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Administrator configured device compliance state Enum</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AdministratorConfiguredDeviceComplianceState
    {
        /// <summary>Set compliance state based on other compliance polices</summary>
        [EnumMember(Value = "basedOnDeviceCompliancePolicy")]
        BasedOnDeviceCompliancePolicy,
        /// <summary>Set compliance to nonCompliant</summary>
        [EnumMember(Value = "nonCompliant")]
        NonCompliant,
    }
}
