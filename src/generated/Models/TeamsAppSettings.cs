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
    public partial class TeamsAppSettings : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether users are allowed to request access to the unavailable Teams apps.</summary>
        public bool? AllowUserRequestsForAppAccess { get; set; }
        /// <summary>The customAppSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomAppSettings? CustomAppSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomAppSettings CustomAppSettings { get; set; }
#endif
        /// <summary>Indicates whether resource-specific consent for chats/meetings has been enabled for the tenant. True indicates that Teams apps that are allowed in the tenant and require resource-specific permissions can be installed inside chats and meetings. False blocks the installation of any Teams app that requires resource-specific permissions in a chat or a meeting.</summary>
        public bool? IsChatResourceSpecificConsentEnabled { get; set; }
        /// <summary>Indicates whether resource-specific consent for personal scope in Teams apps has been enabled for the tenant. True indicates that Teams apps that are allowed in the tenant and require resource-specific permissions can be installed in the personal scope. False blocks the installation of any Teams app that requires resource-specific permissions in the personal scope.</summary>
        public bool? IsUserPersonalScopeResourceSpecificConsentEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TeamsAppSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.TeamsAppSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TeamsAppSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowUserRequestsForAppAccess", n => { AllowUserRequestsForAppAccess = n.GetBoolValue(); } },
                { "customAppSettings", n => { CustomAppSettings = n.GetObjectValue<global::ApiSdk.Models.CustomAppSettings>(global::ApiSdk.Models.CustomAppSettings.CreateFromDiscriminatorValue); } },
                { "isChatResourceSpecificConsentEnabled", n => { IsChatResourceSpecificConsentEnabled = n.GetBoolValue(); } },
                { "isUserPersonalScopeResourceSpecificConsentEnabled", n => { IsUserPersonalScopeResourceSpecificConsentEnabled = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("allowUserRequestsForAppAccess", AllowUserRequestsForAppAccess);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomAppSettings>("customAppSettings", CustomAppSettings);
            writer.WriteBoolValue("isChatResourceSpecificConsentEnabled", IsChatResourceSpecificConsentEnabled);
            writer.WriteBoolValue("isUserPersonalScopeResourceSpecificConsentEnabled", IsUserPersonalScopeResourceSpecificConsentEnabled);
        }
    }
}
#pragma warning restore CS0618
