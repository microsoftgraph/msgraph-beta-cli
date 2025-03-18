// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Communications.Calls.Item.RecordResponse
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class RecordResponsePostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bargeInAllowed property</summary>
        public bool? BargeInAllowed { get; set; }
        /// <summary>The clientContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientContext { get; set; }
#nullable restore
#else
        public string ClientContext { get; set; }
#endif
        /// <summary>The initialSilenceTimeoutInSeconds property</summary>
        public int? InitialSilenceTimeoutInSeconds { get; set; }
        /// <summary>The maxRecordDurationInSeconds property</summary>
        public int? MaxRecordDurationInSeconds { get; set; }
        /// <summary>The maxSilenceTimeoutInSeconds property</summary>
        public int? MaxSilenceTimeoutInSeconds { get; set; }
        /// <summary>The playBeep property</summary>
        public bool? PlayBeep { get; set; }
        /// <summary>The prompts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Prompt>? Prompts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Prompt> Prompts { get; set; }
#endif
        /// <summary>The stopTones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StopTones { get; set; }
#nullable restore
#else
        public List<string> StopTones { get; set; }
#endif
        /// <summary>The streamWhileRecording property</summary>
        public bool? StreamWhileRecording { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Communications.Calls.Item.RecordResponse.RecordResponsePostRequestBody"/> and sets the default values.
        /// </summary>
        public RecordResponsePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Communications.Calls.Item.RecordResponse.RecordResponsePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Communications.Calls.Item.RecordResponse.RecordResponsePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Communications.Calls.Item.RecordResponse.RecordResponsePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bargeInAllowed", n => { BargeInAllowed = n.GetBoolValue(); } },
                { "clientContext", n => { ClientContext = n.GetStringValue(); } },
                { "initialSilenceTimeoutInSeconds", n => { InitialSilenceTimeoutInSeconds = n.GetIntValue(); } },
                { "maxRecordDurationInSeconds", n => { MaxRecordDurationInSeconds = n.GetIntValue(); } },
                { "maxSilenceTimeoutInSeconds", n => { MaxSilenceTimeoutInSeconds = n.GetIntValue(); } },
                { "playBeep", n => { PlayBeep = n.GetBoolValue(); } },
                { "prompts", n => { Prompts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Prompt>(global::ApiSdk.Models.Prompt.CreateFromDiscriminatorValue)?.AsList(); } },
                { "stopTones", n => { StopTones = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "streamWhileRecording", n => { StreamWhileRecording = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("bargeInAllowed", BargeInAllowed);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteIntValue("initialSilenceTimeoutInSeconds", InitialSilenceTimeoutInSeconds);
            writer.WriteIntValue("maxRecordDurationInSeconds", MaxRecordDurationInSeconds);
            writer.WriteIntValue("maxSilenceTimeoutInSeconds", MaxSilenceTimeoutInSeconds);
            writer.WriteBoolValue("playBeep", PlayBeep);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Prompt>("prompts", Prompts);
            writer.WriteCollectionOfPrimitiveValues<string>("stopTones", StopTones);
            writer.WriteBoolValue("streamWhileRecording", StreamWhileRecording);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
