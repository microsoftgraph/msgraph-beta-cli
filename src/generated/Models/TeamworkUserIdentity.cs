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
    public partial class TeamworkUserIdentity : global::ApiSdk.Models.Identity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Type of user. Possible values are: aadUser, onPremiseAadUser, anonymousGuest, federatedUser, personalMicrosoftAccountUser, skypeUser, phoneUser, emailUser and azureCommunicationServicesUser.</summary>
        public global::ApiSdk.Models.TeamworkUserIdentityType? UserIdentityType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.TeamworkUserIdentity"/> and sets the default values.
        /// </summary>
        public TeamworkUserIdentity() : base()
        {
            OdataType = "#microsoft.graph.teamworkUserIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TeamworkUserIdentity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.TeamworkUserIdentity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TeamworkUserIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "userIdentityType", n => { UserIdentityType = n.GetEnumValue<global::ApiSdk.Models.TeamworkUserIdentityType>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.TeamworkUserIdentityType>("userIdentityType", UserIdentityType);
        }
    }
}
#pragma warning restore CS0618
