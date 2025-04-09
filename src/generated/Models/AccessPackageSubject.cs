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
    public partial class AccessPackageSubject : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Not Supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AltSecId { get; set; }
#nullable restore
#else
        public string AltSecId { get; set; }
#endif
        /// <summary>The date and time the subject is marked to be blocked from sign in or deleted. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.</summary>
        public DateTimeOffset? CleanupScheduledDateTime { get; set; }
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ConnectedOrganization? ConnectedOrganization { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ConnectedOrganization ConnectedOrganization { get; set; }
#endif
        /// <summary>The identifier of the connected organization of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectedOrganizationId { get; set; }
#nullable restore
#else
        public string ConnectedOrganizationId { get; set; }
#endif
        /// <summary>The display name of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email address of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The object identifier of the subject. null if the subject isn&apos;t yet a user in the tenant. Alternate key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId { get; set; }
#nullable restore
#else
        public string ObjectId { get; set; }
#endif
        /// <summary>A string representation of the principal&apos;s security identifier, if known, or null if the subject doesn&apos;t have a security identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSecurityIdentifier { get; set; }
#nullable restore
#else
        public string OnPremisesSecurityIdentifier { get; set; }
#endif
        /// <summary>The principal name, if known, of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalName { get; set; }
#nullable restore
#else
        public string PrincipalName { get; set; }
#endif
        /// <summary>The lifecycle of the subject user, if a guest. The possible values are: notDefined, notGoverned, governed, unknownFutureValue.</summary>
        public global::ApiSdk.Models.AccessPackageSubjectLifecycle? SubjectLifecycle { get; set; }
        /// <summary>The resource type of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AccessPackageSubject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AccessPackageSubject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AccessPackageSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "altSecId", n => { AltSecId = n.GetStringValue(); } },
                { "cleanupScheduledDateTime", n => { CleanupScheduledDateTime = n.GetDateTimeOffsetValue(); } },
                { "connectedOrganization", n => { ConnectedOrganization = n.GetObjectValue<global::ApiSdk.Models.ConnectedOrganization>(global::ApiSdk.Models.ConnectedOrganization.CreateFromDiscriminatorValue); } },
                { "connectedOrganizationId", n => { ConnectedOrganizationId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "objectId", n => { ObjectId = n.GetStringValue(); } },
                { "onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                { "principalName", n => { PrincipalName = n.GetStringValue(); } },
                { "subjectLifecycle", n => { SubjectLifecycle = n.GetEnumValue<global::ApiSdk.Models.AccessPackageSubjectLifecycle>(); } },
                { "type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteStringValue("altSecId", AltSecId);
            writer.WriteDateTimeOffsetValue("cleanupScheduledDateTime", CleanupScheduledDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
            writer.WriteStringValue("connectedOrganizationId", ConnectedOrganizationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteEnumValue<global::ApiSdk.Models.AccessPackageSubjectLifecycle>("subjectLifecycle", SubjectLifecycle);
            writer.WriteStringValue("type", Type);
        }
    }
}
#pragma warning restore CS0618
