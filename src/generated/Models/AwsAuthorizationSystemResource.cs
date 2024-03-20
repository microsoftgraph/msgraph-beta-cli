// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AwsAuthorizationSystemResource : AuthorizationSystemResource, IParsable 
    {
        /// <summary>The service associated with the resource in an AWS authorization system. This is auto-expanded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemTypeService? Service { get; set; }
#nullable restore
#else
        public AuthorizationSystemTypeService Service { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AwsAuthorizationSystemResource"/> and sets the default values.
        /// </summary>
        public AwsAuthorizationSystemResource() : base()
        {
            OdataType = "#microsoft.graph.awsAuthorizationSystemResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AwsAuthorizationSystemResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AwsAuthorizationSystemResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AwsAuthorizationSystemResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"service", n => { Service = n.GetObjectValue<AuthorizationSystemTypeService>(AuthorizationSystemTypeService.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<AuthorizationSystemTypeService>("service", Service);
        }
    }
}