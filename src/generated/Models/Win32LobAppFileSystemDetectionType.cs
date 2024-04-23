// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Contains all supported file system detection type.</summary>
    public enum Win32LobAppFileSystemDetectionType
    {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Whether the specified file or folder exists.</summary>
        [EnumMember(Value = "exists")]
        Exists,
        /// <summary>Last modified date.</summary>
        [EnumMember(Value = "modifiedDate")]
        ModifiedDate,
        /// <summary>Created date.</summary>
        [EnumMember(Value = "createdDate")]
        CreatedDate,
        /// <summary>Version value type.</summary>
        [EnumMember(Value = "version")]
        Version,
        /// <summary>Size detection type.</summary>
        [EnumMember(Value = "sizeInMB")]
        SizeInMB,
        /// <summary>The specified file or folder does not exist.</summary>
        [EnumMember(Value = "doesNotExist")]
        DoesNotExist,
    }
}