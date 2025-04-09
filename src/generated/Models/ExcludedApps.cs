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
    /// Contains properties for Excluded Office365 Apps.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ExcludedApps : IAdditionalDataHolder, IParsable
    {
        /// <summary>The value for if MS Office Access should be excluded or not.</summary>
        public bool? Access { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value for if Microsoft Search as default should be excluded or not.</summary>
        public bool? Bing { get; set; }
        /// <summary>The value for if MS Office Excel should be excluded or not.</summary>
        public bool? Excel { get; set; }
        /// <summary>The value for if MS Office OneDrive for Business - Groove should be excluded or not.</summary>
        public bool? Groove { get; set; }
        /// <summary>The value for if MS Office InfoPath should be excluded or not.</summary>
        public bool? InfoPath { get; set; }
        /// <summary>The value for if MS Office Skype for Business - Lync should be excluded or not.</summary>
        public bool? Lync { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The value for if MS Office OneDrive should be excluded or not.</summary>
        public bool? OneDrive { get; set; }
        /// <summary>The value for if MS Office OneNote should be excluded or not.</summary>
        public bool? OneNote { get; set; }
        /// <summary>The value for if MS Office Outlook should be excluded or not.</summary>
        public bool? Outlook { get; set; }
        /// <summary>The value for if MS Office PowerPoint should be excluded or not.</summary>
        public bool? PowerPoint { get; set; }
        /// <summary>The value for if MS Office Publisher should be excluded or not.</summary>
        public bool? Publisher { get; set; }
        /// <summary>The value for if MS Office SharePointDesigner should be excluded or not.</summary>
        public bool? SharePointDesigner { get; set; }
        /// <summary>The value for if MS Office Teams should be excluded or not.</summary>
        public bool? Teams { get; set; }
        /// <summary>The value for if MS Office Visio should be excluded or not.</summary>
        public bool? Visio { get; set; }
        /// <summary>The value for if MS Office Word should be excluded or not.</summary>
        public bool? Word { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ExcludedApps"/> and sets the default values.
        /// </summary>
        public ExcludedApps()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ExcludedApps"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ExcludedApps CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ExcludedApps();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "access", n => { Access = n.GetBoolValue(); } },
                { "bing", n => { Bing = n.GetBoolValue(); } },
                { "excel", n => { Excel = n.GetBoolValue(); } },
                { "groove", n => { Groove = n.GetBoolValue(); } },
                { "infoPath", n => { InfoPath = n.GetBoolValue(); } },
                { "lync", n => { Lync = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "oneDrive", n => { OneDrive = n.GetBoolValue(); } },
                { "oneNote", n => { OneNote = n.GetBoolValue(); } },
                { "outlook", n => { Outlook = n.GetBoolValue(); } },
                { "powerPoint", n => { PowerPoint = n.GetBoolValue(); } },
                { "publisher", n => { Publisher = n.GetBoolValue(); } },
                { "sharePointDesigner", n => { SharePointDesigner = n.GetBoolValue(); } },
                { "teams", n => { Teams = n.GetBoolValue(); } },
                { "visio", n => { Visio = n.GetBoolValue(); } },
                { "word", n => { Word = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("access", Access);
            writer.WriteBoolValue("bing", Bing);
            writer.WriteBoolValue("excel", Excel);
            writer.WriteBoolValue("groove", Groove);
            writer.WriteBoolValue("infoPath", InfoPath);
            writer.WriteBoolValue("lync", Lync);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("oneDrive", OneDrive);
            writer.WriteBoolValue("oneNote", OneNote);
            writer.WriteBoolValue("outlook", Outlook);
            writer.WriteBoolValue("powerPoint", PowerPoint);
            writer.WriteBoolValue("publisher", Publisher);
            writer.WriteBoolValue("sharePointDesigner", SharePointDesigner);
            writer.WriteBoolValue("teams", Teams);
            writer.WriteBoolValue("visio", Visio);
            writer.WriteBoolValue("word", Word);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
