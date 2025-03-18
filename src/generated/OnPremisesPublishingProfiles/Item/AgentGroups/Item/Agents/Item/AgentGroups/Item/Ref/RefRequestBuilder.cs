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
namespace ApiSdk.OnPremisesPublishingProfiles.Item.AgentGroups.Item.Agents.Item.AgentGroups.Item.Ref
{
    /// <summary>
    /// Provides operations to manage the collection of onPremisesPublishingProfile entities.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RefRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete ref of navigation property agentGroups for onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete ref of navigation property agentGroups for onPremisesPublishingProfiles";
            var onPremisesPublishingProfileIdOption = new Option<string>("--on-premises-publishing-profile-id", description: "The unique identifier of onPremisesPublishingProfile") {
            };
            onPremisesPublishingProfileIdOption.IsRequired = true;
            command.AddOption(onPremisesPublishingProfileIdOption);
            var onPremisesAgentGroupIdOption = new Option<string>("--on-premises-agent-group-id", description: "The unique identifier of onPremisesAgentGroup") {
            };
            onPremisesAgentGroupIdOption.IsRequired = true;
            command.AddOption(onPremisesAgentGroupIdOption);
            var onPremisesAgentIdOption = new Option<string>("--on-premises-agent-id", description: "The unique identifier of onPremisesAgent") {
            };
            onPremisesAgentIdOption.IsRequired = true;
            command.AddOption(onPremisesAgentIdOption);
            var onPremisesAgentGroupId1Option = new Option<string>("--on-premises-agent-group-id1", description: "The unique identifier of onPremisesAgentGroup") {
            };
            onPremisesAgentGroupId1Option.IsRequired = true;
            command.AddOption(onPremisesAgentGroupId1Option);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var onPremisesPublishingProfileId = invocationContext.ParseResult.GetValueForOption(onPremisesPublishingProfileIdOption);
                var onPremisesAgentGroupId = invocationContext.ParseResult.GetValueForOption(onPremisesAgentGroupIdOption);
                var onPremisesAgentId = invocationContext.ParseResult.GetValueForOption(onPremisesAgentIdOption);
                var onPremisesAgentGroupId1 = invocationContext.ParseResult.GetValueForOption(onPremisesAgentGroupId1Option);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (onPremisesPublishingProfileId is not null) requestInfo.PathParameters.Add("onPremisesPublishingProfile%2Did", onPremisesPublishingProfileId);
                if (onPremisesAgentGroupId is not null) requestInfo.PathParameters.Add("onPremisesAgentGroup%2Did", onPremisesAgentGroupId);
                if (onPremisesAgentId is not null) requestInfo.PathParameters.Add("onPremisesAgent%2Did", onPremisesAgentId);
                if (onPremisesAgentGroupId1 is not null) requestInfo.PathParameters.Add("onPremisesAgentGroup%2Did1", onPremisesAgentGroupId1);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.OnPremisesPublishingProfiles.Item.AgentGroups.Item.Agents.Item.AgentGroups.Item.Ref.RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/agents/{onPremisesAgent%2Did}/agentGroups/{onPremisesAgentGroup%2Did1}/$ref", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.OnPremisesPublishingProfiles.Item.AgentGroups.Item.Agents.Item.AgentGroups.Item.Ref.RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder(string rawUrl) : base("{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/agents/{onPremisesAgent%2Did}/agentGroups/{onPremisesAgentGroup%2Did1}/$ref", rawUrl)
        {
        }
        /// <summary>
        /// Delete ref of navigation property agentGroups for onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
