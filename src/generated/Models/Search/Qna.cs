// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Search
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Qna : global::ApiSdk.Models.Search.SearchAnswer, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time when the QnA stops appearing as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AvailabilityEndDateTime { get; set; }
        /// <summary>Date and time when the QnA starts to appear as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AvailabilityStartDateTime { get; set; }
        /// <summary>The list of security groups that are able to view this QnA.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GroupIds { get; set; }
#nullable restore
#else
        public List<string> GroupIds { get; set; }
#endif
        /// <summary>True if a user or Microsoft suggested this QnA to the admin. Read-only.</summary>
        public bool? IsSuggested { get; set; }
        /// <summary>Keywords that trigger this QnA to appear in search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Search.AnswerKeyword? Keywords { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Search.AnswerKeyword Keywords { get; set; }
#endif
        /// <summary>A list of geographically specific language names in which this QnA can be viewed. Each language tag value follows the pattern {language}-{region}. For example, en-us is English as used in the United States. For the list of possible values, see Supported language tags.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LanguageTags { get; set; }
#nullable restore
#else
        public List<string> LanguageTags { get; set; }
#endif
        /// <summary>List of devices and operating systems that are able to view this QnA. Possible values are: android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, unknown, androidASOP, androidMobileApplicationManagement, iOSMobileApplicationManagement, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DevicePlatformType?>? Platforms { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DevicePlatformType?> Platforms { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.Search.AnswerState? State { get; set; }
        /// <summary>Variations of a QnA for different countries/regions or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings apply to all variations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Search.AnswerVariant>? TargetedVariations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Search.AnswerVariant> TargetedVariations { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Search.Qna"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Search.Qna CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Search.Qna();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "availabilityEndDateTime", n => { AvailabilityEndDateTime = n.GetDateTimeOffsetValue(); } },
                { "availabilityStartDateTime", n => { AvailabilityStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "groupIds", n => { GroupIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "isSuggested", n => { IsSuggested = n.GetBoolValue(); } },
                { "keywords", n => { Keywords = n.GetObjectValue<global::ApiSdk.Models.Search.AnswerKeyword>(global::ApiSdk.Models.Search.AnswerKeyword.CreateFromDiscriminatorValue); } },
                { "languageTags", n => { LanguageTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "platforms", n => { Platforms = n.GetCollectionOfEnumValues<global::ApiSdk.Models.DevicePlatformType>()?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.Search.AnswerState>(); } },
                { "targetedVariations", n => { TargetedVariations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Search.AnswerVariant>(global::ApiSdk.Models.Search.AnswerVariant.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteDateTimeOffsetValue("availabilityEndDateTime", AvailabilityEndDateTime);
            writer.WriteDateTimeOffsetValue("availabilityStartDateTime", AvailabilityStartDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("groupIds", GroupIds);
            writer.WriteBoolValue("isSuggested", IsSuggested);
            writer.WriteObjectValue<global::ApiSdk.Models.Search.AnswerKeyword>("keywords", Keywords);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.DevicePlatformType>("platforms", Platforms);
            writer.WriteEnumValue<global::ApiSdk.Models.Search.AnswerState>("state", State);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Search.AnswerVariant>("targetedVariations", TargetedVariations);
        }
    }
}
#pragma warning restore CS0618
