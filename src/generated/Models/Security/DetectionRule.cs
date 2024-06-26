// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security
{
    #pragma warning disable CS1591
    public class DetectionRule : ProtectionRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Complex type representing the actions taken when a detection is made by this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.DetectionAction? DetectionAction { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.DetectionAction DetectionAction { get; set; }
#endif
        /// <summary>The ID of the detector that triggered the alert. Also see the &apos;detectorId&apos; field in microsoft.graph.security.alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetectorId { get; set; }
#nullable restore
#else
        public string DetectorId { get; set; }
#endif
        /// <summary>Complex type holding details about the last run of this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RunDetails? LastRunDetails { get; set; }
#nullable restore
#else
        public RunDetails LastRunDetails { get; set; }
#endif
        /// <summary>Complex type holding data about the advanced hunting query of this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.QueryCondition? QueryCondition { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.QueryCondition QueryCondition { get; set; }
#endif
        /// <summary>Complex type holding data about the triggering schedule of this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RuleSchedule? Schedule { get; set; }
#nullable restore
#else
        public RuleSchedule Schedule { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DetectionRule"/> and sets the default values.
        /// </summary>
        public DetectionRule() : base()
        {
            OdataType = "#microsoft.graph.security.detectionRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DetectionRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DetectionRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DetectionRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "detectionAction", n => { DetectionAction = n.GetObjectValue<ApiSdk.Models.Security.DetectionAction>(ApiSdk.Models.Security.DetectionAction.CreateFromDiscriminatorValue); } },
                { "detectorId", n => { DetectorId = n.GetStringValue(); } },
                { "lastRunDetails", n => { LastRunDetails = n.GetObjectValue<RunDetails>(RunDetails.CreateFromDiscriminatorValue); } },
                { "queryCondition", n => { QueryCondition = n.GetObjectValue<ApiSdk.Models.Security.QueryCondition>(ApiSdk.Models.Security.QueryCondition.CreateFromDiscriminatorValue); } },
                { "schedule", n => { Schedule = n.GetObjectValue<RuleSchedule>(RuleSchedule.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Security.DetectionAction>("detectionAction", DetectionAction);
            writer.WriteStringValue("detectorId", DetectorId);
            writer.WriteObjectValue<RunDetails>("lastRunDetails", LastRunDetails);
            writer.WriteObjectValue<ApiSdk.Models.Security.QueryCondition>("queryCondition", QueryCondition);
            writer.WriteObjectValue<RuleSchedule>("schedule", Schedule);
        }
    }
}
