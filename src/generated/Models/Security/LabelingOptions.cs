// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class LabelingOptions : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The assignmentMethod property</summary>
        public global::ApiSdk.Models.Security.AssignmentMethod? AssignmentMethod { get; set; }
        /// <summary>The downgrade justification object that indicates if downgrade was justified and, if so, the reason.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.DowngradeJustification? DowngradeJustification { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.DowngradeJustification DowngradeJustification { get; set; }
#endif
        /// <summary>Extended properties will be parsed and returned in the standard Microsoft Purview Information Protection labeled metadata format as part of the label information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.KeyValuePair>? ExtendedProperties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.KeyValuePair> ExtendedProperties { get; set; }
#endif
        /// <summary>The GUID of the label that should be applied to the information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LabelId { get; set; }
#nullable restore
#else
        public string LabelId { get; set; }
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
        /// Instantiates a new <see cref="global::ApiSdk.Models.Security.LabelingOptions"/> and sets the default values.
        /// </summary>
        public LabelingOptions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.LabelingOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Security.LabelingOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.LabelingOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignmentMethod", n => { AssignmentMethod = n.GetEnumValue<global::ApiSdk.Models.Security.AssignmentMethod>(); } },
                { "downgradeJustification", n => { DowngradeJustification = n.GetObjectValue<global::ApiSdk.Models.Security.DowngradeJustification>(global::ApiSdk.Models.Security.DowngradeJustification.CreateFromDiscriminatorValue); } },
                { "extendedProperties", n => { ExtendedProperties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.KeyValuePair>(global::ApiSdk.Models.Security.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "labelId", n => { LabelId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AssignmentMethod>("assignmentMethod", AssignmentMethod);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.KeyValuePair>("extendedProperties", ExtendedProperties);
            writer.WriteStringValue("labelId", LabelId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
