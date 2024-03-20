// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Bandwidth limits in kilobytes per second.
    /// </summary>
    public class DeliveryOptimizationBandwidthAbsolute : DeliveryOptimizationBandwidth, IParsable 
    {
        /// <summary>Specifies the maximum download bandwidth in KiloBytes/second that the device can use across all concurrent download activities using Delivery Optimization. Valid values 0 to 4294967295</summary>
        public long? MaximumDownloadBandwidthInKilobytesPerSecond { get; set; }
        /// <summary>Specifies the maximum upload bandwidth in KiloBytes/second that a device will use across all concurrent upload activity using Delivery Optimization (0-4000000). Valid values 0 to 4000000</summary>
        public long? MaximumUploadBandwidthInKilobytesPerSecond { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DeliveryOptimizationBandwidthAbsolute"/> and sets the default values.
        /// </summary>
        public DeliveryOptimizationBandwidthAbsolute() : base()
        {
            OdataType = "#microsoft.graph.deliveryOptimizationBandwidthAbsolute";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeliveryOptimizationBandwidthAbsolute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeliveryOptimizationBandwidthAbsolute CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthAbsolute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"maximumDownloadBandwidthInKilobytesPerSecond", n => { MaximumDownloadBandwidthInKilobytesPerSecond = n.GetLongValue(); } },
                {"maximumUploadBandwidthInKilobytesPerSecond", n => { MaximumUploadBandwidthInKilobytesPerSecond = n.GetLongValue(); } },
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
            writer.WriteLongValue("maximumDownloadBandwidthInKilobytesPerSecond", MaximumDownloadBandwidthInKilobytesPerSecond);
            writer.WriteLongValue("maximumUploadBandwidthInKilobytesPerSecond", MaximumUploadBandwidthInKilobytesPerSecond);
        }
    }
}