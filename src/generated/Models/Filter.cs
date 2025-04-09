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
    public partial class Filter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>*Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.FilterGroup>? CategoryFilterGroups { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.FilterGroup> CategoryFilterGroups { get; set; }
#endif
        /// <summary>Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter isn&apos;t satisfied any longer, such object will get de-provisioned&apos;. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.FilterGroup>? Groups { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.FilterGroup> Groups { get; set; }
#endif
        /// <summary>*Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn&apos;t satisfy this filter, it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.FilterGroup>? InputFilterGroups { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.FilterGroup> InputFilterGroups { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Filter"/> and sets the default values.
        /// </summary>
        public Filter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Filter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Filter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Filter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "categoryFilterGroups", n => { CategoryFilterGroups = n.GetCollectionOfObjectValues<global::ApiSdk.Models.FilterGroup>(global::ApiSdk.Models.FilterGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "groups", n => { Groups = n.GetCollectionOfObjectValues<global::ApiSdk.Models.FilterGroup>(global::ApiSdk.Models.FilterGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "inputFilterGroups", n => { InputFilterGroups = n.GetCollectionOfObjectValues<global::ApiSdk.Models.FilterGroup>(global::ApiSdk.Models.FilterGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.FilterGroup>("categoryFilterGroups", CategoryFilterGroups);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.FilterGroup>("groups", Groups);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.FilterGroup>("inputFilterGroups", InputFilterGroups);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
