// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// An item in the list of app positions that sets the order of items on the Managed Home Screen
    /// </summary>
    public class AndroidDeviceOwnerKioskModeAppPositionItem : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents an item on the Android Device Owner Managed Home Screen (application, weblink or folder</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidDeviceOwnerKioskModeHomeScreenItem? Item { get; set; }
#nullable restore
#else
        public AndroidDeviceOwnerKioskModeHomeScreenItem Item { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Position of the item on the grid. Valid values 0 to 9999999</summary>
        public int? Position { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AndroidDeviceOwnerKioskModeAppPositionItem"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerKioskModeAppPositionItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidDeviceOwnerKioskModeAppPositionItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidDeviceOwnerKioskModeAppPositionItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerKioskModeAppPositionItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"item", n => { Item = n.GetObjectValue<AndroidDeviceOwnerKioskModeHomeScreenItem>(AndroidDeviceOwnerKioskModeHomeScreenItem.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"position", n => { Position = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AndroidDeviceOwnerKioskModeHomeScreenItem>("item", Item);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("position", Position);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}