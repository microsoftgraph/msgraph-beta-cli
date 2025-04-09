// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PermissionsCreepIndexDistribution : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The authorizationSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuthorizationSystem? AuthorizationSystem { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuthorizationSystem AuthorizationSystem { get; set; }
#endif
        /// <summary>Defines when the PCI distribution was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The highRiskProfile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RiskProfile? HighRiskProfile { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RiskProfile HighRiskProfile { get; set; }
#endif
        /// <summary>The lowRiskProfile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RiskProfile? LowRiskProfile { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RiskProfile LowRiskProfile { get; set; }
#endif
        /// <summary>The mediumRiskProfile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RiskProfile? MediumRiskProfile { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RiskProfile MediumRiskProfile { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PermissionsCreepIndexDistribution"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PermissionsCreepIndexDistribution CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PermissionsCreepIndexDistribution();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authorizationSystem", n => { AuthorizationSystem = n.GetObjectValue<global::ApiSdk.Models.AuthorizationSystem>(global::ApiSdk.Models.AuthorizationSystem.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "highRiskProfile", n => { HighRiskProfile = n.GetObjectValue<global::ApiSdk.Models.RiskProfile>(global::ApiSdk.Models.RiskProfile.CreateFromDiscriminatorValue); } },
                { "lowRiskProfile", n => { LowRiskProfile = n.GetObjectValue<global::ApiSdk.Models.RiskProfile>(global::ApiSdk.Models.RiskProfile.CreateFromDiscriminatorValue); } },
                { "mediumRiskProfile", n => { MediumRiskProfile = n.GetObjectValue<global::ApiSdk.Models.RiskProfile>(global::ApiSdk.Models.RiskProfile.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::ApiSdk.Models.AuthorizationSystem>("authorizationSystem", AuthorizationSystem);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.RiskProfile>("highRiskProfile", HighRiskProfile);
            writer.WriteObjectValue<global::ApiSdk.Models.RiskProfile>("lowRiskProfile", LowRiskProfile);
            writer.WriteObjectValue<global::ApiSdk.Models.RiskProfile>("mediumRiskProfile", MediumRiskProfile);
        }
    }
}
#pragma warning restore CS0618
