// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class OnPremisesSipInfo : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the user is currently enabled for on-premises Skype for Business.</summary>
        public bool? IsSipEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates a fully qualified DNS name of the Microsoft Online Communications Server deployment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SipDeploymentLocation { get; set; }
#nullable restore
#else
        public string SipDeploymentLocation { get; set; }
#endif
        /// <summary>Serves as a unique identifier for each user on the on-premises Skype for Business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SipPrimaryAddress { get; set; }
#nullable restore
#else
        public string SipPrimaryAddress { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="OnPremisesSipInfo"/> and sets the default values.
        /// </summary>
        public OnPremisesSipInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OnPremisesSipInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesSipInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesSipInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"isSipEnabled", n => { IsSipEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sipDeploymentLocation", n => { SipDeploymentLocation = n.GetStringValue(); } },
                {"sipPrimaryAddress", n => { SipPrimaryAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isSipEnabled", IsSipEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sipDeploymentLocation", SipDeploymentLocation);
            writer.WriteStringValue("sipPrimaryAddress", SipPrimaryAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}