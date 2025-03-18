// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.Networkaccess;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserId
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserIdGetResponse : global::ApiSdk.Models.BaseCollectionPaginationCountResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Networkaccess.DiscoveredApplicationSegmentReport>? Value { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Networkaccess.DiscoveredApplicationSegmentReport> Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserId.GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserIdGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserId.GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserIdGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserId.GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserIdGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "value", n => { Value = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Networkaccess.DiscoveredApplicationSegmentReport>(global::ApiSdk.Models.Networkaccess.DiscoveredApplicationSegmentReport.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Networkaccess.DiscoveredApplicationSegmentReport>("value", Value);
        }
    }
}
#pragma warning restore CS0618
