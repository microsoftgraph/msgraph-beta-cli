// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ExternalConnectors
{
    #pragma warning disable CS1591
    public class Property : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A set of aliases or friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string might not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, &apos;, &apos;, &lt;, &gt;, `, ^. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Aliases { get; set; }
#nullable restore
#else
        public List<string> Aliases { get; set; }
#endif
        /// <summary>Specifies if the property will be matched exactly for queries. Exact matching can only be set to true for non-searchable properties of type string or stringCollection. Optional.</summary>
        public bool? IsExactMatchRequired { get; set; }
        /// <summary>Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.</summary>
        public bool? IsQueryable { get; set; }
        /// <summary>Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.</summary>
        public bool? IsRefinable { get; set; }
        /// <summary>Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.</summary>
        public bool? IsRetrievable { get; set; }
        /// <summary>Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties aren&apos;t added to the search index. Optional.</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (for example, better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, containerName, containerUrl, iconUrl. You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: containerName, containerUrl, iconUrl.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Label?>? Labels { get; set; }
#nullable restore
#else
        public List<Label?> Labels { get; set; }
#endif
        /// <summary>The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, the property name may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, &apos;, &apos;, &lt;, &gt;, `, ^.  Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies the property ranking hint. Developers can specify which properties are most important, allowing Microsoft Search to determine the search relevance of the content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ExternalConnectors.RankingHint? RankingHint { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ExternalConnectors.RankingHint RankingHint { get; set; }
#endif
        /// <summary>The type property</summary>
        public PropertyType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Property"/> and sets the default values.
        /// </summary>
        public Property()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Property"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Property CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Property();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "aliases", n => { Aliases = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "isExactMatchRequired", n => { IsExactMatchRequired = n.GetBoolValue(); } },
                { "isQueryable", n => { IsQueryable = n.GetBoolValue(); } },
                { "isRefinable", n => { IsRefinable = n.GetBoolValue(); } },
                { "isRetrievable", n => { IsRetrievable = n.GetBoolValue(); } },
                { "isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                { "labels", n => { Labels = n.GetCollectionOfEnumValues<Label>()?.ToList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "rankingHint", n => { RankingHint = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.RankingHint>(ApiSdk.Models.ExternalConnectors.RankingHint.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<PropertyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aliases", Aliases);
            writer.WriteBoolValue("isExactMatchRequired", IsExactMatchRequired);
            writer.WriteBoolValue("isQueryable", IsQueryable);
            writer.WriteBoolValue("isRefinable", IsRefinable);
            writer.WriteBoolValue("isRetrievable", IsRetrievable);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteCollectionOfEnumValues<Label>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.RankingHint>("rankingHint", RankingHint);
            writer.WriteEnumValue<PropertyType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
