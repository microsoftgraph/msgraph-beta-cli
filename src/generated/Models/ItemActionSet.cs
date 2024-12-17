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
    public partial class ItemActionSet : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A comment was added to the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CommentAction? Comment { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CommentAction Comment { get; set; }
#endif
        /// <summary>An item was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CreateAction? Create { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CreateAction Create { get; set; }
#endif
        /// <summary>An item was deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeleteAction? Delete { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeleteAction Delete { get; set; }
#endif
        /// <summary>An item was edited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EditAction? Edit { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EditAction Edit { get; set; }
#endif
        /// <summary>A user was mentioned in the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MentionAction? Mention { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MentionAction Mention { get; set; }
#endif
        /// <summary>An item was moved.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MoveAction? Move { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MoveAction Move { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>An item was renamed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RenameAction? Rename { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RenameAction Rename { get; set; }
#endif
        /// <summary>An item was restored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RestoreAction? Restore { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RestoreAction Restore { get; set; }
#endif
        /// <summary>An item was shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ShareAction? Share { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ShareAction Share { get; set; }
#endif
        /// <summary>An item was versioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.VersionAction? Version { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.VersionAction Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ItemActionSet"/> and sets the default values.
        /// </summary>
        public ItemActionSet()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ItemActionSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ItemActionSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ItemActionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "comment", n => { Comment = n.GetObjectValue<global::ApiSdk.Models.CommentAction>(global::ApiSdk.Models.CommentAction.CreateFromDiscriminatorValue); } },
                { "create", n => { Create = n.GetObjectValue<global::ApiSdk.Models.CreateAction>(global::ApiSdk.Models.CreateAction.CreateFromDiscriminatorValue); } },
                { "delete", n => { Delete = n.GetObjectValue<global::ApiSdk.Models.DeleteAction>(global::ApiSdk.Models.DeleteAction.CreateFromDiscriminatorValue); } },
                { "edit", n => { Edit = n.GetObjectValue<global::ApiSdk.Models.EditAction>(global::ApiSdk.Models.EditAction.CreateFromDiscriminatorValue); } },
                { "mention", n => { Mention = n.GetObjectValue<global::ApiSdk.Models.MentionAction>(global::ApiSdk.Models.MentionAction.CreateFromDiscriminatorValue); } },
                { "move", n => { Move = n.GetObjectValue<global::ApiSdk.Models.MoveAction>(global::ApiSdk.Models.MoveAction.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "rename", n => { Rename = n.GetObjectValue<global::ApiSdk.Models.RenameAction>(global::ApiSdk.Models.RenameAction.CreateFromDiscriminatorValue); } },
                { "restore", n => { Restore = n.GetObjectValue<global::ApiSdk.Models.RestoreAction>(global::ApiSdk.Models.RestoreAction.CreateFromDiscriminatorValue); } },
                { "share", n => { Share = n.GetObjectValue<global::ApiSdk.Models.ShareAction>(global::ApiSdk.Models.ShareAction.CreateFromDiscriminatorValue); } },
                { "version", n => { Version = n.GetObjectValue<global::ApiSdk.Models.VersionAction>(global::ApiSdk.Models.VersionAction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.CommentAction>("comment", Comment);
            writer.WriteObjectValue<global::ApiSdk.Models.CreateAction>("create", Create);
            writer.WriteObjectValue<global::ApiSdk.Models.DeleteAction>("delete", Delete);
            writer.WriteObjectValue<global::ApiSdk.Models.EditAction>("edit", Edit);
            writer.WriteObjectValue<global::ApiSdk.Models.MentionAction>("mention", Mention);
            writer.WriteObjectValue<global::ApiSdk.Models.MoveAction>("move", Move);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::ApiSdk.Models.RenameAction>("rename", Rename);
            writer.WriteObjectValue<global::ApiSdk.Models.RestoreAction>("restore", Restore);
            writer.WriteObjectValue<global::ApiSdk.Models.ShareAction>("share", Share);
            writer.WriteObjectValue<global::ApiSdk.Models.VersionAction>("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
