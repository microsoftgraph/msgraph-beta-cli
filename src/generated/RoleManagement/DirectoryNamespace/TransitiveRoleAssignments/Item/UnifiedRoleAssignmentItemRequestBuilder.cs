// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.AppScope;
using ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.DirectoryScope;
using ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.Principal;
using ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.RoleDefinition;
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
namespace ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item
{
    /// <summary>
    /// Provides operations to manage the transitiveRoleAssignments property of the microsoft.graph.rbacApplication entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnifiedRoleAssignmentItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the appScope property of the microsoft.graph.unifiedRoleAssignment entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAppScopeNavCommand()
        {
            var command = new Command("app-scope");
            command.Description = "Provides operations to manage the appScope property of the microsoft.graph.unifiedRoleAssignment entity.";
            var builder = new global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.AppScope.AppScopeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property transitiveRoleAssignments for roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property transitiveRoleAssignments for roleManagement";
            var unifiedRoleAssignmentIdOption = new Option<string>("--unified-role-assignment-id", description: "The unique identifier of unifiedRoleAssignment") {
            };
            unifiedRoleAssignmentIdOption.IsRequired = true;
            command.AddOption(unifiedRoleAssignmentIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleAssignmentId = invocationContext.ParseResult.GetValueForOption(unifiedRoleAssignmentIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (unifiedRoleAssignmentId is not null) requestInfo.PathParameters.Add("unifiedRoleAssignment%2Did", unifiedRoleAssignmentId);
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
        /// Provides operations to manage the directoryScope property of the microsoft.graph.unifiedRoleAssignment entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDirectoryScopeNavCommand()
        {
            var command = new Command("directory-scope");
            command.Description = "Provides operations to manage the directoryScope property of the microsoft.graph.unifiedRoleAssignment entity.";
            var builder = new global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.DirectoryScope.DirectoryScopeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Get transitiveRoleAssignments from roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get transitiveRoleAssignments from roleManagement";
            var unifiedRoleAssignmentIdOption = new Option<string>("--unified-role-assignment-id", description: "The unique identifier of unifiedRoleAssignment") {
            };
            unifiedRoleAssignmentIdOption.IsRequired = true;
            command.AddOption(unifiedRoleAssignmentIdOption);
            var consistencyLevelOption = new Option<string[]>("--consistency-level", description: "Indicates the requested consistency level. Documentation URL: https://docs.microsoft.com/graph/aad-advanced-queries") {
                Arity = ArgumentArity.ZeroOrMore
            };
            consistencyLevelOption.IsRequired = false;
            command.AddOption(consistencyLevelOption);
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
                var unifiedRoleAssignmentId = invocationContext.ParseResult.GetValueForOption(unifiedRoleAssignmentIdOption);
                var consistencyLevel = invocationContext.ParseResult.GetValueForOption(consistencyLevelOption);
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
                if (unifiedRoleAssignmentId is not null) requestInfo.PathParameters.Add("unifiedRoleAssignment%2Did", unifiedRoleAssignmentId);
                if (consistencyLevel is not null) requestInfo.Headers.Add("ConsistencyLevel", consistencyLevel);
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
        /// Update the navigation property transitiveRoleAssignments in roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property transitiveRoleAssignments in roleManagement";
            var unifiedRoleAssignmentIdOption = new Option<string>("--unified-role-assignment-id", description: "The unique identifier of unifiedRoleAssignment") {
            };
            unifiedRoleAssignmentIdOption.IsRequired = true;
            command.AddOption(unifiedRoleAssignmentIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleAssignmentId = invocationContext.ParseResult.GetValueForOption(unifiedRoleAssignmentIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.UnifiedRoleAssignment>(global::ApiSdk.Models.UnifiedRoleAssignment.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (unifiedRoleAssignmentId is not null) requestInfo.PathParameters.Add("unifiedRoleAssignment%2Did", unifiedRoleAssignmentId);
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
        /// Provides operations to manage the principal property of the microsoft.graph.unifiedRoleAssignment entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPrincipalNavCommand()
        {
            var command = new Command("principal");
            command.Description = "Provides operations to manage the principal property of the microsoft.graph.unifiedRoleAssignment entity.";
            var builder = new global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.Principal.PrincipalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the roleDefinition property of the microsoft.graph.unifiedRoleAssignment entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRoleDefinitionNavCommand()
        {
            var command = new Command("role-definition");
            command.Description = "Provides operations to manage the roleDefinition property of the microsoft.graph.unifiedRoleAssignment entity.";
            var builder = new global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.RoleDefinition.RoleDefinitionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.UnifiedRoleAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UnifiedRoleAssignmentItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/roleManagement/directory/transitiveRoleAssignments/{unifiedRoleAssignment%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.UnifiedRoleAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UnifiedRoleAssignmentItemRequestBuilder(string rawUrl) : base("{+baseurl}/roleManagement/directory/transitiveRoleAssignments/{unifiedRoleAssignment%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property transitiveRoleAssignments for roleManagement
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
            return requestInfo;
        }
        /// <summary>
        /// Get transitiveRoleAssignments from roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.UnifiedRoleAssignmentItemRequestBuilder.UnifiedRoleAssignmentItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.Item.UnifiedRoleAssignmentItemRequestBuilder.UnifiedRoleAssignmentItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property transitiveRoleAssignments in roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRoleAssignment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRoleAssignment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get transitiveRoleAssignments from roleManagement
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UnifiedRoleAssignmentItemRequestBuilderGetQueryParameters 
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
#pragma warning restore CS0618
