// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Base type for assignment targets.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceAndAppManagementAssignmentTarget : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the filter for the target assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceAndAppManagementAssignmentFilterId { get; set; }
#nullable restore
#else
        public string DeviceAndAppManagementAssignmentFilterId { get; set; }
#endif
        /// <summary>Represents type of the assignment filter.</summary>
        public global::ApiSdk.Models.DeviceAndAppManagementAssignmentFilterType? DeviceAndAppManagementAssignmentFilterType { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceAndAppManagementAssignmentTarget"/> and sets the default values.
        /// </summary>
        public DeviceAndAppManagementAssignmentTarget()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceAndAppManagementAssignmentTarget"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.DeviceAndAppManagementAssignmentTarget CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.allDevicesAssignmentTarget" => new global::ApiSdk.Models.AllDevicesAssignmentTarget(),
                "#microsoft.graph.allLicensedUsersAssignmentTarget" => new global::ApiSdk.Models.AllLicensedUsersAssignmentTarget(),
                "#microsoft.graph.androidFotaDeploymentAssignmentTarget" => new global::ApiSdk.Models.AndroidFotaDeploymentAssignmentTarget(),
                "#microsoft.graph.configurationManagerCollectionAssignmentTarget" => new global::ApiSdk.Models.ConfigurationManagerCollectionAssignmentTarget(),
                "#microsoft.graph.exclusionGroupAssignmentTarget" => new global::ApiSdk.Models.ExclusionGroupAssignmentTarget(),
                "#microsoft.graph.groupAssignmentTarget" => new global::ApiSdk.Models.GroupAssignmentTarget(),
                _ => new global::ApiSdk.Models.DeviceAndAppManagementAssignmentTarget(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceAndAppManagementAssignmentFilterId", n => { DeviceAndAppManagementAssignmentFilterId = n.GetStringValue(); } },
                { "deviceAndAppManagementAssignmentFilterType", n => { DeviceAndAppManagementAssignmentFilterType = n.GetEnumValue<global::ApiSdk.Models.DeviceAndAppManagementAssignmentFilterType>(); } },
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
            writer.WriteStringValue("deviceAndAppManagementAssignmentFilterId", DeviceAndAppManagementAssignmentFilterId);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceAndAppManagementAssignmentFilterType>("deviceAndAppManagementAssignmentFilterType", DeviceAndAppManagementAssignmentFilterType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
