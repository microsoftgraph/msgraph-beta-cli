// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Users.Item.ManagedDevices.Item.Wipe
{
    #pragma warning disable CS1591
    public class WipePostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The keepEnrollmentData property</summary>
        public bool? KeepEnrollmentData { get; set; }
        /// <summary>The keepUserData property</summary>
        public bool? KeepUserData { get; set; }
        /// <summary>The macOsUnlockCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacOsUnlockCode { get; set; }
#nullable restore
#else
        public string MacOsUnlockCode { get; set; }
#endif
        /// <summary>The obliterationBehavior property</summary>
        public ApiSdk.Models.ObliterationBehavior? ObliterationBehavior { get; set; }
        /// <summary>The persistEsimDataPlan property</summary>
        public bool? PersistEsimDataPlan { get; set; }
        /// <summary>The useProtectedWipe property</summary>
        public bool? UseProtectedWipe { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WipePostRequestBody"/> and sets the default values.
        /// </summary>
        public WipePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WipePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WipePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WipePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "keepEnrollmentData", n => { KeepEnrollmentData = n.GetBoolValue(); } },
                { "keepUserData", n => { KeepUserData = n.GetBoolValue(); } },
                { "macOsUnlockCode", n => { MacOsUnlockCode = n.GetStringValue(); } },
                { "obliterationBehavior", n => { ObliterationBehavior = n.GetEnumValue<ObliterationBehavior>(); } },
                { "persistEsimDataPlan", n => { PersistEsimDataPlan = n.GetBoolValue(); } },
                { "useProtectedWipe", n => { UseProtectedWipe = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("keepEnrollmentData", KeepEnrollmentData);
            writer.WriteBoolValue("keepUserData", KeepUserData);
            writer.WriteStringValue("macOsUnlockCode", MacOsUnlockCode);
            writer.WriteEnumValue<ObliterationBehavior>("obliterationBehavior", ObliterationBehavior);
            writer.WriteBoolValue("persistEsimDataPlan", PersistEsimDataPlan);
            writer.WriteBoolValue("useProtectedWipe", UseProtectedWipe);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
