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
    public partial class UserRegistrationMethodSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Total number of users in the tenant.</summary>
        public long? TotalUserCount { get; set; }
        /// <summary>Number of users registered for each authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UserRegistrationMethodCount>? UserRegistrationMethodCounts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UserRegistrationMethodCount> UserRegistrationMethodCounts { get; set; }
#endif
        /// <summary>The role type of the user. Possible values are: all, privilegedAdmin, admin, user, unknownFutureValue.</summary>
        public global::ApiSdk.Models.IncludedUserRoles? UserRoles { get; set; }
        /// <summary>User type. Possible values are: all, member, guest, unknownFutureValue.</summary>
        public global::ApiSdk.Models.IncludedUserTypes? UserTypes { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.UserRegistrationMethodSummary"/> and sets the default values.
        /// </summary>
        public UserRegistrationMethodSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserRegistrationMethodSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.UserRegistrationMethodSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserRegistrationMethodSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "totalUserCount", n => { TotalUserCount = n.GetLongValue(); } },
                { "userRegistrationMethodCounts", n => { UserRegistrationMethodCounts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UserRegistrationMethodCount>(global::ApiSdk.Models.UserRegistrationMethodCount.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userRoles", n => { UserRoles = n.GetEnumValue<global::ApiSdk.Models.IncludedUserRoles>(); } },
                { "userTypes", n => { UserTypes = n.GetEnumValue<global::ApiSdk.Models.IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UserRegistrationMethodCount>("userRegistrationMethodCounts", UserRegistrationMethodCounts);
            writer.WriteEnumValue<global::ApiSdk.Models.IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<global::ApiSdk.Models.IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
