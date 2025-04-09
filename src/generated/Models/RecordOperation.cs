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
    public partial class RecordOperation : global::ApiSdk.Models.CommsOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Possible values are: operationCanceled, stopToneDetected, maxRecordDurationReached, initialSilenceTimeout, maxSilenceTimeout, playPromptFailed, playBeepFailed, mediaReceiveTimeout, unspecifiedError, none.</summary>
        public global::ApiSdk.Models.RecordCompletionReason? CompletionReason { get; set; }
        /// <summary>The access token required to retrieve the recording.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingAccessToken { get; set; }
#nullable restore
#else
        public string RecordingAccessToken { get; set; }
#endif
        /// <summary>The location where the recording is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingLocation { get; set; }
#nullable restore
#else
        public string RecordingLocation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RecordOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.RecordOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.RecordOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completionReason", n => { CompletionReason = n.GetEnumValue<global::ApiSdk.Models.RecordCompletionReason>(); } },
                { "recordingAccessToken", n => { RecordingAccessToken = n.GetStringValue(); } },
                { "recordingLocation", n => { RecordingLocation = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.RecordCompletionReason>("completionReason", CompletionReason);
            writer.WriteStringValue("recordingAccessToken", RecordingAccessToken);
            writer.WriteStringValue("recordingLocation", RecordingLocation);
        }
    }
}
#pragma warning restore CS0618
