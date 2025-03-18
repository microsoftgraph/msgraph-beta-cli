// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Users.Item.ManagedDevices.MoveDevicesToOU
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MoveDevicesToOUPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deviceIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? DeviceIds { get; set; }
#nullable restore
#else
        public List<Guid?> DeviceIds { get; set; }
#endif
        /// <summary>The organizationalUnitPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationalUnitPath { get; set; }
#nullable restore
#else
        public string OrganizationalUnitPath { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.ManagedDevices.MoveDevicesToOU.MoveDevicesToOUPostRequestBody"/> and sets the default values.
        /// </summary>
        public MoveDevicesToOUPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Users.Item.ManagedDevices.MoveDevicesToOU.MoveDevicesToOUPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Users.Item.ManagedDevices.MoveDevicesToOU.MoveDevicesToOUPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Users.Item.ManagedDevices.MoveDevicesToOU.MoveDevicesToOUPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceIds", n => { DeviceIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "organizationalUnitPath", n => { OrganizationalUnitPath = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<Guid?>("deviceIds", DeviceIds);
            writer.WriteStringValue("organizationalUnitPath", OrganizationalUnitPath);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
