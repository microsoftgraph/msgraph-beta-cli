// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Partner.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CustomersSpendingBudgetSecurityRequirement : global::ApiSdk.Models.Partner.Security.SecurityRequirement, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The number of customers with a spending budget set.</summary>
        public long? CustomersWithSpendBudgetCount { get; set; }
        /// <summary>The total number of customers associated with the partner.</summary>
        public long? TotalCustomersCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Partner.Security.CustomersSpendingBudgetSecurityRequirement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Partner.Security.CustomersSpendingBudgetSecurityRequirement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Partner.Security.CustomersSpendingBudgetSecurityRequirement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "customersWithSpendBudgetCount", n => { CustomersWithSpendBudgetCount = n.GetLongValue(); } },
                { "totalCustomersCount", n => { TotalCustomersCount = n.GetLongValue(); } },
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
            writer.WriteLongValue("customersWithSpendBudgetCount", CustomersWithSpendBudgetCount);
            writer.WriteLongValue("totalCustomersCount", TotalCustomersCount);
        }
    }
}
#pragma warning restore CS0618
