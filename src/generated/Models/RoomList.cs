// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class RoomList : Place, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The email address of the room list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>The rooms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Room>? Rooms { get; set; }
#nullable restore
#else
        public List<Room> Rooms { get; set; }
#endif
        /// <summary>The workspaces property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Workspace>? Workspaces { get; set; }
#nullable restore
#else
        public List<Workspace> Workspaces { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RoomList"/> and sets the default values.
        /// </summary>
        public RoomList() : base()
        {
            OdataType = "#microsoft.graph.roomList";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RoomList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RoomList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoomList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                { "rooms", n => { Rooms = n.GetCollectionOfObjectValues<Room>(Room.CreateFromDiscriminatorValue)?.ToList(); } },
                { "workspaces", n => { Workspaces = n.GetCollectionOfObjectValues<Workspace>(Workspace.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteCollectionOfObjectValues<Room>("rooms", Rooms);
            writer.WriteCollectionOfObjectValues<Workspace>("workspaces", Workspaces);
        }
    }
}
