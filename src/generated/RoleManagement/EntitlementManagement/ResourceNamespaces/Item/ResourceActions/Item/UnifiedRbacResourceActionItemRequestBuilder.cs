// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.AuthenticationContext;
using ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.ResourceScope;
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
namespace ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item
{
    /// <summary>
    /// Provides operations to manage the resourceActions property of the microsoft.graph.unifiedRbacResourceNamespace entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnifiedRbacResourceActionItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the authenticationContext property of the microsoft.graph.unifiedRbacResourceAction entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAuthenticationContextNavCommand()
        {
            var command = new Command("authentication-context");
            command.Description = "Provides operations to manage the authenticationContext property of the microsoft.graph.unifiedRbacResourceAction entity.";
            var builder = new global::ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.AuthenticationContext.AuthenticationContextRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property resourceActions for roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property resourceActions for roleManagement";
            var unifiedRbacResourceNamespaceIdOption = new Option<string>("--unified-rbac-resource-namespace-id", description: "The unique identifier of unifiedRbacResourceNamespace") {
            };
            unifiedRbacResourceNamespaceIdOption.IsRequired = true;
            command.AddOption(unifiedRbacResourceNamespaceIdOption);
            var unifiedRbacResourceActionIdOption = new Option<string>("--unified-rbac-resource-action-id", description: "The unique identifier of unifiedRbacResourceAction") {
            };
            unifiedRbacResourceActionIdOption.IsRequired = true;
            command.AddOption(unifiedRbacResourceActionIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRbacResourceNamespaceId = invocationContext.ParseResult.GetValueForOption(unifiedRbacResourceNamespaceIdOption);
                var unifiedRbacResourceActionId = invocationContext.ParseResult.GetValueForOption(unifiedRbacResourceActionIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (unifiedRbacResourceNamespaceId is not null) requestInfo.PathParameters.Add("unifiedRbacResourceNamespace%2Did", unifiedRbacResourceNamespaceId);
                if (unifiedRbacResourceActionId is not null) requestInfo.PathParameters.Add("unifiedRbacResourceAction%2Did", unifiedRbacResourceActionId);
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
        /// Operations that an authorized principal is allowed to perform.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Operations that an authorized principal is allowed to perform.";
            var unifiedRbacResourceNamespaceIdOption = new Option<string>("--unified-rbac-resource-namespace-id", description: "The unique identifier of unifiedRbacResourceNamespace") {
            };
            unifiedRbacResourceNamespaceIdOption.IsRequired = true;
            command.AddOption(unifiedRbacResourceNamespaceIdOption);
            var unifiedRbacResourceActionIdOption = new Option<string>("--unified-rbac-resource-action-id", description: "The unique identifier of unifiedRbacResourceAction") {
            };
            unifiedRbacResourceActionIdOption.IsRequired = true;
            command.AddOption(unifiedRbacResourceActionIdOption);
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
                var unifiedRbacResourceNamespaceId = invocationContext.ParseResult.GetValueForOption(unifiedRbacResourceNamespaceIdOption);
                var unifiedRbacResourceActionId = invocationContext.ParseResult.GetValueForOption(unifiedRbacResourceActionIdOption);
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
                if (unifiedRbacResourceNamespaceId is not null) requestInfo.PathParameters.Add("unifiedRbacResourceNamespace%2Did", unifiedRbacResourceNamespaceId);
                if (unifiedRbacResourceActionId is not null) requestInfo.PathParameters.Add("unifiedRbacResourceAction%2Did", unifiedRbacResourceActionId);
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
        /// Update the navigation property resourceActions in roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property resourceActions in roleManagement";
            var unifiedRbacResourceNamespaceIdOption = new Option<string>("--unified-rbac-resource-namespace-id", description: "The unique identifier of unifiedRbacResourceNamespace") {
            };
            unifiedRbacResourceNamespaceIdOption.IsRequired = true;
            command.AddOption(unifiedRbacResourceNamespaceIdOption);
            var unifiedRbacResourceActionIdOption = new Option<string>("--unified-rbac-resource-action-id", description: "The unique identifier of unifiedRbacResourceAction") {
            };
            unifiedRbacResourceActionIdOption.IsRequired = true;
            command.AddOption(unifiedRbacResourceActionIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRbacResourceNamespaceId = invocationContext.ParseResult.GetValueForOption(unifiedRbacResourceNamespaceIdOption);
                var unifiedRbacResourceActionId = invocationContext.ParseResult.GetValueForOption(unifiedRbacResourceActionIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.UnifiedRbacResourceAction>(global::ApiSdk.Models.UnifiedRbacResourceAction.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (unifiedRbacResourceNamespaceId is not null) requestInfo.PathParameters.Add("unifiedRbacResourceNamespace%2Did", unifiedRbacResourceNamespaceId);
                if (unifiedRbacResourceActionId is not null) requestInfo.PathParameters.Add("unifiedRbacResourceAction%2Did", unifiedRbacResourceActionId);
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
        /// Provides operations to manage the resourceScope property of the microsoft.graph.unifiedRbacResourceAction entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResourceScopeNavCommand()
        {
            var command = new Command("resource-scope");
            command.Description = "Provides operations to manage the resourceScope property of the microsoft.graph.unifiedRbacResourceAction entity.";
            var builder = new global::ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.ResourceScope.ResourceScopeRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="global::ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.UnifiedRbacResourceActionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UnifiedRbacResourceActionItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/roleManagement/entitlementManagement/resourceNamespaces/{unifiedRbacResourceNamespace%2Did}/resourceActions/{unifiedRbacResourceAction%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.UnifiedRbacResourceActionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UnifiedRbacResourceActionItemRequestBuilder(string rawUrl) : base("{+baseurl}/roleManagement/entitlementManagement/resourceNamespaces/{unifiedRbacResourceNamespace%2Did}/resourceActions/{unifiedRbacResourceAction%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property resourceActions for roleManagement
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
        /// Operations that an authorized principal is allowed to perform.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.UnifiedRbacResourceActionItemRequestBuilder.UnifiedRbacResourceActionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.RoleManagement.EntitlementManagement.ResourceNamespaces.Item.ResourceActions.Item.UnifiedRbacResourceActionItemRequestBuilder.UnifiedRbacResourceActionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property resourceActions in roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRbacResourceAction body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRbacResourceAction body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Operations that an authorized principal is allowed to perform.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UnifiedRbacResourceActionItemRequestBuilderGetQueryParameters 
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
