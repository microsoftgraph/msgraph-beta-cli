// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>An enum type to represent approval type of a driver update profile.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DriverUpdateProfileApprovalType
    {
        /// <summary>This indicates a driver and firmware profile needs to be approved manually.</summary>
        [EnumMember(Value = "manual")]
        Manual,
        /// <summary>This indicates a driver and firmware profile is approved automatically.</summary>
        [EnumMember(Value = "automatic")]
        Automatic,
    }
}
