// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ClassGroupConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The different attributes to sync for the class groups. The possible values are: courseTitle, courseCode, courseSubject, courseGradeLevel, courseExternalId, academicSessionTitle, academicSessionExternalId, classCode, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IndustryData.AdditionalClassGroupAttributes?>? AdditionalAttributes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IndustryData.AdditionalClassGroupAttributes?> AdditionalAttributes { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additionalOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IndustryData.AdditionalClassGroupOptions? AdditionalOptions { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IndustryData.AdditionalClassGroupOptions AdditionalOptions { get; set; }
#endif
        /// <summary>The enrollmentMappings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IndustryData.EnrollmentMappings? EnrollmentMappings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IndustryData.EnrollmentMappings EnrollmentMappings { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.IndustryData.ClassGroupConfiguration"/> and sets the default values.
        /// </summary>
        public ClassGroupConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.IndustryData.ClassGroupConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.IndustryData.ClassGroupConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.IndustryData.ClassGroupConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additionalAttributes", n => { AdditionalAttributes = n.GetCollectionOfEnumValues<global::ApiSdk.Models.IndustryData.AdditionalClassGroupAttributes>()?.AsList(); } },
                { "additionalOptions", n => { AdditionalOptions = n.GetObjectValue<global::ApiSdk.Models.IndustryData.AdditionalClassGroupOptions>(global::ApiSdk.Models.IndustryData.AdditionalClassGroupOptions.CreateFromDiscriminatorValue); } },
                { "enrollmentMappings", n => { EnrollmentMappings = n.GetObjectValue<global::ApiSdk.Models.IndustryData.EnrollmentMappings>(global::ApiSdk.Models.IndustryData.EnrollmentMappings.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.IndustryData.AdditionalClassGroupAttributes>("additionalAttributes", AdditionalAttributes);
            writer.WriteObjectValue<global::ApiSdk.Models.IndustryData.AdditionalClassGroupOptions>("additionalOptions", AdditionalOptions);
            writer.WriteObjectValue<global::ApiSdk.Models.IndustryData.EnrollmentMappings>("enrollmentMappings", EnrollmentMappings);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
