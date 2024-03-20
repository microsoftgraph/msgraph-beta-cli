// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Describes the status for a single FOTA deployment.
    /// </summary>
    public class ZebraFotaDeploymentStatus : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A boolean that indicates if a cancellation was requested on the deployment. NOTE: A cancellation request does not guarantee that the deployment was canceled.</summary>
        public bool? CancelRequested { get; set; }
        /// <summary>The date and time when this deployment was completed or canceled. The actual date time is determined by the value of state. If the state is canceled, this property holds the cancellation date/time. If the the state is completed, this property holds the completion date/time. If the deployment is not completed before the deployment end date, then completed date/time and end date/time are the same. This is always in the deployment timezone. Note: An installation that is in progress can continue past the deployment end date.</summary>
        public DateTimeOffset? CompleteOrCanceledDateTime { get; set; }
        /// <summary>An error code indicating the failure reason, when the deployment state is createFailed. Possible values: See zebraFotaErrorCode enum.</summary>
        public ZebraFotaErrorCode? ErrorCode { get; set; }
        /// <summary>Date and time when the deployment status was updated from Zebra</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Represents the state of Zebra FOTA deployment.</summary>
        public ZebraFotaDeploymentState? State { get; set; }
        /// <summary>An integer that indicates the total number of devices where installation was successful.</summary>
        public int? TotalAwaitingInstall { get; set; }
        /// <summary>An integer that indicates the total number of devices where installation was canceled.</summary>
        public int? TotalCanceled { get; set; }
        /// <summary>An integer that indicates the total number of devices that have a job in the CREATED state. Typically indicates jobs that did not reach the devices.</summary>
        public int? TotalCreated { get; set; }
        /// <summary>An integer that indicates the total number of devices in the deployment.</summary>
        public int? TotalDevices { get; set; }
        /// <summary>An integer that indicates the total number of devices where installation was successful.</summary>
        public int? TotalDownloading { get; set; }
        /// <summary>An integer that indicates the total number of devices that have failed to download the new OS file.</summary>
        public int? TotalFailedDownload { get; set; }
        /// <summary>An integer that indicates the total number of devices that have failed to install the new OS file.</summary>
        public int? TotalFailedInstall { get; set; }
        /// <summary>An integer that indicates the total number of devices that received the json and are scheduled.</summary>
        public int? TotalScheduled { get; set; }
        /// <summary>An integer that indicates the total number of devices where installation was successful.</summary>
        public int? TotalSucceededInstall { get; set; }
        /// <summary>An integer that indicates the total number of devices where no deployment status or end state has not received, even after the scheduled end date was reached.</summary>
        public int? TotalUnknown { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ZebraFotaDeploymentStatus"/> and sets the default values.
        /// </summary>
        public ZebraFotaDeploymentStatus()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ZebraFotaDeploymentStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ZebraFotaDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZebraFotaDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"cancelRequested", n => { CancelRequested = n.GetBoolValue(); } },
                {"completeOrCanceledDateTime", n => { CompleteOrCanceledDateTime = n.GetDateTimeOffsetValue(); } },
                {"errorCode", n => { ErrorCode = n.GetEnumValue<ZebraFotaErrorCode>(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<ZebraFotaDeploymentState>(); } },
                {"totalAwaitingInstall", n => { TotalAwaitingInstall = n.GetIntValue(); } },
                {"totalCanceled", n => { TotalCanceled = n.GetIntValue(); } },
                {"totalCreated", n => { TotalCreated = n.GetIntValue(); } },
                {"totalDevices", n => { TotalDevices = n.GetIntValue(); } },
                {"totalDownloading", n => { TotalDownloading = n.GetIntValue(); } },
                {"totalFailedDownload", n => { TotalFailedDownload = n.GetIntValue(); } },
                {"totalFailedInstall", n => { TotalFailedInstall = n.GetIntValue(); } },
                {"totalScheduled", n => { TotalScheduled = n.GetIntValue(); } },
                {"totalSucceededInstall", n => { TotalSucceededInstall = n.GetIntValue(); } },
                {"totalUnknown", n => { TotalUnknown = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("cancelRequested", CancelRequested);
            writer.WriteDateTimeOffsetValue("completeOrCanceledDateTime", CompleteOrCanceledDateTime);
            writer.WriteEnumValue<ZebraFotaErrorCode>("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ZebraFotaDeploymentState>("state", State);
            writer.WriteIntValue("totalAwaitingInstall", TotalAwaitingInstall);
            writer.WriteIntValue("totalCanceled", TotalCanceled);
            writer.WriteIntValue("totalCreated", TotalCreated);
            writer.WriteIntValue("totalDevices", TotalDevices);
            writer.WriteIntValue("totalDownloading", TotalDownloading);
            writer.WriteIntValue("totalFailedDownload", TotalFailedDownload);
            writer.WriteIntValue("totalFailedInstall", TotalFailedInstall);
            writer.WriteIntValue("totalScheduled", TotalScheduled);
            writer.WriteIntValue("totalSucceededInstall", TotalSucceededInstall);
            writer.WriteIntValue("totalUnknown", TotalUnknown);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}