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
    public partial class ServicePrincipalCreationPolicy : global::ApiSdk.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The excludes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ServicePrincipalCreationConditionSet>? Excludes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ServicePrincipalCreationConditionSet> Excludes { get; set; }
#endif
        /// <summary>The includes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ServicePrincipalCreationConditionSet>? Includes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ServicePrincipalCreationConditionSet> Includes { get; set; }
#endif
        /// <summary>The isBuiltIn property</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ServicePrincipalCreationPolicy"/> and sets the default values.
        /// </summary>
        public ServicePrincipalCreationPolicy() : base()
        {
            OdataType = "#microsoft.graph.servicePrincipalCreationPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ServicePrincipalCreationPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ServicePrincipalCreationPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ServicePrincipalCreationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "excludes", n => { Excludes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ServicePrincipalCreationConditionSet>(global::ApiSdk.Models.ServicePrincipalCreationConditionSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "includes", n => { Includes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ServicePrincipalCreationConditionSet>(global::ApiSdk.Models.ServicePrincipalCreationConditionSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ServicePrincipalCreationConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ServicePrincipalCreationConditionSet>("includes", Includes);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
        }
    }
}
#pragma warning restore CS0618
