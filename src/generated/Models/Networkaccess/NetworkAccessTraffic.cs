// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Networkaccess
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class NetworkAccessTraffic : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates what action to take based on filtering policies. The possible values are: block, allow.</summary>
        public global::ApiSdk.Models.Networkaccess.FilteringPolicyAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the version of the Global Secure Access client agent software. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgentVersion { get; set; }
#nullable restore
#else
        public string AgentVersion { get; set; }
#endif
        /// <summary>The applicationSnapshot property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Networkaccess.ApplicationSnapshot? ApplicationSnapshot { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Networkaccess.ApplicationSnapshot ApplicationSnapshot { get; set; }
#endif
        /// <summary>Represents a unique identifier assigned to a connection. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionId { get; set; }
#nullable restore
#else
        public string ConnectionId { get; set; }
#endif
        /// <summary>Represents the date and time when a network access traffic log entry was created. Supports $filter (eq) and $orderby.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Represents the Fully Qualified Domain Name (FQDN) of the destination host or server in a network communication. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationFQDN { get; set; }
#nullable restore
#else
        public string DestinationFQDN { get; set; }
#endif
        /// <summary>Represents the IP address of the destination host or server in a network communication. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationIp { get; set; }
#nullable restore
#else
        public string DestinationIp { get; set; }
#endif
        /// <summary>Represents the network port number on the destination host or server in a network communication. Supports $filter (eq) and $orderby.</summary>
        public int? DestinationPort { get; set; }
        /// <summary>The destinationUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationUrl { get; set; }
#nullable restore
#else
        public string DestinationUrl { get; set; }
#endif
        /// <summary>The destinationWebCategory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Networkaccess.WebCategory? DestinationWebCategory { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Networkaccess.WebCategory DestinationWebCategory { get; set; }
#endif
        /// <summary>The device property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Device? Device { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Device Device { get; set; }
#endif
        /// <summary>Represents the category classification of a device within a network infrastructure. The possible values are: client, branch, unknownFutureValue. Supports $filter (eq) and $orderby.</summary>
        public global::ApiSdk.Models.Networkaccess.DeviceCategory? DeviceCategory { get; set; }
        /// <summary>Represents a unique identifier assigned to a device within a network infrastructure. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>Represents the operating system installed on a device within a network infrastructure. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOperatingSystem { get; set; }
#nullable restore
#else
        public string DeviceOperatingSystem { get; set; }
#endif
        /// <summary>Represents the version or release number of the operating system installed on a device within a network infrastructure. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOperatingSystemVersion { get; set; }
#nullable restore
#else
        public string DeviceOperatingSystemVersion { get; set; }
#endif
        /// <summary>The filteringProfileId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilteringProfileId { get; set; }
#nullable restore
#else
        public string FilteringProfileId { get; set; }
#endif
        /// <summary>The filteringProfileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilteringProfileName { get; set; }
#nullable restore
#else
        public string FilteringProfileName { get; set; }
#endif
        /// <summary>Represents the headers included in a network request or response. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Networkaccess.Headers? Headers { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Networkaccess.Headers Headers { get; set; }
#endif
        /// <summary>The httpMethod property</summary>
        public global::ApiSdk.Models.Networkaccess.HttpMethod? HttpMethod { get; set; }
        /// <summary>The initiatingProcessName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatingProcessName { get; set; }
#nullable restore
#else
        public string InitiatingProcessName { get; set; }
#endif
        /// <summary>Represents the networking protocol used for communication.The possible values are: ip, icmp, igmp, ggp, ipv4, tcp, pup, udp, idp, ipv6, ipv6RoutingHeader, ipv6FragmentHeader, ipSecEncapsulatingSecurityPayload, ipSecAuthenticationHeader, icmpV6, ipv6NoNextHeader, ipv6DestinationOptions, nd, raw, ipx, spx, spxII, unknownFutureValue. Supports $filter (eq) and $orderby.</summary>
        public global::ApiSdk.Models.Networkaccess.NetworkingProtocol? NetworkProtocol { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The operationStatus property</summary>
        public global::ApiSdk.Models.Networkaccess.NetworkTrafficOperationStatus? OperationStatus { get; set; }
        /// <summary>Represents a unique identifier assigned to a policy. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId { get; set; }
#nullable restore
#else
        public string PolicyId { get; set; }
#endif
        /// <summary>The policyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyName { get; set; }
#nullable restore
#else
        public string PolicyName { get; set; }
#endif
        /// <summary>Represents a unique identifier assigned to a policy rule. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyRuleId { get; set; }
#nullable restore
#else
        public string PolicyRuleId { get; set; }
#endif
        /// <summary>The policyRuleName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyRuleName { get; set; }
#nullable restore
#else
        public string PolicyRuleName { get; set; }
#endif
        /// <summary>The popProcessingRegion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PopProcessingRegion { get; set; }
#nullable restore
#else
        public string PopProcessingRegion { get; set; }
#endif
        /// <summary>The privateAccessDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Networkaccess.PrivateAccessDetails? PrivateAccessDetails { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Networkaccess.PrivateAccessDetails PrivateAccessDetails { get; set; }
#endif
        /// <summary>Represents the total number of bytes received in a network communication or data transfer. Supports $filter (eq) and $orderby.</summary>
        public long? ReceivedBytes { get; set; }
        /// <summary>The remoteNetworkId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteNetworkId { get; set; }
#nullable restore
#else
        public string RemoteNetworkId { get; set; }
#endif
        /// <summary>The resourceTenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceTenantId { get; set; }
#nullable restore
#else
        public string ResourceTenantId { get; set; }
#endif
        /// <summary>The responseCode property</summary>
        public int? ResponseCode { get; set; }
        /// <summary>Represents the total number of bytes sent in a network communication or data transfer. Supports $filter (eq) and $orderby.</summary>
        public long? SentBytes { get; set; }
        /// <summary>Represents a unique identifier assigned to a session or connection within a network infrastructure. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionId { get; set; }
#nullable restore
#else
        public string SessionId { get; set; }
#endif
        /// <summary>Represents the source IP address in a network communication. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceIp { get; set; }
#nullable restore
#else
        public string SourceIp { get; set; }
#endif
        /// <summary>Represents the network port number on the source host or device in a network communication. Supports $filter (eq) and $orderby.</summary>
        public int? SourcePort { get; set; }
        /// <summary>Represents a unique identifier assigned to a tenant within a network infrastructure. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The threatType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatType { get; set; }
#nullable restore
#else
        public string ThreatType { get; set; }
#endif
        /// <summary>The trafficType property</summary>
        public global::ApiSdk.Models.Networkaccess.TrafficType? TrafficType { get; set; }
        /// <summary>Represents a unique identifier assigned to a specific transaction or operation. Key. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionId { get; set; }
#nullable restore
#else
        public string TransactionId { get; set; }
#endif
        /// <summary>Represents the transport protocol used for communication.The possible values are: ip, icmp, igmp, ggp, ipv4, tcp, pup, udp, idp, ipv6, ipv6RoutingHeader, ipv6FragmentHeader, ipSecEncapsulatingSecurityPayload, ipSecAuthenticationHeader, icmpV6, ipv6NoNextHeader, ipv6DestinationOptions, nd, raw, ipx, spx, spxII, unknownFutureValue. Supports $filter (eq) and $orderby.</summary>
        public global::ApiSdk.Models.Networkaccess.NetworkingProtocol? TransportProtocol { get; set; }
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.User? User { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.User User { get; set; }
#endif
        /// <summary>Represents a unique identifier assigned to a user. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>Represents the user principal name (UPN) associated with a user. Supports $filter (eq) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>The vendorNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? VendorNames { get; set; }
#nullable restore
#else
        public List<string> VendorNames { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Networkaccess.NetworkAccessTraffic"/> and sets the default values.
        /// </summary>
        public NetworkAccessTraffic()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Networkaccess.NetworkAccessTraffic"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Networkaccess.NetworkAccessTraffic CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Networkaccess.NetworkAccessTraffic();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.FilteringPolicyAction>(); } },
                { "agentVersion", n => { AgentVersion = n.GetStringValue(); } },
                { "applicationSnapshot", n => { ApplicationSnapshot = n.GetObjectValue<global::ApiSdk.Models.Networkaccess.ApplicationSnapshot>(global::ApiSdk.Models.Networkaccess.ApplicationSnapshot.CreateFromDiscriminatorValue); } },
                { "connectionId", n => { ConnectionId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "destinationFQDN", n => { DestinationFQDN = n.GetStringValue(); } },
                { "destinationIp", n => { DestinationIp = n.GetStringValue(); } },
                { "destinationPort", n => { DestinationPort = n.GetIntValue(); } },
                { "destinationUrl", n => { DestinationUrl = n.GetStringValue(); } },
                { "destinationWebCategory", n => { DestinationWebCategory = n.GetObjectValue<global::ApiSdk.Models.Networkaccess.WebCategory>(global::ApiSdk.Models.Networkaccess.WebCategory.CreateFromDiscriminatorValue); } },
                { "device", n => { Device = n.GetObjectValue<global::ApiSdk.Models.Device>(global::ApiSdk.Models.Device.CreateFromDiscriminatorValue); } },
                { "deviceCategory", n => { DeviceCategory = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.DeviceCategory>(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "deviceOperatingSystem", n => { DeviceOperatingSystem = n.GetStringValue(); } },
                { "deviceOperatingSystemVersion", n => { DeviceOperatingSystemVersion = n.GetStringValue(); } },
                { "filteringProfileId", n => { FilteringProfileId = n.GetStringValue(); } },
                { "filteringProfileName", n => { FilteringProfileName = n.GetStringValue(); } },
                { "headers", n => { Headers = n.GetObjectValue<global::ApiSdk.Models.Networkaccess.Headers>(global::ApiSdk.Models.Networkaccess.Headers.CreateFromDiscriminatorValue); } },
                { "httpMethod", n => { HttpMethod = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.HttpMethod>(); } },
                { "initiatingProcessName", n => { InitiatingProcessName = n.GetStringValue(); } },
                { "networkProtocol", n => { NetworkProtocol = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.NetworkingProtocol>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "operationStatus", n => { OperationStatus = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.NetworkTrafficOperationStatus>(); } },
                { "policyId", n => { PolicyId = n.GetStringValue(); } },
                { "policyName", n => { PolicyName = n.GetStringValue(); } },
                { "policyRuleId", n => { PolicyRuleId = n.GetStringValue(); } },
                { "policyRuleName", n => { PolicyRuleName = n.GetStringValue(); } },
                { "popProcessingRegion", n => { PopProcessingRegion = n.GetStringValue(); } },
                { "privateAccessDetails", n => { PrivateAccessDetails = n.GetObjectValue<global::ApiSdk.Models.Networkaccess.PrivateAccessDetails>(global::ApiSdk.Models.Networkaccess.PrivateAccessDetails.CreateFromDiscriminatorValue); } },
                { "receivedBytes", n => { ReceivedBytes = n.GetLongValue(); } },
                { "remoteNetworkId", n => { RemoteNetworkId = n.GetStringValue(); } },
                { "resourceTenantId", n => { ResourceTenantId = n.GetStringValue(); } },
                { "responseCode", n => { ResponseCode = n.GetIntValue(); } },
                { "sentBytes", n => { SentBytes = n.GetLongValue(); } },
                { "sessionId", n => { SessionId = n.GetStringValue(); } },
                { "sourceIp", n => { SourceIp = n.GetStringValue(); } },
                { "sourcePort", n => { SourcePort = n.GetIntValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "threatType", n => { ThreatType = n.GetStringValue(); } },
                { "trafficType", n => { TrafficType = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.TrafficType>(); } },
                { "transactionId", n => { TransactionId = n.GetStringValue(); } },
                { "transportProtocol", n => { TransportProtocol = n.GetEnumValue<global::ApiSdk.Models.Networkaccess.NetworkingProtocol>(); } },
                { "user", n => { User = n.GetObjectValue<global::ApiSdk.Models.User>(global::ApiSdk.Models.User.CreateFromDiscriminatorValue); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "vendorNames", n => { VendorNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.FilteringPolicyAction>("action", Action);
            writer.WriteStringValue("agentVersion", AgentVersion);
            writer.WriteObjectValue<global::ApiSdk.Models.Networkaccess.ApplicationSnapshot>("applicationSnapshot", ApplicationSnapshot);
            writer.WriteStringValue("connectionId", ConnectionId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("destinationFQDN", DestinationFQDN);
            writer.WriteStringValue("destinationIp", DestinationIp);
            writer.WriteIntValue("destinationPort", DestinationPort);
            writer.WriteStringValue("destinationUrl", DestinationUrl);
            writer.WriteObjectValue<global::ApiSdk.Models.Networkaccess.WebCategory>("destinationWebCategory", DestinationWebCategory);
            writer.WriteObjectValue<global::ApiSdk.Models.Device>("device", Device);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceOperatingSystem", DeviceOperatingSystem);
            writer.WriteStringValue("deviceOperatingSystemVersion", DeviceOperatingSystemVersion);
            writer.WriteStringValue("filteringProfileId", FilteringProfileId);
            writer.WriteStringValue("filteringProfileName", FilteringProfileName);
            writer.WriteObjectValue<global::ApiSdk.Models.Networkaccess.Headers>("headers", Headers);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.HttpMethod>("httpMethod", HttpMethod);
            writer.WriteStringValue("initiatingProcessName", InitiatingProcessName);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.NetworkingProtocol>("networkProtocol", NetworkProtocol);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.NetworkTrafficOperationStatus>("operationStatus", OperationStatus);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteStringValue("policyRuleId", PolicyRuleId);
            writer.WriteStringValue("policyRuleName", PolicyRuleName);
            writer.WriteStringValue("popProcessingRegion", PopProcessingRegion);
            writer.WriteObjectValue<global::ApiSdk.Models.Networkaccess.PrivateAccessDetails>("privateAccessDetails", PrivateAccessDetails);
            writer.WriteLongValue("receivedBytes", ReceivedBytes);
            writer.WriteStringValue("remoteNetworkId", RemoteNetworkId);
            writer.WriteStringValue("resourceTenantId", ResourceTenantId);
            writer.WriteIntValue("responseCode", ResponseCode);
            writer.WriteLongValue("sentBytes", SentBytes);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteStringValue("sourceIp", SourceIp);
            writer.WriteIntValue("sourcePort", SourcePort);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("threatType", ThreatType);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.TrafficType>("trafficType", TrafficType);
            writer.WriteStringValue("transactionId", TransactionId);
            writer.WriteEnumValue<global::ApiSdk.Models.Networkaccess.NetworkingProtocol>("transportProtocol", TransportProtocol);
            writer.WriteObjectValue<global::ApiSdk.Models.User>("user", User);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfPrimitiveValues<string>("vendorNames", VendorNames);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
