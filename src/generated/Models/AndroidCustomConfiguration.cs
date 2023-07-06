using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AndroidCustomConfiguration : DeviceConfiguration, IParsable {
        /// <summary>OMA settings. This collection can contain a maximum of 1000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OmaSetting>? OmaSettings { get; set; }
#nullable restore
#else
        public List<OmaSetting> OmaSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new AndroidCustomConfiguration and sets the default values.
        /// </summary>
        public AndroidCustomConfiguration() : base() {
            OdataType = "#microsoft.graph.androidCustomConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidCustomConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidCustomConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"omaSettings", n => { OmaSettings = n.GetCollectionOfObjectValues<OmaSetting>(OmaSetting.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OmaSetting>("omaSettings", OmaSettings);
        }
    }
}