using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>TV content rating labels in Japan</summary>
    public enum RatingJapanTelevisionType {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>All TV content is explicitly allowed</summary>
        [EnumMember(Value = "explicitAllowed")]
        ExplicitAllowed,
    }
}