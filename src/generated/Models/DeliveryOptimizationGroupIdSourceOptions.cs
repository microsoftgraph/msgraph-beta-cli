// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Group id options type
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeliveryOptimizationGroupIdSourceOptions : global::ApiSdk.Models.DeliveryOptimizationGroupIdSource, IParsable
    {
        /// <summary>Possible values for the DeliveryOptimizationGroupIdOptionsType setting.</summary>
        public global::ApiSdk.Models.DeliveryOptimizationGroupIdOptionsType? GroupIdSourceOption { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeliveryOptimizationGroupIdSourceOptions"/> and sets the default values.
        /// </summary>
        public DeliveryOptimizationGroupIdSourceOptions() : base()
        {
            OdataType = "#microsoft.graph.deliveryOptimizationGroupIdSourceOptions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeliveryOptimizationGroupIdSourceOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeliveryOptimizationGroupIdSourceOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeliveryOptimizationGroupIdSourceOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "groupIdSourceOption", n => { GroupIdSourceOption = n.GetEnumValue<global::ApiSdk.Models.DeliveryOptimizationGroupIdOptionsType>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.DeliveryOptimizationGroupIdOptionsType>("groupIdSourceOption", GroupIdSourceOption);
        }
    }
}
#pragma warning restore CS0618
