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
    public partial class ManagementAction : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The category property</summary>
        public global::ApiSdk.Models.ManagedTenants.ManagementCategory? Category { get; set; }
        /// <summary>The description for the management action. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name for the management action. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The reference for the management template used to generate the management action. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceTemplateId { get; set; }
#nullable restore
#else
        public string ReferenceTemplateId { get; set; }
#endif
        /// <summary>The referenceTemplateVersion property</summary>
        public int? ReferenceTemplateVersion { get; set; }
        /// <summary>The collection of workload actions associated with the management action. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedTenants.WorkloadAction>? WorkloadActions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedTenants.WorkloadAction> WorkloadActions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedTenants.ManagementAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ManagedTenants.ManagementAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ManagedTenants.ManagementAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "category", n => { Category = n.GetEnumValue<global::ApiSdk.Models.ManagedTenants.ManagementCategory>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "referenceTemplateId", n => { ReferenceTemplateId = n.GetStringValue(); } },
                { "referenceTemplateVersion", n => { ReferenceTemplateVersion = n.GetIntValue(); } },
                { "workloadActions", n => { WorkloadActions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.WorkloadAction>(global::ApiSdk.Models.ManagedTenants.WorkloadAction.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.ManagedTenants.ManagementCategory>("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("referenceTemplateId", ReferenceTemplateId);
            writer.WriteIntValue("referenceTemplateVersion", ReferenceTemplateVersion);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedTenants.WorkloadAction>("workloadActions", WorkloadActions);
        }
    }
}
#pragma warning restore CS0618
