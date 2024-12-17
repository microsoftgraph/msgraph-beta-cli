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
    public partial class MailFolder : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The number of immediate child mailFolders in the current mailFolder.</summary>
        public int? ChildFolderCount { get; set; }
        /// <summary>The collection of child folders in the mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MailFolder>? ChildFolders { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MailFolder> ChildFolders { get; set; }
#endif
        /// <summary>The mailFolder&apos;s display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicates whether the mailFolder is hidden. This property can be set only when creating the folder. Find more information in Hidden mail folders.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>The collection of rules that apply to the user&apos;s Inbox folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MessageRule>? MessageRules { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MessageRule> MessageRules { get; set; }
#endif
        /// <summary>The collection of messages in the mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Message>? Messages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Message> Messages { get; set; }
#endif
        /// <summary>The collection of multi-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MailFolderOperation>? Operations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MailFolderOperation> Operations { get; set; }
#endif
        /// <summary>The unique identifier for the mailFolder&apos;s parent mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId { get; set; }
#nullable restore
#else
        public string ParentFolderId { get; set; }
#endif
        /// <summary>The collection of single-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
#endif
        /// <summary>The number of items in the mailFolder.</summary>
        public int? TotalItemCount { get; set; }
        /// <summary>The number of items in the mailFolder marked as unread.</summary>
        public int? UnreadItemCount { get; set; }
        /// <summary>The userConfigurations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UserConfiguration>? UserConfigurations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UserConfiguration> UserConfigurations { get; set; }
#endif
        /// <summary>The well-known folder name for the folder. The possible values are listed above. This property is only set for default folders created by Outlook. For other folders, this property is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WellKnownName { get; set; }
#nullable restore
#else
        public string WellKnownName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.MailFolder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.MailFolder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.mailSearchFolder" => new global::ApiSdk.Models.MailSearchFolder(),
                _ => new global::ApiSdk.Models.MailFolder(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "childFolderCount", n => { ChildFolderCount = n.GetIntValue(); } },
                { "childFolders", n => { ChildFolders = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MailFolder>(global::ApiSdk.Models.MailFolder.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isHidden", n => { IsHidden = n.GetBoolValue(); } },
                { "messageRules", n => { MessageRules = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MessageRule>(global::ApiSdk.Models.MessageRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Message>(global::ApiSdk.Models.Message.CreateFromDiscriminatorValue)?.AsList(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>(global::ApiSdk.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MailFolderOperation>(global::ApiSdk.Models.MailFolderOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>(global::ApiSdk.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "totalItemCount", n => { TotalItemCount = n.GetIntValue(); } },
                { "unreadItemCount", n => { UnreadItemCount = n.GetIntValue(); } },
                { "userConfigurations", n => { UserConfigurations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UserConfiguration>(global::ApiSdk.Models.UserConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "wellKnownName", n => { WellKnownName = n.GetStringValue(); } },
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
            writer.WriteIntValue("childFolderCount", ChildFolderCount);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MailFolder>("childFolders", ChildFolders);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MessageRule>("messageRules", MessageRules);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Message>("messages", Messages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MailFolderOperation>("operations", Operations);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteIntValue("totalItemCount", TotalItemCount);
            writer.WriteIntValue("unreadItemCount", UnreadItemCount);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UserConfiguration>("userConfigurations", UserConfigurations);
            writer.WriteStringValue("wellKnownName", WellKnownName);
        }
    }
}
#pragma warning restore CS0618
