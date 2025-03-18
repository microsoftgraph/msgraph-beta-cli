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
    public partial class AzureAssociatedIdentities : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The all property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AzureIdentity>? All { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AzureIdentity> All { get; set; }
#endif
        /// <summary>The managedIdentities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AzureManagedIdentity>? ManagedIdentities { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AzureManagedIdentity> ManagedIdentities { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The servicePrincipals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AzureServicePrincipal>? ServicePrincipals { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AzureServicePrincipal> ServicePrincipals { get; set; }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AzureUser>? Users { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AzureUser> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AzureAssociatedIdentities"/> and sets the default values.
        /// </summary>
        public AzureAssociatedIdentities()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AzureAssociatedIdentities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.AzureAssociatedIdentities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AzureAssociatedIdentities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "all", n => { All = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AzureIdentity>(global::ApiSdk.Models.AzureIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedIdentities", n => { ManagedIdentities = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AzureManagedIdentity>(global::ApiSdk.Models.AzureManagedIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "servicePrincipals", n => { ServicePrincipals = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AzureServicePrincipal>(global::ApiSdk.Models.AzureServicePrincipal.CreateFromDiscriminatorValue)?.AsList(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AzureUser>(global::ApiSdk.Models.AzureUser.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AzureIdentity>("all", All);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AzureManagedIdentity>("managedIdentities", ManagedIdentities);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AzureServicePrincipal>("servicePrincipals", ServicePrincipals);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AzureUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
