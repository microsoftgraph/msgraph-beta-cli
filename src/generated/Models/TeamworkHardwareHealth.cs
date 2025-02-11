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
    public partial class TeamworkHardwareHealth : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The system health details for a teamworkDevice.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkPeripheralHealth? ComputeHealth { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkPeripheralHealth ComputeHealth { get; set; }
#endif
        /// <summary>The health details about the HDMI ingest of a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkPeripheralHealth? HdmiIngestHealth { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkPeripheralHealth HdmiIngestHealth { get; set; }
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
        /// Instantiates a new <see cref="global::ApiSdk.Models.TeamworkHardwareHealth"/> and sets the default values.
        /// </summary>
        public TeamworkHardwareHealth()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TeamworkHardwareHealth"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.TeamworkHardwareHealth CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TeamworkHardwareHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "computeHealth", n => { ComputeHealth = n.GetObjectValue<global::ApiSdk.Models.TeamworkPeripheralHealth>(global::ApiSdk.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                { "hdmiIngestHealth", n => { HdmiIngestHealth = n.GetObjectValue<global::ApiSdk.Models.TeamworkPeripheralHealth>(global::ApiSdk.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkPeripheralHealth>("computeHealth", ComputeHealth);
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkPeripheralHealth>("hdmiIngestHealth", HdmiIngestHealth);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
