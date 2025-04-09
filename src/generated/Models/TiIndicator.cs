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
    public partial class TiIndicator : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action to apply if the indicator is matched from within the targetProduct security tool. Possible values are: unknown, allow, block, alert. Required.</summary>
        public global::ApiSdk.Models.TiAction? Action { get; set; }
        /// <summary>The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ActivityGroupNames { get; set; }
#nullable restore
#else
        public List<string> ActivityGroupNames { get; set; }
#endif
        /// <summary>A catchall area for extra data from the indicator that is not specifically covered by other tiIndicator properties. The security tool specified by targetProduct typically does not utilize this data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; set; }
#nullable restore
#else
        public string AdditionalInformation { get; set; }
#endif
        /// <summary>Stamped by the system when the indicator is ingested. The Microsoft Entra tenant id of submitting client. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId { get; set; }
#nullable restore
#else
        public string AzureTenantId { get; set; }
#endif
        /// <summary>An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable values are 0 – 100 with 100 being the highest.</summary>
        public int? Confidence { get; set; }
        /// <summary>Brief description (100 characters or less) of the threat represented by the indicator. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The area of the Diamond Model in which this indicator exists. Possible values are: unknown, adversary, capability, infrastructure, victim.</summary>
        public global::ApiSdk.Models.DiamondModel? DiamondModel { get; set; }
        /// <summary>The domainName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainName { get; set; }
#nullable restore
#else
        public string DomainName { get; set; }
#endif
        /// <summary>The emailEncoding property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailEncoding { get; set; }
#nullable restore
#else
        public string EmailEncoding { get; set; }
#endif
        /// <summary>The emailLanguage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailLanguage { get; set; }
#nullable restore
#else
        public string EmailLanguage { get; set; }
#endif
        /// <summary>The emailRecipient property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailRecipient { get; set; }
#nullable restore
#else
        public string EmailRecipient { get; set; }
#endif
        /// <summary>The emailSenderAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailSenderAddress { get; set; }
#nullable restore
#else
        public string EmailSenderAddress { get; set; }
#endif
        /// <summary>The emailSenderName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailSenderName { get; set; }
#nullable restore
#else
        public string EmailSenderName { get; set; }
#endif
        /// <summary>The emailSourceDomain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailSourceDomain { get; set; }
#nullable restore
#else
        public string EmailSourceDomain { get; set; }
#endif
        /// <summary>The emailSourceIpAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailSourceIpAddress { get; set; }
#nullable restore
#else
        public string EmailSourceIpAddress { get; set; }
#endif
        /// <summary>The emailSubject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailSubject { get; set; }
#nullable restore
#else
        public string EmailSubject { get; set; }
#endif
        /// <summary>The emailXMailer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailXMailer { get; set; }
#nullable restore
#else
        public string EmailXMailer { get; set; }
#endif
        /// <summary>DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>An identification number that ties the indicator back to the indicator provider’s system (for example, a foreign key).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The fileCompileDateTime property</summary>
        public DateTimeOffset? FileCompileDateTime { get; set; }
        /// <summary>The fileCreatedDateTime property</summary>
        public DateTimeOffset? FileCreatedDateTime { get; set; }
        /// <summary>The fileHashType property</summary>
        public global::ApiSdk.Models.FileHashType? FileHashType { get; set; }
        /// <summary>The fileHashValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileHashValue { get; set; }
#nullable restore
#else
        public string FileHashValue { get; set; }
#endif
        /// <summary>The fileMutexName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileMutexName { get; set; }
#nullable restore
#else
        public string FileMutexName { get; set; }
#endif
        /// <summary>The fileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The filePacker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePacker { get; set; }
#nullable restore
#else
        public string FilePacker { get; set; }
#endif
        /// <summary>The filePath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePath { get; set; }
#nullable restore
#else
        public string FilePath { get; set; }
#endif
        /// <summary>The fileSize property</summary>
        public long? FileSize { get; set; }
        /// <summary>The fileType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileType { get; set; }
#nullable restore
#else
        public string FileType { get; set; }
#endif
        /// <summary>Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? IngestedDateTime { get; set; }
        /// <summary>Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.</summary>
        public bool? IsActive { get; set; }
        /// <summary>A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain values’ below for exact values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? KillChain { get; set; }
#nullable restore
#else
        public List<string> KillChain { get; set; }
#endif
        /// <summary>Scenarios in which the indicator may cause false positives. This should be human-readable text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KnownFalsePositives { get; set; }
#nullable restore
#else
        public string KnownFalsePositives { get; set; }
#endif
        /// <summary>The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible that can be found via the Windows Defender Security Intelligence threat encyclopedia.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MalwareFamilyNames { get; set; }
#nullable restore
#else
        public List<string> MalwareFamilyNames { get; set; }
#endif
        /// <summary>The networkCidrBlock property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkCidrBlock { get; set; }
#nullable restore
#else
        public string NetworkCidrBlock { get; set; }
#endif
        /// <summary>The networkDestinationAsn property</summary>
        public long? NetworkDestinationAsn { get; set; }
        /// <summary>The networkDestinationCidrBlock property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkDestinationCidrBlock { get; set; }
#nullable restore
#else
        public string NetworkDestinationCidrBlock { get; set; }
#endif
        /// <summary>The networkDestinationIPv4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkDestinationIPv4 { get; set; }
#nullable restore
#else
        public string NetworkDestinationIPv4 { get; set; }
#endif
        /// <summary>The networkDestinationIPv6 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkDestinationIPv6 { get; set; }
#nullable restore
#else
        public string NetworkDestinationIPv6 { get; set; }
#endif
        /// <summary>The networkDestinationPort property</summary>
        public int? NetworkDestinationPort { get; set; }
        /// <summary>The networkIPv4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkIPv4 { get; set; }
#nullable restore
#else
        public string NetworkIPv4 { get; set; }
#endif
        /// <summary>The networkIPv6 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkIPv6 { get; set; }
#nullable restore
#else
        public string NetworkIPv6 { get; set; }
#endif
        /// <summary>The networkPort property</summary>
        public int? NetworkPort { get; set; }
        /// <summary>The networkProtocol property</summary>
        public int? NetworkProtocol { get; set; }
        /// <summary>The networkSourceAsn property</summary>
        public long? NetworkSourceAsn { get; set; }
        /// <summary>The networkSourceCidrBlock property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkSourceCidrBlock { get; set; }
#nullable restore
#else
        public string NetworkSourceCidrBlock { get; set; }
#endif
        /// <summary>The networkSourceIPv4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkSourceIPv4 { get; set; }
#nullable restore
#else
        public string NetworkSourceIPv4 { get; set; }
#endif
        /// <summary>The networkSourceIPv6 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkSourceIPv6 { get; set; }
#nullable restore
#else
        public string NetworkSourceIPv6 { get; set; }
#endif
        /// <summary>The networkSourcePort property</summary>
        public int? NetworkSourcePort { get; set; }
        /// <summary>Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools won&apos;t notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they&apos;ll simply log that a match occurred but won&apos;t perform the action. Default value is false.</summary>
        public bool? PassiveOnly { get; set; }
        /// <summary>An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero isn&apos;t severe at all. Default value is 3.</summary>
        public int? Severity { get; set; }
        /// <summary>A JSON array of strings that stores arbitrary tags/keywords.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetProduct { get; set; }
#nullable restore
#else
        public string TargetProduct { get; set; }
#endif
        /// <summary>Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatType { get; set; }
#nullable restore
#else
        public string ThreatType { get; set; }
#endif
        /// <summary>Traffic Light Protocol value for the indicator. Possible values are: unknown, white, green, amber, red. Required.</summary>
        public global::ApiSdk.Models.TlpLevel? TlpLevel { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The userAgent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserAgent { get; set; }
#nullable restore
#else
        public string UserAgent { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TiIndicator"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.TiIndicator CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TiIndicator();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "action", n => { Action = n.GetEnumValue<global::ApiSdk.Models.TiAction>(); } },
                { "activityGroupNames", n => { ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                { "azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                { "confidence", n => { Confidence = n.GetIntValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "diamondModel", n => { DiamondModel = n.GetEnumValue<global::ApiSdk.Models.DiamondModel>(); } },
                { "domainName", n => { DomainName = n.GetStringValue(); } },
                { "emailEncoding", n => { EmailEncoding = n.GetStringValue(); } },
                { "emailLanguage", n => { EmailLanguage = n.GetStringValue(); } },
                { "emailRecipient", n => { EmailRecipient = n.GetStringValue(); } },
                { "emailSenderAddress", n => { EmailSenderAddress = n.GetStringValue(); } },
                { "emailSenderName", n => { EmailSenderName = n.GetStringValue(); } },
                { "emailSourceDomain", n => { EmailSourceDomain = n.GetStringValue(); } },
                { "emailSourceIpAddress", n => { EmailSourceIpAddress = n.GetStringValue(); } },
                { "emailSubject", n => { EmailSubject = n.GetStringValue(); } },
                { "emailXMailer", n => { EmailXMailer = n.GetStringValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "fileCompileDateTime", n => { FileCompileDateTime = n.GetDateTimeOffsetValue(); } },
                { "fileCreatedDateTime", n => { FileCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "fileHashType", n => { FileHashType = n.GetEnumValue<global::ApiSdk.Models.FileHashType>(); } },
                { "fileHashValue", n => { FileHashValue = n.GetStringValue(); } },
                { "fileMutexName", n => { FileMutexName = n.GetStringValue(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "filePacker", n => { FilePacker = n.GetStringValue(); } },
                { "filePath", n => { FilePath = n.GetStringValue(); } },
                { "fileSize", n => { FileSize = n.GetLongValue(); } },
                { "fileType", n => { FileType = n.GetStringValue(); } },
                { "ingestedDateTime", n => { IngestedDateTime = n.GetDateTimeOffsetValue(); } },
                { "isActive", n => { IsActive = n.GetBoolValue(); } },
                { "killChain", n => { KillChain = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "knownFalsePositives", n => { KnownFalsePositives = n.GetStringValue(); } },
                { "lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                { "malwareFamilyNames", n => { MalwareFamilyNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "networkCidrBlock", n => { NetworkCidrBlock = n.GetStringValue(); } },
                { "networkDestinationAsn", n => { NetworkDestinationAsn = n.GetLongValue(); } },
                { "networkDestinationCidrBlock", n => { NetworkDestinationCidrBlock = n.GetStringValue(); } },
                { "networkDestinationIPv4", n => { NetworkDestinationIPv4 = n.GetStringValue(); } },
                { "networkDestinationIPv6", n => { NetworkDestinationIPv6 = n.GetStringValue(); } },
                { "networkDestinationPort", n => { NetworkDestinationPort = n.GetIntValue(); } },
                { "networkIPv4", n => { NetworkIPv4 = n.GetStringValue(); } },
                { "networkIPv6", n => { NetworkIPv6 = n.GetStringValue(); } },
                { "networkPort", n => { NetworkPort = n.GetIntValue(); } },
                { "networkProtocol", n => { NetworkProtocol = n.GetIntValue(); } },
                { "networkSourceAsn", n => { NetworkSourceAsn = n.GetLongValue(); } },
                { "networkSourceCidrBlock", n => { NetworkSourceCidrBlock = n.GetStringValue(); } },
                { "networkSourceIPv4", n => { NetworkSourceIPv4 = n.GetStringValue(); } },
                { "networkSourceIPv6", n => { NetworkSourceIPv6 = n.GetStringValue(); } },
                { "networkSourcePort", n => { NetworkSourcePort = n.GetIntValue(); } },
                { "passiveOnly", n => { PassiveOnly = n.GetBoolValue(); } },
                { "severity", n => { Severity = n.GetIntValue(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "targetProduct", n => { TargetProduct = n.GetStringValue(); } },
                { "threatType", n => { ThreatType = n.GetStringValue(); } },
                { "tlpLevel", n => { TlpLevel = n.GetEnumValue<global::ApiSdk.Models.TlpLevel>(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "userAgent", n => { UserAgent = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.TiAction>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("activityGroupNames", ActivityGroupNames);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::ApiSdk.Models.DiamondModel>("diamondModel", DiamondModel);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("emailEncoding", EmailEncoding);
            writer.WriteStringValue("emailLanguage", EmailLanguage);
            writer.WriteStringValue("emailRecipient", EmailRecipient);
            writer.WriteStringValue("emailSenderAddress", EmailSenderAddress);
            writer.WriteStringValue("emailSenderName", EmailSenderName);
            writer.WriteStringValue("emailSourceDomain", EmailSourceDomain);
            writer.WriteStringValue("emailSourceIpAddress", EmailSourceIpAddress);
            writer.WriteStringValue("emailSubject", EmailSubject);
            writer.WriteStringValue("emailXMailer", EmailXMailer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteDateTimeOffsetValue("fileCompileDateTime", FileCompileDateTime);
            writer.WriteDateTimeOffsetValue("fileCreatedDateTime", FileCreatedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.FileHashType>("fileHashType", FileHashType);
            writer.WriteStringValue("fileHashValue", FileHashValue);
            writer.WriteStringValue("fileMutexName", FileMutexName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("filePacker", FilePacker);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteLongValue("fileSize", FileSize);
            writer.WriteStringValue("fileType", FileType);
            writer.WriteDateTimeOffsetValue("ingestedDateTime", IngestedDateTime);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteCollectionOfPrimitiveValues<string>("killChain", KillChain);
            writer.WriteStringValue("knownFalsePositives", KnownFalsePositives);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("malwareFamilyNames", MalwareFamilyNames);
            writer.WriteStringValue("networkCidrBlock", NetworkCidrBlock);
            writer.WriteLongValue("networkDestinationAsn", NetworkDestinationAsn);
            writer.WriteStringValue("networkDestinationCidrBlock", NetworkDestinationCidrBlock);
            writer.WriteStringValue("networkDestinationIPv4", NetworkDestinationIPv4);
            writer.WriteStringValue("networkDestinationIPv6", NetworkDestinationIPv6);
            writer.WriteIntValue("networkDestinationPort", NetworkDestinationPort);
            writer.WriteStringValue("networkIPv4", NetworkIPv4);
            writer.WriteStringValue("networkIPv6", NetworkIPv6);
            writer.WriteIntValue("networkPort", NetworkPort);
            writer.WriteIntValue("networkProtocol", NetworkProtocol);
            writer.WriteLongValue("networkSourceAsn", NetworkSourceAsn);
            writer.WriteStringValue("networkSourceCidrBlock", NetworkSourceCidrBlock);
            writer.WriteStringValue("networkSourceIPv4", NetworkSourceIPv4);
            writer.WriteStringValue("networkSourceIPv6", NetworkSourceIPv6);
            writer.WriteIntValue("networkSourcePort", NetworkSourcePort);
            writer.WriteBoolValue("passiveOnly", PassiveOnly);
            writer.WriteIntValue("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("targetProduct", TargetProduct);
            writer.WriteStringValue("threatType", ThreatType);
            writer.WriteEnumValue<global::ApiSdk.Models.TlpLevel>("tlpLevel", TlpLevel);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("userAgent", UserAgent);
        }
    }
}
#pragma warning restore CS0618
