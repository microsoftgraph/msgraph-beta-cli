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
    public partial class AccessPackageResource : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains the environment information for the resource. This environment can be set using either the @odata.bind annotation or the environment&apos;s originId. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AccessPackageResourceEnvironment? AccessPackageResourceEnvironment { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AccessPackageResourceEnvironment AccessPackageResourceEnvironment { get; set; }
#endif
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageResourceRole>? AccessPackageResourceRoles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageResourceRole> AccessPackageResourceRoles { get; set; }
#endif
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageResourceScope>? AccessPackageResourceScopes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageResourceScope> AccessPackageResourceScopes { get; set; }
#endif
        /// <summary>The name of the user or application that first added this resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddedBy { get; set; }
#nullable restore
#else
        public string AddedBy { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? AddedOn { get; set; }
        /// <summary>Contains information about the attributes to be collected from the requestor and sent to the resource application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageResourceAttribute>? Attributes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageResourceAttribute> Attributes { get; set; }
#endif
        /// <summary>A description for the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the resource, such as the application name, group name, or site name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>True if the resource is not yet available for assignment. Read-only.</summary>
        public bool? IsPendingOnboarding { get; set; }
        /// <summary>The unique identifier of the resource in the origin system. In the case of a Microsoft Entra group, originId is the identifier of the group. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginId { get; set; }
#nullable restore
#else
        public string OriginId { get; set; }
#endif
        /// <summary>The type of the resource in the origin system, such as SharePointOnline, AadApplication, or AadGroup. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginSystem { get; set; }
#nullable restore
#else
        public string OriginSystem { get; set; }
#endif
        /// <summary>The type of the resource, such as Application if it is a Microsoft Entra connected application, or SharePoint Online Site for a SharePoint Online site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType { get; set; }
#nullable restore
#else
        public string ResourceType { get; set; }
#endif
        /// <summary>A unique resource locator for the resource, such as the URL for signing a user into an application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AccessPackageResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AccessPackageResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AccessPackageResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackageResourceEnvironment", n => { AccessPackageResourceEnvironment = n.GetObjectValue<global::ApiSdk.Models.AccessPackageResourceEnvironment>(global::ApiSdk.Models.AccessPackageResourceEnvironment.CreateFromDiscriminatorValue); } },
                { "accessPackageResourceRoles", n => { AccessPackageResourceRoles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceRole>(global::ApiSdk.Models.AccessPackageResourceRole.CreateFromDiscriminatorValue)?.AsList(); } },
                { "accessPackageResourceScopes", n => { AccessPackageResourceScopes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceScope>(global::ApiSdk.Models.AccessPackageResourceScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "addedBy", n => { AddedBy = n.GetStringValue(); } },
                { "addedOn", n => { AddedOn = n.GetDateTimeOffsetValue(); } },
                { "attributes", n => { Attributes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceAttribute>(global::ApiSdk.Models.AccessPackageResourceAttribute.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isPendingOnboarding", n => { IsPendingOnboarding = n.GetBoolValue(); } },
                { "originId", n => { OriginId = n.GetStringValue(); } },
                { "originSystem", n => { OriginSystem = n.GetStringValue(); } },
                { "resourceType", n => { ResourceType = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.AccessPackageResourceEnvironment>("accessPackageResourceEnvironment", AccessPackageResourceEnvironment);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceRole>("accessPackageResourceRoles", AccessPackageResourceRoles);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceScope>("accessPackageResourceScopes", AccessPackageResourceScopes);
            writer.WriteStringValue("addedBy", AddedBy);
            writer.WriteDateTimeOffsetValue("addedOn", AddedOn);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceAttribute>("attributes", Attributes);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isPendingOnboarding", IsPendingOnboarding);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteStringValue("url", Url);
        }
    }
}
#pragma warning restore CS0618
