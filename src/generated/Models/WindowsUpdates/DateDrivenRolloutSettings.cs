// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DateDrivenRolloutSettings : global::ApiSdk.Models.WindowsUpdates.GradualRolloutSettings, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the date before which all devices currently in the deployment are offered the update. Devices added after this date are offered immediately. When the endDateTime isn&apos;t set, all devices in the deployment are offered content at the same time.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.WindowsUpdates.DateDrivenRolloutSettings"/> and sets the default values.
        /// </summary>
        public DateDrivenRolloutSettings() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.dateDrivenRolloutSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsUpdates.DateDrivenRolloutSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsUpdates.DateDrivenRolloutSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsUpdates.DateDrivenRolloutSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
        }
    }
}
#pragma warning restore CS0618
