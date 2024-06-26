// <auto-generated/>
using ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item.DefinitionValue;
using ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item.Presentation;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item
{
    /// <summary>
    /// Provides operations to manage the presentationValues property of the microsoft.graph.groupPolicyDefinitionValue entity.
    /// </summary>
    public class GroupPolicyPresentationValueItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the definitionValue property of the microsoft.graph.groupPolicyPresentationValue entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDefinitionValueNavCommand()
        {
            var command = new Command("definition-value");
            command.Description = "Provides operations to manage the definitionValue property of the microsoft.graph.groupPolicyPresentationValue entity.";
            var builder = new DefinitionValueRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property presentationValues for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property presentationValues for deviceManagement";
            var groupPolicyConfigurationIdOption = new Option<string>("--group-policy-configuration-id", description: "The unique identifier of groupPolicyConfiguration") {
            };
            groupPolicyConfigurationIdOption.IsRequired = true;
            command.AddOption(groupPolicyConfigurationIdOption);
            var groupPolicyDefinitionValueIdOption = new Option<string>("--group-policy-definition-value-id", description: "The unique identifier of groupPolicyDefinitionValue") {
            };
            groupPolicyDefinitionValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyDefinitionValueIdOption);
            var groupPolicyPresentationValueIdOption = new Option<string>("--group-policy-presentation-value-id", description: "The unique identifier of groupPolicyPresentationValue") {
            };
            groupPolicyPresentationValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyPresentationValueIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var groupPolicyConfigurationId = invocationContext.ParseResult.GetValueForOption(groupPolicyConfigurationIdOption);
                var groupPolicyDefinitionValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyDefinitionValueIdOption);
                var groupPolicyPresentationValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyPresentationValueIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (groupPolicyConfigurationId is not null) requestInfo.PathParameters.Add("groupPolicyConfiguration%2Did", groupPolicyConfigurationId);
                if (groupPolicyDefinitionValueId is not null) requestInfo.PathParameters.Add("groupPolicyDefinitionValue%2Did", groupPolicyDefinitionValueId);
                if (groupPolicyPresentationValueId is not null) requestInfo.PathParameters.Add("groupPolicyPresentationValue%2Did", groupPolicyPresentationValueId);
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
        /// The associated group policy presentation values with the definition value.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The associated group policy presentation values with the definition value.";
            var groupPolicyConfigurationIdOption = new Option<string>("--group-policy-configuration-id", description: "The unique identifier of groupPolicyConfiguration") {
            };
            groupPolicyConfigurationIdOption.IsRequired = true;
            command.AddOption(groupPolicyConfigurationIdOption);
            var groupPolicyDefinitionValueIdOption = new Option<string>("--group-policy-definition-value-id", description: "The unique identifier of groupPolicyDefinitionValue") {
            };
            groupPolicyDefinitionValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyDefinitionValueIdOption);
            var groupPolicyPresentationValueIdOption = new Option<string>("--group-policy-presentation-value-id", description: "The unique identifier of groupPolicyPresentationValue") {
            };
            groupPolicyPresentationValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyPresentationValueIdOption);
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
                var groupPolicyConfigurationId = invocationContext.ParseResult.GetValueForOption(groupPolicyConfigurationIdOption);
                var groupPolicyDefinitionValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyDefinitionValueIdOption);
                var groupPolicyPresentationValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyPresentationValueIdOption);
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
                if (groupPolicyConfigurationId is not null) requestInfo.PathParameters.Add("groupPolicyConfiguration%2Did", groupPolicyConfigurationId);
                if (groupPolicyDefinitionValueId is not null) requestInfo.PathParameters.Add("groupPolicyDefinitionValue%2Did", groupPolicyDefinitionValueId);
                if (groupPolicyPresentationValueId is not null) requestInfo.PathParameters.Add("groupPolicyPresentationValue%2Did", groupPolicyPresentationValueId);
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
        /// Update the navigation property presentationValues in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property presentationValues in deviceManagement";
            var groupPolicyConfigurationIdOption = new Option<string>("--group-policy-configuration-id", description: "The unique identifier of groupPolicyConfiguration") {
            };
            groupPolicyConfigurationIdOption.IsRequired = true;
            command.AddOption(groupPolicyConfigurationIdOption);
            var groupPolicyDefinitionValueIdOption = new Option<string>("--group-policy-definition-value-id", description: "The unique identifier of groupPolicyDefinitionValue") {
            };
            groupPolicyDefinitionValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyDefinitionValueIdOption);
            var groupPolicyPresentationValueIdOption = new Option<string>("--group-policy-presentation-value-id", description: "The unique identifier of groupPolicyPresentationValue") {
            };
            groupPolicyPresentationValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyPresentationValueIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var groupPolicyConfigurationId = invocationContext.ParseResult.GetValueForOption(groupPolicyConfigurationIdOption);
                var groupPolicyDefinitionValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyDefinitionValueIdOption);
                var groupPolicyPresentationValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyPresentationValueIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<GroupPolicyPresentationValue>(GroupPolicyPresentationValue.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (groupPolicyConfigurationId is not null) requestInfo.PathParameters.Add("groupPolicyConfiguration%2Did", groupPolicyConfigurationId);
                if (groupPolicyDefinitionValueId is not null) requestInfo.PathParameters.Add("groupPolicyDefinitionValue%2Did", groupPolicyDefinitionValueId);
                if (groupPolicyPresentationValueId is not null) requestInfo.PathParameters.Add("groupPolicyPresentationValue%2Did", groupPolicyPresentationValueId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Provides operations to manage the presentation property of the microsoft.graph.groupPolicyPresentationValue entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPresentationNavCommand()
        {
            var command = new Command("presentation");
            command.Description = "Provides operations to manage the presentation property of the microsoft.graph.groupPolicyPresentationValue entity.";
            var builder = new PresentationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="GroupPolicyPresentationValueItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GroupPolicyPresentationValueItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration%2Did}/definitionValues/{groupPolicyDefinitionValue%2Did}/presentationValues/{groupPolicyPresentationValue%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GroupPolicyPresentationValueItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GroupPolicyPresentationValueItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration%2Did}/definitionValues/{groupPolicyDefinitionValue%2Did}/presentationValues/{groupPolicyPresentationValue%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property presentationValues for deviceManagement
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
        /// <summary>
        /// The associated group policy presentation values with the definition value.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GroupPolicyPresentationValueItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GroupPolicyPresentationValueItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property presentationValues in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(GroupPolicyPresentationValue body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(GroupPolicyPresentationValue body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The associated group policy presentation values with the definition value.
        /// </summary>
        public class GroupPolicyPresentationValueItemRequestBuilderGetQueryParameters 
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
