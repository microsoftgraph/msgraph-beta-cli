// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CloudPcServicePlan : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name for the service plan. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Specifies the type of license used when provisioning Cloud PCs. By default, the license type is dedicated. Possible values are: dedicated, shared, unknownFutureValue, sharedByUser, sharedByEntraGroup. You must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: sharedByUser, sharedByEntraGroup. The shared member is deprecated and will stop returning on April 30, 2027; going forward, use the sharedByUser member.</summary>
        public global::ApiSdk.Models.CloudPcProvisioningType? ProvisioningType { get; set; }
        /// <summary>The size of the RAM in GB. Read-only.</summary>
        public int? RamInGB { get; set; }
        /// <summary>The size of the OS Disk in GB. Read-only.</summary>
        public int? StorageInGB { get; set; }
        /// <summary>The supportedSolution property</summary>
        public global::ApiSdk.Models.CloudPcManagementService? SupportedSolution { get; set; }
        /// <summary>The type of the service plan. Possible values are: enterprise, business, unknownFutureValue. Read-only.</summary>
        public global::ApiSdk.Models.CloudPcServicePlanType? Type { get; set; }
        /// <summary>The size of the user profile disk in GB. Read-only.</summary>
        public int? UserProfileInGB { get; set; }
        /// <summary>The number of vCPUs. Read-only.</summary>
        public int? VCpuCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CloudPcServicePlan"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CloudPcServicePlan CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CloudPcServicePlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "provisioningType", n => { ProvisioningType = n.GetEnumValue<global::ApiSdk.Models.CloudPcProvisioningType>(); } },
                { "ramInGB", n => { RamInGB = n.GetIntValue(); } },
                { "storageInGB", n => { StorageInGB = n.GetIntValue(); } },
                { "supportedSolution", n => { SupportedSolution = n.GetEnumValue<global::ApiSdk.Models.CloudPcManagementService>(); } },
                { "type", n => { Type = n.GetEnumValue<global::ApiSdk.Models.CloudPcServicePlanType>(); } },
                { "userProfileInGB", n => { UserProfileInGB = n.GetIntValue(); } },
                { "vCpuCount", n => { VCpuCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::ApiSdk.Models.CloudPcProvisioningType>("provisioningType", ProvisioningType);
            writer.WriteIntValue("ramInGB", RamInGB);
            writer.WriteIntValue("storageInGB", StorageInGB);
            writer.WriteEnumValue<global::ApiSdk.Models.CloudPcManagementService>("supportedSolution", SupportedSolution);
            writer.WriteEnumValue<global::ApiSdk.Models.CloudPcServicePlanType>("type", Type);
            writer.WriteIntValue("userProfileInGB", UserProfileInGB);
            writer.WriteIntValue("vCpuCount", VCpuCount);
        }
    }
}
#pragma warning restore CS0618
