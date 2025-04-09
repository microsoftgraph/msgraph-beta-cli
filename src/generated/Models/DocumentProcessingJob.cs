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
    public partial class DocumentProcessingJob : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The document processing job type. The possible values are: file, folder</summary>
        public global::ApiSdk.Models.DocumentProcessingJobType? JobType { get; set; }
        /// <summary>The listItemUniqueId of the file, or folder to process. Use GET driveItem resource operation and read  sharepointIds property to get listItemUniqueId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListItemUniqueId { get; set; }
#nullable restore
#else
        public string ListItemUniqueId { get; set; }
#endif
        /// <summary>The document processing Job status. The possible values are: inProgress, completed, failed, unknownFutureValue.</summary>
        public global::ApiSdk.Models.DocumentProcessingJobStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DocumentProcessingJob"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.DocumentProcessingJob CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DocumentProcessingJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "jobType", n => { JobType = n.GetEnumValue<global::ApiSdk.Models.DocumentProcessingJobType>(); } },
                { "listItemUniqueId", n => { ListItemUniqueId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.DocumentProcessingJobStatus>(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.DocumentProcessingJobType>("jobType", JobType);
            writer.WriteStringValue("listItemUniqueId", ListItemUniqueId);
            writer.WriteEnumValue<global::ApiSdk.Models.DocumentProcessingJobStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
