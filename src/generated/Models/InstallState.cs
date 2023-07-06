using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for install state.</summary>
    public enum InstallState {
        /// <summary>Not Applicable.</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
        /// <summary>Installed.</summary>
        [EnumMember(Value = "installed")]
        Installed,
        /// <summary>Failed.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Not Installed.</summary>
        [EnumMember(Value = "notInstalled")]
        NotInstalled,
        /// <summary>Uninstall Failed.</summary>
        [EnumMember(Value = "uninstallFailed")]
        UninstallFailed,
        /// <summary>Unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}