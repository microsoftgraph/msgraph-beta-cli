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
    public partial class EncryptedGcpStorageBucketFinding : global::ApiSdk.Models.Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessibility property</summary>
        public global::ApiSdk.Models.GcpAccessType? Accessibility { get; set; }
        /// <summary>The encryptionManagedBy property</summary>
        public global::ApiSdk.Models.GcpEncryption? EncryptionManagedBy { get; set; }
        /// <summary>The storageBucket property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuthorizationSystemResource? StorageBucket { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuthorizationSystemResource StorageBucket { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EncryptedGcpStorageBucketFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.EncryptedGcpStorageBucketFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EncryptedGcpStorageBucketFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessibility", n => { Accessibility = n.GetEnumValue<global::ApiSdk.Models.GcpAccessType>(); } },
                { "encryptionManagedBy", n => { EncryptionManagedBy = n.GetEnumValue<global::ApiSdk.Models.GcpEncryption>(); } },
                { "storageBucket", n => { StorageBucket = n.GetObjectValue<global::ApiSdk.Models.AuthorizationSystemResource>(global::ApiSdk.Models.AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.GcpAccessType>("accessibility", Accessibility);
            writer.WriteEnumValue<global::ApiSdk.Models.GcpEncryption>("encryptionManagedBy", EncryptionManagedBy);
            writer.WriteObjectValue<global::ApiSdk.Models.AuthorizationSystemResource>("storageBucket", StorageBucket);
        }
    }
}
#pragma warning restore CS0618
