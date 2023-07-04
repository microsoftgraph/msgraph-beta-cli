using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UserLastSignInRecommendationInsightSetting : AccessReviewRecommendationInsightSetting, IParsable {
        /// <summary>The recommendationLookBackDuration property</summary>
        public TimeSpan? RecommendationLookBackDuration { get; set; }
        /// <summary>The signInScope property</summary>
        public UserSignInRecommendationScope? SignInScope { get; set; }
        /// <summary>
        /// Instantiates a new UserLastSignInRecommendationInsightSetting and sets the default values.
        /// </summary>
        public UserLastSignInRecommendationInsightSetting() : base() {
            OdataType = "#microsoft.graph.userLastSignInRecommendationInsightSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserLastSignInRecommendationInsightSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserLastSignInRecommendationInsightSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"recommendationLookBackDuration", n => { RecommendationLookBackDuration = n.GetTimeSpanValue(); } },
                {"signInScope", n => { SignInScope = n.GetEnumValue<UserSignInRecommendationScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("recommendationLookBackDuration", RecommendationLookBackDuration);
            writer.WriteEnumValue<UserSignInRecommendationScope>("signInScope", SignInScope);
        }
    }
}
