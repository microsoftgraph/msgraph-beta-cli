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
    /// By providing configurations in this profile you can instruct the Nine Work email client on Android For Work devices to communicate with an Exchange server and get email, contacts, calendar, tasks, and notes. Furthermore, you can also specify how much email to sync and how often the device should sync.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidForWorkNineWorkEasConfiguration : global::ApiSdk.Models.AndroidForWorkEasEmailProfileBase, IParsable
    {
        /// <summary>Toggles syncing the calendar. If set to false the calendar is turned off on the device.</summary>
        public bool? SyncCalendar { get; set; }
        /// <summary>Toggles syncing contacts. If set to false contacts are turned off on the device.</summary>
        public bool? SyncContacts { get; set; }
        /// <summary>Toggles syncing tasks. If set to false tasks are turned off on the device.</summary>
        public bool? SyncTasks { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AndroidForWorkNineWorkEasConfiguration"/> and sets the default values.
        /// </summary>
        public AndroidForWorkNineWorkEasConfiguration() : base()
        {
            OdataType = "#microsoft.graph.androidForWorkNineWorkEasConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AndroidForWorkNineWorkEasConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AndroidForWorkNineWorkEasConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AndroidForWorkNineWorkEasConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
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
            writer.WriteBoolValue("syncCalendar", SyncCalendar);
            writer.WriteBoolValue("syncContacts", SyncContacts);
            writer.WriteBoolValue("syncTasks", SyncTasks);
        }
    }
}
#pragma warning restore CS0618
