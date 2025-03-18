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
    /// The DeviceAndAppManagementAssignedRoleDetail is a complex type in Microsoft Intune used to represent the Role Definitions and Permissions that are assigned to a specific user. This type provides a detailed view of the roles a user holds, along with the associated permissions that determine the specific actions the user can perform within Intune environment.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceAndAppManagementAssignedRoleDetail : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The list of permissions assigned to a specific user based on their associated role definitions. Each permission defines the specific actions the user can perform on Intune resources, such as managing devices, applications, or configurations. Some possible values are: Microsoft.Intune/MobileApps/Read, Microsoft.Intune/DeviceConfigurations/Write, Microsoft.Intune/ManagedDevices/Retire, and Microsoft.Intune/DeviceCompliancePolicies/Assign. This Permissions property provides a comprehensive view of the user&apos;s effective access rights, ensuring that they can only perform actions relevant to their assigned roles. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Permissions { get; private set; }
#nullable restore
#else
        public List<string> Permissions { get; private set; }
#endif
        /// <summary>A collection of RoleDefinitions represents the various administrative roles that define permissions and access levels within Microsoft Intune. Each RoleDefinition outlines a set of permissions that determine the actions an admin or user can perform in the Intune environment. These permissions can include actions like reading or writing to specific resources, managing device configurations, deploying policies, or handling user data. RoleDefinitions are critical for enforcing role-based access control (RBAC), ensuring that administrators can only interact with the features and data relevant to their responsibilities. RoleDefinitions in Intune can either be built-in roles provided by Microsoft or custom roles created by an organization to tailor access based on specific needs. These definitions are referenced when assigning roles to users or groups, effectively controlling the scope of their administrative privileges. The collection of RoleDefinitions is managed through the Intune console or the Graph API, allowing for scalable role management across large environments. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDefinition>? RoleDefinitions { get; private set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDefinition> RoleDefinitions { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDetail"/> and sets the default values.
        /// </summary>
        public DeviceAndAppManagementAssignedRoleDetail()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "permissions", n => { Permissions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDefinition>(global::ApiSdk.Models.DeviceAndAppManagementAssignedRoleDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
