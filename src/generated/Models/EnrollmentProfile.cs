// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// The enrollmentProfile resource represents a collection of configurations which must be provided pre-enrollment to enable enrolling certain devices whose identities have been pre-staged. Pre-staged device identities are assigned to this type of profile to apply the profile&apos;s configurations at enrollment of the corresponding device.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EnrollmentProfile : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Configuration endpoint url to use for Enrollment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationEndpointUrl { get; set; }
#nullable restore
#else
        public string ConfigurationEndpointUrl { get; set; }
#endif
        /// <summary>Description of the profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name of the profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicates to authenticate with Apple Setup Assistant instead of Company Portal.</summary>
        public bool? EnableAuthenticationViaCompanyPortal { get; set; }
        /// <summary>Indicates that Company Portal is required on setup assistant enrolled devices</summary>
        public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices { get; set; }
        /// <summary>Indicates if the profile requires user authentication</summary>
        public bool? RequiresUserAuthentication { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EnrollmentProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.EnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.depEnrollmentBaseProfile" => new global::ApiSdk.Models.DepEnrollmentBaseProfile(),
                "#microsoft.graph.depEnrollmentProfile" => new global::ApiSdk.Models.DepEnrollmentProfile(),
                "#microsoft.graph.depIOSEnrollmentProfile" => new global::ApiSdk.Models.DepIOSEnrollmentProfile(),
                "#microsoft.graph.depMacOSEnrollmentProfile" => new global::ApiSdk.Models.DepMacOSEnrollmentProfile(),
                "#microsoft.graph.depTvOSEnrollmentProfile" => new global::ApiSdk.Models.DepTvOSEnrollmentProfile(),
                "#microsoft.graph.depVisionOSEnrollmentProfile" => new global::ApiSdk.Models.DepVisionOSEnrollmentProfile(),
                _ => new global::ApiSdk.Models.EnrollmentProfile(),
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
                { "configurationEndpointUrl", n => { ConfigurationEndpointUrl = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enableAuthenticationViaCompanyPortal", n => { EnableAuthenticationViaCompanyPortal = n.GetBoolValue(); } },
                { "requireCompanyPortalOnSetupAssistantEnrolledDevices", n => { RequireCompanyPortalOnSetupAssistantEnrolledDevices = n.GetBoolValue(); } },
                { "requiresUserAuthentication", n => { RequiresUserAuthentication = n.GetBoolValue(); } },
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
            writer.WriteStringValue("configurationEndpointUrl", ConfigurationEndpointUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enableAuthenticationViaCompanyPortal", EnableAuthenticationViaCompanyPortal);
            writer.WriteBoolValue("requireCompanyPortalOnSetupAssistantEnrolledDevices", RequireCompanyPortalOnSetupAssistantEnrolledDevices);
            writer.WriteBoolValue("requiresUserAuthentication", RequiresUserAuthentication);
        }
    }
}
#pragma warning restore CS0618
