// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.IdentityGovernance.RoleManagementAlerts.Alerts.Item.AlertIncidents.Item.Remediate;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.IdentityGovernance.RoleManagementAlerts.Alerts.Item.AlertIncidents.Item
{
    /// <summary>
    /// Provides operations to manage the alertIncidents property of the microsoft.graph.unifiedRoleManagementAlert entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnifiedRoleManagementAlertIncidentItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property alertIncidents for identityGovernance
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property alertIncidents for identityGovernance";
            var unifiedRoleManagementAlertIdOption = new Option<string>("--unified-role-management-alert-id", description: "The unique identifier of unifiedRoleManagementAlert") {
            };
            unifiedRoleManagementAlertIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementAlertIdOption);
            var unifiedRoleManagementAlertIncidentIdOption = new Option<string>("--unified-role-management-alert-incident-id", description: "The unique identifier of unifiedRoleManagementAlertIncident") {
            };
            unifiedRoleManagementAlertIncidentIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementAlertIncidentIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleManagementAlertId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementAlertIdOption);
                var unifiedRoleManagementAlertIncidentId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementAlertIncidentIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (unifiedRoleManagementAlertId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementAlert%2Did", unifiedRoleManagementAlertId);
                if (unifiedRoleManagementAlertIncidentId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementAlertIncident%2Did", unifiedRoleManagementAlertIncidentId);
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
        /// Represents the incidents of this type of alert that have been triggered in Privileged Identity Management (PIM) for Microsoft Entra roles in the tenant. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Represents the incidents of this type of alert that have been triggered in Privileged Identity Management (PIM) for Microsoft Entra roles in the tenant. Supports $expand.";
            var unifiedRoleManagementAlertIdOption = new Option<string>("--unified-role-management-alert-id", description: "The unique identifier of unifiedRoleManagementAlert") {
            };
            unifiedRoleManagementAlertIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementAlertIdOption);
            var unifiedRoleManagementAlertIncidentIdOption = new Option<string>("--unified-role-management-alert-incident-id", description: "The unique identifier of unifiedRoleManagementAlertIncident") {
            };
            unifiedRoleManagementAlertIncidentIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementAlertIncidentIdOption);
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
                var unifiedRoleManagementAlertId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementAlertIdOption);
                var unifiedRoleManagementAlertIncidentId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementAlertIncidentIdOption);
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
                if (unifiedRoleManagementAlertId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementAlert%2Did", unifiedRoleManagementAlertId);
                if (unifiedRoleManagementAlertIncidentId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementAlertIncident%2Did", unifiedRoleManagementAlertIncidentId);
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
        /// Update the navigation property alertIncidents in identityGovernance
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property alertIncidents in identityGovernance";
            var unifiedRoleManagementAlertIdOption = new Option<string>("--unified-role-management-alert-id", description: "The unique identifier of unifiedRoleManagementAlert") {
            };
            unifiedRoleManagementAlertIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementAlertIdOption);
            var unifiedRoleManagementAlertIncidentIdOption = new Option<string>("--unified-role-management-alert-incident-id", description: "The unique identifier of unifiedRoleManagementAlertIncident") {
            };
            unifiedRoleManagementAlertIncidentIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementAlertIncidentIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleManagementAlertId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementAlertIdOption);
                var unifiedRoleManagementAlertIncidentId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementAlertIncidentIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.UnifiedRoleManagementAlertIncident>(global::ApiSdk.Models.UnifiedRoleManagementAlertIncident.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (unifiedRoleManagementAlertId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementAlert%2Did", unifiedRoleManagementAlertId);
                if (unifiedRoleManagementAlertIncidentId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementAlertIncident%2Did", unifiedRoleManagementAlertIncidentId);
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
        /// Provides operations to call the remediate method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRemediateNavCommand()
        {
            var command = new Command("remediate");
            command.Description = "Provides operations to call the remediate method.";
            var builder = new global::ApiSdk.IdentityGovernance.RoleManagementAlerts.Alerts.Item.AlertIncidents.Item.Remediate.RemediateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.RoleManagementAlerts.Alerts.Item.AlertIncidents.Item.UnifiedRoleManagementAlertIncidentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UnifiedRoleManagementAlertIncidentItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/roleManagementAlerts/alerts/{unifiedRoleManagementAlert%2Did}/alertIncidents/{unifiedRoleManagementAlertIncident%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.RoleManagementAlerts.Alerts.Item.AlertIncidents.Item.UnifiedRoleManagementAlertIncidentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UnifiedRoleManagementAlertIncidentItemRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/roleManagementAlerts/alerts/{unifiedRoleManagementAlert%2Did}/alertIncidents/{unifiedRoleManagementAlertIncident%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property alertIncidents for identityGovernance
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
        /// Represents the incidents of this type of alert that have been triggered in Privileged Identity Management (PIM) for Microsoft Entra roles in the tenant. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.IdentityGovernance.RoleManagementAlerts.Alerts.Item.AlertIncidents.Item.UnifiedRoleManagementAlertIncidentItemRequestBuilder.UnifiedRoleManagementAlertIncidentItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.IdentityGovernance.RoleManagementAlerts.Alerts.Item.AlertIncidents.Item.UnifiedRoleManagementAlertIncidentItemRequestBuilder.UnifiedRoleManagementAlertIncidentItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property alertIncidents in identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRoleManagementAlertIncident body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UnifiedRoleManagementAlertIncident body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Represents the incidents of this type of alert that have been triggered in Privileged Identity Management (PIM) for Microsoft Entra roles in the tenant. Supports $expand.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UnifiedRoleManagementAlertIncidentItemRequestBuilderGetQueryParameters 
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
