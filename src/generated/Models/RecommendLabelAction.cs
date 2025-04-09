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
    public partial class RecommendLabelAction : global::ApiSdk.Models.InformationProtectionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Actions to take if the label is accepted by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.InformationProtectionAction>? Actions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.InformationProtectionAction> Actions { get; set; }
#endif
        /// <summary>The actionSource property</summary>
        public global::ApiSdk.Models.ActionSource? ActionSource { get; set; }
        /// <summary>The label that is being recommended.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LabelDetails? Label { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LabelDetails Label { get; set; }
#endif
        /// <summary>The sensitive information type GUIDs that caused the recommendation to be given.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? ResponsibleSensitiveTypeIds { get; set; }
#nullable restore
#else
        public List<Guid?> ResponsibleSensitiveTypeIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.RecommendLabelAction"/> and sets the default values.
        /// </summary>
        public RecommendLabelAction() : base()
        {
            OdataType = "#microsoft.graph.recommendLabelAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RecommendLabelAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.RecommendLabelAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.RecommendLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionSource", n => { ActionSource = n.GetEnumValue<global::ApiSdk.Models.ActionSource>(); } },
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.InformationProtectionAction>(global::ApiSdk.Models.InformationProtectionAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "label", n => { Label = n.GetObjectValue<global::ApiSdk.Models.LabelDetails>(global::ApiSdk.Models.LabelDetails.CreateFromDiscriminatorValue); } },
                { "responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.InformationProtectionAction>("actions", Actions);
            writer.WriteEnumValue<global::ApiSdk.Models.ActionSource>("actionSource", ActionSource);
            writer.WriteObjectValue<global::ApiSdk.Models.LabelDetails>("label", Label);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
        }
    }
}
#pragma warning restore CS0618
