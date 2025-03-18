// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>The type of VPN security association encryption algorithm</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum VpnEncryptionAlgorithmType
    {
        /// <summary>AES-256</summary>
        [EnumMember(Value = "aes256")]
        Aes256,
        /// <summary>DES</summary>
        [EnumMember(Value = "des")]
        Des,
        /// <summary>3DES</summary>
        [EnumMember(Value = "tripleDes")]
        TripleDes,
        /// <summary>AES-128</summary>
        [EnumMember(Value = "aes128")]
        Aes128,
        /// <summary>AES-128-GCM</summary>
        [EnumMember(Value = "aes128Gcm")]
        Aes128Gcm,
        /// <summary>AES-256-GCM</summary>
        [EnumMember(Value = "aes256Gcm")]
        Aes256Gcm,
        /// <summary>AES-192</summary>
        [EnumMember(Value = "aes192")]
        Aes192,
        /// <summary>AES-192-GCM</summary>
        [EnumMember(Value = "aes192Gcm")]
        Aes192Gcm,
        /// <summary>ChaCha20Poly1305</summary>
        [EnumMember(Value = "chaCha20Poly1305")]
        ChaCha20Poly1305,
    }
}
