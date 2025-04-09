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
    public partial class Simulation : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue, oAuthConsentGrant, phishTraining. Use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: oAuthConsentGrant, phishTraining. For more information on the types of social engineering attack techniques, see simulations.</summary>
        public global::ApiSdk.Models.SimulationAttackTechnique? AttackTechnique { get; set; }
        /// <summary>Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.</summary>
        public global::ApiSdk.Models.SimulationAttackType? AttackType { get; set; }
        /// <summary>Unique identifier for the attack simulation automation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AutomationId { get; set; }
#nullable restore
#else
        public string AutomationId { get; set; }
#endif
        /// <summary>Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? CompletionDateTime { get; set; }
        /// <summary>Identity of the user who created the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EmailIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EmailIdentity CreatedBy { get; set; }
#endif
        /// <summary>Date and time of creation of the attack simulation and training campaign.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display name of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Simulation duration in days.</summary>
        public int? DurationInDays { get; set; }
        /// <summary>Details about the end user notification setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EndUserNotificationSetting? EndUserNotificationSetting { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EndUserNotificationSetting EndUserNotificationSetting { get; set; }
#endif
        /// <summary>Users excluded from the simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AccountTargetContent? ExcludedAccountTarget { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AccountTargetContent ExcludedAccountTarget { get; set; }
#endif
        /// <summary>Users targeted in the simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AccountTargetContent? IncludedAccountTarget { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AccountTargetContent IncludedAccountTarget { get; set; }
#endif
        /// <summary>Flag that represents if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.</summary>
        public bool? IsAutomated { get; set; }
        /// <summary>The landing page associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LandingPage? LandingPage { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LandingPage LandingPage { get; set; }
#endif
        /// <summary>Identity of the user who most recently modified the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EmailIdentity? LastModifiedBy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EmailIdentity LastModifiedBy { get; set; }
#endif
        /// <summary>Date and time of the most recent modification of the attack simulation and training campaign.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? LaunchDateTime { get; set; }
        /// <summary>The login page associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LoginPage? LoginPage { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LoginPage LoginPage { get; set; }
#endif
        /// <summary>OAuth app details for the OAuth technique.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OAuthConsentAppDetail? OAuthConsentAppDetail { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OAuthConsentAppDetail OAuthConsentAppDetail { get; set; }
#endif
        /// <summary>The payload associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Payload? Payload { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Payload Payload { get; set; }
#endif
        /// <summary>Method of delivery of the phishing payload used in the attack simulation and training campaign. Possible values are: unknown, sms, email, teams, unknownFutureValue.</summary>
        public global::ApiSdk.Models.PayloadDeliveryPlatform? PayloadDeliveryPlatform { get; set; }
        /// <summary>Report of the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SimulationReport? Report { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SimulationReport Report { get; set; }
#endif
        /// <summary>Status of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, draft, running, scheduled, succeeded, failed, cancelled, excluded, unknownFutureValue.</summary>
        public global::ApiSdk.Models.SimulationStatus? Status { get; set; }
        /// <summary>Details about the training settings for a simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TrainingSetting? TrainingSetting { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TrainingSetting TrainingSetting { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Simulation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Simulation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Simulation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attackTechnique", n => { AttackTechnique = n.GetEnumValue<global::ApiSdk.Models.SimulationAttackTechnique>(); } },
                { "attackType", n => { AttackType = n.GetEnumValue<global::ApiSdk.Models.SimulationAttackType>(); } },
                { "automationId", n => { AutomationId = n.GetStringValue(); } },
                { "completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::ApiSdk.Models.EmailIdentity>(global::ApiSdk.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                { "endUserNotificationSetting", n => { EndUserNotificationSetting = n.GetObjectValue<global::ApiSdk.Models.EndUserNotificationSetting>(global::ApiSdk.Models.EndUserNotificationSetting.CreateFromDiscriminatorValue); } },
                { "excludedAccountTarget", n => { ExcludedAccountTarget = n.GetObjectValue<global::ApiSdk.Models.AccountTargetContent>(global::ApiSdk.Models.AccountTargetContent.CreateFromDiscriminatorValue); } },
                { "includedAccountTarget", n => { IncludedAccountTarget = n.GetObjectValue<global::ApiSdk.Models.AccountTargetContent>(global::ApiSdk.Models.AccountTargetContent.CreateFromDiscriminatorValue); } },
                { "isAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                { "landingPage", n => { LandingPage = n.GetObjectValue<global::ApiSdk.Models.LandingPage>(global::ApiSdk.Models.LandingPage.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::ApiSdk.Models.EmailIdentity>(global::ApiSdk.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "launchDateTime", n => { LaunchDateTime = n.GetDateTimeOffsetValue(); } },
                { "loginPage", n => { LoginPage = n.GetObjectValue<global::ApiSdk.Models.LoginPage>(global::ApiSdk.Models.LoginPage.CreateFromDiscriminatorValue); } },
                { "oAuthConsentAppDetail", n => { OAuthConsentAppDetail = n.GetObjectValue<global::ApiSdk.Models.OAuthConsentAppDetail>(global::ApiSdk.Models.OAuthConsentAppDetail.CreateFromDiscriminatorValue); } },
                { "payload", n => { Payload = n.GetObjectValue<global::ApiSdk.Models.Payload>(global::ApiSdk.Models.Payload.CreateFromDiscriminatorValue); } },
                { "payloadDeliveryPlatform", n => { PayloadDeliveryPlatform = n.GetEnumValue<global::ApiSdk.Models.PayloadDeliveryPlatform>(); } },
                { "report", n => { Report = n.GetObjectValue<global::ApiSdk.Models.SimulationReport>(global::ApiSdk.Models.SimulationReport.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.SimulationStatus>(); } },
                { "trainingSetting", n => { TrainingSetting = n.GetObjectValue<global::ApiSdk.Models.TrainingSetting>(global::ApiSdk.Models.TrainingSetting.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.SimulationAttackTechnique>("attackTechnique", AttackTechnique);
            writer.WriteEnumValue<global::ApiSdk.Models.SimulationAttackType>("attackType", AttackType);
            writer.WriteStringValue("automationId", AutomationId);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteObjectValue<global::ApiSdk.Models.EndUserNotificationSetting>("endUserNotificationSetting", EndUserNotificationSetting);
            writer.WriteObjectValue<global::ApiSdk.Models.AccountTargetContent>("excludedAccountTarget", ExcludedAccountTarget);
            writer.WriteObjectValue<global::ApiSdk.Models.AccountTargetContent>("includedAccountTarget", IncludedAccountTarget);
            writer.WriteBoolValue("isAutomated", IsAutomated);
            writer.WriteObjectValue<global::ApiSdk.Models.LandingPage>("landingPage", LandingPage);
            writer.WriteObjectValue<global::ApiSdk.Models.EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("launchDateTime", LaunchDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.LoginPage>("loginPage", LoginPage);
            writer.WriteObjectValue<global::ApiSdk.Models.OAuthConsentAppDetail>("oAuthConsentAppDetail", OAuthConsentAppDetail);
            writer.WriteObjectValue<global::ApiSdk.Models.Payload>("payload", Payload);
            writer.WriteEnumValue<global::ApiSdk.Models.PayloadDeliveryPlatform>("payloadDeliveryPlatform", PayloadDeliveryPlatform);
            writer.WriteObjectValue<global::ApiSdk.Models.SimulationReport>("report", Report);
            writer.WriteEnumValue<global::ApiSdk.Models.SimulationStatus>("status", Status);
            writer.WriteObjectValue<global::ApiSdk.Models.TrainingSetting>("trainingSetting", TrainingSetting);
        }
    }
}
#pragma warning restore CS0618
