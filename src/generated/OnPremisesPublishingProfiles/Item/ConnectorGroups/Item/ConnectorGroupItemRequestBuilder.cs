// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Applications;
using ApiSdk.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithAppId;
using ApiSdk.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithUniqueName;
using ApiSdk.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Members;
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
namespace ApiSdk.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item
{
    /// <summary>
    /// Provides operations to manage the connectorGroups property of the microsoft.graph.onPremisesPublishingProfile entity.
    /// </summary>
    public class ConnectorGroupItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildApplicationsNavCommand()
        {
            var command = new Command("applications");
            command.Description = "Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.";
            var builder = new ApplicationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildApplicationsWithAppIdRbCommand()
        {
            var command = new Command("applications-with-app-id");
            command.Description = "Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.";
            var builder = new ApplicationsWithAppIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildApplicationsWithUniqueNameRbCommand()
        {
            var command = new Command("applications-with-unique-name");
            command.Description = "Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.";
            var builder = new ApplicationsWithUniqueNameRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property connectorGroups for onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property connectorGroups for onPremisesPublishingProfiles";
            var onPremisesPublishingProfileIdOption = new Option<string>("--on-premises-publishing-profile-id", description: "The unique identifier of onPremisesPublishingProfile") {
            };
            onPremisesPublishingProfileIdOption.IsRequired = true;
            command.AddOption(onPremisesPublishingProfileIdOption);
            var connectorGroupIdOption = new Option<string>("--connector-group-id", description: "The unique identifier of connectorGroup") {
            };
            connectorGroupIdOption.IsRequired = true;
            command.AddOption(connectorGroupIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var onPremisesPublishingProfileId = invocationContext.ParseResult.GetValueForOption(onPremisesPublishingProfileIdOption);
                var connectorGroupId = invocationContext.ParseResult.GetValueForOption(connectorGroupIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (onPremisesPublishingProfileId is not null) requestInfo.PathParameters.Add("onPremisesPublishingProfile%2Did", onPremisesPublishingProfileId);
                if (connectorGroupId is not null) requestInfo.PathParameters.Add("connectorGroup%2Did", connectorGroupId);
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
        /// List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.";
            var onPremisesPublishingProfileIdOption = new Option<string>("--on-premises-publishing-profile-id", description: "The unique identifier of onPremisesPublishingProfile") {
            };
            onPremisesPublishingProfileIdOption.IsRequired = true;
            command.AddOption(onPremisesPublishingProfileIdOption);
            var connectorGroupIdOption = new Option<string>("--connector-group-id", description: "The unique identifier of connectorGroup") {
            };
            connectorGroupIdOption.IsRequired = true;
            command.AddOption(connectorGroupIdOption);
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
                var onPremisesPublishingProfileId = invocationContext.ParseResult.GetValueForOption(onPremisesPublishingProfileIdOption);
                var connectorGroupId = invocationContext.ParseResult.GetValueForOption(connectorGroupIdOption);
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
                if (onPremisesPublishingProfileId is not null) requestInfo.PathParameters.Add("onPremisesPublishingProfile%2Did", onPremisesPublishingProfileId);
                if (connectorGroupId is not null) requestInfo.PathParameters.Add("connectorGroup%2Did", connectorGroupId);
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
        /// Provides operations to manage the members property of the microsoft.graph.connectorGroup entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMembersNavCommand()
        {
            var command = new Command("members");
            command.Description = "Provides operations to manage the members property of the microsoft.graph.connectorGroup entity.";
            var builder = new MembersRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildRefNavCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property connectorGroups in onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property connectorGroups in onPremisesPublishingProfiles";
            var onPremisesPublishingProfileIdOption = new Option<string>("--on-premises-publishing-profile-id", description: "The unique identifier of onPremisesPublishingProfile") {
            };
            onPremisesPublishingProfileIdOption.IsRequired = true;
            command.AddOption(onPremisesPublishingProfileIdOption);
            var connectorGroupIdOption = new Option<string>("--connector-group-id", description: "The unique identifier of connectorGroup") {
            };
            connectorGroupIdOption.IsRequired = true;
            command.AddOption(connectorGroupIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var onPremisesPublishingProfileId = invocationContext.ParseResult.GetValueForOption(onPremisesPublishingProfileIdOption);
                var connectorGroupId = invocationContext.ParseResult.GetValueForOption(connectorGroupIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.ConnectorGroup>(ApiSdk.Models.ConnectorGroup.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (onPremisesPublishingProfileId is not null) requestInfo.PathParameters.Add("onPremisesPublishingProfile%2Did", onPremisesPublishingProfileId);
                if (connectorGroupId is not null) requestInfo.PathParameters.Add("connectorGroup%2Did", connectorGroupId);
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
        /// Instantiates a new <see cref="ConnectorGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ConnectorGroupItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/connectorGroups/{connectorGroup%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConnectorGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConnectorGroupItemRequestBuilder(string rawUrl) : base("{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/connectorGroups/{connectorGroup%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property connectorGroups for onPremisesPublishingProfiles
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
        /// List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConnectorGroupItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConnectorGroupItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property connectorGroups in onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.ConnectorGroup body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.ConnectorGroup body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        public class ConnectorGroupItemRequestBuilderGetQueryParameters 
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
