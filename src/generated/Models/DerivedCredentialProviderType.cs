// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Provider type for Derived Credentials.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DerivedCredentialProviderType
    {
        /// <summary>No Derived Credential Provider Configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Entrust.</summary>
        [EnumMember(Value = "entrustDataCard")]
        EntrustDataCard,
        /// <summary>Purebred - Defense Information Systems Agency.</summary>
        [EnumMember(Value = "purebred")]
        Purebred,
        /// <summary>Xtec - AuthentX.</summary>
        [EnumMember(Value = "xTec")]
        XTec,
        /// <summary>Intercede.</summary>
        [EnumMember(Value = "intercede")]
        Intercede,
    }
}
