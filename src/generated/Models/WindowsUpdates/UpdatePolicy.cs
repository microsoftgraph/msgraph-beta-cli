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
    public partial class UpdatePolicy : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the audience to target.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WindowsUpdates.DeploymentAudience? Audience { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WindowsUpdates.DeploymentAudience Audience { get; set; }
#endif
        /// <summary>Rules for governing the automatic creation of compliance changes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsUpdates.ComplianceChangeRule>? ComplianceChangeRules { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsUpdates.ComplianceChangeRule> ComplianceChangeRules { get; set; }
#endif
        /// <summary>Compliance changes like content approvals which result in the automatic creation of deployments using the audience and deploymentSettings of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WindowsUpdates.ComplianceChange>? ComplianceChanges { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WindowsUpdates.ComplianceChange> ComplianceChanges { get; set; }
#endif
        /// <summary>The date and time when the update policy was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Settings for governing how to deploy content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WindowsUpdates.DeploymentSettings? DeploymentSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WindowsUpdates.DeploymentSettings DeploymentSettings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsUpdates.UpdatePolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsUpdates.UpdatePolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsUpdates.UpdatePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audience", n => { Audience = n.GetObjectValue<global::ApiSdk.Models.WindowsUpdates.DeploymentAudience>(global::ApiSdk.Models.WindowsUpdates.DeploymentAudience.CreateFromDiscriminatorValue); } },
                { "complianceChangeRules", n => { ComplianceChangeRules = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.ComplianceChangeRule>(global::ApiSdk.Models.WindowsUpdates.ComplianceChangeRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "complianceChanges", n => { ComplianceChanges = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.ComplianceChange>(global::ApiSdk.Models.WindowsUpdates.ComplianceChange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<global::ApiSdk.Models.WindowsUpdates.DeploymentSettings>(global::ApiSdk.Models.WindowsUpdates.DeploymentSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.WindowsUpdates.DeploymentAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.ComplianceChangeRule>("complianceChangeRules", ComplianceChangeRules);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WindowsUpdates.ComplianceChange>("complianceChanges", ComplianceChanges);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings", DeploymentSettings);
        }
    }
}
#pragma warning restore CS0618
