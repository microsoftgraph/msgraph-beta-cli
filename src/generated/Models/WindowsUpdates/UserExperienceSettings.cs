// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates
{
    #pragma warning disable CS1591
    public class UserExperienceSettings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the number of days after an update is installed, during which the user of the device can control when the device restarts.</summary>
        public int? DaysUntilForcedReboot { get; set; }
        /// <summary>The isHotpatchEnabled property</summary>
        public bool? IsHotpatchEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies whether the update is offered as Optional rather than Required.</summary>
        public bool? OfferAsOptional { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="UserExperienceSettings"/> and sets the default values.
        /// </summary>
        public UserExperienceSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserExperienceSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "daysUntilForcedReboot", n => { DaysUntilForcedReboot = n.GetIntValue(); } },
                { "isHotpatchEnabled", n => { IsHotpatchEnabled = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "offerAsOptional", n => { OfferAsOptional = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("daysUntilForcedReboot", DaysUntilForcedReboot);
            writer.WriteBoolValue("isHotpatchEnabled", IsHotpatchEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("offerAsOptional", OfferAsOptional);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
