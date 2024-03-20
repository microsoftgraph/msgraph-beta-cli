// <auto-generated/>
using ApiSdk.Models.Networkaccess;
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.NetworkAccess.FilteringProfiles.Item.ConditionalAccessPolicies.Item {
    /// <summary>
    /// Provides operations to manage the conditionalAccessPolicies property of the microsoft.graph.networkaccess.filteringProfile entity.
    /// </summary>
    public class ConditionalAccessPolicyItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// A set of associated policies defined to regulate access to resources or systems based on specific conditions. Automatically expanded.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "A set of associated policies defined to regulate access to resources or systems based on specific conditions. Automatically expanded.";
            var filteringProfileIdOption = new Option<string>("--filtering-profile-id", description: "The unique identifier of filteringProfile") {
            };
            filteringProfileIdOption.IsRequired = true;
            command.AddOption(filteringProfileIdOption);
            var conditionalAccessPolicyIdOption = new Option<string>("--conditional-access-policy-id", description: "The unique identifier of conditionalAccessPolicy") {
            };
            conditionalAccessPolicyIdOption.IsRequired = true;
            command.AddOption(conditionalAccessPolicyIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var filteringProfileId = invocationContext.ParseResult.GetValueForOption(filteringProfileIdOption);
                var conditionalAccessPolicyId = invocationContext.ParseResult.GetValueForOption(conditionalAccessPolicyIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (filteringProfileId is not null) requestInfo.PathParameters.Add("filteringProfile%2Did", filteringProfileId);
                if (conditionalAccessPolicyId is not null) requestInfo.PathParameters.Add("conditionalAccessPolicy%2Did", conditionalAccessPolicyId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ConditionalAccessPolicyItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/networkAccess/filteringProfiles/{filteringProfile%2Did}/conditionalAccessPolicies/{conditionalAccessPolicy%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConditionalAccessPolicyItemRequestBuilder(string rawUrl) : base("{+baseurl}/networkAccess/filteringProfiles/{filteringProfile%2Did}/conditionalAccessPolicies/{conditionalAccessPolicy%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// A set of associated policies defined to regulate access to resources or systems based on specific conditions. Automatically expanded.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConditionalAccessPolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConditionalAccessPolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// A set of associated policies defined to regulate access to resources or systems based on specific conditions. Automatically expanded.
        /// </summary>
        public class ConditionalAccessPolicyItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}