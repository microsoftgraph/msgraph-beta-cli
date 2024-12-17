// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.Partners.Billing;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Reports.Partners.Billing.Usage.Billed.MicrosoftGraphPartnersBillingExport
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ExportPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributeSet property</summary>
        public global::ApiSdk.Models.Partners.Billing.AttributeSet? AttributeSet { get; set; }
        /// <summary>The invoiceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceId { get; set; }
#nullable restore
#else
        public string InvoiceId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Reports.Partners.Billing.Usage.Billed.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody"/> and sets the default values.
        /// </summary>
        public ExportPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Reports.Partners.Billing.Usage.Billed.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Reports.Partners.Billing.Usage.Billed.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Reports.Partners.Billing.Usage.Billed.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributeSet", n => { AttributeSet = n.GetEnumValue<global::ApiSdk.Models.Partners.Billing.AttributeSet>(); } },
                { "invoiceId", n => { InvoiceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.Partners.Billing.AttributeSet>("attributeSet", AttributeSet);
            writer.WriteStringValue("invoiceId", InvoiceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
