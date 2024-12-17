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
    public partial class Calendar : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.OnlineMeetingProviderType?>? AllowedOnlineMeetingProviders { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.OnlineMeetingProviderType?> AllowedOnlineMeetingProviders { get; set; }
#endif
        /// <summary>The calendarGroup in which to create the calendar. If the user has never explicitly set a group for the calendar, this property is  null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CalendarGroupId { get; set; }
#nullable restore
#else
        public string CalendarGroupId { get; set; }
#endif
        /// <summary>The permissions of the users with whom the calendar is shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CalendarPermission>? CalendarPermissions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CalendarPermission> CalendarPermissions { get; set; }
#endif
        /// <summary>The calendar view for the calendar. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Event>? CalendarView { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Event> CalendarView { get; set; }
#endif
        /// <summary>true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanEdit { get; set; }
        /// <summary>true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.</summary>
        public bool? CanShare { get; set; }
        /// <summary>true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanViewPrivateItems { get; set; }
        /// <summary>Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeKey { get; set; }
#nullable restore
#else
        public string ChangeKey { get; set; }
#endif
        /// <summary>Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: auto, lightBlue, lightGreen, lightOrange, lightGray, lightYellow, lightTeal, lightPink, lightBrown, lightRed, maxColor.</summary>
        public global::ApiSdk.Models.CalendarColor? Color { get; set; }
        /// <summary>The default online meeting provider for meetings sent from this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
        public global::ApiSdk.Models.OnlineMeetingProviderType? DefaultOnlineMeetingProvider { get; set; }
        /// <summary>The events in the calendar. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Event>? Events { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Event> Events { get; set; }
#endif
        /// <summary>The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HexColor { get; set; }
#nullable restore
#else
        public string HexColor { get; set; }
#endif
        /// <summary>true if this is the default calendar where new events are created by default, false otherwise.</summary>
        public bool? IsDefaultCalendar { get; set; }
        /// <summary>Indicates whether this user calendar can be deleted from the user mailbox.</summary>
        public bool? IsRemovable { get; set; }
        /// <summary>true if the user has shared the calendar with other users, false otherwise. Since only the user who created the calendar can share it, isShared and isSharedWithMe cannot be true for the same user. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? IsShared { get; set; }
        /// <summary>true if the user has been shared this calendar, false otherwise. This property is always false for a calendar owner. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? IsSharedWithMe { get; set; }
        /// <summary>Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users&apos; primary calendars support tracking of meeting responses.</summary>
        public bool? IsTallyingResponses { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
#endif
        /// <summary>The calendar name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>If set, this represents the user who created or added the calendar. For a calendar that the user created or added, the owner property is set to the user. For a calendar shared with the user, the owner property is set to the person who shared that calendar with the user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EmailAddress? Owner { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EmailAddress Owner { get; set; }
#endif
        /// <summary>The collection of single-value extended properties defined for the calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Calendar"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Calendar CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Calendar();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedOnlineMeetingProviders", n => { AllowedOnlineMeetingProviders = n.GetCollectionOfEnumValues<global::ApiSdk.Models.OnlineMeetingProviderType>()?.AsList(); } },
                { "calendarGroupId", n => { CalendarGroupId = n.GetStringValue(); } },
                { "calendarPermissions", n => { CalendarPermissions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CalendarPermission>(global::ApiSdk.Models.CalendarPermission.CreateFromDiscriminatorValue)?.AsList(); } },
                { "calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Event>(global::ApiSdk.Models.Event.CreateFromDiscriminatorValue)?.AsList(); } },
                { "canEdit", n => { CanEdit = n.GetBoolValue(); } },
                { "canShare", n => { CanShare = n.GetBoolValue(); } },
                { "canViewPrivateItems", n => { CanViewPrivateItems = n.GetBoolValue(); } },
                { "changeKey", n => { ChangeKey = n.GetStringValue(); } },
                { "color", n => { Color = n.GetEnumValue<global::ApiSdk.Models.CalendarColor>(); } },
                { "defaultOnlineMeetingProvider", n => { DefaultOnlineMeetingProvider = n.GetEnumValue<global::ApiSdk.Models.OnlineMeetingProviderType>(); } },
                { "events", n => { Events = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Event>(global::ApiSdk.Models.Event.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hexColor", n => { HexColor = n.GetStringValue(); } },
                { "isDefaultCalendar", n => { IsDefaultCalendar = n.GetBoolValue(); } },
                { "isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                { "isShared", n => { IsShared = n.GetBoolValue(); } },
                { "isSharedWithMe", n => { IsSharedWithMe = n.GetBoolValue(); } },
                { "isTallyingResponses", n => { IsTallyingResponses = n.GetBoolValue(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>(global::ApiSdk.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetObjectValue<global::ApiSdk.Models.EmailAddress>(global::ApiSdk.Models.EmailAddress.CreateFromDiscriminatorValue); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>(global::ApiSdk.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.OnlineMeetingProviderType>("allowedOnlineMeetingProviders", AllowedOnlineMeetingProviders);
            writer.WriteStringValue("calendarGroupId", CalendarGroupId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CalendarPermission>("calendarPermissions", CalendarPermissions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Event>("calendarView", CalendarView);
            writer.WriteBoolValue("canEdit", CanEdit);
            writer.WriteBoolValue("canShare", CanShare);
            writer.WriteBoolValue("canViewPrivateItems", CanViewPrivateItems);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteEnumValue<global::ApiSdk.Models.CalendarColor>("color", Color);
            writer.WriteEnumValue<global::ApiSdk.Models.OnlineMeetingProviderType>("defaultOnlineMeetingProvider", DefaultOnlineMeetingProvider);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Event>("events", Events);
            writer.WriteStringValue("hexColor", HexColor);
            writer.WriteBoolValue("isDefaultCalendar", IsDefaultCalendar);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteBoolValue("isSharedWithMe", IsSharedWithMe);
            writer.WriteBoolValue("isTallyingResponses", IsTallyingResponses);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::ApiSdk.Models.EmailAddress>("owner", Owner);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
#pragma warning restore CS0618
