// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// The details of the application which the user has requested to elevate
    /// </summary>
    public class ElevationRequestApplicationDetail : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The path of the file in the request for elevation, for example, %programfiles%\git\cmd</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileDescription { get; set; }
#nullable restore
#else
        public string FileDescription { get; set; }
#endif
        /// <summary>The SHA256 hash of the file in the request for elevation, for example, &apos;18ee24150dcb1d96752a4d6dd0f20dfd8ba8c38527e40aa8509b7adecf78f9c6&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileHash { get; set; }
#nullable restore
#else
        public string FileHash { get; set; }
#endif
        /// <summary>The name of the file in the request for elevation, for example, git.exe</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The path of the file in the request for elevation, for example, %programfiles%\git\cmd</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePath { get; set; }
#nullable restore
#else
        public string FilePath { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The internal name of the application for which elevation request has been made. For example, &apos;git&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductInternalName { get; set; }
#nullable restore
#else
        public string ProductInternalName { get; set; }
#endif
        /// <summary>The product name of the application for which elevation request has been made. For example, &apos;Git&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName { get; set; }
#nullable restore
#else
        public string ProductName { get; set; }
#endif
        /// <summary>The product version of the application for which elevation request has been made. For example, &apos;2.40.1.0&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductVersion { get; set; }
#nullable restore
#else
        public string ProductVersion { get; set; }
#endif
        /// <summary>The list of base64 encoded certificate for each signer, for example, string[encoded_leaf_cert1, encoded_leaf_cert2....]</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherCert { get; set; }
#nullable restore
#else
        public string PublisherCert { get; set; }
#endif
        /// <summary>The certificate issuer name of the certificate used to sign the application, for example, &apos;Sectigo Public Code Signing CA R36&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherName { get; set; }
#nullable restore
#else
        public string PublisherName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ElevationRequestApplicationDetail"/> and sets the default values.
        /// </summary>
        public ElevationRequestApplicationDetail()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ElevationRequestApplicationDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ElevationRequestApplicationDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ElevationRequestApplicationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fileDescription", n => { FileDescription = n.GetStringValue(); } },
                { "fileHash", n => { FileHash = n.GetStringValue(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "filePath", n => { FilePath = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "productInternalName", n => { ProductInternalName = n.GetStringValue(); } },
                { "productName", n => { ProductName = n.GetStringValue(); } },
                { "productVersion", n => { ProductVersion = n.GetStringValue(); } },
                { "publisherCert", n => { PublisherCert = n.GetStringValue(); } },
                { "publisherName", n => { PublisherName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fileDescription", FileDescription);
            writer.WriteStringValue("fileHash", FileHash);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("productInternalName", ProductInternalName);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteStringValue("publisherCert", PublisherCert);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
