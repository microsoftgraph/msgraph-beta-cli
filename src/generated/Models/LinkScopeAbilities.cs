// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class LinkScopeAbilities : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The blockDownload link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LinkRoleAbilities? BlockDownloadLinkAbilities { get; set; }
#nullable restore
#else
        public LinkRoleAbilities BlockDownloadLinkAbilities { get; set; }
#endif
        /// <summary>The editLinkAbilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LinkRoleAbilities? EditLinkAbilities { get; set; }
#nullable restore
#else
        public LinkRoleAbilities EditLinkAbilities { get; set; }
#endif
        /// <summary>The manageList link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LinkRoleAbilities? ManageListLinkAbilities { get; set; }
#nullable restore
#else
        public LinkRoleAbilities ManageListLinkAbilities { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The readLinkAbilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LinkRoleAbilities? ReadLinkAbilities { get; set; }
#nullable restore
#else
        public LinkRoleAbilities ReadLinkAbilities { get; set; }
#endif
        /// <summary>The review link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LinkRoleAbilities? ReviewLinkAbilities { get; set; }
#nullable restore
#else
        public LinkRoleAbilities ReviewLinkAbilities { get; set; }
#endif
        /// <summary>The submitOnly link abilities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LinkRoleAbilities? SubmitOnlyLinkAbilities { get; set; }
#nullable restore
#else
        public LinkRoleAbilities SubmitOnlyLinkAbilities { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="LinkScopeAbilities"/> and sets the default values.
        /// </summary>
        public LinkScopeAbilities()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LinkScopeAbilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LinkScopeAbilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LinkScopeAbilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "blockDownloadLinkAbilities", n => { BlockDownloadLinkAbilities = n.GetObjectValue<LinkRoleAbilities>(LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "editLinkAbilities", n => { EditLinkAbilities = n.GetObjectValue<LinkRoleAbilities>(LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "manageListLinkAbilities", n => { ManageListLinkAbilities = n.GetObjectValue<LinkRoleAbilities>(LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "readLinkAbilities", n => { ReadLinkAbilities = n.GetObjectValue<LinkRoleAbilities>(LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "reviewLinkAbilities", n => { ReviewLinkAbilities = n.GetObjectValue<LinkRoleAbilities>(LinkRoleAbilities.CreateFromDiscriminatorValue); } },
                { "submitOnlyLinkAbilities", n => { SubmitOnlyLinkAbilities = n.GetObjectValue<LinkRoleAbilities>(LinkRoleAbilities.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<LinkRoleAbilities>("blockDownloadLinkAbilities", BlockDownloadLinkAbilities);
            writer.WriteObjectValue<LinkRoleAbilities>("editLinkAbilities", EditLinkAbilities);
            writer.WriteObjectValue<LinkRoleAbilities>("manageListLinkAbilities", ManageListLinkAbilities);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<LinkRoleAbilities>("readLinkAbilities", ReadLinkAbilities);
            writer.WriteObjectValue<LinkRoleAbilities>("reviewLinkAbilities", ReviewLinkAbilities);
            writer.WriteObjectValue<LinkRoleAbilities>("submitOnlyLinkAbilities", SubmitOnlyLinkAbilities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}