// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Data type for a configuration item inside an Android for Work application&apos;s custom configuration schema</summary>
    public enum AndroidForWorkAppConfigurationSchemaItemDataType
    {
        [EnumMember(Value = "bool")]
        Bool,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "choice")]
        Choice,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "bundle")]
        Bundle,
        [EnumMember(Value = "bundleArray")]
        BundleArray,
        [EnumMember(Value = "hidden")]
        Hidden,
    }
}