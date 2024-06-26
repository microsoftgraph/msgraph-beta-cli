// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Contains properties for User state of the hardware configuration
    /// </summary>
    public class HardwareConfigurationUserState : Entity, IParsable
    {
        /// <summary>Error device count for specific user.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Failed device count for specific user.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>Last timestamp when the hardware configuration executed</summary>
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
        /// <summary>Not applicable device count for specific user.</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Pending device count for specific user.</summary>
        public int? PendingDeviceCount { get; set; }
        /// <summary>Success device count for specific user.</summary>
        public int? SuccessfulDeviceCount { get; set; }
        /// <summary>Unknown device count for specific user.</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>User Principal Name (UPN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Upn { get; set; }
#nullable restore
#else
        public string Upn { get; set; }
#endif
        /// <summary>User Email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserEmail { get; set; }
#nullable restore
#else
        public string UserEmail { get; set; }
#endif
        /// <summary>User name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HardwareConfigurationUserState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HardwareConfigurationUserState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HardwareConfigurationUserState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                { "failedDeviceCount", n => { FailedDeviceCount = n.GetIntValue(); } },
                { "lastStateUpdateDateTime", n => { LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                { "pendingDeviceCount", n => { PendingDeviceCount = n.GetIntValue(); } },
                { "successfulDeviceCount", n => { SuccessfulDeviceCount = n.GetIntValue(); } },
                { "unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
                { "upn", n => { Upn = n.GetStringValue(); } },
                { "userEmail", n => { UserEmail = n.GetStringValue(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
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
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("pendingDeviceCount", PendingDeviceCount);
            writer.WriteIntValue("successfulDeviceCount", SuccessfulDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
            writer.WriteStringValue("upn", Upn);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
