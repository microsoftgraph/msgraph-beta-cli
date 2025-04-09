// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.CallRecords
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PstnBlockedUsersLogRow : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time when the user was blocked/unblocked from making PSTN calls. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? BlockDateTime { get; set; }
        /// <summary>The reason why the user is blocked/unblocked from making calls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BlockReason { get; set; }
#nullable restore
#else
        public string BlockReason { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Unique identifier (GUID) for the blocking/unblocking action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationId { get; set; }
#nullable restore
#else
        public string RemediationId { get; set; }
#endif
        /// <summary>Indicates whether the user is blocked or unblocked from making PSTN calls in Microsoft Teams. The possible values are: blocked, unblocked, unknownFutureValue.</summary>
        public global::ApiSdk.Models.CallRecords.PstnUserBlockMode? UserBlockMode { get; set; }
        /// <summary>Display name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; set; }
#nullable restore
#else
        public string UserDisplayName { get; set; }
#endif
        /// <summary>The unique identifier (GUID) of the user in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>The user principal name (sign-in name) in Microsoft Entra ID. This is usually the same as the user&apos;s SIP address, and can be same as the user&apos;s e-mail address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>User&apos;s blocked number. For details, see E.164.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserTelephoneNumber { get; set; }
#nullable restore
#else
        public string UserTelephoneNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CallRecords.PstnBlockedUsersLogRow"/> and sets the default values.
        /// </summary>
        public PstnBlockedUsersLogRow()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CallRecords.PstnBlockedUsersLogRow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.CallRecords.PstnBlockedUsersLogRow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CallRecords.PstnBlockedUsersLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "blockDateTime", n => { BlockDateTime = n.GetDateTimeOffsetValue(); } },
                { "blockReason", n => { BlockReason = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "remediationId", n => { RemediationId = n.GetStringValue(); } },
                { "userBlockMode", n => { UserBlockMode = n.GetEnumValue<global::ApiSdk.Models.CallRecords.PstnUserBlockMode>(); } },
                { "userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "userTelephoneNumber", n => { UserTelephoneNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("blockDateTime", BlockDateTime);
            writer.WriteStringValue("blockReason", BlockReason);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("remediationId", RemediationId);
            writer.WriteEnumValue<global::ApiSdk.Models.CallRecords.PstnUserBlockMode>("userBlockMode", UserBlockMode);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userTelephoneNumber", UserTelephoneNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
