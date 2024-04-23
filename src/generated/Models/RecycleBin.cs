// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class RecycleBin : BaseItem, IParsable 
    {
        /// <summary>List of the recycleBinItems deleted by a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RecycleBinItem>? Items { get; set; }
#nullable restore
#else
        public List<RecycleBinItem> Items { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RecycleBin"/> and sets the default values.
        /// </summary>
        public RecycleBin() : base()
        {
            OdataType = "#microsoft.graph.recycleBin";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RecycleBin"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RecycleBin CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecycleBin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"items", n => { Items = n.GetCollectionOfObjectValues<RecycleBinItem>(RecycleBinItem.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<RecycleBinItem>("items", Items);
        }
    }
}