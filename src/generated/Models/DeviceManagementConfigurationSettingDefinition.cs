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
    public partial class DeviceManagementConfigurationSettingDefinition : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessTypes property</summary>
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingAccessTypes? AccessTypes { get; set; }
        /// <summary>Details which device setting is applicable on</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingApplicability? Applicability { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingApplicability Applicability { get; set; }
#endif
        /// <summary>Base CSP Path</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUri { get; set; }
#nullable restore
#else
        public string BaseUri { get; set; }
#endif
        /// <summary>Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CategoryId { get; set; }
#nullable restore
#else
        public string CategoryId { get; set; }
#endif
        /// <summary>Description of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display name of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Help text of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HelpText { get; set; }
#nullable restore
#else
        public string HelpText { get; set; }
#endif
        /// <summary>List of links more info for the setting can be found at</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InfoUrls { get; set; }
#nullable restore
#else
        public List<string> InfoUrls { get; set; }
#endif
        /// <summary>Tokens which to search settings on</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Keywords { get; set; }
#nullable restore
#else
        public List<string> Keywords { get; set; }
#endif
        /// <summary>Name of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Indicates whether the setting is required or not</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingOccurrence? Occurrence { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingOccurrence Occurrence { get; set; }
#endif
        /// <summary>Offset CSP Path from Base</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OffsetUri { get; set; }
#nullable restore
#else
        public string OffsetUri { get; set; }
#endif
        /// <summary>List of referred setting information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceManagementConfigurationReferredSettingInformation>? ReferredSettingInformationList { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceManagementConfigurationReferredSettingInformation> ReferredSettingInformationList { get; set; }
#endif
        /// <summary>Setting RiskLevel</summary>
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingRiskLevel? RiskLevel { get; set; }
        /// <summary>Root setting definition if the setting is a child setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RootDefinitionId { get; set; }
#nullable restore
#else
        public string RootDefinitionId { get; set; }
#endif
        /// <summary>Supported setting types</summary>
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }
        /// <summary>Setting control type representation in the UX</summary>
        public global::ApiSdk.Models.DeviceManagementConfigurationControlType? UxBehavior { get; set; }
        /// <summary>Item Version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>Supported setting types</summary>
        public global::ApiSdk.Models.DeviceManagementConfigurationSettingVisibility? Visibility { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceManagementConfigurationSettingDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DeviceManagementConfigurationSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationChoiceSettingCollectionDefinition(),
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationChoiceSettingDefinition(),
                "#microsoft.graph.deviceManagementConfigurationRedirectSettingDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationRedirectSettingDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupCollectionDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationSettingGroupCollectionDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationSettingGroupDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingCollectionDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingDefinition" => new global::ApiSdk.Models.DeviceManagementConfigurationSimpleSettingDefinition(),
                _ => new global::ApiSdk.Models.DeviceManagementConfigurationSettingDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessTypes", n => { AccessTypes = n.GetEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingAccessTypes>(); } },
                { "applicability", n => { Applicability = n.GetObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingApplicability>(global::ApiSdk.Models.DeviceManagementConfigurationSettingApplicability.CreateFromDiscriminatorValue); } },
                { "baseUri", n => { BaseUri = n.GetStringValue(); } },
                { "categoryId", n => { CategoryId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "helpText", n => { HelpText = n.GetStringValue(); } },
                { "infoUrls", n => { InfoUrls = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "keywords", n => { Keywords = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "occurrence", n => { Occurrence = n.GetObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingOccurrence>(global::ApiSdk.Models.DeviceManagementConfigurationSettingOccurrence.CreateFromDiscriminatorValue); } },
                { "offsetUri", n => { OffsetUri = n.GetStringValue(); } },
                { "referredSettingInformationList", n => { ReferredSettingInformationList = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationReferredSettingInformation>(global::ApiSdk.Models.DeviceManagementConfigurationReferredSettingInformation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "riskLevel", n => { RiskLevel = n.GetEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingRiskLevel>(); } },
                { "rootDefinitionId", n => { RootDefinitionId = n.GetStringValue(); } },
                { "settingUsage", n => { SettingUsage = n.GetEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingUsage>(); } },
                { "uxBehavior", n => { UxBehavior = n.GetEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationControlType>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingVisibility>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingAccessTypes>("accessTypes", AccessTypes);
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingApplicability>("applicability", Applicability);
            writer.WriteStringValue("baseUri", BaseUri);
            writer.WriteStringValue("categoryId", CategoryId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteCollectionOfPrimitiveValues<string>("infoUrls", InfoUrls);
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingOccurrence>("occurrence", Occurrence);
            writer.WriteStringValue("offsetUri", OffsetUri);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DeviceManagementConfigurationReferredSettingInformation>("referredSettingInformationList", ReferredSettingInformationList);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingRiskLevel>("riskLevel", RiskLevel);
            writer.WriteStringValue("rootDefinitionId", RootDefinitionId);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingUsage>("settingUsage", SettingUsage);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationControlType>("uxBehavior", UxBehavior);
            writer.WriteStringValue("version", Version);
            writer.WriteEnumValue<global::ApiSdk.Models.DeviceManagementConfigurationSettingVisibility>("visibility", Visibility);
        }
    }
}
#pragma warning restore CS0618
