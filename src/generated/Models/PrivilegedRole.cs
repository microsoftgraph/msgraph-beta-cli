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
    public partial class PrivilegedRole : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The assignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrivilegedRoleAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrivilegedRoleAssignment> Assignments { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PrivilegedRoleSettings? Settings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PrivilegedRoleSettings Settings { get; set; }
#endif
        /// <summary>The summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PrivilegedRoleSummary? Summary { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PrivilegedRoleSummary Summary { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PrivilegedRole"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PrivilegedRole CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PrivilegedRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PrivilegedRoleAssignment>(global::ApiSdk.Models.PrivilegedRoleAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "settings", n => { Settings = n.GetObjectValue<global::ApiSdk.Models.PrivilegedRoleSettings>(global::ApiSdk.Models.PrivilegedRoleSettings.CreateFromDiscriminatorValue); } },
                { "summary", n => { Summary = n.GetObjectValue<global::ApiSdk.Models.PrivilegedRoleSummary>(global::ApiSdk.Models.PrivilegedRoleSummary.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PrivilegedRoleAssignment>("assignments", Assignments);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::ApiSdk.Models.PrivilegedRoleSettings>("settings", Settings);
            writer.WriteObjectValue<global::ApiSdk.Models.PrivilegedRoleSummary>("summary", Summary);
        }
    }
}
#pragma warning restore CS0618
