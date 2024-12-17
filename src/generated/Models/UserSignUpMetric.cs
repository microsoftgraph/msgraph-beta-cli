// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UserSignUpMetric : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The appId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>The browser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Browser { get; set; }
#nullable restore
#else
        public string Browser { get; set; }
#endif
        /// <summary>The total number of users who signed up in the specified period. Supports $filter (eq).</summary>
        public long? Count { get; set; }
        /// <summary>The country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The date of the user insight.</summary>
        public Date? FactDate { get; set; }
        /// <summary>The identityProvider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProvider { get; set; }
#nullable restore
#else
        public string IdentityProvider { get; set; }
#endif
        /// <summary>The language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The device plaform that the customers used. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Os { get; set; }
#nullable restore
#else
        public string Os { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UserSignUpMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UserSignUpMetric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.UserSignUpMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "browser", n => { Browser = n.GetStringValue(); } },
                { "count", n => { Count = n.GetLongValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "factDate", n => { FactDate = n.GetDateValue(); } },
                { "identityProvider", n => { IdentityProvider = n.GetStringValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "os", n => { Os = n.GetStringValue(); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("browser", Browser);
            writer.WriteLongValue("count", Count);
            writer.WriteStringValue("country", Country);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteStringValue("identityProvider", IdentityProvider);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("os", Os);
        }
    }
}
#pragma warning restore CS0618
