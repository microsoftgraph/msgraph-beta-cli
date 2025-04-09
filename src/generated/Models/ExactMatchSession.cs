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
    public partial class ExactMatchSession : global::ApiSdk.Models.ExactMatchSessionBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The checksum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Checksum { get; set; }
#nullable restore
#else
        public string Checksum { get; set; }
#endif
        /// <summary>The dataUploadURI property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataUploadURI { get; set; }
#nullable restore
#else
        public string DataUploadURI { get; set; }
#endif
        /// <summary>The fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Fields { get; set; }
#nullable restore
#else
        public List<string> Fields { get; set; }
#endif
        /// <summary>The fileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The rowsPerBlock property</summary>
        public int? RowsPerBlock { get; set; }
        /// <summary>The salt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Salt { get; set; }
#nullable restore
#else
        public string Salt { get; set; }
#endif
        /// <summary>The uploadAgent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ExactMatchUploadAgent? UploadAgent { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ExactMatchUploadAgent UploadAgent { get; set; }
#endif
        /// <summary>The uploadAgentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UploadAgentId { get; set; }
#nullable restore
#else
        public string UploadAgentId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ExactMatchSession"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ExactMatchSession CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ExactMatchSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "checksum", n => { Checksum = n.GetStringValue(); } },
                { "dataUploadURI", n => { DataUploadURI = n.GetStringValue(); } },
                { "fields", n => { Fields = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "rowsPerBlock", n => { RowsPerBlock = n.GetIntValue(); } },
                { "salt", n => { Salt = n.GetStringValue(); } },
                { "uploadAgent", n => { UploadAgent = n.GetObjectValue<global::ApiSdk.Models.ExactMatchUploadAgent>(global::ApiSdk.Models.ExactMatchUploadAgent.CreateFromDiscriminatorValue); } },
                { "uploadAgentId", n => { UploadAgentId = n.GetStringValue(); } },
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
            writer.WriteStringValue("checksum", Checksum);
            writer.WriteStringValue("dataUploadURI", DataUploadURI);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteIntValue("rowsPerBlock", RowsPerBlock);
            writer.WriteStringValue("salt", Salt);
            writer.WriteObjectValue<global::ApiSdk.Models.ExactMatchUploadAgent>("uploadAgent", UploadAgent);
            writer.WriteStringValue("uploadAgentId", UploadAgentId);
        }
    }
}
#pragma warning restore CS0618
