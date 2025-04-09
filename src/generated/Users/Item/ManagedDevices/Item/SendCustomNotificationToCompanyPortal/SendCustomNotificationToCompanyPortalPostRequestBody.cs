// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Users.Item.ManagedDevices.Item.SendCustomNotificationToCompanyPortal
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SendCustomNotificationToCompanyPortalPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The notificationBody property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationBody { get; set; }
#nullable restore
#else
        public string NotificationBody { get; set; }
#endif
        /// <summary>The notificationTitle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationTitle { get; set; }
#nullable restore
#else
        public string NotificationTitle { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.ManagedDevices.Item.SendCustomNotificationToCompanyPortal.SendCustomNotificationToCompanyPortalPostRequestBody"/> and sets the default values.
        /// </summary>
        public SendCustomNotificationToCompanyPortalPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Users.Item.ManagedDevices.Item.SendCustomNotificationToCompanyPortal.SendCustomNotificationToCompanyPortalPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Users.Item.ManagedDevices.Item.SendCustomNotificationToCompanyPortal.SendCustomNotificationToCompanyPortalPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Users.Item.ManagedDevices.Item.SendCustomNotificationToCompanyPortal.SendCustomNotificationToCompanyPortalPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "notificationBody", n => { NotificationBody = n.GetStringValue(); } },
                { "notificationTitle", n => { NotificationTitle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("notificationBody", NotificationBody);
            writer.WriteStringValue("notificationTitle", NotificationTitle);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
