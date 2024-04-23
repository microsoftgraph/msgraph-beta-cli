// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Describes the features of a device that are shared between all devices in a correlation group.
    /// </summary>
    public class UserExperienceAnalyticsAnomalyCorrelationGroupFeature : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the device&apos;s feature type. Possible values are: manufacturer, model, osVersion, application or driver.</summary>
        public UserExperienceAnalyticsAnomalyDeviceFeatureType? DeviceFeatureType { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specific metric values that describe the features of the given device feature type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Values { get; set; }
#nullable restore
#else
        public List<string> Values { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UserExperienceAnalyticsAnomalyCorrelationGroupFeature"/> and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsAnomalyCorrelationGroupFeature()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserExperienceAnalyticsAnomalyCorrelationGroupFeature"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceAnalyticsAnomalyCorrelationGroupFeature CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAnomalyCorrelationGroupFeature();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"deviceFeatureType", n => { DeviceFeatureType = n.GetEnumValue<UserExperienceAnalyticsAnomalyDeviceFeatureType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<UserExperienceAnalyticsAnomalyDeviceFeatureType>("deviceFeatureType", DeviceFeatureType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}