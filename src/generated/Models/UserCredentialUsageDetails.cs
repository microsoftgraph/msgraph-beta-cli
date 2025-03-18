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
    public partial class UserCredentialUsageDetails : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The authMethod property</summary>
        public global::ApiSdk.Models.UsageAuthMethod? AuthMethod { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Provides the failure reason for the corresponding reset or registration workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FailureReason { get; set; }
#nullable restore
#else
        public string FailureReason { get; set; }
#endif
        /// <summary>The feature property</summary>
        public global::ApiSdk.Models.FeatureType? Feature { get; set; }
        /// <summary>Indicates success or failure of the workflow.</summary>
        public bool? IsSuccess { get; set; }
        /// <summary>User name of the user performing the reset or registration workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; set; }
#nullable restore
#else
        public string UserDisplayName { get; set; }
#endif
        /// <summary>User principal name of the user performing the reset or registration workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserCredentialUsageDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UserCredentialUsageDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserCredentialUsageDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authMethod", n => { AuthMethod = n.GetEnumValue<global::ApiSdk.Models.UsageAuthMethod>(); } },
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "failureReason", n => { FailureReason = n.GetStringValue(); } },
                { "feature", n => { Feature = n.GetEnumValue<global::ApiSdk.Models.FeatureType>(); } },
                { "isSuccess", n => { IsSuccess = n.GetBoolValue(); } },
                { "userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.UsageAuthMethod>("authMethod", AuthMethod);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteEnumValue<global::ApiSdk.Models.FeatureType>("feature", Feature);
            writer.WriteBoolValue("isSuccess", IsSuccess);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
#pragma warning restore CS0618
