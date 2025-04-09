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
    public partial class AwsActionsPermissionsDefinitionAction : global::ApiSdk.Models.AwsPermissionsDefinitionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines AWS statements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignToRoleId { get; set; }
#nullable restore
#else
        public string AssignToRoleId { get; set; }
#endif
        /// <summary>The statements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AwsStatement>? Statements { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AwsStatement> Statements { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AwsActionsPermissionsDefinitionAction"/> and sets the default values.
        /// </summary>
        public AwsActionsPermissionsDefinitionAction() : base()
        {
            OdataType = "#microsoft.graph.awsActionsPermissionsDefinitionAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AwsActionsPermissionsDefinitionAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AwsActionsPermissionsDefinitionAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AwsActionsPermissionsDefinitionAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignToRoleId", n => { AssignToRoleId = n.GetStringValue(); } },
                { "statements", n => { Statements = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AwsStatement>(global::ApiSdk.Models.AwsStatement.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("assignToRoleId", AssignToRoleId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AwsStatement>("statements", Statements);
        }
    }
}
#pragma warning restore CS0618
