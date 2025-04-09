// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DetonationDetails : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The time of detonation.</summary>
        public DateTimeOffset? AnalysisDateTime { get; set; }
        /// <summary>The compromiseIndicators property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.CompromiseIndicator>? CompromiseIndicators { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.CompromiseIndicator> CompromiseIndicators { get; set; }
#endif
        /// <summary>The detonationBehaviourDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.DetonationBehaviourDetails? DetonationBehaviourDetails { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.DetonationBehaviourDetails DetonationBehaviourDetails { get; set; }
#endif
        /// <summary>The chain of detonation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.DetonationChain? DetonationChain { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.DetonationChain DetonationChain { get; set; }
#endif
        /// <summary>All observables in the detonation tree.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.DetonationObservables? DetonationObservables { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.DetonationObservables DetonationObservables { get; set; }
#endif
        /// <summary>The detonationScreenshotUri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetonationScreenshotUri { get; set; }
#nullable restore
#else
        public string DetonationScreenshotUri { get; set; }
#endif
        /// <summary>The verdict of the detonation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetonationVerdict { get; set; }
#nullable restore
#else
        public string DetonationVerdict { get; set; }
#endif
        /// <summary>The reason for the verdict of the detonation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetonationVerdictReason { get; set; }
#nullable restore
#else
        public string DetonationVerdictReason { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Security.DetonationDetails"/> and sets the default values.
        /// </summary>
        public DetonationDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.DetonationDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Security.DetonationDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.DetonationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "analysisDateTime", n => { AnalysisDateTime = n.GetDateTimeOffsetValue(); } },
                { "compromiseIndicators", n => { CompromiseIndicators = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.CompromiseIndicator>(global::ApiSdk.Models.Security.CompromiseIndicator.CreateFromDiscriminatorValue)?.AsList(); } },
                { "detonationBehaviourDetails", n => { DetonationBehaviourDetails = n.GetObjectValue<global::ApiSdk.Models.Security.DetonationBehaviourDetails>(global::ApiSdk.Models.Security.DetonationBehaviourDetails.CreateFromDiscriminatorValue); } },
                { "detonationChain", n => { DetonationChain = n.GetObjectValue<global::ApiSdk.Models.Security.DetonationChain>(global::ApiSdk.Models.Security.DetonationChain.CreateFromDiscriminatorValue); } },
                { "detonationObservables", n => { DetonationObservables = n.GetObjectValue<global::ApiSdk.Models.Security.DetonationObservables>(global::ApiSdk.Models.Security.DetonationObservables.CreateFromDiscriminatorValue); } },
                { "detonationScreenshotUri", n => { DetonationScreenshotUri = n.GetStringValue(); } },
                { "detonationVerdict", n => { DetonationVerdict = n.GetStringValue(); } },
                { "detonationVerdictReason", n => { DetonationVerdictReason = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("analysisDateTime", AnalysisDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.CompromiseIndicator>("compromiseIndicators", CompromiseIndicators);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.DetonationBehaviourDetails>("detonationBehaviourDetails", DetonationBehaviourDetails);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.DetonationChain>("detonationChain", DetonationChain);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.DetonationObservables>("detonationObservables", DetonationObservables);
            writer.WriteStringValue("detonationScreenshotUri", DetonationScreenshotUri);
            writer.WriteStringValue("detonationVerdict", DetonationVerdict);
            writer.WriteStringValue("detonationVerdictReason", DetonationVerdictReason);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
