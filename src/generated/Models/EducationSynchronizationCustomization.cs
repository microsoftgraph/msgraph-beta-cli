// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class EducationSynchronizationCustomization : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the display name of the resource can be overwritten by the sync.</summary>
        public bool? AllowDisplayNameUpdate { get; set; }
        /// <summary>Indicates whether synchronization of the parent entity is deferred to a later date.</summary>
        public bool? IsSyncDeferred { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The collection of property names to sync. If set to null, all properties will be synchronized. Does not apply to Student Enrollments or Teacher Rosters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OptionalPropertiesToSync { get; set; }
#nullable restore
#else
        public List<string> OptionalPropertiesToSync { get; set; }
#endif
        /// <summary>The date that the synchronization should start. This value should be set to a future date. If set to null, the resource will be synchronized when the profile setup completes. Only applies to Student Enrollments</summary>
        public DateTimeOffset? SynchronizationStartDate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="EducationSynchronizationCustomization"/> and sets the default values.
        /// </summary>
        public EducationSynchronizationCustomization()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationSynchronizationCustomization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EducationSynchronizationCustomization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationCustomization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allowDisplayNameUpdate", n => { AllowDisplayNameUpdate = n.GetBoolValue(); } },
                {"isSyncDeferred", n => { IsSyncDeferred = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"optionalPropertiesToSync", n => { OptionalPropertiesToSync = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"synchronizationStartDate", n => { SynchronizationStartDate = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowDisplayNameUpdate", AllowDisplayNameUpdate);
            writer.WriteBoolValue("isSyncDeferred", IsSyncDeferred);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("optionalPropertiesToSync", OptionalPropertiesToSync);
            writer.WriteDateTimeOffsetValue("synchronizationStartDate", SynchronizationStartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}