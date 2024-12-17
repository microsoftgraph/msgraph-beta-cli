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
    public partial class EducationPowerSchoolDataProvider : global::ApiSdk.Models.EducationSynchronizationDataProvider, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the source has multiple identifiers for a single student or teacher.</summary>
        public bool? AllowTeachersInMultipleSchools { get; set; }
        /// <summary>The client ID used to connect to PowerSchool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>The client secret to authenticate the connection to the PowerSchool instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientSecret { get; set; }
#nullable restore
#else
        public string ClientSecret { get; set; }
#endif
        /// <summary>The connection URL to the PowerSchool instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionUrl { get; set; }
#nullable restore
#else
        public string ConnectionUrl { get; set; }
#endif
        /// <summary>Optional customization to be applied to the synchronization profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EducationSynchronizationCustomizations? Customizations { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EducationSynchronizationCustomizations Customizations { get; set; }
#endif
        /// <summary>The list of schools to sync.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SchoolsIds { get; set; }
#nullable restore
#else
        public List<string> SchoolsIds { get; set; }
#endif
        /// <summary>The school year to sync.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchoolYear { get; set; }
#nullable restore
#else
        public string SchoolYear { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.EducationPowerSchoolDataProvider"/> and sets the default values.
        /// </summary>
        public EducationPowerSchoolDataProvider() : base()
        {
            OdataType = "#microsoft.graph.educationPowerSchoolDataProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EducationPowerSchoolDataProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.EducationPowerSchoolDataProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EducationPowerSchoolDataProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowTeachersInMultipleSchools", n => { AllowTeachersInMultipleSchools = n.GetBoolValue(); } },
                { "clientId", n => { ClientId = n.GetStringValue(); } },
                { "clientSecret", n => { ClientSecret = n.GetStringValue(); } },
                { "connectionUrl", n => { ConnectionUrl = n.GetStringValue(); } },
                { "customizations", n => { Customizations = n.GetObjectValue<global::ApiSdk.Models.EducationSynchronizationCustomizations>(global::ApiSdk.Models.EducationSynchronizationCustomizations.CreateFromDiscriminatorValue); } },
                { "schoolYear", n => { SchoolYear = n.GetStringValue(); } },
                { "schoolsIds", n => { SchoolsIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteBoolValue("allowTeachersInMultipleSchools", AllowTeachersInMultipleSchools);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteStringValue("connectionUrl", ConnectionUrl);
            writer.WriteObjectValue<global::ApiSdk.Models.EducationSynchronizationCustomizations>("customizations", Customizations);
            writer.WriteCollectionOfPrimitiveValues<string>("schoolsIds", SchoolsIds);
            writer.WriteStringValue("schoolYear", SchoolYear);
        }
    }
}
#pragma warning restore CS0618
