// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.TermStore;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TermColumn : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether the column allows more than one value</summary>
        public bool? AllowMultipleValues { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The parentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TermStore.Term? ParentTerm { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TermStore.Term ParentTerm { get; set; }
#endif
        /// <summary>Specifies whether to display the entire term path or only the term label.</summary>
        public bool? ShowFullyQualifiedName { get; set; }
        /// <summary>The termSet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TermStore.Set? TermSet { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TermStore.Set TermSet { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.TermColumn"/> and sets the default values.
        /// </summary>
        public TermColumn()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TermColumn"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.TermColumn CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TermColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowMultipleValues", n => { AllowMultipleValues = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "parentTerm", n => { ParentTerm = n.GetObjectValue<global::ApiSdk.Models.TermStore.Term>(global::ApiSdk.Models.TermStore.Term.CreateFromDiscriminatorValue); } },
                { "showFullyQualifiedName", n => { ShowFullyQualifiedName = n.GetBoolValue(); } },
                { "termSet", n => { TermSet = n.GetObjectValue<global::ApiSdk.Models.TermStore.Set>(global::ApiSdk.Models.TermStore.Set.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleValues", AllowMultipleValues);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::ApiSdk.Models.TermStore.Term>("parentTerm", ParentTerm);
            writer.WriteBoolValue("showFullyQualifiedName", ShowFullyQualifiedName);
            writer.WriteObjectValue<global::ApiSdk.Models.TermStore.Set>("termSet", TermSet);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
