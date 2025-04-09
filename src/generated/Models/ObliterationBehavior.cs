// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>In macOS 12 and later, this command uses Erase All Content and Settings (EACS) on Mac computers with the Apple M1 chip or the Apple T2 Security Chip. On those devices, if EACS can’t run, the device can use obliteration (macOS 11.x behavior). This key has no effect on machines prior to the T2 chip. Upon receiving this command, the device performs preflight checks to determine if the device is in a state that allows EACS. The ObliterationBehavior value defines the device&apos;s fallback behavior.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ObliterationBehavior
    {
        /// <summary>Default. If Erase All Content and Settings (EACS) preflight fails, the device responds to the server with an Error status and then attempts to erase itself. If EACS preflight succeeds but EACS fails, then the device attempts to erase itself.</summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>If Erase All Content and Settings (EACS) preflight fails, the device responds to the server with an Error status and doesn’t attempt to erase itself. If EACS preflight succeeds but EACS fails, then the device doesn’t attempt to erase itself.</summary>
        [EnumMember(Value = "doNotObliterate")]
        DoNotObliterate,
        /// <summary>If Erase All Content and Settings (EACS) preflight fails, the device responds with an Acknowledged status and then attempts to erase itself. If EACS preflight succeeds but EACS fails, then the device attempts to erase itself.</summary>
        [EnumMember(Value = "obliterateWithWarning")]
        ObliterateWithWarning,
        /// <summary>The system doesn’t attempt Erase All Content and Settings (EACS). T2 and later devices always obliterate.</summary>
        [EnumMember(Value = "always")]
        Always,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
