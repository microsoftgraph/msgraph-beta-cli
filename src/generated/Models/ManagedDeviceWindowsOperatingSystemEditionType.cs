// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Windows Operating System is available in different editions, which have a specific set of features available. This enum type defines the corresponding edition.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ManagedDeviceWindowsOperatingSystemEditionType
    {
        /// <summary>Default. Indicates Professional Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "professional")]
        Professional,
        /// <summary>Indicates Professional N Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "professionalN")]
        ProfessionalN,
        /// <summary>Indicates Enterprise Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "enterprise")]
        Enterprise,
        /// <summary>Indicates Enterprise N Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "enterpriseN")]
        EnterpriseN,
        /// <summary>Indicates Education Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "education")]
        Education,
        /// <summary>Indicates Education N Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "educationN")]
        EducationN,
        /// <summary>Indicates Pro Education Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "proEducation")]
        ProEducation,
        /// <summary>Indicates Pro Education N Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "proEducationN")]
        ProEducationN,
        /// <summary>Indicates Pro Workstation Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "proWorkstation")]
        ProWorkstation,
        /// <summary>Indicates Pro Workstation N Operating System edition used for the managed device.</summary>
        [EnumMember(Value = "proWorkstationN")]
        ProWorkstationN,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}