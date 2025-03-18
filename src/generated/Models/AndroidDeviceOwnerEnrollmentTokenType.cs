// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>The enrollment token type for an enrollment profile.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AndroidDeviceOwnerEnrollmentTokenType
    {
        /// <summary>Default token type.</summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>Token type for Azure AD shared dedicated device enrollment. It applies to CorporateOwnedDedicatedDevice enrollment mode only.</summary>
        [EnumMember(Value = "corporateOwnedDedicatedDeviceWithAzureADSharedMode")]
        CorporateOwnedDedicatedDeviceWithAzureADSharedMode,
        /// <summary>Token type for Android Device Staging enrollment type. It applies to CorporateOwnedFullyManaged and CorporateOwnedWorkProfile only.</summary>
        [EnumMember(Value = "deviceStaging")]
        DeviceStaging,
    }
}
