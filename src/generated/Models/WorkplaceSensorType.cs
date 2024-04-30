// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public enum WorkplaceSensorType
    #pragma warning restore CS1591
    {
        /// <summary>The occupancy sensor type.</summary>
        [EnumMember(Value = "occupancy")]
        Occupancy,
        /// <summary>The people count sensor type.</summary>
        [EnumMember(Value = "peopleCount")]
        PeopleCount,
        /// <summary>The inferred Occupancy sensor type.</summary>
        [EnumMember(Value = "inferredOccupancy")]
        InferredOccupancy,
        /// <summary>The heartbeat sensor type.</summary>
        [EnumMember(Value = "heartbeat")]
        Heartbeat,
        /// <summary>The unknown feature value.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}