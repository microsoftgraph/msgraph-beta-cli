// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AwsIdentityAccessManagementKeyAgeFinding : global::ApiSdk.Models.Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AwsAccessKey? AccessKey { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AwsAccessKey AccessKey { get; set; }
#endif
        /// <summary>The actionSummary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ActionSummary? ActionSummary { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ActionSummary ActionSummary { get; set; }
#endif
        /// <summary>The awsAccessKeyDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AwsAccessKeyDetails? AwsAccessKeyDetails { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AwsAccessKeyDetails AwsAccessKeyDetails { get; set; }
#endif
        /// <summary>The permissionsCreepIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PermissionsCreepIndex? PermissionsCreepIndex { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PermissionsCreepIndex PermissionsCreepIndex { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.IamStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AwsIdentityAccessManagementKeyAgeFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AwsIdentityAccessManagementKeyAgeFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AwsIdentityAccessManagementKeyAgeFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessKey", n => { AccessKey = n.GetObjectValue<global::ApiSdk.Models.AwsAccessKey>(global::ApiSdk.Models.AwsAccessKey.CreateFromDiscriminatorValue); } },
                { "actionSummary", n => { ActionSummary = n.GetObjectValue<global::ApiSdk.Models.ActionSummary>(global::ApiSdk.Models.ActionSummary.CreateFromDiscriminatorValue); } },
                { "awsAccessKeyDetails", n => { AwsAccessKeyDetails = n.GetObjectValue<global::ApiSdk.Models.AwsAccessKeyDetails>(global::ApiSdk.Models.AwsAccessKeyDetails.CreateFromDiscriminatorValue); } },
                { "permissionsCreepIndex", n => { PermissionsCreepIndex = n.GetObjectValue<global::ApiSdk.Models.PermissionsCreepIndex>(global::ApiSdk.Models.PermissionsCreepIndex.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.IamStatus>(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.AwsAccessKey>("accessKey", AccessKey);
            writer.WriteObjectValue<global::ApiSdk.Models.ActionSummary>("actionSummary", ActionSummary);
            writer.WriteObjectValue<global::ApiSdk.Models.AwsAccessKeyDetails>("awsAccessKeyDetails", AwsAccessKeyDetails);
            writer.WriteObjectValue<global::ApiSdk.Models.PermissionsCreepIndex>("permissionsCreepIndex", PermissionsCreepIndex);
            writer.WriteEnumValue<global::ApiSdk.Models.IamStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
