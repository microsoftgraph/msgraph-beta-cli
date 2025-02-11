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
    public partial class SharePointProtectionPolicy : global::ApiSdk.Models.ProtectionPolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The rules associated with the SharePoint Protection policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SiteProtectionRule>? SiteInclusionRules { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SiteProtectionRule> SiteInclusionRules { get; set; }
#endif
        /// <summary>The protection units (sites) that are protected under the site protection policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SiteProtectionUnit>? SiteProtectionUnits { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SiteProtectionUnit> SiteProtectionUnits { get; set; }
#endif
        /// <summary>The siteProtectionUnitsBulkAdditionJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SiteProtectionUnitsBulkAdditionJob>? SiteProtectionUnitsBulkAdditionJobs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SiteProtectionUnitsBulkAdditionJob> SiteProtectionUnitsBulkAdditionJobs { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SharePointProtectionPolicy"/> and sets the default values.
        /// </summary>
        public SharePointProtectionPolicy() : base()
        {
            OdataType = "#microsoft.graph.sharePointProtectionPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SharePointProtectionPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.SharePointProtectionPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.SharePointProtectionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "siteInclusionRules", n => { SiteInclusionRules = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SiteProtectionRule>(global::ApiSdk.Models.SiteProtectionRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "siteProtectionUnits", n => { SiteProtectionUnits = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SiteProtectionUnit>(global::ApiSdk.Models.SiteProtectionUnit.CreateFromDiscriminatorValue)?.AsList(); } },
                { "siteProtectionUnitsBulkAdditionJobs", n => { SiteProtectionUnitsBulkAdditionJobs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SiteProtectionUnitsBulkAdditionJob>(global::ApiSdk.Models.SiteProtectionUnitsBulkAdditionJob.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SiteProtectionRule>("siteInclusionRules", SiteInclusionRules);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SiteProtectionUnit>("siteProtectionUnits", SiteProtectionUnits);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SiteProtectionUnitsBulkAdditionJob>("siteProtectionUnitsBulkAdditionJobs", SiteProtectionUnitsBulkAdditionJobs);
        }
    }
}
#pragma warning restore CS0618
