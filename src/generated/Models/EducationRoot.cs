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
    public partial class EducationRoot : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The classes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.EducationClass>? Classes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.EducationClass> Classes { get; set; }
#endif
        /// <summary>The me property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EducationUser? Me { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EducationUser Me { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The reports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ReportsRoot? Reports { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ReportsRoot Reports { get; set; }
#endif
        /// <summary>The schools property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.EducationSchool>? Schools { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.EducationSchool> Schools { get; set; }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.EducationUser>? Users { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.EducationUser> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.EducationRoot"/> and sets the default values.
        /// </summary>
        public EducationRoot()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EducationRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.EducationRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EducationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "classes", n => { Classes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.EducationClass>(global::ApiSdk.Models.EducationClass.CreateFromDiscriminatorValue)?.AsList(); } },
                { "me", n => { Me = n.GetObjectValue<global::ApiSdk.Models.EducationUser>(global::ApiSdk.Models.EducationUser.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "reports", n => { Reports = n.GetObjectValue<global::ApiSdk.Models.ReportsRoot>(global::ApiSdk.Models.ReportsRoot.CreateFromDiscriminatorValue); } },
                { "schools", n => { Schools = n.GetCollectionOfObjectValues<global::ApiSdk.Models.EducationSchool>(global::ApiSdk.Models.EducationSchool.CreateFromDiscriminatorValue)?.AsList(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<global::ApiSdk.Models.EducationUser>(global::ApiSdk.Models.EducationUser.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.EducationClass>("classes", Classes);
            writer.WriteObjectValue<global::ApiSdk.Models.EducationUser>("me", Me);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::ApiSdk.Models.ReportsRoot>("reports", Reports);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.EducationUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
