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
    /// Updates for different Windows&apos; versions are usually released on the Patch Tuesday or B-week  of each month. This complex type defines the Build-version and the release-date for a particular B-week update of the Windows&apos; version.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedDeviceWindowsOperatingSystemUpdate : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the build version for associated windows update. Windows Operating System updates are usually released on the Patch Tuesday or B-week of each month. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BuildVersion { get; set; }
#nullable restore
#else
        public string BuildVersion { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates the Month in which this B-week update was released. Read-only.</summary>
        public int? ReleaseMonth { get; set; }
        /// <summary>Indicates the Year in which this B-week update was released. Read-only.</summary>
        public int? ReleaseYear { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ManagedDeviceWindowsOperatingSystemUpdate"/> and sets the default values.
        /// </summary>
        public ManagedDeviceWindowsOperatingSystemUpdate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ManagedDeviceWindowsOperatingSystemUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ManagedDeviceWindowsOperatingSystemUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ManagedDeviceWindowsOperatingSystemUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "buildVersion", n => { BuildVersion = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "releaseMonth", n => { ReleaseMonth = n.GetIntValue(); } },
                { "releaseYear", n => { ReleaseYear = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("buildVersion", BuildVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("releaseMonth", ReleaseMonth);
            writer.WriteIntValue("releaseYear", ReleaseYear);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618