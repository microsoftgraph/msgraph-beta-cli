// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Determines when notification previews are visible on an iOS device. Previews can include things like text (from Messages and Mail) and invitation details (from Calendar). When configured, it will override the user&apos;s defined preview settings.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum IosNotificationPreviewVisibility
    {
        /// <summary>Notification preview settings will not be overwritten.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Always show notification previews.</summary>
        [EnumMember(Value = "alwaysShow")]
        AlwaysShow,
        /// <summary>Only show notification previews when the device is unlocked.</summary>
        [EnumMember(Value = "hideWhenLocked")]
        HideWhenLocked,
        /// <summary>Never show notification previews.</summary>
        [EnumMember(Value = "neverShow")]
        NeverShow,
    }
}
