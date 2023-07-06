using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Movies rating labels in New Zealand</summary>
    public enum RatingNewZealandMoviesType {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>Suitable for general audience</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The PG classification recommends parental guidance</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The M classification is suitable for mature audience</summary>
        [EnumMember(Value = "mature")]
        Mature,
        /// <summary>The R13 classification is restricted to persons 13 years and over</summary>
        [EnumMember(Value = "agesAbove13")]
        AgesAbove13,
        /// <summary>The R15 classification is restricted to persons 15 years and over</summary>
        [EnumMember(Value = "agesAbove15")]
        AgesAbove15,
        /// <summary>The R16 classification is restricted to persons 16 years and over</summary>
        [EnumMember(Value = "agesAbove16")]
        AgesAbove16,
        /// <summary>The R18 classification is restricted to persons 18 years and over</summary>
        [EnumMember(Value = "agesAbove18")]
        AgesAbove18,
        /// <summary>The R classification is restricted to a certain audience</summary>
        [EnumMember(Value = "restricted")]
        Restricted,
        /// <summary>The RP16 classification requires viewers under 16 accompanied by a parent or an adult</summary>
        [EnumMember(Value = "agesAbove16Restricted")]
        AgesAbove16Restricted,
    }
}