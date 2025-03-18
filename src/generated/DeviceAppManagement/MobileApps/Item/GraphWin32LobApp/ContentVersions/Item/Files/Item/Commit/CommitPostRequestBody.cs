// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.Commit
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CommitPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fileEncryptionInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.FileEncryptionInfo? FileEncryptionInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.FileEncryptionInfo FileEncryptionInfo { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.Commit.CommitPostRequestBody"/> and sets the default values.
        /// </summary>
        public CommitPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.Commit.CommitPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.Commit.CommitPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.Commit.CommitPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fileEncryptionInfo", n => { FileEncryptionInfo = n.GetObjectValue<global::ApiSdk.Models.FileEncryptionInfo>(global::ApiSdk.Models.FileEncryptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.FileEncryptionInfo>("fileEncryptionInfo", FileEncryptionInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
