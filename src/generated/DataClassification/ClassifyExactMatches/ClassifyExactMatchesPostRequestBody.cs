// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DataClassification.ClassifyExactMatches
{
    #pragma warning disable CS1591
    public class ClassifyExactMatchesPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contentClassifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentClassification>? ContentClassifications { get; set; }
#nullable restore
#else
        public List<ContentClassification> ContentClassifications { get; set; }
#endif
        /// <summary>The sensitiveTypeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SensitiveTypeIds { get; set; }
#nullable restore
#else
        public List<string> SensitiveTypeIds { get; set; }
#endif
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The timeoutInMs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeoutInMs { get; set; }
#nullable restore
#else
        public string TimeoutInMs { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ClassifyExactMatchesPostRequestBody"/> and sets the default values.
        /// </summary>
        public ClassifyExactMatchesPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ClassifyExactMatchesPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ClassifyExactMatchesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassifyExactMatchesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "contentClassifications", n => { ContentClassifications = n.GetCollectionOfObjectValues<ContentClassification>(ContentClassification.CreateFromDiscriminatorValue)?.ToList(); } },
                { "sensitiveTypeIds", n => { SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "timeoutInMs", n => { TimeoutInMs = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ContentClassification>("contentClassifications", ContentClassifications);
            writer.WriteCollectionOfPrimitiveValues<string>("sensitiveTypeIds", SensitiveTypeIds);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("timeoutInMs", TimeoutInMs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
