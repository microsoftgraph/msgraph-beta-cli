using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Movies rating labels in Japan</summary>
    public enum RatingJapanMoviesType {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>Suitable for all ages</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The PG-12 classification requests parental guidance for young people under 12</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The R15+ classification is suitable for viewers of 15 or older</summary>
        [EnumMember(Value = "agesAbove15")]
        AgesAbove15,
        /// <summary>The R18+ classification is suitable for viewers of 18 or older</summary>
        [EnumMember(Value = "agesAbove18")]
        AgesAbove18,
    }
}