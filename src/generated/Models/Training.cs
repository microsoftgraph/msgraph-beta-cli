// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Training : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The training availability status. Possible values are: unknown, notAvailable, available, archive, delete, unknownFutureValue.</summary>
        public TrainingAvailabilityStatus? AvailabilityStatus { get; set; }
        /// <summary>The identity of the user who created the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public EmailIdentity CreatedBy { get; set; }
#endif
        /// <summary>The date and time when the training was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The training URL</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomUrl { get; set; }
#nullable restore
#else
        public string CustomUrl { get; set; }
#endif
        /// <summary>The description for the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name for the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The duration of the training in minutes.</summary>
        public int? DurationInMinutes { get; set; }
        /// <summary>Whether the training has any evaluation.</summary>
        public bool? HasEvaluation { get; set; }
        /// <summary>Details about the language used in the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TrainingLanguageDetail>? LanguageDetails { get; set; }
#nullable restore
#else
        public List<TrainingLanguageDetail> LanguageDetails { get; set; }
#endif
        /// <summary>The identity of the user who last modified the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? LastModifiedBy { get; set; }
#nullable restore
#else
        public EmailIdentity LastModifiedBy { get; set; }
#endif
        /// <summary>The date and time when the training was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The source of the training content. Possible values are: unknown, global, tenant, unknownFutureValue.</summary>
        public SimulationContentSource? Source { get; set; }
        /// <summary>The supported locales for content for the associated training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedLocales { get; set; }
#nullable restore
#else
        public List<string> SupportedLocales { get; set; }
#endif
        /// <summary>Training tags.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The type of training. Possible values are: unknown, phishing, unknownFutureValue.</summary>
        public TrainingType? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Training"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Training CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Training();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "availabilityStatus", n => { AvailabilityStatus = n.GetEnumValue<TrainingAvailabilityStatus>(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customUrl", n => { CustomUrl = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "durationInMinutes", n => { DurationInMinutes = n.GetIntValue(); } },
                { "hasEvaluation", n => { HasEvaluation = n.GetBoolValue(); } },
                { "languageDetails", n => { LanguageDetails = n.GetCollectionOfObjectValues<TrainingLanguageDetail>(TrainingLanguageDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "source", n => { Source = n.GetEnumValue<SimulationContentSource>(); } },
                { "supportedLocales", n => { SupportedLocales = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "type", n => { Type = n.GetEnumValue<TrainingType>(); } },
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
            writer.WriteEnumValue<TrainingAvailabilityStatus>("availabilityStatus", AvailabilityStatus);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customUrl", CustomUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInMinutes", DurationInMinutes);
            writer.WriteBoolValue("hasEvaluation", HasEvaluation);
            writer.WriteCollectionOfObjectValues<TrainingLanguageDetail>("languageDetails", LanguageDetails);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<SimulationContentSource>("source", Source);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedLocales", SupportedLocales);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<TrainingType>("type", Type);
        }
    }
}
