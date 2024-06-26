// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Represents a mapping between team identifiers for macOS system extensions and system extension types.
    /// </summary>
    public class MacOSSystemExtensionTypeMapping : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Flag enum representing the allowed macOS system extension types.</summary>
        public MacOSSystemExtensionType? AllowedTypes { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Gets or sets the team identifier used to sign the system extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamIdentifier { get; set; }
#nullable restore
#else
        public string TeamIdentifier { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MacOSSystemExtensionTypeMapping"/> and sets the default values.
        /// </summary>
        public MacOSSystemExtensionTypeMapping()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MacOSSystemExtensionTypeMapping"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MacOSSystemExtensionTypeMapping CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSystemExtensionTypeMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowedTypes", n => { AllowedTypes = n.GetEnumValue<MacOSSystemExtensionType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "teamIdentifier", n => { TeamIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MacOSSystemExtensionType>("allowedTypes", AllowedTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("teamIdentifier", TeamIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
