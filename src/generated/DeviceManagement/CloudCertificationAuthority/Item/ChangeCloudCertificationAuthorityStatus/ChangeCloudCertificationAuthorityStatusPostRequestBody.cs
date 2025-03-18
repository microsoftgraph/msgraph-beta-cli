// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.ChangeCloudCertificationAuthorityStatus
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ChangeCloudCertificationAuthorityStatusPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enum type of possible certification authority statuses. These statuses indicate whether a certification authority is currently able to issue certificates or temporarily paused or permanently revoked.</summary>
        public global::ApiSdk.Models.CloudCertificationAuthorityStatus? CertificationAuthorityStatus { get; set; }
        /// <summary>The certificationAuthorityVersion property</summary>
        public int? CertificationAuthorityVersion { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.ChangeCloudCertificationAuthorityStatus.ChangeCloudCertificationAuthorityStatusPostRequestBody"/> and sets the default values.
        /// </summary>
        public ChangeCloudCertificationAuthorityStatusPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.ChangeCloudCertificationAuthorityStatus.ChangeCloudCertificationAuthorityStatusPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.ChangeCloudCertificationAuthorityStatus.ChangeCloudCertificationAuthorityStatusPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.ChangeCloudCertificationAuthorityStatus.ChangeCloudCertificationAuthorityStatusPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "certificationAuthorityStatus", n => { CertificationAuthorityStatus = n.GetEnumValue<global::ApiSdk.Models.CloudCertificationAuthorityStatus>(); } },
                { "certificationAuthorityVersion", n => { CertificationAuthorityVersion = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.CloudCertificationAuthorityStatus>("certificationAuthorityStatus", CertificationAuthorityStatus);
            writer.WriteIntValue("certificationAuthorityVersion", CertificationAuthorityVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
