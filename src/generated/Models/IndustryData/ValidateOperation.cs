// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.IndustryData
{
    /// <summary>
    /// The status of a long-running operation.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ValidateOperation : global::ApiSdk.Models.LongRunningOperation, IParsable
    {
        /// <summary>Set of errors discovered through validation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PublicError>? Errors { get; private set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PublicError> Errors { get; private set; }
#endif
        /// <summary>Set of warnings discovered through validation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PublicError>? Warnings { get; private set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PublicError> Warnings { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IndustryData.ValidateOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.IndustryData.ValidateOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.industryData.fileValidateOperation" => new global::ApiSdk.Models.IndustryData.FileValidateOperation(),
                _ => new global::ApiSdk.Models.IndustryData.ValidateOperation(),
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
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PublicError>(global::ApiSdk.Models.PublicError.CreateFromDiscriminatorValue)?.AsList(); } },
                { "warnings", n => { Warnings = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PublicError>(global::ApiSdk.Models.PublicError.CreateFromDiscriminatorValue)?.AsList(); } },
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
        }
    }
}
#pragma warning restore CS0618
