// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// By providing configurations in this profile you can instruct the native email client (Outlook) on Windows 10 devices to communicate with an Exchange server and get email, contacts, calendar, and tasks. Furthermore, you can also specify how much email to sync and how often the device should sync.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Windows10EasEmailProfileConfiguration : global::ApiSdk.Models.EasEmailProfileConfigurationBase, IParsable
    {
        /// <summary>Account name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName { get; set; }
#nullable restore
#else
        public string AccountName { get; set; }
#endif
        /// <summary>Possible values for email sync duration.</summary>
        public global::ApiSdk.Models.EmailSyncDuration? DurationOfEmailToSync { get; set; }
        /// <summary>Possible values for username source or email source.</summary>
        public global::ApiSdk.Models.UserEmailSource? EmailAddressSource { get; set; }
        /// <summary>Possible values for email sync schedule.</summary>
        public global::ApiSdk.Models.EmailSyncSchedule? EmailSyncSchedule { get; set; }
        /// <summary>Exchange location that (URL) that the native mail app connects to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostName { get; set; }
#nullable restore
#else
        public string HostName { get; set; }
#endif
        /// <summary>Indicates whether or not to use SSL.</summary>
        public bool? RequireSsl { get; set; }
        /// <summary>Whether or not to sync the calendar.</summary>
        public bool? SyncCalendar { get; set; }
        /// <summary>Whether or not to sync contacts.</summary>
        public bool? SyncContacts { get; set; }
        /// <summary>Whether or not to sync tasks.</summary>
        public bool? SyncTasks { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Windows10EasEmailProfileConfiguration"/> and sets the default values.
        /// </summary>
        public Windows10EasEmailProfileConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windows10EasEmailProfileConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Windows10EasEmailProfileConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Windows10EasEmailProfileConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Windows10EasEmailProfileConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountName", n => { AccountName = n.GetStringValue(); } },
                { "durationOfEmailToSync", n => { DurationOfEmailToSync = n.GetEnumValue<global::ApiSdk.Models.EmailSyncDuration>(); } },
                { "emailAddressSource", n => { EmailAddressSource = n.GetEnumValue<global::ApiSdk.Models.UserEmailSource>(); } },
                { "emailSyncSchedule", n => { EmailSyncSchedule = n.GetEnumValue<global::ApiSdk.Models.EmailSyncSchedule>(); } },
                { "hostName", n => { HostName = n.GetStringValue(); } },
                { "requireSsl", n => { RequireSsl = n.GetBoolValue(); } },
                { "syncCalendar", n => { SyncCalendar = n.GetBoolValue(); } },
                { "syncContacts", n => { SyncContacts = n.GetBoolValue(); } },
                { "syncTasks", n => { SyncTasks = n.GetBoolValue(); } },
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
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteEnumValue<global::ApiSdk.Models.EmailSyncDuration>("durationOfEmailToSync", DurationOfEmailToSync);
            writer.WriteEnumValue<global::ApiSdk.Models.UserEmailSource>("emailAddressSource", EmailAddressSource);
            writer.WriteEnumValue<global::ApiSdk.Models.EmailSyncSchedule>("emailSyncSchedule", EmailSyncSchedule);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteBoolValue("requireSsl", RequireSsl);
            writer.WriteBoolValue("syncCalendar", SyncCalendar);
            writer.WriteBoolValue("syncContacts", SyncContacts);
            writer.WriteBoolValue("syncTasks", SyncTasks);
        }
    }
}
#pragma warning restore CS0618
