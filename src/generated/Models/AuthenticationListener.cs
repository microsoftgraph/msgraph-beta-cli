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
    public partial class AuthenticationListener : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The priority of the listener. Determines the order of evaluation when an event has multiple listeners. The priority is evaluated from low to high.</summary>
        public int? Priority { get; set; }
        /// <summary>Filter based on the source of the authentication that is used to determine whether the listener is evaluated, and is currently limited to evaluations based on application the user is authenticating to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuthenticationSourceFilter? SourceFilter { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuthenticationSourceFilter SourceFilter { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AuthenticationListener"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AuthenticationListener CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.invokeUserFlowListener" => new global::ApiSdk.Models.InvokeUserFlowListener(),
                _ => new global::ApiSdk.Models.AuthenticationListener(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "priority", n => { Priority = n.GetIntValue(); } },
                { "sourceFilter", n => { SourceFilter = n.GetObjectValue<global::ApiSdk.Models.AuthenticationSourceFilter>(global::ApiSdk.Models.AuthenticationSourceFilter.CreateFromDiscriminatorValue); } },
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
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<global::ApiSdk.Models.AuthenticationSourceFilter>("sourceFilter", SourceFilter);
        }
    }
}
#pragma warning restore CS0618
