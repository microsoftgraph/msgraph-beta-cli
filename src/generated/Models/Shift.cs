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
    public partial class Shift : global::ApiSdk.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Draft changes in the shift. Draft changes are only visible to managers. The changes are visible to employees when they&apos;re shared, which copies the changes from the draftShift to the sharedShift property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ShiftItem? DraftShift { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ShiftItem DraftShift { get; set; }
#endif
        /// <summary>The shift is marked for deletion, a process that is finalized when the schedule is shared.</summary>
        public bool? IsStagedForDeletion { get; set; }
        /// <summary>ID of the scheduling group the shift is part of. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchedulingGroupId { get; set; }
#nullable restore
#else
        public string SchedulingGroupId { get; set; }
#endif
        /// <summary>Information of the scheduling group the shift is part of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SchedulingGroupInfo? SchedulingGroupInfo { get; private set; }
#nullable restore
#else
        public global::ApiSdk.Models.SchedulingGroupInfo SchedulingGroupInfo { get; private set; }
#endif
        /// <summary>The shared version of this shift that is viewable by both employees and managers. Updates to the sharedShift property send notifications to users in the Teams client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ShiftItem? SharedShift { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ShiftItem SharedShift { get; set; }
#endif
        /// <summary>Information of the team that the shift is in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ShiftsTeamInfo? TeamInfo { get; private set; }
#nullable restore
#else
        public global::ApiSdk.Models.ShiftsTeamInfo TeamInfo { get; private set; }
#endif
        /// <summary>ID of the user assigned to the shift. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>Information of the user assigned to the shift.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ShiftsUserInfo? UserInfo { get; private set; }
#nullable restore
#else
        public global::ApiSdk.Models.ShiftsUserInfo UserInfo { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Shift"/> and sets the default values.
        /// </summary>
        public Shift() : base()
        {
            OdataType = "#microsoft.graph.shift";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Shift"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Shift CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Shift();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "draftShift", n => { DraftShift = n.GetObjectValue<global::ApiSdk.Models.ShiftItem>(global::ApiSdk.Models.ShiftItem.CreateFromDiscriminatorValue); } },
                { "isStagedForDeletion", n => { IsStagedForDeletion = n.GetBoolValue(); } },
                { "schedulingGroupId", n => { SchedulingGroupId = n.GetStringValue(); } },
                { "schedulingGroupInfo", n => { SchedulingGroupInfo = n.GetObjectValue<global::ApiSdk.Models.SchedulingGroupInfo>(global::ApiSdk.Models.SchedulingGroupInfo.CreateFromDiscriminatorValue); } },
                { "sharedShift", n => { SharedShift = n.GetObjectValue<global::ApiSdk.Models.ShiftItem>(global::ApiSdk.Models.ShiftItem.CreateFromDiscriminatorValue); } },
                { "teamInfo", n => { TeamInfo = n.GetObjectValue<global::ApiSdk.Models.ShiftsTeamInfo>(global::ApiSdk.Models.ShiftsTeamInfo.CreateFromDiscriminatorValue); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userInfo", n => { UserInfo = n.GetObjectValue<global::ApiSdk.Models.ShiftsUserInfo>(global::ApiSdk.Models.ShiftsUserInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ShiftItem>("draftShift", DraftShift);
            writer.WriteBoolValue("isStagedForDeletion", IsStagedForDeletion);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<global::ApiSdk.Models.ShiftItem>("sharedShift", SharedShift);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
#pragma warning restore CS0618
