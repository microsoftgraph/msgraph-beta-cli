// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.ManagedTenants
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ManagementIntentInfo : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name for the management intent. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementIntentDisplayName { get; set; }
#nullable restore
#else
        public string ManagementIntentDisplayName { get; set; }
#endif
        /// <summary>The identifier for the management intent. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementIntentId { get; set; }
#nullable restore
#else
        public string ManagementIntentId { get; set; }
#endif
        /// <summary>The collection of management template information associated with the management intent. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateDetailedInfo>? ManagementTemplates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.ManagementTemplateDetailedInfo> ManagementTemplates { get; set; }
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
        /// Instantiates a new <see cref="global::ApiSdk.Models.ManagedTenants.ManagementIntentInfo"/> and sets the default values.
        /// </summary>
        public ManagementIntentInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedTenants.ManagementIntentInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ManagedTenants.ManagementIntentInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ManagedTenants.ManagementIntentInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "managementIntentDisplayName", n => { ManagementIntentDisplayName = n.GetStringValue(); } },
                { "managementIntentId", n => { ManagementIntentId = n.GetStringValue(); } },
                { "managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateDetailedInfo>(global::ApiSdk.Models.ManagedTenants.ManagementTemplateDetailedInfo.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("managementIntentDisplayName", ManagementIntentDisplayName);
            writer.WriteStringValue("managementIntentId", ManagementIntentId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.ManagementTemplateDetailedInfo>("managementTemplates", ManagementTemplates);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
