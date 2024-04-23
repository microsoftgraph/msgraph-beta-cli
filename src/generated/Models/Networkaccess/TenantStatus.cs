// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess {
    public class TenantStatus : ApiSdk.Models.Entity, IParsable 
    {
        /// <summary>Reflects a message to the user if there&apos;s an error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnboardingErrorMessage { get; set; }
#nullable restore
#else
        public string OnboardingErrorMessage { get; set; }
#endif
        /// <summary>The onboardingStatus property</summary>
        public ApiSdk.Models.Networkaccess.OnboardingStatus? OnboardingStatus { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TenantStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"onboardingErrorMessage", n => { OnboardingErrorMessage = n.GetStringValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<OnboardingStatus>(); } },
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
            writer.WriteStringValue("onboardingErrorMessage", OnboardingErrorMessage);
            writer.WriteEnumValue<OnboardingStatus>("onboardingStatus", OnboardingStatus);
        }
    }
}