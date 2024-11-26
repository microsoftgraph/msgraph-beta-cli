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
    public partial class CopilotAdminLimitedMode : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ID of a Microsoft Entra group to which the value of the isEnabledForGroup property is applied value. The default value is null. This parameter is optional. If isEnabledForGroup is set to true, the groupId value must be provided in order for Copilot limited mode in Teams Meetings to be enabled for the members of the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId { get; set; }
#nullable restore
#else
        public string GroupId { get; set; }
#endif
        /// <summary>Enables the user to be in limited mode for Copilot in Teams meetings. When copilotAdminLimitedMode=true, users in this mode can ask any questions, but Copilot doesn&apos;t respond to certain questions related to inferring emotions, behavior, or judgments. When copilotAdminLimitedMode=false, it responds to any types of questions grounded to the meeting conversation. The default value is false.</summary>
        public bool? IsEnabledForGroup { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CopilotAdminLimitedMode"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CopilotAdminLimitedMode CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CopilotAdminLimitedMode();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "groupId", n => { GroupId = n.GetStringValue(); } },
                { "isEnabledForGroup", n => { IsEnabledForGroup = n.GetBoolValue(); } },
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
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteBoolValue("isEnabledForGroup", IsEnabledForGroup);
        }
    }
}
#pragma warning restore CS0618