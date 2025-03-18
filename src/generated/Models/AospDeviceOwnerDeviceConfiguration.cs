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
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the AndroidDeviceOwnerAOSPDeviceConfiguration resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AospDeviceOwnerDeviceConfiguration : global::ApiSdk.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Indicates whether or not the user is allowed to enable unknown sources setting. When set to true, user is not allowed to enable unknown sources settings.</summary>
        public bool? AppsBlockInstallFromUnknownSources { get; set; }
        /// <summary>Indicates whether or not to block a user from configuring bluetooth.</summary>
        public bool? BluetoothBlockConfiguration { get; set; }
        /// <summary>Indicates whether or not to disable the use of bluetooth. When set to true, bluetooth cannot be enabled on the device.</summary>
        public bool? BluetoothBlocked { get; set; }
        /// <summary>Indicates whether or not to disable the use of the camera.</summary>
        public bool? CameraBlocked { get; set; }
        /// <summary>Indicates whether or not the factory reset option in settings is disabled.</summary>
        public bool? FactoryResetBlocked { get; set; }
        /// <summary>Indicates the minimum length of the password required on the device. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
        /// <summary>Indicates the minimum password quality required on the device. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public global::ApiSdk.Models.AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType { get; set; }
        /// <summary>Indicates the number of times a user can enter an incorrect password before the device is wiped. Valid values 4 to 11</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
        /// <summary>Indicates whether or not to disable the capability to take screenshots.</summary>
        public bool? ScreenCaptureBlocked { get; set; }
        /// <summary>Indicates whether or not to block the user from enabling debugging features on the device.</summary>
        public bool? SecurityAllowDebuggingFeatures { get; set; }
        /// <summary>Indicates whether or not to block external media.</summary>
        public bool? StorageBlockExternalMedia { get; set; }
        /// <summary>Indicates whether or not to block USB file transfer.</summary>
        public bool? StorageBlockUsbFileTransfer { get; set; }
        /// <summary>Indicates whether or not to block the user from editing the wifi connection settings.</summary>
        public bool? WifiBlockEditConfigurations { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AospDeviceOwnerDeviceConfiguration"/> and sets the default values.
        /// </summary>
        public AospDeviceOwnerDeviceConfiguration() : base()
        {
            OdataType = "#microsoft.graph.aospDeviceOwnerDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AospDeviceOwnerDeviceConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AospDeviceOwnerDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AospDeviceOwnerDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appsBlockInstallFromUnknownSources", n => { AppsBlockInstallFromUnknownSources = n.GetBoolValue(); } },
                { "bluetoothBlockConfiguration", n => { BluetoothBlockConfiguration = n.GetBoolValue(); } },
                { "bluetoothBlocked", n => { BluetoothBlocked = n.GetBoolValue(); } },
                { "cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                { "factoryResetBlocked", n => { FactoryResetBlocked = n.GetBoolValue(); } },
                { "passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                { "passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                { "passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<global::ApiSdk.Models.AndroidDeviceOwnerRequiredPasswordType>(); } },
                { "passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                { "screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                { "securityAllowDebuggingFeatures", n => { SecurityAllowDebuggingFeatures = n.GetBoolValue(); } },
                { "storageBlockExternalMedia", n => { StorageBlockExternalMedia = n.GetBoolValue(); } },
                { "storageBlockUsbFileTransfer", n => { StorageBlockUsbFileTransfer = n.GetBoolValue(); } },
                { "wifiBlockEditConfigurations", n => { WifiBlockEditConfigurations = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("appsBlockInstallFromUnknownSources", AppsBlockInstallFromUnknownSources);
            writer.WriteBoolValue("bluetoothBlockConfiguration", BluetoothBlockConfiguration);
            writer.WriteBoolValue("bluetoothBlocked", BluetoothBlocked);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("factoryResetBlocked", FactoryResetBlocked);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteEnumValue<global::ApiSdk.Models.AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("securityAllowDebuggingFeatures", SecurityAllowDebuggingFeatures);
            writer.WriteBoolValue("storageBlockExternalMedia", StorageBlockExternalMedia);
            writer.WriteBoolValue("storageBlockUsbFileTransfer", StorageBlockUsbFileTransfer);
            writer.WriteBoolValue("wifiBlockEditConfigurations", WifiBlockEditConfigurations);
        }
    }
}
#pragma warning restore CS0618
