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
    /// ServiceNow properties including the ServiceNow instanceUrl, connection credentials and other metadata.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ServiceNowConnection : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>Indicates the method used by Intune to authenticate with ServiceNow. Currently supports only web authentication with ServiceNow using the specified app id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ServiceNowAuthenticationMethod? AuthenticationMethod { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ServiceNowAuthenticationMethod AuthenticationMethod { get; set; }
#endif
        /// <summary>Date Time when connection properties were created. The value cannot be modified and is automatically populated when the connection properties were entered.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Indicates the ServiceNow incident API URL that Intune will use the fetch incidents. Saved in the format of /api/now/table/incident</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentApiUrl { get; set; }
#nullable restore
#else
        public string IncidentApiUrl { get; set; }
#endif
        /// <summary>Indicates the ServiceNow instance URL that Intune will connect to. Saved in the format of https://.service-now.com</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceUrl { get; set; }
#nullable restore
#else
        public string InstanceUrl { get; set; }
#endif
        /// <summary>Date Time when connection properties were last updated. The value cannot be modified and is automatically populated when the connection properties were updated.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Date Time when incidents from ServiceNow were last queried</summary>
        public DateTimeOffset? LastQueriedDateTime { get; set; }
        /// <summary>Status of ServiceNow Connection</summary>
        public global::ApiSdk.Models.ServiceNowConnectionStatus? ServiceNowConnectionStatus { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ServiceNowConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ServiceNowConnection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ServiceNowConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationMethod", n => { AuthenticationMethod = n.GetObjectValue<global::ApiSdk.Models.ServiceNowAuthenticationMethod>(global::ApiSdk.Models.ServiceNowAuthenticationMethod.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "incidentApiUrl", n => { IncidentApiUrl = n.GetStringValue(); } },
                { "instanceUrl", n => { InstanceUrl = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastQueriedDateTime", n => { LastQueriedDateTime = n.GetDateTimeOffsetValue(); } },
                { "serviceNowConnectionStatus", n => { ServiceNowConnectionStatus = n.GetEnumValue<global::ApiSdk.Models.ServiceNowConnectionStatus>(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ServiceNowAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("incidentApiUrl", IncidentApiUrl);
            writer.WriteStringValue("instanceUrl", InstanceUrl);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastQueriedDateTime", LastQueriedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.ServiceNowConnectionStatus>("serviceNowConnectionStatus", ServiceNowConnectionStatus);
        }
    }
}
#pragma warning restore CS0618
