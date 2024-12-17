// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Represents the type of pricing of a booking service.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum BookingPriceType
    {
        /// <summary>The price of the service is not defined.</summary>
        [EnumMember(Value = "undefined")]
        Undefined,
        /// <summary>The price of the service is fixed.</summary>
        [EnumMember(Value = "fixedPrice")]
        FixedPrice,
        /// <summary>The price of the service starts with a particular value, but can be higher based on the final services performed.</summary>
        [EnumMember(Value = "startingAt")]
        StartingAt,
        /// <summary>The price of the service depends on the number of hours a staff member works on the service.</summary>
        [EnumMember(Value = "hourly")]
        Hourly,
        /// <summary>The service is free.</summary>
        [EnumMember(Value = "free")]
        Free,
        /// <summary>The price of the service varies.</summary>
        [EnumMember(Value = "priceVaries")]
        PriceVaries,
        /// <summary>The price of the service is not listed.</summary>
        [EnumMember(Value = "callUs")]
        CallUs,
        /// <summary>The price of the service is not set.</summary>
        [EnumMember(Value = "notSet")]
        NotSet,
    }
}
