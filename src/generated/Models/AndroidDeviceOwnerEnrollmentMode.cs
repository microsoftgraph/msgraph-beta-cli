// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>The enrollment mode for an enrollment profile.</summary>
    public enum AndroidDeviceOwnerEnrollmentMode
    {
        [EnumMember(Value = "corporateOwnedDedicatedDevice")]
        CorporateOwnedDedicatedDevice,
        [EnumMember(Value = "corporateOwnedFullyManaged")]
        CorporateOwnedFullyManaged,
        [EnumMember(Value = "corporateOwnedWorkProfile")]
        CorporateOwnedWorkProfile,
        /// <summary>Corporate owned, userless Android Open Source Project (AOSP) device, without Google Mobile Services.</summary>
        [EnumMember(Value = "corporateOwnedAOSPUserlessDevice")]
        CorporateOwnedAOSPUserlessDevice,
        /// <summary>Corporate owned, user-associated Android Open Source Project (AOSP) device, without Google Mobile Services.</summary>
        [EnumMember(Value = "corporateOwnedAOSPUserAssociatedDevice")]
        CorporateOwnedAOSPUserAssociatedDevice,
    }
}