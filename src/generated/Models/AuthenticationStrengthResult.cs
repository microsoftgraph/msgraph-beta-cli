// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum AuthenticationStrengthResult
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "notSet")]
        #pragma warning disable CS1591
        NotSet,
        #pragma warning restore CS1591
        [EnumMember(Value = "skippedForProofUp")]
        #pragma warning disable CS1591
        SkippedForProofUp,
        #pragma warning restore CS1591
        [EnumMember(Value = "satisfied")]
        #pragma warning disable CS1591
        Satisfied,
        #pragma warning restore CS1591
        [EnumMember(Value = "singleChallengeRequired")]
        #pragma warning disable CS1591
        SingleChallengeRequired,
        #pragma warning restore CS1591
        [EnumMember(Value = "multipleChallengesRequired")]
        #pragma warning disable CS1591
        MultipleChallengesRequired,
        #pragma warning restore CS1591
        [EnumMember(Value = "singleRegistrationRequired")]
        #pragma warning disable CS1591
        SingleRegistrationRequired,
        #pragma warning restore CS1591
        [EnumMember(Value = "multipleRegistrationsRequired")]
        #pragma warning disable CS1591
        MultipleRegistrationsRequired,
        #pragma warning restore CS1591
        [EnumMember(Value = "cannotSatisfyDueToCombinationConfiguration")]
        #pragma warning disable CS1591
        CannotSatisfyDueToCombinationConfiguration,
        #pragma warning restore CS1591
        [EnumMember(Value = "cannotSatisfy")]
        #pragma warning disable CS1591
        CannotSatisfy,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
    }
}
