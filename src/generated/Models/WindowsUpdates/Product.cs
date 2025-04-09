// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Product : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents an edition of a particular Windows product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsUpdates.Edition>? Editions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsUpdates.Edition> Editions { get; set; }
#endif
        /// <summary>The friendly names of the product. For example, Version 22H2 (OS build 22621). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FriendlyNames { get; set; }
#nullable restore
#else
        public List<string> FriendlyNames { get; set; }
#endif
        /// <summary>The name of the product group. For example, Windows 11. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupName { get; set; }
#nullable restore
#else
        public string GroupName { get; set; }
#endif
        /// <summary>Represents a known issue related to a Windows product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsUpdates.KnownIssue>? KnownIssues { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsUpdates.KnownIssue> KnownIssues { get; set; }
#endif
        /// <summary>The name of the product. For example, Windows 11, version 22H2. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Represents a product revision.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsUpdates.ProductRevision>? Revisions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsUpdates.ProductRevision> Revisions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsUpdates.Product"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsUpdates.Product CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsUpdates.Product();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "editions", n => { Editions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.Edition>(global::ApiSdk.Models.WindowsUpdates.Edition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "friendlyNames", n => { FriendlyNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "groupName", n => { GroupName = n.GetStringValue(); } },
                { "knownIssues", n => { KnownIssues = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.KnownIssue>(global::ApiSdk.Models.WindowsUpdates.KnownIssue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "revisions", n => { Revisions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.ProductRevision>(global::ApiSdk.Models.WindowsUpdates.ProductRevision.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.Edition>("editions", Editions);
            writer.WriteCollectionOfPrimitiveValues<string>("friendlyNames", FriendlyNames);
            writer.WriteStringValue("groupName", GroupName);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.KnownIssue>("knownIssues", KnownIssues);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.ProductRevision>("revisions", Revisions);
        }
    }
}
#pragma warning restore CS0618
