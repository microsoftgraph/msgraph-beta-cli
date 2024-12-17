// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Device operating system summary.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceOperatingSystemSummary : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count of Corporate work profile Android devices. Also known as Corporate Owned Personally Enabled (COPE). Valid values -1 to 2147483647</summary>
        public int? AndroidCorporateWorkProfileCount { get; set; }
        /// <summary>Number of android device count.</summary>
        public int? AndroidCount { get; set; }
        /// <summary>Number of dedicated Android devices.</summary>
        public int? AndroidDedicatedCount { get; set; }
        /// <summary>Number of device admin Android devices.</summary>
        public int? AndroidDeviceAdminCount { get; set; }
        /// <summary>Number of fully managed Android devices.</summary>
        public int? AndroidFullyManagedCount { get; set; }
        /// <summary>Number of work profile Android devices.</summary>
        public int? AndroidWorkProfileCount { get; set; }
        /// <summary>Number of AOSP user-associated Android devices. Valid values 0 to 2147483647</summary>
        public int? AospUserAssociatedCount { get; set; }
        /// <summary>Number of AOSP userless Android devices. Valid values 0 to 2147483647</summary>
        public int? AospUserlessCount { get; set; }
        /// <summary>Number of Chrome OS devices. Valid values 0 to 2147483647</summary>
        public int? ChromeOSCount { get; set; }
        /// <summary>Number of ConfigMgr managed devices.</summary>
        public int? ConfigMgrDeviceCount { get; set; }
        /// <summary>Number of iOS device count.</summary>
        public int? IosCount { get; set; }
        /// <summary>Number of Linux OS devices. Valid values 0 to 2147483647</summary>
        public int? LinuxCount { get; set; }
        /// <summary>Number of Mac OS X device count.</summary>
        public int? MacOSCount { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Number of unknown device count.</summary>
        public int? UnknownCount { get; set; }
        /// <summary>Number of Windows device count.</summary>
        public int? WindowsCount { get; set; }
        /// <summary>Number of Windows mobile device count.</summary>
        public int? WindowsMobileCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DeviceOperatingSystemSummary"/> and sets the default values.
        /// </summary>
        public DeviceOperatingSystemSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DeviceOperatingSystemSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.DeviceOperatingSystemSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DeviceOperatingSystemSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "androidCorporateWorkProfileCount", n => { AndroidCorporateWorkProfileCount = n.GetIntValue(); } },
                { "androidCount", n => { AndroidCount = n.GetIntValue(); } },
                { "androidDedicatedCount", n => { AndroidDedicatedCount = n.GetIntValue(); } },
                { "androidDeviceAdminCount", n => { AndroidDeviceAdminCount = n.GetIntValue(); } },
                { "androidFullyManagedCount", n => { AndroidFullyManagedCount = n.GetIntValue(); } },
                { "androidWorkProfileCount", n => { AndroidWorkProfileCount = n.GetIntValue(); } },
                { "aospUserAssociatedCount", n => { AospUserAssociatedCount = n.GetIntValue(); } },
                { "aospUserlessCount", n => { AospUserlessCount = n.GetIntValue(); } },
                { "chromeOSCount", n => { ChromeOSCount = n.GetIntValue(); } },
                { "configMgrDeviceCount", n => { ConfigMgrDeviceCount = n.GetIntValue(); } },
                { "iosCount", n => { IosCount = n.GetIntValue(); } },
                { "linuxCount", n => { LinuxCount = n.GetIntValue(); } },
                { "macOSCount", n => { MacOSCount = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "unknownCount", n => { UnknownCount = n.GetIntValue(); } },
                { "windowsCount", n => { WindowsCount = n.GetIntValue(); } },
                { "windowsMobileCount", n => { WindowsMobileCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("androidCorporateWorkProfileCount", AndroidCorporateWorkProfileCount);
            writer.WriteIntValue("androidCount", AndroidCount);
            writer.WriteIntValue("androidDedicatedCount", AndroidDedicatedCount);
            writer.WriteIntValue("androidDeviceAdminCount", AndroidDeviceAdminCount);
            writer.WriteIntValue("androidFullyManagedCount", AndroidFullyManagedCount);
            writer.WriteIntValue("androidWorkProfileCount", AndroidWorkProfileCount);
            writer.WriteIntValue("aospUserAssociatedCount", AospUserAssociatedCount);
            writer.WriteIntValue("aospUserlessCount", AospUserlessCount);
            writer.WriteIntValue("chromeOSCount", ChromeOSCount);
            writer.WriteIntValue("configMgrDeviceCount", ConfigMgrDeviceCount);
            writer.WriteIntValue("iosCount", IosCount);
            writer.WriteIntValue("linuxCount", LinuxCount);
            writer.WriteIntValue("macOSCount", MacOSCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("unknownCount", UnknownCount);
            writer.WriteIntValue("windowsCount", WindowsCount);
            writer.WriteIntValue("windowsMobileCount", WindowsMobileCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
