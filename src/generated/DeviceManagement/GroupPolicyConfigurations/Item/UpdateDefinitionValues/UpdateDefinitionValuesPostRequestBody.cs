// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UpdateDefinitionValuesPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The added property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.GroupPolicyDefinitionValue>? Added { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.GroupPolicyDefinitionValue> Added { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deletedIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DeletedIds { get; set; }
#nullable restore
#else
        public List<string> DeletedIds { get; set; }
#endif
        /// <summary>The updated property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.GroupPolicyDefinitionValue>? Updated { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.GroupPolicyDefinitionValue> Updated { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues.UpdateDefinitionValuesPostRequestBody"/> and sets the default values.
        /// </summary>
        public UpdateDefinitionValuesPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues.UpdateDefinitionValuesPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues.UpdateDefinitionValuesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues.UpdateDefinitionValuesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "added", n => { Added = n.GetCollectionOfObjectValues<global::ApiSdk.Models.GroupPolicyDefinitionValue>(global::ApiSdk.Models.GroupPolicyDefinitionValue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deletedIds", n => { DeletedIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "updated", n => { Updated = n.GetCollectionOfObjectValues<global::ApiSdk.Models.GroupPolicyDefinitionValue>(global::ApiSdk.Models.GroupPolicyDefinitionValue.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.GroupPolicyDefinitionValue>("added", Added);
            writer.WriteCollectionOfPrimitiveValues<string>("deletedIds", DeletedIds);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.GroupPolicyDefinitionValue>("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
