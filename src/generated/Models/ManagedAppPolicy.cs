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
    /// The ManagedAppPolicy resource represents a base type for platform specific policies.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedAppPolicy : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The date and time the policy was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The policy&apos;s description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Policy display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Last time the policy was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedAppPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ManagedAppPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedAppProtection" => new global::ApiSdk.Models.AndroidManagedAppProtection(),
                "#microsoft.graph.defaultManagedAppProtection" => new global::ApiSdk.Models.DefaultManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new global::ApiSdk.Models.IosManagedAppProtection(),
                "#microsoft.graph.managedAppConfiguration" => new global::ApiSdk.Models.ManagedAppConfiguration(),
                "#microsoft.graph.managedAppProtection" => new global::ApiSdk.Models.ManagedAppProtection(),
                "#microsoft.graph.mdmWindowsInformationProtectionPolicy" => new global::ApiSdk.Models.MdmWindowsInformationProtectionPolicy(),
                "#microsoft.graph.targetedManagedAppConfiguration" => new global::ApiSdk.Models.TargetedManagedAppConfiguration(),
                "#microsoft.graph.targetedManagedAppProtection" => new global::ApiSdk.Models.TargetedManagedAppProtection(),
                "#microsoft.graph.windowsInformationProtection" => new global::ApiSdk.Models.WindowsInformationProtection(),
                "#microsoft.graph.windowsInformationProtectionPolicy" => new global::ApiSdk.Models.WindowsInformationProtectionPolicy(),
                "#microsoft.graph.windowsManagedAppProtection" => new global::ApiSdk.Models.WindowsManagedAppProtection(),
                _ => new global::ApiSdk.Models.ManagedAppPolicy(),
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
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
