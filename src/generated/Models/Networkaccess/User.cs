// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class User : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>User display Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The firstAccessDateTime property</summary>
        public DateTimeOffset? FirstAccessDateTime { get; set; }
        /// <summary>The date and time of the most recent access.</summary>
        public DateTimeOffset? LastAccessDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The totalBytesReceived property</summary>
        public long? TotalBytesReceived { get; set; }
        /// <summary>The totalBytesSent property</summary>
        public long? TotalBytesSent { get; set; }
        /// <summary>The trafficType property</summary>
        public ApiSdk.Models.Networkaccess.TrafficType? TrafficType { get; set; }
        /// <summary>The transactionCount property</summary>
        public long? TransactionCount { get; set; }
        /// <summary>The ID for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>A unique identifier that is associated with a user in a system or directory. Typically, this value is an email address that is used for user authentication and identification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>The userType property</summary>
        public ApiSdk.Models.Networkaccess.UserType? UserType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="User"/> and sets the default values.
        /// </summary>
        public User()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="User"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static User CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "firstAccessDateTime", n => { FirstAccessDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastAccessDateTime", n => { LastAccessDateTime = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "totalBytesReceived", n => { TotalBytesReceived = n.GetLongValue(); } },
                { "totalBytesSent", n => { TotalBytesSent = n.GetLongValue(); } },
                { "trafficType", n => { TrafficType = n.GetEnumValue<TrafficType>(); } },
                { "transactionCount", n => { TransactionCount = n.GetLongValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "userType", n => { UserType = n.GetEnumValue<UserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("firstAccessDateTime", FirstAccessDateTime);
            writer.WriteDateTimeOffsetValue("lastAccessDateTime", LastAccessDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("totalBytesReceived", TotalBytesReceived);
            writer.WriteLongValue("totalBytesSent", TotalBytesSent);
            writer.WriteEnumValue<TrafficType>("trafficType", TrafficType);
            writer.WriteLongValue("transactionCount", TransactionCount);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<UserType>("userType", UserType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
