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
    public partial class EducationAssignmentDefaults : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Class-level default behavior for handling students who are added after the assignment is published. Possible values are: none, assignIfOpen.</summary>
        public global::ApiSdk.Models.EducationAddedStudentAction? AddedStudentAction { get; set; }
        /// <summary>Optional field to control adding assignments to students&apos; and teachers&apos; calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. You must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: studentsOnly. The default value is none.</summary>
        public global::ApiSdk.Models.EducationAddToCalendarOptions? AddToCalendarAction { get; set; }
        /// <summary>Class-level default value for due time field. Default value is 23:59:00.</summary>
        public Time? DueTime { get; set; }
        /// <summary>Default Teams channel to which notifications are sent. Default value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationChannelUrl { get; set; }
#nullable restore
#else
        public string NotificationChannelUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EducationAssignmentDefaults"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.EducationAssignmentDefaults CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EducationAssignmentDefaults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addToCalendarAction", n => { AddToCalendarAction = n.GetEnumValue<global::ApiSdk.Models.EducationAddToCalendarOptions>(); } },
                { "addedStudentAction", n => { AddedStudentAction = n.GetEnumValue<global::ApiSdk.Models.EducationAddedStudentAction>(); } },
                { "dueTime", n => { DueTime = n.GetTimeValue(); } },
                { "notificationChannelUrl", n => { NotificationChannelUrl = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.EducationAddedStudentAction>("addedStudentAction", AddedStudentAction);
            writer.WriteEnumValue<global::ApiSdk.Models.EducationAddToCalendarOptions>("addToCalendarAction", AddToCalendarAction);
            writer.WriteTimeValue("dueTime", DueTime);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
        }
    }
}
#pragma warning restore CS0618
