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
    public partial class ExternalIdentitiesPolicy : global::ApiSdk.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Reserved for future use.</summary>
        public bool? AllowDeletedIdentitiesDataRemoval { get; set; }
        /// <summary>Defines whether external users can leave the guest tenant. If set to false, self-service controls are disabled, and the admin of the guest tenant must manually remove the external user from the guest tenant. When the external user leaves the tenant, their data in the guest tenant is first soft-deleted then permanently deleted in 30 days.</summary>
        public bool? AllowExternalIdentitiesToLeave { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ExternalIdentitiesPolicy"/> and sets the default values.
        /// </summary>
        public ExternalIdentitiesPolicy() : base()
        {
            OdataType = "#microsoft.graph.externalIdentitiesPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ExternalIdentitiesPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ExternalIdentitiesPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ExternalIdentitiesPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowDeletedIdentitiesDataRemoval", n => { AllowDeletedIdentitiesDataRemoval = n.GetBoolValue(); } },
                { "allowExternalIdentitiesToLeave", n => { AllowExternalIdentitiesToLeave = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("allowDeletedIdentitiesDataRemoval", AllowDeletedIdentitiesDataRemoval);
            writer.WriteBoolValue("allowExternalIdentitiesToLeave", AllowExternalIdentitiesToLeave);
        }
    }
}
#pragma warning restore CS0618
