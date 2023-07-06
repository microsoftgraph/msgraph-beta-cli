using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for the install intent chosen by the admin.</summary>
    public enum InstallIntent {
        /// <summary>Available install intent.</summary>
        [EnumMember(Value = "available")]
        Available,
        /// <summary>Required install intent.</summary>
        [EnumMember(Value = "required")]
        Required,
        /// <summary>Uninstall install intent.</summary>
        [EnumMember(Value = "uninstall")]
        Uninstall,
        /// <summary>Available without enrollment install intent.</summary>
        [EnumMember(Value = "availableWithoutEnrollment")]
        AvailableWithoutEnrollment,
    }
}