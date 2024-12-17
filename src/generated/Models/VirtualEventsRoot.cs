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
    public partial class VirtualEventsRoot : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The events property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.VirtualEvent>? Events { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.VirtualEvent> Events { get; set; }
#endif
        /// <summary>A collection of town halls. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.VirtualEventTownhall>? Townhalls { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.VirtualEventTownhall> Townhalls { get; set; }
#endif
        /// <summary>A collection of webinars. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.VirtualEventWebinar>? Webinars { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.VirtualEventWebinar> Webinars { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.VirtualEventsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.VirtualEventsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.VirtualEventsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "events", n => { Events = n.GetCollectionOfObjectValues<global::ApiSdk.Models.VirtualEvent>(global::ApiSdk.Models.VirtualEvent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "townhalls", n => { Townhalls = n.GetCollectionOfObjectValues<global::ApiSdk.Models.VirtualEventTownhall>(global::ApiSdk.Models.VirtualEventTownhall.CreateFromDiscriminatorValue)?.AsList(); } },
                { "webinars", n => { Webinars = n.GetCollectionOfObjectValues<global::ApiSdk.Models.VirtualEventWebinar>(global::ApiSdk.Models.VirtualEventWebinar.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.VirtualEvent>("events", Events);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.VirtualEventTownhall>("townhalls", Townhalls);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.VirtualEventWebinar>("webinars", Webinars);
        }
    }
}
#pragma warning restore CS0618
