// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.ActivatedUsing;
using ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.AppScope;
using ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.Cancel;
using ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.DirectoryScope;
using ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.Principal;
using ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.RoleDefinition;
using ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.TargetSchedule;
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
namespace ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item
{
    /// <summary>
    /// Provides operations to manage the roleAssignmentScheduleRequests property of the microsoft.graph.rbacApplication entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnifiedRoleAssignmentScheduleRequestItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the activatedUsing property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildActivatedUsingNavCommand()
        {
            var command = new Command("activated-using");
            command.Description = "Provides operations to manage the activatedUsing property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.";
            var builder = new global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.ActivatedUsing.ActivatedUsingRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the appScope property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAppScopeNavCommand()
        {
            var command = new Command("app-scope");
            command.Description = "Provides operations to manage the appScope property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.";
            var builder = new global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.AppScope.AppScopeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the cancel method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCancelNavCommand()
        {
            var command = new Command("cancel");
            command.Description = "Provides operations to call the cancel method.";
            var builder = new global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.Cancel.CancelRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property roleAssignmentScheduleRequests for roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property roleAssignmentScheduleRequests for roleManagement";
            var rbacApplicationIdOption = new Option<string>("--rbac-application-id", description: "The unique identifier of rbacApplication") {
            };
            rbacApplicationIdOption.IsRequired = true;
            command.AddOption(rbacApplicationIdOption);
            var unifiedRoleAssignmentScheduleRequestIdOption = new Option<string>("--unified-role-assignment-schedule-request-id", description: "The unique identifier of unifiedRoleAssignmentScheduleRequest") {
            };
            unifiedRoleAssignmentScheduleRequestIdOption.IsRequired = true;
            command.AddOption(unifiedRoleAssignmentScheduleRequestIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var rbacApplicationId = invocationContext.ParseResult.GetValueForOption(rbacApplicationIdOption);
                var unifiedRoleAssignmentScheduleRequestId = invocationContext.ParseResult.GetValueForOption(unifiedRoleAssignmentScheduleRequestIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (rbacApplicationId is not null) requestInfo.PathParameters.Add("rbacApplication%2Did", rbacApplicationId);
                if (unifiedRoleAssignmentScheduleRequestId is not null) requestInfo.PathParameters.Add("unifiedRoleAssignmentScheduleRequest%2Did", unifiedRoleAssignmentScheduleRequestId);
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
        /// Provides operations to manage the directoryScope property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDirectoryScopeNavCommand()
        {
            var command = new Command("directory-scope");
            command.Description = "Provides operations to manage the directoryScope property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.";
            var builder = new global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.DirectoryScope.DirectoryScopeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Get roleAssignmentScheduleRequests from roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get roleAssignmentScheduleRequests from roleManagement";
            var rbacApplicationIdOption = new Option<string>("--rbac-application-id", description: "The unique identifier of rbacApplication") {
            };
            rbacApplicationIdOption.IsRequired = true;
            command.AddOption(rbacApplicationIdOption);
            var unifiedRoleAssignmentScheduleRequestIdOption = new Option<string>("--unified-role-assignment-schedule-request-id", description: "The unique identifier of unifiedRoleAssignmentScheduleRequest") {
            };
            unifiedRoleAssignmentScheduleRequestIdOption.IsRequired = true;
            command.AddOption(unifiedRoleAssignmentScheduleRequestIdOption);
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
                var rbacApplicationId = invocationContext.ParseResult.GetValueForOption(rbacApplicationIdOption);
                var unifiedRoleAssignmentScheduleRequestId = invocationContext.ParseResult.GetValueForOption(unifiedRoleAssignmentScheduleRequestIdOption);
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
                if (rbacApplicationId is not null) requestInfo.PathParameters.Add("rbacApplication%2Did", rbacApplicationId);
                if (unifiedRoleAssignmentScheduleRequestId is not null) requestInfo.PathParameters.Add("unifiedRoleAssignmentScheduleRequest%2Did", unifiedRoleAssignmentScheduleRequestId);
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
        /// Update the navigation property roleAssignmentScheduleRequests in roleManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property roleAssignmentScheduleRequests in roleManagement";
            var rbacApplicationIdOption = new Option<string>("--rbac-application-id", description: "The unique identifier of rbacApplication") {
            };
            rbacApplicationIdOption.IsRequired = true;
            command.AddOption(rbacApplicationIdOption);
            var unifiedRoleAssignmentScheduleRequestIdOption = new Option<string>("--unified-role-assignment-schedule-request-id", description: "The unique identifier of unifiedRoleAssignmentScheduleRequest") {
            };
            unifiedRoleAssignmentScheduleRequestIdOption.IsRequired = true;
            command.AddOption(unifiedRoleAssignmentScheduleRequestIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var rbacApplicationId = invocationContext.ParseResult.GetValueForOption(rbacApplicationIdOption);
                var unifiedRoleAssignmentScheduleRequestId = invocationContext.ParseResult.GetValueForOption(unifiedRoleAssignmentScheduleRequestIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.UnifiedRoleAssignmentScheduleRequest>(global::ApiSdk.Models.UnifiedRoleAssignmentScheduleRequest.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (rbacApplicationId is not null) requestInfo.PathParameters.Add("rbacApplication%2Did", rbacApplicationId);
                if (unifiedRoleAssignmentScheduleRequestId is not null) requestInfo.PathParameters.Add("unifiedRoleAssignmentScheduleRequest%2Did", unifiedRoleAssignmentScheduleRequestId);
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
        /// Provides operations to manage the principal property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPrincipalNavCommand()
        {
            var command = new Command("principal");
            command.Description = "Provides operations to manage the principal property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.";
            var builder = new global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.Principal.PrincipalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the roleDefinition property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRoleDefinitionNavCommand()
        {
            var command = new Command("role-definition");
            command.Description = "Provides operations to manage the roleDefinition property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.";
            var builder = new global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.RoleDefinition.RoleDefinitionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the targetSchedule property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTargetScheduleNavCommand()
        {
            var command = new Command("target-schedule");
            command.Description = "Provides operations to manage the targetSchedule property of the microsoft.graph.unifiedRoleAssignmentScheduleRequest entity.";
            var builder = new global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.TargetSchedule.TargetScheduleRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.UnifiedRoleAssignmentScheduleRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UnifiedRoleAssignmentScheduleRequestItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/roleManagement/enterpriseApps/{rbacApplication%2Did}/roleAssignmentScheduleRequests/{unifiedRoleAssignmentScheduleRequest%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.UnifiedRoleAssignmentScheduleRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UnifiedRoleAssignmentScheduleRequestItemRequestBuilder(string rawUrl) : base("{+baseurl}/roleManagement/enterpriseApps/{rbacApplication%2Did}/roleAssignmentScheduleRequests/{unifiedRoleAssignmentScheduleRequest%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property roleAssignmentScheduleRequests for roleManagement
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
        /// Get roleAssignmentScheduleRequests from roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.UnifiedRoleAssignmentScheduleRequestItemRequestBuilder.UnifiedRoleAssignmentScheduleRequestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.RoleManagement.EnterpriseApps.Item.RoleAssignmentScheduleRequests.Item.UnifiedRoleAssignmentScheduleRequestItemRequestBuilder.UnifiedRoleAssignmentScheduleRequestItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property roleAssignmentScheduleRequests in roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRoleAssignmentScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRoleAssignmentScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get roleAssignmentScheduleRequests from roleManagement
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UnifiedRoleAssignmentScheduleRequestItemRequestBuilderGetQueryParameters 
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
