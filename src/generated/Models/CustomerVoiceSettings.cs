// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CustomerVoiceSettings : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Controls whether phishing protection is run on forms created by users, blocking the creation of forms if common phishing questions are detected.</summary>
        public bool? IsInOrgFormsPhishingScanEnabled { get; set; }
        /// <summary>Controls whether the names of users who fill out forms are recorded.</summary>
        public bool? IsRecordIdentityByDefaultEnabled { get; set; }
        /// <summary>Controls whether only users inside your organization can submit a response.</summary>
        public bool? IsRestrictedSurveyAccessEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CustomerVoiceSettings"/> and sets the default values.
        /// </summary>
        public CustomerVoiceSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomerVoiceSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomerVoiceSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomerVoiceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"isInOrgFormsPhishingScanEnabled", n => { IsInOrgFormsPhishingScanEnabled = n.GetBoolValue(); } },
                {"isRecordIdentityByDefaultEnabled", n => { IsRecordIdentityByDefaultEnabled = n.GetBoolValue(); } },
                {"isRestrictedSurveyAccessEnabled", n => { IsRestrictedSurveyAccessEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isInOrgFormsPhishingScanEnabled", IsInOrgFormsPhishingScanEnabled);
            writer.WriteBoolValue("isRecordIdentityByDefaultEnabled", IsRecordIdentityByDefaultEnabled);
            writer.WriteBoolValue("isRestrictedSurveyAccessEnabled", IsRestrictedSurveyAccessEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}