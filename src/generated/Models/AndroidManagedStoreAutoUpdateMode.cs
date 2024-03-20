// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Prioritization for automatic updates of Android Managed Store apps set on assignment.</summary>
    public enum AndroidManagedStoreAutoUpdateMode
    {
        /// <summary>Default update behavior (device must be connected to Wifi, charging and not actively used).</summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>Updates are postponed for a maximum of 90 days after the app becomes out of date.</summary>
        [EnumMember(Value = "postponed")]
        Postponed,
        /// <summary>The app is updated as soon as possible by the developer. If device is online, it will be updated within minutes.</summary>
        [EnumMember(Value = "priority")]
        Priority,
        /// <summary>Unknown future mode (reserved, not used right now).</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}