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
    /// Android For Work PFX Import certificate profile
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidForWorkImportedPFXCertificateProfile : global::ApiSdk.Models.AndroidCertificateProfileBase, IParsable
    {
        /// <summary>PFX Import Options.</summary>
        public global::ApiSdk.Models.IntendedPurpose? IntendedPurpose { get; set; }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ManagedDeviceCertificateState>? ManagedDeviceCertificateStates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ManagedDeviceCertificateState> ManagedDeviceCertificateStates { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AndroidForWorkImportedPFXCertificateProfile"/> and sets the default values.
        /// </summary>
        public AndroidForWorkImportedPFXCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.androidForWorkImportedPFXCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AndroidForWorkImportedPFXCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AndroidForWorkImportedPFXCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AndroidForWorkImportedPFXCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "intendedPurpose", n => { IntendedPurpose = n.GetEnumValue<global::ApiSdk.Models.IntendedPurpose>(); } },
                { "managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ManagedDeviceCertificateState>(global::ApiSdk.Models.ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.IntendedPurpose>("intendedPurpose", IntendedPurpose);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
        }
    }
}
#pragma warning restore CS0618
