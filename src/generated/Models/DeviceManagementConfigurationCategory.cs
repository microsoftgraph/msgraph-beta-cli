// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Device Management Configuration Policy
    /// </summary>
    public class DeviceManagementConfigurationCategory : Entity, IParsable 
    {
        /// <summary>Description of the category header in policy summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CategoryDescription { get; set; }
#nullable restore
#else
        public string CategoryDescription { get; set; }
#endif
        /// <summary>List of child ids of the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ChildCategoryIds { get; set; }
#nullable restore
#else
        public List<string> ChildCategoryIds { get; set; }
#endif
        /// <summary>Description of the category. For example: Display</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name of the category. For example: Device Lock</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Help text of the category. Give more details of the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HelpText { get; set; }
#nullable restore
#else
        public string HelpText { get; set; }
#endif
        /// <summary>Name of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Direct parent id of the category. If the category is the root, the parent id is same as its id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentCategoryId { get; set; }
#nullable restore
#else
        public string ParentCategoryId { get; set; }
#endif
        /// <summary>Supported platform types.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
        /// <summary>Root id of the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RootCategoryId { get; set; }
#nullable restore
#else
        public string RootCategoryId { get; set; }
#endif
        /// <summary>Supported setting types</summary>
        public DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }
        /// <summary>Describes which technology this setting can be deployed with</summary>
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementConfigurationCategory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationCategory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"categoryDescription", n => { CategoryDescription = n.GetStringValue(); } },
                {"childCategoryIds", n => { ChildCategoryIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"helpText", n => { HelpText = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parentCategoryId", n => { ParentCategoryId = n.GetStringValue(); } },
                {"platforms", n => { Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"rootCategoryId", n => { RootCategoryId = n.GetStringValue(); } },
                {"settingUsage", n => { SettingUsage = n.GetEnumValue<DeviceManagementConfigurationSettingUsage>(); } },
                {"technologies", n => { Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
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
            writer.WriteStringValue("categoryDescription", CategoryDescription);
            writer.WriteCollectionOfPrimitiveValues<string>("childCategoryIds", ChildCategoryIds);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentCategoryId", ParentCategoryId);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platforms", Platforms);
            writer.WriteStringValue("rootCategoryId", RootCategoryId);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingUsage>("settingUsage", SettingUsage);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
        }
    }
}