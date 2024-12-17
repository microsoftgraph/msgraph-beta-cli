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
    /// <summary>
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the sharedPCConfiguration resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SharedPCConfiguration : global::ApiSdk.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Specifies how accounts are managed on a shared PC. Only applies when disableAccountManager is false.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SharedPCAccountManagerPolicy? AccountManagerPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SharedPCAccountManagerPolicy AccountManagerPolicy { get; set; }
#endif
        /// <summary>Type of accounts that are allowed to share the PC.</summary>
        public global::ApiSdk.Models.SharedPCAllowedAccountType? AllowedAccounts { get; set; }
        /// <summary>Specifies whether local storage is allowed on a shared PC.</summary>
        public bool? AllowLocalStorage { get; set; }
        /// <summary>Disables the account manager for shared PC mode.</summary>
        public bool? DisableAccountManager { get; set; }
        /// <summary>Specifies whether the default shared PC education environment policies should be disabled. For Windows 10 RS2 and later, this policy will be applied without setting Enabled to true.</summary>
        public bool? DisableEduPolicies { get; set; }
        /// <summary>Specifies whether the default shared PC power policies should be disabled.</summary>
        public bool? DisablePowerPolicies { get; set; }
        /// <summary>Disables the requirement to sign in whenever the device wakes up from sleep mode.</summary>
        public bool? DisableSignInOnResume { get; set; }
        /// <summary>Enables shared PC mode and applies the shared pc policies.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? FastFirstSignIn { get; set; }
        /// <summary>Specifies the time in seconds that a device must sit idle before the PC goes to sleep. Setting this value to 0 prevents the sleep timeout from occurring.</summary>
        public int? IdleTimeBeforeSleepInSeconds { get; set; }
        /// <summary>Specifies the display text for the account shown on the sign-in screen which launches the app specified by SetKioskAppUserModelId. Only applies when KioskAppUserModelId is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskAppDisplayName { get; set; }
#nullable restore
#else
        public string KioskAppDisplayName { get; set; }
#endif
        /// <summary>Specifies the application user model ID of the app to use with assigned access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskAppUserModelId { get; set; }
#nullable restore
#else
        public string KioskAppUserModelId { get; set; }
#endif
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? LocalStorage { get; set; }
        /// <summary>Specifies the daily start time of maintenance hour.</summary>
        public Time? MaintenanceStartTime { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SetAccountManager { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SetEduPolicies { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SetPowerPolicies { get; set; }
        /// <summary>Possible values of a property</summary>
        public global::ApiSdk.Models.Enablement? SignInOnResume { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SharedPCConfiguration"/> and sets the default values.
        /// </summary>
        public SharedPCConfiguration() : base()
        {
            OdataType = "#microsoft.graph.sharedPCConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SharedPCConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.SharedPCConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.SharedPCConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountManagerPolicy", n => { AccountManagerPolicy = n.GetObjectValue<global::ApiSdk.Models.SharedPCAccountManagerPolicy>(global::ApiSdk.Models.SharedPCAccountManagerPolicy.CreateFromDiscriminatorValue); } },
                { "allowLocalStorage", n => { AllowLocalStorage = n.GetBoolValue(); } },
                { "allowedAccounts", n => { AllowedAccounts = n.GetEnumValue<global::ApiSdk.Models.SharedPCAllowedAccountType>(); } },
                { "disableAccountManager", n => { DisableAccountManager = n.GetBoolValue(); } },
                { "disableEduPolicies", n => { DisableEduPolicies = n.GetBoolValue(); } },
                { "disablePowerPolicies", n => { DisablePowerPolicies = n.GetBoolValue(); } },
                { "disableSignInOnResume", n => { DisableSignInOnResume = n.GetBoolValue(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "fastFirstSignIn", n => { FastFirstSignIn = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "idleTimeBeforeSleepInSeconds", n => { IdleTimeBeforeSleepInSeconds = n.GetIntValue(); } },
                { "kioskAppDisplayName", n => { KioskAppDisplayName = n.GetStringValue(); } },
                { "kioskAppUserModelId", n => { KioskAppUserModelId = n.GetStringValue(); } },
                { "localStorage", n => { LocalStorage = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "maintenanceStartTime", n => { MaintenanceStartTime = n.GetTimeValue(); } },
                { "setAccountManager", n => { SetAccountManager = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "setEduPolicies", n => { SetEduPolicies = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "setPowerPolicies", n => { SetPowerPolicies = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
                { "signInOnResume", n => { SignInOnResume = n.GetEnumValue<global::ApiSdk.Models.Enablement>(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.SharedPCAccountManagerPolicy>("accountManagerPolicy", AccountManagerPolicy);
            writer.WriteEnumValue<global::ApiSdk.Models.SharedPCAllowedAccountType>("allowedAccounts", AllowedAccounts);
            writer.WriteBoolValue("allowLocalStorage", AllowLocalStorage);
            writer.WriteBoolValue("disableAccountManager", DisableAccountManager);
            writer.WriteBoolValue("disableEduPolicies", DisableEduPolicies);
            writer.WriteBoolValue("disablePowerPolicies", DisablePowerPolicies);
            writer.WriteBoolValue("disableSignInOnResume", DisableSignInOnResume);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("fastFirstSignIn", FastFirstSignIn);
            writer.WriteIntValue("idleTimeBeforeSleepInSeconds", IdleTimeBeforeSleepInSeconds);
            writer.WriteStringValue("kioskAppDisplayName", KioskAppDisplayName);
            writer.WriteStringValue("kioskAppUserModelId", KioskAppUserModelId);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("localStorage", LocalStorage);
            writer.WriteTimeValue("maintenanceStartTime", MaintenanceStartTime);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("setAccountManager", SetAccountManager);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("setEduPolicies", SetEduPolicies);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("setPowerPolicies", SetPowerPolicies);
            writer.WriteEnumValue<global::ApiSdk.Models.Enablement>("signInOnResume", SignInOnResume);
        }
    }
}
#pragma warning restore CS0618
