// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class GcpRole : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the GCP role. Supports $filter and (eq,contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The ID of the GCP role as defined by GCP. Alternate key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The gcpRoleType property</summary>
        public ApiSdk.Models.GcpRoleType? GcpRoleType { get; set; }
        /// <summary>Resources that an identity assigned this GCP role can perform actions on. Supports $filter and (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GcpScope>? Scopes { get; set; }
#nullable restore
#else
        public List<GcpScope> Scopes { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GcpRole"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GcpRole CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GcpRole();
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
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "gcpRoleType", n => { GcpRoleType = n.GetEnumValue<GcpRoleType>(); } },
                { "scopes", n => { Scopes = n.GetCollectionOfObjectValues<GcpScope>(GcpScope.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteEnumValue<GcpRoleType>("gcpRoleType", GcpRoleType);
            writer.WriteCollectionOfObjectValues<GcpScope>("scopes", Scopes);
        }
    }
}
