// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GeneralLedgerEntry : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Account? Account { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Account Account { get; set; }
#endif
        /// <summary>The accountId property</summary>
        public Guid? AccountId { get; set; }
        /// <summary>The accountNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountNumber { get; set; }
#nullable restore
#else
        public string AccountNumber { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The creditAmount property</summary>
        public decimal? CreditAmount { get; set; }
        /// <summary>The debitAmount property</summary>
        public decimal? DebitAmount { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The documentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentNumber { get; set; }
#nullable restore
#else
        public string DocumentNumber { get; set; }
#endif
        /// <summary>The documentType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentType { get; set; }
#nullable restore
#else
        public string DocumentType { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The postingDate property</summary>
        public Date? PostingDate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.GeneralLedgerEntry"/> and sets the default values.
        /// </summary>
        public GeneralLedgerEntry()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GeneralLedgerEntry"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.GeneralLedgerEntry CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.GeneralLedgerEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account", n => { Account = n.GetObjectValue<global::ApiSdk.Models.Account>(global::ApiSdk.Models.Account.CreateFromDiscriminatorValue); } },
                { "accountId", n => { AccountId = n.GetGuidValue(); } },
                { "accountNumber", n => { AccountNumber = n.GetStringValue(); } },
                { "creditAmount", n => { CreditAmount = n.GetDecimalValue(); } },
                { "debitAmount", n => { DebitAmount = n.GetDecimalValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "documentNumber", n => { DocumentNumber = n.GetStringValue(); } },
                { "documentType", n => { DocumentType = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "postingDate", n => { PostingDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.Account>("account", Account);
            writer.WriteGuidValue("accountId", AccountId);
            writer.WriteStringValue("accountNumber", AccountNumber);
            writer.WriteDecimalValue("creditAmount", CreditAmount);
            writer.WriteDecimalValue("debitAmount", DebitAmount);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("documentNumber", DocumentNumber);
            writer.WriteStringValue("documentType", DocumentType);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateValue("postingDate", PostingDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
