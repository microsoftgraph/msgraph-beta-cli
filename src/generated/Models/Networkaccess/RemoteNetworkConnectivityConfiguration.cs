// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class RemoteNetworkConnectivityConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of connectivity configurations for deviceLink objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConnectivityConfigurationLink>? Links { get; set; }
#nullable restore
#else
        public List<ConnectivityConfigurationLink> Links { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Unique identifier or a specific reference assigned to a branchSite. Key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteNetworkId { get; set; }
#nullable restore
#else
        public string RemoteNetworkId { get; set; }
#endif
        /// <summary>Display name assigned to a branchSite.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteNetworkName { get; set; }
#nullable restore
#else
        public string RemoteNetworkName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RemoteNetworkConnectivityConfiguration"/> and sets the default values.
        /// </summary>
        public RemoteNetworkConnectivityConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RemoteNetworkConnectivityConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RemoteNetworkConnectivityConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteNetworkConnectivityConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "links", n => { Links = n.GetCollectionOfObjectValues<ConnectivityConfigurationLink>(ConnectivityConfigurationLink.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "remoteNetworkId", n => { RemoteNetworkId = n.GetStringValue(); } },
                { "remoteNetworkName", n => { RemoteNetworkName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ConnectivityConfigurationLink>("links", Links);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("remoteNetworkId", RemoteNetworkId);
            writer.WriteStringValue("remoteNetworkName", RemoteNetworkName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
