// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>A list of possible System Management Mode levels for a device. System Management Mode levels is determined by report sent from Microsoft Azure Attestation service. Only specific hardwares support System Management Mode. Windows 11 devices will have values &quot;notApplicable&quot;, &quot;level1&quot;, &quot;level2&quot; or &quot;level3&quot;. Windows 10 devices will have value &quot;notApplicable&quot;.</summary>
    public enum SystemManagementModeLevel
    {
        /// <summary>Indicates that the device does not have Firmware protection (System Management Mode) enabled.</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
        /// <summary>Indicates that deny System Management Mode (SMM) read/write access to OS and Virtualization-based security (VBS) memory. The benefit is that by design System Management Mode (SMM) cannot modify security of or exfiltrate secrets from the OS (including Virtualization-based security).</summary>
        [EnumMember(Value = "level1")]
        Level1,
        /// <summary>Indicates that in addition to the System Management Mode (SMM) Level 1 protections, this level prevents System Management Mode (SMM) from tampering with Input-Output Memory Management Unit (IOMMU) config. The benefit is that by design System Management Mode (SMM) cannot disable Virtualization-based security (VBS) and kernel Direct memory access (DMA) protections.</summary>
        [EnumMember(Value = "level2")]
        Level2,
        /// <summary>Indicates that in addition to the System Management Mode (SMM) Level 2 protections, this level reduces System Management Mode (SMM) save state capabilities. The benefit is that by design System Management Mode (SMM) cannot exploit save state to modify security of or exfiltrate secrets from the OS (including Virtualization-based security).</summary>
        [EnumMember(Value = "level3")]
        Level3,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}