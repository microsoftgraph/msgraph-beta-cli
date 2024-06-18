// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class LinkRoleAbilities : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates if the current user can add existing external user recipients to this sharing link.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? AddExistingExternalUsers { get; set; }
#nullable restore
#else
        public SharingOperationStatus AddExistingExternalUsers { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if the current user can add new external user recipients to this sharing link.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? AddNewExternalUsers { get; set; }
#nullable restore
#else
        public SharingOperationStatus AddNewExternalUsers { get; set; }
#endif
        /// <summary>Indicates the status of the potential sharing link variants. If selected, it generates a separate sharing link from the sharing link that would otherwise be generated without the variant, yet with an identical role and scope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingLinkVariants? ApplyVariants { get; set; }
#nullable restore
#else
        public SharingLinkVariants ApplyVariants { get; set; }
#endif
        /// <summary>Indicates if links of this role can be created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? CreateLink { get; set; }
#nullable restore
#else
        public SharingOperationStatus CreateLink { get; set; }
#endif
        /// <summary>Indicates if links of this role can be deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? DeleteLink { get; set; }
#nullable restore
#else
        public SharingOperationStatus DeleteLink { get; set; }
#endif
        /// <summary>Indicates if this link can include external users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? LinkAllowsExternalUsers { get; set; }
#nullable restore
#else
        public SharingOperationStatus LinkAllowsExternalUsers { get; set; }
#endif
        /// <summary>Indicates if links must expire, meaning the link is no longer usable after a specified time. If link expiration is enabled, a default link expiration time is provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingLinkExpirationStatus? LinkExpiration { get; set; }
#nullable restore
#else
        public SharingLinkExpirationStatus LinkExpiration { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates if links of this role can be retrieved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? RetrieveLink { get; set; }
#nullable restore
#else
        public SharingOperationStatus RetrieveLink { get; set; }
#endif
        /// <summary>Indicates if links of this role can be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? UpdateLink { get; set; }
#nullable restore
#else
        public SharingOperationStatus UpdateLink { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="LinkRoleAbilities"/> and sets the default values.
        /// </summary>
        public LinkRoleAbilities()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LinkRoleAbilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LinkRoleAbilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LinkRoleAbilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "addExistingExternalUsers", n => { AddExistingExternalUsers = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "addNewExternalUsers", n => { AddNewExternalUsers = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "applyVariants", n => { ApplyVariants = n.GetObjectValue<SharingLinkVariants>(SharingLinkVariants.CreateFromDiscriminatorValue); } },
                { "createLink", n => { CreateLink = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "deleteLink", n => { DeleteLink = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "linkAllowsExternalUsers", n => { LinkAllowsExternalUsers = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "linkExpiration", n => { LinkExpiration = n.GetObjectValue<SharingLinkExpirationStatus>(SharingLinkExpirationStatus.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "retrieveLink", n => { RetrieveLink = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "updateLink", n => { UpdateLink = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SharingOperationStatus>("addExistingExternalUsers", AddExistingExternalUsers);
            writer.WriteObjectValue<SharingOperationStatus>("addNewExternalUsers", AddNewExternalUsers);
            writer.WriteObjectValue<SharingLinkVariants>("applyVariants", ApplyVariants);
            writer.WriteObjectValue<SharingOperationStatus>("createLink", CreateLink);
            writer.WriteObjectValue<SharingOperationStatus>("deleteLink", DeleteLink);
            writer.WriteObjectValue<SharingOperationStatus>("linkAllowsExternalUsers", LinkAllowsExternalUsers);
            writer.WriteObjectValue<SharingLinkExpirationStatus>("linkExpiration", LinkExpiration);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SharingOperationStatus>("retrieveLink", RetrieveLink);
            writer.WriteObjectValue<SharingOperationStatus>("updateLink", UpdateLink);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}