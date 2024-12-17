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
    public partial class BookingQuestionAnswer : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The answer given by the user in case the answerInputType is text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Answer { get; set; }
#nullable restore
#else
        public string Answer { get; set; }
#endif
        /// <summary>The expected answer type. The possible values are: text, radioButton, unknownFutureValue.</summary>
        public global::ApiSdk.Models.AnswerInputType? AnswerInputType { get; set; }
        /// <summary>In case the answerInputType is radioButton, this will consists of a list of possible answer values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AnswerOptions { get; set; }
#nullable restore
#else
        public List<string> AnswerOptions { get; set; }
#endif
        /// <summary>Indicates whether it is mandatory to answer the custom question.</summary>
        public bool? IsRequired { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The question.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Question { get; set; }
#nullable restore
#else
        public string Question { get; set; }
#endif
        /// <summary>The ID of the custom question.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuestionId { get; set; }
#nullable restore
#else
        public string QuestionId { get; set; }
#endif
        /// <summary>The answers selected by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SelectedOptions { get; set; }
#nullable restore
#else
        public List<string> SelectedOptions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.BookingQuestionAnswer"/> and sets the default values.
        /// </summary>
        public BookingQuestionAnswer()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.BookingQuestionAnswer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.BookingQuestionAnswer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.BookingQuestionAnswer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "answer", n => { Answer = n.GetStringValue(); } },
                { "answerInputType", n => { AnswerInputType = n.GetEnumValue<global::ApiSdk.Models.AnswerInputType>(); } },
                { "answerOptions", n => { AnswerOptions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "isRequired", n => { IsRequired = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "question", n => { Question = n.GetStringValue(); } },
                { "questionId", n => { QuestionId = n.GetStringValue(); } },
                { "selectedOptions", n => { SelectedOptions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("answer", Answer);
            writer.WriteEnumValue<global::ApiSdk.Models.AnswerInputType>("answerInputType", AnswerInputType);
            writer.WriteCollectionOfPrimitiveValues<string>("answerOptions", AnswerOptions);
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("question", Question);
            writer.WriteStringValue("questionId", QuestionId);
            writer.WriteCollectionOfPrimitiveValues<string>("selectedOptions", SelectedOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
