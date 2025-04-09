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
    public partial class UserTrainingCompletionSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of users who completed all the trainings before the due date.</summary>
        public int? CompletedUsersCount { get; set; }
        /// <summary>The number of users who started at least one training.</summary>
        public int? InProgressUsersCount { get; set; }
        /// <summary>The number of users who didn&apos;t complete all the trainings before the due date.</summary>
        public int? NotCompletedUsersCount { get; set; }
        /// <summary>The number of users who didn&apos;t start any training.</summary>
        public int? NotStartedUsersCount { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The number of users who are already assigned the same training.</summary>
        public int? PreviouslyAssignedUsersCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.UserTrainingCompletionSummary"/> and sets the default values.
        /// </summary>
        public UserTrainingCompletionSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserTrainingCompletionSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.UserTrainingCompletionSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserTrainingCompletionSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "completedUsersCount", n => { CompletedUsersCount = n.GetIntValue(); } },
                { "inProgressUsersCount", n => { InProgressUsersCount = n.GetIntValue(); } },
                { "notCompletedUsersCount", n => { NotCompletedUsersCount = n.GetIntValue(); } },
                { "notStartedUsersCount", n => { NotStartedUsersCount = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "previouslyAssignedUsersCount", n => { PreviouslyAssignedUsersCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("completedUsersCount", CompletedUsersCount);
            writer.WriteIntValue("inProgressUsersCount", InProgressUsersCount);
            writer.WriteIntValue("notCompletedUsersCount", NotCompletedUsersCount);
            writer.WriteIntValue("notStartedUsersCount", NotStartedUsersCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("previouslyAssignedUsersCount", PreviouslyAssignedUsersCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
