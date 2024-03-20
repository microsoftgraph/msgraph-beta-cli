// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Flag enum representing the allowed macOS system extension types.</summary>
    [Flags]
    public enum MacOSSystemExtensionType
    {
        /// <summary>Enables driver extensions.</summary>
        [EnumMember(Value = "driverExtensionsAllowed")]
        DriverExtensionsAllowed = 1,
        /// <summary>Enables network extensions.</summary>
        [EnumMember(Value = "networkExtensionsAllowed")]
        NetworkExtensionsAllowed = 2,
        /// <summary>Enables endpoint security extensions.</summary>
        [EnumMember(Value = "endpointSecurityExtensionsAllowed")]
        EndpointSecurityExtensionsAllowed = 4,
    }
}