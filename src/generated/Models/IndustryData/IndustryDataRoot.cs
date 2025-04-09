// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IndustryDataRoot : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Set of connectors for importing data from source systems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.IndustryDataConnector>? DataConnectors { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.IndustryDataConnector> DataConnectors { get; set; }
#endif
        /// <summary>Set of data import flow activities to bring data into the canonical store via a connector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.InboundFlow>? InboundFlows { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.InboundFlow> InboundFlows { get; set; }
#endif
        /// <summary>Set of ephemeral operations that the system runs currently. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.LongRunningOperation>? Operations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.LongRunningOperation> Operations { get; set; }
#endif
        /// <summary>The outboundProvisioningFlowSets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.OutboundProvisioningFlowSet>? OutboundProvisioningFlowSets { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.OutboundProvisioningFlowSet> OutboundProvisioningFlowSets { get; set; }
#endif
        /// <summary>Set of user modifiable system picker types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.ReferenceDefinition>? ReferenceDefinitions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.ReferenceDefinition> ReferenceDefinitions { get; set; }
#endif
        /// <summary>Set of groups of individual roles that makes role-based admin simpler.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.RoleGroup>? RoleGroups { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.RoleGroup> RoleGroups { get; set; }
#endif
        /// <summary>Set of ephemeral runs which present the point-in-time that diagnostic state of activities performed by the system. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.IndustryDataRun>? Runs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.IndustryDataRun> Runs { get; set; }
#endif
        /// <summary>Set of source definitions that represents real-world external systems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.SourceSystemDefinition>? SourceSystems { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.SourceSystemDefinition> SourceSystems { get; set; }
#endif
        /// <summary>Set of years represented in the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.YearTimePeriodDefinition>? Years { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.YearTimePeriodDefinition> Years { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IndustryData.IndustryDataRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.IndustryData.IndustryDataRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.IndustryData.IndustryDataRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dataConnectors", n => { DataConnectors = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.IndustryDataConnector>(global::ApiSdk.Models.IndustryData.IndustryDataConnector.CreateFromDiscriminatorValue)?.AsList(); } },
                { "inboundFlows", n => { InboundFlows = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.InboundFlow>(global::ApiSdk.Models.IndustryData.InboundFlow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.LongRunningOperation>(global::ApiSdk.Models.LongRunningOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "outboundProvisioningFlowSets", n => { OutboundProvisioningFlowSets = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.OutboundProvisioningFlowSet>(global::ApiSdk.Models.IndustryData.OutboundProvisioningFlowSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "referenceDefinitions", n => { ReferenceDefinitions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.ReferenceDefinition>(global::ApiSdk.Models.IndustryData.ReferenceDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleGroups", n => { RoleGroups = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.RoleGroup>(global::ApiSdk.Models.IndustryData.RoleGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "runs", n => { Runs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.IndustryDataRun>(global::ApiSdk.Models.IndustryData.IndustryDataRun.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sourceSystems", n => { SourceSystems = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.SourceSystemDefinition>(global::ApiSdk.Models.IndustryData.SourceSystemDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "years", n => { Years = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.YearTimePeriodDefinition>(global::ApiSdk.Models.IndustryData.YearTimePeriodDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.IndustryDataConnector>("dataConnectors", DataConnectors);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.InboundFlow>("inboundFlows", InboundFlows);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.LongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.OutboundProvisioningFlowSet>("outboundProvisioningFlowSets", OutboundProvisioningFlowSets);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.ReferenceDefinition>("referenceDefinitions", ReferenceDefinitions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.RoleGroup>("roleGroups", RoleGroups);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.IndustryDataRun>("runs", Runs);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.SourceSystemDefinition>("sourceSystems", SourceSystems);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IndustryData.YearTimePeriodDefinition>("years", Years);
        }
    }
}
#pragma warning restore CS0618
