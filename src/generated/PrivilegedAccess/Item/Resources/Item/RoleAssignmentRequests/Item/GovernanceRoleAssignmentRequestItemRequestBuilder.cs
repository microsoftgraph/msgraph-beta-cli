// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.Cancel;
using ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.Resource;
using ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.RoleDefinition;
using ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.Subject;
using ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.UpdateRequest;
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
namespace ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item {
    /// <summary>
    /// Provides operations to manage the roleAssignmentRequests property of the microsoft.graph.governanceResource entity.
    /// </summary>
    public class GovernanceRoleAssignmentRequestItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to call the cancel method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCancelNavCommand()
        {
            var command = new Command("cancel");
            command.Description = "Provides operations to call the cancel method.";
            var builder = new CancelRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property roleAssignmentRequests for privilegedAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property roleAssignmentRequests for privilegedAccess";
            var privilegedAccessIdOption = new Option<string>("--privileged-access-id", description: "The unique identifier of privilegedAccess") {
            };
            privilegedAccessIdOption.IsRequired = true;
            command.AddOption(privilegedAccessIdOption);
            var governanceResourceIdOption = new Option<string>("--governance-resource-id", description: "The unique identifier of governanceResource") {
            };
            governanceResourceIdOption.IsRequired = true;
            command.AddOption(governanceResourceIdOption);
            var governanceRoleAssignmentRequestIdOption = new Option<string>("--governance-role-assignment-request-id", description: "The unique identifier of governanceRoleAssignmentRequest") {
            };
            governanceRoleAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(governanceRoleAssignmentRequestIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var privilegedAccessId = invocationContext.ParseResult.GetValueForOption(privilegedAccessIdOption);
                var governanceResourceId = invocationContext.ParseResult.GetValueForOption(governanceResourceIdOption);
                var governanceRoleAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(governanceRoleAssignmentRequestIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (privilegedAccessId is not null) requestInfo.PathParameters.Add("privilegedAccess%2Did", privilegedAccessId);
                if (governanceResourceId is not null) requestInfo.PathParameters.Add("governanceResource%2Did", governanceResourceId);
                if (governanceRoleAssignmentRequestId is not null) requestInfo.PathParameters.Add("governanceRoleAssignmentRequest%2Did", governanceRoleAssignmentRequestId);
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
        /// The collection of role assignment requests for the resource.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The collection of role assignment requests for the resource.";
            var privilegedAccessIdOption = new Option<string>("--privileged-access-id", description: "The unique identifier of privilegedAccess") {
            };
            privilegedAccessIdOption.IsRequired = true;
            command.AddOption(privilegedAccessIdOption);
            var governanceResourceIdOption = new Option<string>("--governance-resource-id", description: "The unique identifier of governanceResource") {
            };
            governanceResourceIdOption.IsRequired = true;
            command.AddOption(governanceResourceIdOption);
            var governanceRoleAssignmentRequestIdOption = new Option<string>("--governance-role-assignment-request-id", description: "The unique identifier of governanceRoleAssignmentRequest") {
            };
            governanceRoleAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(governanceRoleAssignmentRequestIdOption);
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
                var privilegedAccessId = invocationContext.ParseResult.GetValueForOption(privilegedAccessIdOption);
                var governanceResourceId = invocationContext.ParseResult.GetValueForOption(governanceResourceIdOption);
                var governanceRoleAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(governanceRoleAssignmentRequestIdOption);
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
                if (privilegedAccessId is not null) requestInfo.PathParameters.Add("privilegedAccess%2Did", privilegedAccessId);
                if (governanceResourceId is not null) requestInfo.PathParameters.Add("governanceResource%2Did", governanceResourceId);
                if (governanceRoleAssignmentRequestId is not null) requestInfo.PathParameters.Add("governanceRoleAssignmentRequest%2Did", governanceRoleAssignmentRequestId);
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
        /// Update the navigation property roleAssignmentRequests in privilegedAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property roleAssignmentRequests in privilegedAccess";
            var privilegedAccessIdOption = new Option<string>("--privileged-access-id", description: "The unique identifier of privilegedAccess") {
            };
            privilegedAccessIdOption.IsRequired = true;
            command.AddOption(privilegedAccessIdOption);
            var governanceResourceIdOption = new Option<string>("--governance-resource-id", description: "The unique identifier of governanceResource") {
            };
            governanceResourceIdOption.IsRequired = true;
            command.AddOption(governanceResourceIdOption);
            var governanceRoleAssignmentRequestIdOption = new Option<string>("--governance-role-assignment-request-id", description: "The unique identifier of governanceRoleAssignmentRequest") {
            };
            governanceRoleAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(governanceRoleAssignmentRequestIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var privilegedAccessId = invocationContext.ParseResult.GetValueForOption(privilegedAccessIdOption);
                var governanceResourceId = invocationContext.ParseResult.GetValueForOption(governanceResourceIdOption);
                var governanceRoleAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(governanceRoleAssignmentRequestIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<GovernanceRoleAssignmentRequest>(GovernanceRoleAssignmentRequest.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (privilegedAccessId is not null) requestInfo.PathParameters.Add("privilegedAccess%2Did", privilegedAccessId);
                if (governanceResourceId is not null) requestInfo.PathParameters.Add("governanceResource%2Did", governanceResourceId);
                if (governanceRoleAssignmentRequestId is not null) requestInfo.PathParameters.Add("governanceRoleAssignmentRequest%2Did", governanceRoleAssignmentRequestId);
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
        /// Provides operations to manage the resource property of the microsoft.graph.governanceRoleAssignmentRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResourceNavCommand()
        {
            var command = new Command("resource");
            command.Description = "Provides operations to manage the resource property of the microsoft.graph.governanceRoleAssignmentRequest entity.";
            var builder = new ResourceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the roleDefinition property of the microsoft.graph.governanceRoleAssignmentRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRoleDefinitionNavCommand()
        {
            var command = new Command("role-definition");
            command.Description = "Provides operations to manage the roleDefinition property of the microsoft.graph.governanceRoleAssignmentRequest entity.";
            var builder = new RoleDefinitionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildResourceNavCommand());
            nonExecCommands.Add(builder.BuildRoleSettingNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the subject property of the microsoft.graph.governanceRoleAssignmentRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSubjectNavCommand()
        {
            var command = new Command("subject");
            command.Description = "Provides operations to manage the subject property of the microsoft.graph.governanceRoleAssignmentRequest entity.";
            var builder = new SubjectRequestBuilder(PathParameters);
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
        /// Provides operations to call the updateRequest method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUpdateRequestNavCommand()
        {
            var command = new Command("update-request");
            command.Description = "Provides operations to call the updateRequest method.";
            var builder = new UpdateRequestRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="GovernanceRoleAssignmentRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GovernanceRoleAssignmentRequestItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/privilegedAccess/{privilegedAccess%2Did}/resources/{governanceResource%2Did}/roleAssignmentRequests/{governanceRoleAssignmentRequest%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GovernanceRoleAssignmentRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GovernanceRoleAssignmentRequestItemRequestBuilder(string rawUrl) : base("{+baseurl}/privilegedAccess/{privilegedAccess%2Did}/resources/{governanceResource%2Did}/roleAssignmentRequests/{governanceRoleAssignmentRequest%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property roleAssignmentRequests for privilegedAccess
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/privilegedAccess/{privilegedAccess%2Did}/resources/{governanceResource%2Did}/roleAssignmentRequests/{governanceRoleAssignmentRequest%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The collection of role assignment requests for the resource.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GovernanceRoleAssignmentRequestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GovernanceRoleAssignmentRequestItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property roleAssignmentRequests in privilegedAccess
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(GovernanceRoleAssignmentRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(GovernanceRoleAssignmentRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/privilegedAccess/{privilegedAccess%2Did}/resources/{governanceResource%2Did}/roleAssignmentRequests/{governanceRoleAssignmentRequest%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The collection of role assignment requests for the resource.
        /// </summary>
        public class GovernanceRoleAssignmentRequestItemRequestBuilderGetQueryParameters 
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