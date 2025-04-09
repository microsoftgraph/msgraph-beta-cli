// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.HealthMonitoring
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Alert : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alertType property</summary>
        public global::ApiSdk.Models.HealthMonitoring.AlertType? AlertType { get; set; }
        /// <summary>The category property</summary>
        public global::ApiSdk.Models.HealthMonitoring.Category? Category { get; set; }
        /// <summary>The time when Microsoft Entra Health monitoring generated the alert. Supports $orderby.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A key-value pair that contains the name of and link to the documentation to aid in investigation of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.HealthMonitoring.Documentation? Documentation { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.HealthMonitoring.Documentation Documentation { get; set; }
#endif
        /// <summary>Investigative information on the alert. This information typically includes counts of impacted objects, which include directory objects such as users, groups, and devices, and a pointer to supporting data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.HealthMonitoring.Enrichment? Enrichment { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.HealthMonitoring.Enrichment Enrichment { get; set; }
#endif
        /// <summary>The scenario property</summary>
        public global::ApiSdk.Models.HealthMonitoring.Scenario? Scenario { get; set; }
        /// <summary>The collection of signals that were used in the generation of the alert. These signals are sourced from serviceActivity APIs and are added to the alert as key-value pairs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.HealthMonitoring.Signals? Signals { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.HealthMonitoring.Signals Signals { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.HealthMonitoring.AlertState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.HealthMonitoring.Alert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.HealthMonitoring.Alert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.HealthMonitoring.Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alertType", n => { AlertType = n.GetEnumValue<global::ApiSdk.Models.HealthMonitoring.AlertType>(); } },
                { "category", n => { Category = n.GetEnumValue<global::ApiSdk.Models.HealthMonitoring.Category>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "documentation", n => { Documentation = n.GetObjectValue<global::ApiSdk.Models.HealthMonitoring.Documentation>(global::ApiSdk.Models.HealthMonitoring.Documentation.CreateFromDiscriminatorValue); } },
                { "enrichment", n => { Enrichment = n.GetObjectValue<global::ApiSdk.Models.HealthMonitoring.Enrichment>(global::ApiSdk.Models.HealthMonitoring.Enrichment.CreateFromDiscriminatorValue); } },
                { "scenario", n => { Scenario = n.GetEnumValue<global::ApiSdk.Models.HealthMonitoring.Scenario>(); } },
                { "signals", n => { Signals = n.GetObjectValue<global::ApiSdk.Models.HealthMonitoring.Signals>(global::ApiSdk.Models.HealthMonitoring.Signals.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.HealthMonitoring.AlertState>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.HealthMonitoring.AlertType>("alertType", AlertType);
            writer.WriteEnumValue<global::ApiSdk.Models.HealthMonitoring.Category>("category", Category);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.HealthMonitoring.Documentation>("documentation", Documentation);
            writer.WriteObjectValue<global::ApiSdk.Models.HealthMonitoring.Enrichment>("enrichment", Enrichment);
            writer.WriteEnumValue<global::ApiSdk.Models.HealthMonitoring.Scenario>("scenario", Scenario);
            writer.WriteObjectValue<global::ApiSdk.Models.HealthMonitoring.Signals>("signals", Signals);
            writer.WriteEnumValue<global::ApiSdk.Models.HealthMonitoring.AlertState>("state", State);
        }
    }
}
#pragma warning restore CS0618
