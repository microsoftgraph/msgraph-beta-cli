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
    public partial class TeamworkDeviceHealth : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The connection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkConnection? Connection { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkConnection Connection { get; set; }
#endif
        /// <summary>Identity of the user who created the device health document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The UTC date and time when the device health document was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Health details about the device hardware.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkHardwareHealth? HardwareHealth { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkHardwareHealth HardwareHealth { get; set; }
#endif
        /// <summary>Identity of the user who last modified the device health details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The UTC date and time when the device health detail was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The login status of Microsoft Teams, Skype for Business, and Exchange.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkLoginStatus? LoginStatus { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkLoginStatus LoginStatus { get; set; }
#endif
        /// <summary>Health details about all peripherals (for example, speaker and microphone) attached to a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkPeripheralsHealth? PeripheralsHealth { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkPeripheralsHealth PeripheralsHealth { get; set; }
#endif
        /// <summary>Software updates available for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkSoftwareUpdateHealth? SoftwareUpdateHealth { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkSoftwareUpdateHealth SoftwareUpdateHealth { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TeamworkDeviceHealth"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.TeamworkDeviceHealth CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TeamworkDeviceHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "connection", n => { Connection = n.GetObjectValue<global::ApiSdk.Models.TeamworkConnection>(global::ApiSdk.Models.TeamworkConnection.CreateFromDiscriminatorValue); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "hardwareHealth", n => { HardwareHealth = n.GetObjectValue<global::ApiSdk.Models.TeamworkHardwareHealth>(global::ApiSdk.Models.TeamworkHardwareHealth.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "loginStatus", n => { LoginStatus = n.GetObjectValue<global::ApiSdk.Models.TeamworkLoginStatus>(global::ApiSdk.Models.TeamworkLoginStatus.CreateFromDiscriminatorValue); } },
                { "peripheralsHealth", n => { PeripheralsHealth = n.GetObjectValue<global::ApiSdk.Models.TeamworkPeripheralsHealth>(global::ApiSdk.Models.TeamworkPeripheralsHealth.CreateFromDiscriminatorValue); } },
                { "softwareUpdateHealth", n => { SoftwareUpdateHealth = n.GetObjectValue<global::ApiSdk.Models.TeamworkSoftwareUpdateHealth>(global::ApiSdk.Models.TeamworkSoftwareUpdateHealth.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkConnection>("connection", Connection);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkHardwareHealth>("hardwareHealth", HardwareHealth);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkLoginStatus>("loginStatus", LoginStatus);
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkPeripheralsHealth>("peripheralsHealth", PeripheralsHealth);
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkSoftwareUpdateHealth>("softwareUpdateHealth", SoftwareUpdateHealth);
        }
    }
}
#pragma warning restore CS0618
