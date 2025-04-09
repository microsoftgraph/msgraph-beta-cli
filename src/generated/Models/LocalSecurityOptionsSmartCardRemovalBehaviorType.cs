// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Possible values for LocalSecurityOptionsSmartCardRemovalBehaviorType</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum LocalSecurityOptionsSmartCardRemovalBehaviorType
    {
        /// <summary>No Action</summary>
        [EnumMember(Value = "noAction")]
        NoAction,
        /// <summary>Lock Workstation</summary>
        [EnumMember(Value = "lockWorkstation")]
        LockWorkstation,
        /// <summary>Force Logoff</summary>
        [EnumMember(Value = "forceLogoff")]
        ForceLogoff,
        /// <summary>Disconnect if a remote Remote Desktop Services session</summary>
        [EnumMember(Value = "disconnectRemoteDesktopSession")]
        DisconnectRemoteDesktopSession,
    }
}
