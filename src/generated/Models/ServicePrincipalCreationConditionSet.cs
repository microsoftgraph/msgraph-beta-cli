// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ServicePrincipalCreationConditionSet : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The applicationIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApplicationIds { get; set; }
#nullable restore
#else
        public List<string> ApplicationIds { get; set; }
#endif
        /// <summary>The applicationPublisherIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApplicationPublisherIds { get; set; }
#nullable restore
#else
        public List<string> ApplicationPublisherIds { get; set; }
#endif
        /// <summary>The applicationsFromVerifiedPublisherOnly property</summary>
        public bool? ApplicationsFromVerifiedPublisherOnly { get; set; }
        /// <summary>The applicationTenantIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApplicationTenantIds { get; set; }
#nullable restore
#else
        public List<string> ApplicationTenantIds { get; set; }
#endif
        /// <summary>The certifiedApplicationsOnly property</summary>
        public bool? CertifiedApplicationsOnly { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ServicePrincipalCreationConditionSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServicePrincipalCreationConditionSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalCreationConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicationIds", n => { ApplicationIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "applicationPublisherIds", n => { ApplicationPublisherIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "applicationTenantIds", n => { ApplicationTenantIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "applicationsFromVerifiedPublisherOnly", n => { ApplicationsFromVerifiedPublisherOnly = n.GetBoolValue(); } },
                { "certifiedApplicationsOnly", n => { CertifiedApplicationsOnly = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("applicationIds", ApplicationIds);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationPublisherIds", ApplicationPublisherIds);
            writer.WriteBoolValue("applicationsFromVerifiedPublisherOnly", ApplicationsFromVerifiedPublisherOnly);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationTenantIds", ApplicationTenantIds);
            writer.WriteBoolValue("certifiedApplicationsOnly", CertifiedApplicationsOnly);
        }
    }
}
