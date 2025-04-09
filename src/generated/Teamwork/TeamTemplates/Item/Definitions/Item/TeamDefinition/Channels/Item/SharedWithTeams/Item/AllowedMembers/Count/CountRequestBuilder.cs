// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Channels.Item.SharedWithTeams.Item.AllowedMembers.Count
{
    /// <summary>
    /// Provides operations to count the resources in the collection.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CountRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the number of the resource";
            var teamTemplateIdOption = new Option<string>("--team-template-id", description: "The unique identifier of teamTemplate") {
            };
            teamTemplateIdOption.IsRequired = true;
            command.AddOption(teamTemplateIdOption);
            var teamTemplateDefinitionIdOption = new Option<string>("--team-template-definition-id", description: "The unique identifier of teamTemplateDefinition") {
            };
            teamTemplateDefinitionIdOption.IsRequired = true;
            command.AddOption(teamTemplateDefinitionIdOption);
            var channelIdOption = new Option<string>("--channel-id", description: "The unique identifier of channel") {
            };
            channelIdOption.IsRequired = true;
            command.AddOption(channelIdOption);
            var sharedWithChannelTeamInfoIdOption = new Option<string>("--shared-with-channel-team-info-id", description: "The unique identifier of sharedWithChannelTeamInfo") {
            };
            sharedWithChannelTeamInfoIdOption.IsRequired = true;
            command.AddOption(sharedWithChannelTeamInfoIdOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            command.SetHandler(async (invocationContext) => {
                var teamTemplateId = invocationContext.ParseResult.GetValueForOption(teamTemplateIdOption);
                var teamTemplateDefinitionId = invocationContext.ParseResult.GetValueForOption(teamTemplateDefinitionIdOption);
                var channelId = invocationContext.ParseResult.GetValueForOption(channelIdOption);
                var sharedWithChannelTeamInfoId = invocationContext.ParseResult.GetValueForOption(sharedWithChannelTeamInfoIdOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                });
                if (teamTemplateId is not null) requestInfo.PathParameters.Add("teamTemplate%2Did", teamTemplateId);
                if (teamTemplateDefinitionId is not null) requestInfo.PathParameters.Add("teamTemplateDefinition%2Did", teamTemplateDefinitionId);
                if (channelId is not null) requestInfo.PathParameters.Add("channel%2Did", channelId);
                if (sharedWithChannelTeamInfoId is not null) requestInfo.PathParameters.Add("sharedWithChannelTeamInfo%2Did", sharedWithChannelTeamInfoId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                var formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Channels.Item.SharedWithTeams.Item.AllowedMembers.Count.CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CountRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/channels/{channel%2Did}/sharedWithTeams/{sharedWithChannelTeamInfo%2Did}/allowedMembers/$count{?%24filter,%24search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Channels.Item.SharedWithTeams.Item.AllowedMembers.Count.CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CountRequestBuilder(string rawUrl) : base("{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/channels/{channel%2Did}/sharedWithTeams/{sharedWithChannelTeamInfo%2Did}/allowedMembers/$count{?%24filter,%24search}", rawUrl)
        {
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Channels.Item.SharedWithTeams.Item.AllowedMembers.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Channels.Item.SharedWithTeams.Item.AllowedMembers.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CountRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
