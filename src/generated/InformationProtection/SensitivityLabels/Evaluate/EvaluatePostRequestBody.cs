// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.InformationProtection.SensitivityLabels.Evaluate
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EvaluatePostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The currentLabel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CurrentLabel? CurrentLabel { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CurrentLabel CurrentLabel { get; set; }
#endif
        /// <summary>The discoveredSensitiveTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DiscoveredSensitiveType>? DiscoveredSensitiveTypes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DiscoveredSensitiveType> DiscoveredSensitiveTypes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.InformationProtection.SensitivityLabels.Evaluate.EvaluatePostRequestBody"/> and sets the default values.
        /// </summary>
        public EvaluatePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.InformationProtection.SensitivityLabels.Evaluate.EvaluatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.InformationProtection.SensitivityLabels.Evaluate.EvaluatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.InformationProtection.SensitivityLabels.Evaluate.EvaluatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "currentLabel", n => { CurrentLabel = n.GetObjectValue<global::ApiSdk.Models.CurrentLabel>(global::ApiSdk.Models.CurrentLabel.CreateFromDiscriminatorValue); } },
                { "discoveredSensitiveTypes", n => { DiscoveredSensitiveTypes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DiscoveredSensitiveType>(global::ApiSdk.Models.DiscoveredSensitiveType.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.CurrentLabel>("currentLabel", CurrentLabel);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DiscoveredSensitiveType>("discoveredSensitiveTypes", DiscoveredSensitiveTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
