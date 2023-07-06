using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Indicates the publishing state of an app.</summary>
    public enum MobileAppPublishingState {
        /// <summary>The app is not yet published.</summary>
        [EnumMember(Value = "notPublished")]
        NotPublished,
        /// <summary>The app is pending service-side processing.</summary>
        [EnumMember(Value = "processing")]
        Processing,
        /// <summary>The app is published.</summary>
        [EnumMember(Value = "published")]
        Published,
    }
}