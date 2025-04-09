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
    public partial class SimulationReportOverview : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>List of recommended actions for a tenant to improve its security posture based on the attack simulation and training campaign attack type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.RecommendedAction>? RecommendedActions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.RecommendedAction> RecommendedActions { get; set; }
#endif
        /// <summary>Number of valid users in the attack simulation and training campaign.</summary>
        public int? ResolvedTargetsCount { get; set; }
        /// <summary>Summary of simulation events in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SimulationEventsContent? SimulationEventsContent { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SimulationEventsContent SimulationEventsContent { get; set; }
#endif
        /// <summary>Summary of assigned trainings in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TrainingEventsContent? TrainingEventsContent { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TrainingEventsContent TrainingEventsContent { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SimulationReportOverview"/> and sets the default values.
        /// </summary>
        public SimulationReportOverview()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SimulationReportOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.SimulationReportOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.SimulationReportOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "recommendedActions", n => { RecommendedActions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.RecommendedAction>(global::ApiSdk.Models.RecommendedAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resolvedTargetsCount", n => { ResolvedTargetsCount = n.GetIntValue(); } },
                { "simulationEventsContent", n => { SimulationEventsContent = n.GetObjectValue<global::ApiSdk.Models.SimulationEventsContent>(global::ApiSdk.Models.SimulationEventsContent.CreateFromDiscriminatorValue); } },
                { "trainingEventsContent", n => { TrainingEventsContent = n.GetObjectValue<global::ApiSdk.Models.TrainingEventsContent>(global::ApiSdk.Models.TrainingEventsContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.RecommendedAction>("recommendedActions", RecommendedActions);
            writer.WriteIntValue("resolvedTargetsCount", ResolvedTargetsCount);
            writer.WriteObjectValue<global::ApiSdk.Models.SimulationEventsContent>("simulationEventsContent", SimulationEventsContent);
            writer.WriteObjectValue<global::ApiSdk.Models.TrainingEventsContent>("trainingEventsContent", TrainingEventsContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
