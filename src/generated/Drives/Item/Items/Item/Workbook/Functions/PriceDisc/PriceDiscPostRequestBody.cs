// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.PriceDisc
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PriceDiscPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The basis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Basis { get; set; }
#nullable restore
#else
        public UntypedNode Basis { get; set; }
#endif
        /// <summary>The discount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Discount { get; set; }
#nullable restore
#else
        public UntypedNode Discount { get; set; }
#endif
        /// <summary>The maturity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Maturity { get; set; }
#nullable restore
#else
        public UntypedNode Maturity { get; set; }
#endif
        /// <summary>The redemption property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Redemption { get; set; }
#nullable restore
#else
        public UntypedNode Redemption { get; set; }
#endif
        /// <summary>The settlement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Settlement { get; set; }
#nullable restore
#else
        public UntypedNode Settlement { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Drives.Item.Items.Item.Workbook.Functions.PriceDisc.PriceDiscPostRequestBody"/> and sets the default values.
        /// </summary>
        public PriceDiscPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Drives.Item.Items.Item.Workbook.Functions.PriceDisc.PriceDiscPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Drives.Item.Items.Item.Workbook.Functions.PriceDisc.PriceDiscPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Drives.Item.Items.Item.Workbook.Functions.PriceDisc.PriceDiscPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "basis", n => { Basis = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "discount", n => { Discount = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "maturity", n => { Maturity = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "redemption", n => { Redemption = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "settlement", n => { Settlement = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("basis", Basis);
            writer.WriteObjectValue<UntypedNode>("discount", Discount);
            writer.WriteObjectValue<UntypedNode>("maturity", Maturity);
            writer.WriteObjectValue<UntypedNode>("redemption", Redemption);
            writer.WriteObjectValue<UntypedNode>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
