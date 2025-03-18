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
    /// Enrollment Profile used to enroll Android Enterprise devices using Google&apos;s Cloud Management.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidDeviceOwnerEnrollmentProfile : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Tenant GUID the enrollment profile belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>Boolean that indicates that the Wi-Fi network should be configured during device provisioning. When set to TRUE, device provisioning will use Wi-Fi related properties to automatically connect to Wi-Fi networks. When set to FALSE or undefined, other Wi-Fi related properties will be ignored. Default value is TRUE. Returned by default.</summary>
        public bool? ConfigureWifi { get; set; }
        /// <summary>Date time the enrollment profile was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description for the enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display name for the enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Total number of Android devices that have enrolled using this enrollment profile.</summary>
        public int? EnrolledDeviceCount { get; set; }
        /// <summary>The enrollment mode for an enrollment profile.</summary>
        public global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentMode? EnrollmentMode { get; set; }
        /// <summary>The enrollment token type for an enrollment profile.</summary>
        public global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentTokenType? EnrollmentTokenType { get; set; }
        /// <summary>Total number of AOSP devices that have enrolled using the current token. Valid values 0 to 20000</summary>
        public int? EnrollmentTokenUsageCount { get; set; }
        /// <summary>Boolean indicating if this profile is an Android AOSP for Teams device profile.</summary>
        public bool? IsTeamsDeviceProfile { get; set; }
        /// <summary>Date time the enrollment profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>String used to generate a QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QrCodeContent { get; set; }
#nullable restore
#else
        public string QrCodeContent { get; set; }
#endif
        /// <summary>String used to generate a QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MimeContent? QrCodeImage { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MimeContent QrCodeImage { get; set; }
#endif
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>Date time the most recently created token was created.</summary>
        public DateTimeOffset? TokenCreationDateTime { get; set; }
        /// <summary>Date time the most recently created token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
        /// <summary>Value of the most recently created token for this enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenValue { get; set; }
#nullable restore
#else
        public string TokenValue { get; set; }
#endif
        /// <summary>Boolean that indicates if hidden wifi networks are enabled</summary>
        public bool? WifiHidden { get; set; }
        /// <summary>String that contains the wi-fi login password</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WifiPassword { get; set; }
#nullable restore
#else
        public string WifiPassword { get; set; }
#endif
        /// <summary>This enum represents Wi-Fi Security Types for Android Device Owner AOSP Scenarios.</summary>
        public global::ApiSdk.Models.AospWifiSecurityType? WifiSecurityType { get; set; }
        /// <summary>String that contains the wi-fi login ssid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WifiSsid { get; set; }
#nullable restore
#else
        public string WifiSsid { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountId", n => { AccountId = n.GetStringValue(); } },
                { "configureWifi", n => { ConfigureWifi = n.GetBoolValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enrolledDeviceCount", n => { EnrolledDeviceCount = n.GetIntValue(); } },
                { "enrollmentMode", n => { EnrollmentMode = n.GetEnumValue<global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentMode>(); } },
                { "enrollmentTokenType", n => { EnrollmentTokenType = n.GetEnumValue<global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentTokenType>(); } },
                { "enrollmentTokenUsageCount", n => { EnrollmentTokenUsageCount = n.GetIntValue(); } },
                { "isTeamsDeviceProfile", n => { IsTeamsDeviceProfile = n.GetBoolValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "qrCodeContent", n => { QrCodeContent = n.GetStringValue(); } },
                { "qrCodeImage", n => { QrCodeImage = n.GetObjectValue<global::ApiSdk.Models.MimeContent>(global::ApiSdk.Models.MimeContent.CreateFromDiscriminatorValue); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tokenCreationDateTime", n => { TokenCreationDateTime = n.GetDateTimeOffsetValue(); } },
                { "tokenExpirationDateTime", n => { TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "tokenValue", n => { TokenValue = n.GetStringValue(); } },
                { "wifiHidden", n => { WifiHidden = n.GetBoolValue(); } },
                { "wifiPassword", n => { WifiPassword = n.GetStringValue(); } },
                { "wifiSecurityType", n => { WifiSecurityType = n.GetEnumValue<global::ApiSdk.Models.AospWifiSecurityType>(); } },
                { "wifiSsid", n => { WifiSsid = n.GetStringValue(); } },
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
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteBoolValue("configureWifi", ConfigureWifi);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteEnumValue<global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentMode>("enrollmentMode", EnrollmentMode);
            writer.WriteEnumValue<global::ApiSdk.Models.AndroidDeviceOwnerEnrollmentTokenType>("enrollmentTokenType", EnrollmentTokenType);
            writer.WriteIntValue("enrollmentTokenUsageCount", EnrollmentTokenUsageCount);
            writer.WriteBoolValue("isTeamsDeviceProfile", IsTeamsDeviceProfile);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("qrCodeContent", QrCodeContent);
            writer.WriteObjectValue<global::ApiSdk.Models.MimeContent>("qrCodeImage", QrCodeImage);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteDateTimeOffsetValue("tokenCreationDateTime", TokenCreationDateTime);
            writer.WriteDateTimeOffsetValue("tokenExpirationDateTime", TokenExpirationDateTime);
            writer.WriteStringValue("tokenValue", TokenValue);
            writer.WriteBoolValue("wifiHidden", WifiHidden);
            writer.WriteStringValue("wifiPassword", WifiPassword);
            writer.WriteEnumValue<global::ApiSdk.Models.AospWifiSecurityType>("wifiSecurityType", WifiSecurityType);
            writer.WriteStringValue("wifiSsid", WifiSsid);
        }
    }
}
#pragma warning restore CS0618
