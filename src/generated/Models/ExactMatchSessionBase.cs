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
    public partial class ExactMatchSessionBase : global::ApiSdk.Models.ExactMatchJobBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The dataStoreId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataStoreId { get; set; }
#nullable restore
#else
        public string DataStoreId { get; set; }
#endif
        /// <summary>The processingCompletionDateTime property</summary>
        public DateTimeOffset? ProcessingCompletionDateTime { get; set; }
        /// <summary>The remainingBlockCount property</summary>
        public int? RemainingBlockCount { get; set; }
        /// <summary>The remainingJobCount property</summary>
        public int? RemainingJobCount { get; set; }
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The totalBlockCount property</summary>
        public int? TotalBlockCount { get; set; }
        /// <summary>The totalJobCount property</summary>
        public int? TotalJobCount { get; set; }
        /// <summary>The uploadCompletionDateTime property</summary>
        public DateTimeOffset? UploadCompletionDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ExactMatchSessionBase"/> and sets the default values.
        /// </summary>
        public ExactMatchSessionBase() : base()
        {
            OdataType = "#microsoft.graph.exactMatchSessionBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ExactMatchSessionBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ExactMatchSessionBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.exactMatchSession" => new global::ApiSdk.Models.ExactMatchSession(),
                _ => new global::ApiSdk.Models.ExactMatchSessionBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dataStoreId", n => { DataStoreId = n.GetStringValue(); } },
                { "processingCompletionDateTime", n => { ProcessingCompletionDateTime = n.GetDateTimeOffsetValue(); } },
                { "remainingBlockCount", n => { RemainingBlockCount = n.GetIntValue(); } },
                { "remainingJobCount", n => { RemainingJobCount = n.GetIntValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "totalBlockCount", n => { TotalBlockCount = n.GetIntValue(); } },
                { "totalJobCount", n => { TotalJobCount = n.GetIntValue(); } },
                { "uploadCompletionDateTime", n => { UploadCompletionDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("dataStoreId", DataStoreId);
            writer.WriteDateTimeOffsetValue("processingCompletionDateTime", ProcessingCompletionDateTime);
            writer.WriteIntValue("remainingBlockCount", RemainingBlockCount);
            writer.WriteIntValue("remainingJobCount", RemainingJobCount);
            writer.WriteStringValue("state", State);
            writer.WriteIntValue("totalBlockCount", TotalBlockCount);
            writer.WriteIntValue("totalJobCount", TotalJobCount);
            writer.WriteDateTimeOffsetValue("uploadCompletionDateTime", UploadCompletionDateTime);
        }
    }
}
#pragma warning restore CS0618
