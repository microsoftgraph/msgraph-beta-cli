// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess {
    public class CrossTenantAccess : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of devices that accessed the external tenant.</summary>
        public long? DeviceCount { get; set; }
        /// <summary>The timestamp of the most recent access to the external tenant.</summary>
        public DateTimeOffset? LastAccessDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The tenant ID of the external tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceTenantId { get; set; }
#nullable restore
#else
        public string ResourceTenantId { get; set; }
#endif
        /// <summary>The name of the external tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceTenantName { get; set; }
#nullable restore
#else
        public string ResourceTenantName { get; set; }
#endif
        /// <summary>The domain of the external tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceTenantPrimaryDomain { get; set; }
#nullable restore
#else
        public string ResourceTenantPrimaryDomain { get; set; }
#endif
        /// <summary>The usageStatus property</summary>
        public ApiSdk.Models.Networkaccess.UsageStatus? UsageStatus { get; set; }
        /// <summary>The number of users that accessed the external tenant.</summary>
        public long? UserCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="CrossTenantAccess"/> and sets the default values.
        /// </summary>
        public CrossTenantAccess()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CrossTenantAccess"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CrossTenantAccess CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"deviceCount", n => { DeviceCount = n.GetLongValue(); } },
                {"lastAccessDateTime", n => { LastAccessDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"resourceTenantId", n => { ResourceTenantId = n.GetStringValue(); } },
                {"resourceTenantName", n => { ResourceTenantName = n.GetStringValue(); } },
                {"resourceTenantPrimaryDomain", n => { ResourceTenantPrimaryDomain = n.GetStringValue(); } },
                {"usageStatus", n => { UsageStatus = n.GetEnumValue<UsageStatus>(); } },
                {"userCount", n => { UserCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteDateTimeOffsetValue("lastAccessDateTime", LastAccessDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resourceTenantId", ResourceTenantId);
            writer.WriteStringValue("resourceTenantName", ResourceTenantName);
            writer.WriteStringValue("resourceTenantPrimaryDomain", ResourceTenantPrimaryDomain);
            writer.WriteEnumValue<UsageStatus>("usageStatus", UsageStatus);
            writer.WriteLongValue("userCount", UserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}