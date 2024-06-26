// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Teamwork : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of deleted chats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeletedChat>? DeletedChats { get; set; }
#nullable restore
#else
        public List<DeletedChat> DeletedChats { get; set; }
#endif
        /// <summary>A collection of deleted teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeletedTeam>? DeletedTeams { get; set; }
#nullable restore
#else
        public List<DeletedTeam> DeletedTeams { get; set; }
#endif
        /// <summary>The Teams devices provisioned for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkDevice>? Devices { get; set; }
#nullable restore
#else
        public List<TeamworkDevice> Devices { get; set; }
#endif
        /// <summary>Indicates whether Microsoft Teams is enabled for the organization.</summary>
        public bool? IsTeamsEnabled { get; set; }
        /// <summary>Represents the region of the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>Represents tenant-wide settings for all Teams apps in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TeamsAppSettings? TeamsAppSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TeamsAppSettings TeamsAppSettings { get; set; }
#endif
        /// <summary>The templates associated with a team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamTemplate>? TeamTemplates { get; set; }
#nullable restore
#else
        public List<TeamTemplate> TeamTemplates { get; set; }
#endif
        /// <summary>A workforce integration with shifts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkforceIntegration>? WorkforceIntegrations { get; set; }
#nullable restore
#else
        public List<WorkforceIntegration> WorkforceIntegrations { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Teamwork"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Teamwork CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Teamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deletedChats", n => { DeletedChats = n.GetCollectionOfObjectValues<DeletedChat>(DeletedChat.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deletedTeams", n => { DeletedTeams = n.GetCollectionOfObjectValues<DeletedTeam>(DeletedTeam.CreateFromDiscriminatorValue)?.ToList(); } },
                { "devices", n => { Devices = n.GetCollectionOfObjectValues<TeamworkDevice>(TeamworkDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isTeamsEnabled", n => { IsTeamsEnabled = n.GetBoolValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "teamTemplates", n => { TeamTemplates = n.GetCollectionOfObjectValues<TeamTemplate>(TeamTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                { "teamsAppSettings", n => { TeamsAppSettings = n.GetObjectValue<ApiSdk.Models.TeamsAppSettings>(ApiSdk.Models.TeamsAppSettings.CreateFromDiscriminatorValue); } },
                { "workforceIntegrations", n => { WorkforceIntegrations = n.GetCollectionOfObjectValues<WorkforceIntegration>(WorkforceIntegration.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<DeletedChat>("deletedChats", DeletedChats);
            writer.WriteCollectionOfObjectValues<DeletedTeam>("deletedTeams", DeletedTeams);
            writer.WriteCollectionOfObjectValues<TeamworkDevice>("devices", Devices);
            writer.WriteBoolValue("isTeamsEnabled", IsTeamsEnabled);
            writer.WriteStringValue("region", Region);
            writer.WriteObjectValue<ApiSdk.Models.TeamsAppSettings>("teamsAppSettings", TeamsAppSettings);
            writer.WriteCollectionOfObjectValues<TeamTemplate>("teamTemplates", TeamTemplates);
            writer.WriteCollectionOfObjectValues<WorkforceIntegration>("workforceIntegrations", WorkforceIntegrations);
        }
    }
}
