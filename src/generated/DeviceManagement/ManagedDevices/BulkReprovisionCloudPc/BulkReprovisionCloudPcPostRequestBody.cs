// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.DeviceManagement.ManagedDevices.BulkReprovisionCloudPc
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class BulkReprovisionCloudPcPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The managedDeviceIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ManagedDeviceIds { get; set; }
#nullable restore
#else
        public List<string> ManagedDeviceIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.ManagedDevices.BulkReprovisionCloudPc.BulkReprovisionCloudPcPostRequestBody"/> and sets the default values.
        /// </summary>
        public BulkReprovisionCloudPcPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.DeviceManagement.ManagedDevices.BulkReprovisionCloudPc.BulkReprovisionCloudPcPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.DeviceManagement.ManagedDevices.BulkReprovisionCloudPc.BulkReprovisionCloudPcPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.DeviceManagement.ManagedDevices.BulkReprovisionCloudPc.BulkReprovisionCloudPcPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "managedDeviceIds", n => { ManagedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("managedDeviceIds", ManagedDeviceIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
