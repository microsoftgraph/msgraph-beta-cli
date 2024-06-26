// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// History Item contained in the Mobile App Troubleshooting Event.
    /// </summary>
    public class MobileAppTroubleshootingAppStateHistory : MobileAppTroubleshootingHistoryItem, IParsable
    {
        /// <summary>Defines the Action Types for an Intune Application.</summary>
        public MobileAppActionType? ActionType { get; set; }
        /// <summary>Error code for the failure, empty if no failure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode { get; set; }
#nullable restore
#else
        public string ErrorCode { get; set; }
#endif
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public ApiSdk.Models.RunState? RunState { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MobileAppTroubleshootingAppStateHistory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppTroubleshootingAppStateHistory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppTroubleshootingAppStateHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionType", n => { ActionType = n.GetEnumValue<MobileAppActionType>(); } },
                { "errorCode", n => { ErrorCode = n.GetStringValue(); } },
                { "runState", n => { RunState = n.GetEnumValue<RunState>(); } },
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
            writer.WriteEnumValue<MobileAppActionType>("actionType", ActionType);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteEnumValue<RunState>("runState", RunState);
        }
    }
}
