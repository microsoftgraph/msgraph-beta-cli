// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AnalyzedEmailAttachment : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The detonation details of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.DetonationDetails? DetonationDetails { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.DetonationDetails DetonationDetails { get; set; }
#endif
        /// <summary>The fileExtension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileExtension { get; set; }
#nullable restore
#else
        public string FileExtension { get; set; }
#endif
        /// <summary>The name of the attachment in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The fileSize property</summary>
        public int? FileSize { get; set; }
        /// <summary>The type of the attachment in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileType { get; set; }
#nullable restore
#else
        public string FileType { get; set; }
#endif
        /// <summary>The malwareFamily property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MalwareFamily { get; set; }
#nullable restore
#else
        public string MalwareFamily { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The SHA256 file hash of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha256 { get; set; }
#nullable restore
#else
        public string Sha256 { get; set; }
#endif
        /// <summary>The tenantAllowBlockListDetailInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantAllowBlockListDetailInfo { get; set; }
#nullable restore
#else
        public string TenantAllowBlockListDetailInfo { get; set; }
#endif
        /// <summary>The threat type associated with the attachment. The possible values are: unknown, spam, malware, phishing, none, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.ThreatType? ThreatType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Security.AnalyzedEmailAttachment"/> and sets the default values.
        /// </summary>
        public AnalyzedEmailAttachment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.AnalyzedEmailAttachment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Security.AnalyzedEmailAttachment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.AnalyzedEmailAttachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detonationDetails", n => { DetonationDetails = n.GetObjectValue<global::ApiSdk.Models.Security.DetonationDetails>(global::ApiSdk.Models.Security.DetonationDetails.CreateFromDiscriminatorValue); } },
                { "fileExtension", n => { FileExtension = n.GetStringValue(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "fileSize", n => { FileSize = n.GetIntValue(); } },
                { "fileType", n => { FileType = n.GetStringValue(); } },
                { "malwareFamily", n => { MalwareFamily = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sha256", n => { Sha256 = n.GetStringValue(); } },
                { "tenantAllowBlockListDetailInfo", n => { TenantAllowBlockListDetailInfo = n.GetStringValue(); } },
                { "threatType", n => { ThreatType = n.GetEnumValue<global::ApiSdk.Models.Security.ThreatType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.Security.DetonationDetails>("detonationDetails", DetonationDetails);
            writer.WriteStringValue("fileExtension", FileExtension);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteIntValue("fileSize", FileSize);
            writer.WriteStringValue("fileType", FileType);
            writer.WriteStringValue("malwareFamily", MalwareFamily);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sha256", Sha256);
            writer.WriteStringValue("tenantAllowBlockListDetailInfo", TenantAllowBlockListDetailInfo);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.ThreatType>("threatType", ThreatType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
