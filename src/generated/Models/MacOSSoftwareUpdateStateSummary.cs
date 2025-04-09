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
    /// MacOS software update state summary for a device and user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MacOSSoftwareUpdateStateSummary : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Human readable name of the software update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Last date time the report for this device and product key was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>Product key of the software update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductKey { get; set; }
#nullable restore
#else
        public string ProductKey { get; set; }
#endif
        /// <summary>MacOS Software Update State</summary>
        public global::ApiSdk.Models.MacOSSoftwareUpdateState? State { get; set; }
        /// <summary>MacOS Software Update Category</summary>
        public global::ApiSdk.Models.MacOSSoftwareUpdateCategory? UpdateCategory { get; set; }
        /// <summary>Version of the software update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdateVersion { get; set; }
#nullable restore
#else
        public string UpdateVersion { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.MacOSSoftwareUpdateStateSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.MacOSSoftwareUpdateStateSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.MacOSSoftwareUpdateStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "productKey", n => { ProductKey = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.MacOSSoftwareUpdateState>(); } },
                { "updateCategory", n => { UpdateCategory = n.GetEnumValue<global::ApiSdk.Models.MacOSSoftwareUpdateCategory>(); } },
                { "updateVersion", n => { UpdateVersion = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteEnumValue<global::ApiSdk.Models.MacOSSoftwareUpdateState>("state", State);
            writer.WriteEnumValue<global::ApiSdk.Models.MacOSSoftwareUpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteStringValue("updateVersion", UpdateVersion);
        }
    }
}
#pragma warning restore CS0618
