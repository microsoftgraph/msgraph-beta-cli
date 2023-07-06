using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Type of display modes for the start menu.</summary>
    public enum WindowsStartMenuModeType {
        /// <summary>User defined. Default value.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Full screen.</summary>
        [EnumMember(Value = "fullScreen")]
        FullScreen,
        /// <summary>Non-full screen.</summary>
        [EnumMember(Value = "nonFullScreen")]
        NonFullScreen,
    }
}