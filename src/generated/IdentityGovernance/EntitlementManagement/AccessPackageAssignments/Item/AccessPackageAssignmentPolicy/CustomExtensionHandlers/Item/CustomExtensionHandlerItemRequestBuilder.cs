// <auto-generated/>
using ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionHandlers.Item.CustomExtension;
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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionHandlers.Item {
    /// <summary>
    /// Provides operations to manage the customExtensionHandlers property of the microsoft.graph.accessPackageAssignmentPolicy entity.
    /// </summary>
    public class CustomExtensionHandlerItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the customExtension property of the microsoft.graph.customExtensionHandler entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCustomExtensionNavCommand()
        {
            var command = new Command("custom-extension");
            command.Description = "Provides operations to manage the customExtension property of the microsoft.graph.customExtensionHandler entity.";
            var builder = new CustomExtensionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property customExtensionHandlers for identityGovernance
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property customExtensionHandlers for identityGovernance";
            var accessPackageAssignmentIdOption = new Option<string>("--access-package-assignment-id", description: "The unique identifier of accessPackageAssignment") {
            };
            accessPackageAssignmentIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentIdOption);
            var customExtensionHandlerIdOption = new Option<string>("--custom-extension-handler-id", description: "The unique identifier of customExtensionHandler") {
            };
            customExtensionHandlerIdOption.IsRequired = true;
            command.AddOption(customExtensionHandlerIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageAssignmentId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentIdOption);
                var customExtensionHandlerId = invocationContext.ParseResult.GetValueForOption(customExtensionHandlerIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (accessPackageAssignmentId is not null) requestInfo.PathParameters.Add("accessPackageAssignment%2Did", accessPackageAssignmentId);
                if (customExtensionHandlerId is not null) requestInfo.PathParameters.Add("customExtensionHandler%2Did", customExtensionHandlerId);
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
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.";
            var accessPackageAssignmentIdOption = new Option<string>("--access-package-assignment-id", description: "The unique identifier of accessPackageAssignment") {
            };
            accessPackageAssignmentIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentIdOption);
            var customExtensionHandlerIdOption = new Option<string>("--custom-extension-handler-id", description: "The unique identifier of customExtensionHandler") {
            };
            customExtensionHandlerIdOption.IsRequired = true;
            command.AddOption(customExtensionHandlerIdOption);
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
                var accessPackageAssignmentId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentIdOption);
                var customExtensionHandlerId = invocationContext.ParseResult.GetValueForOption(customExtensionHandlerIdOption);
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
                if (accessPackageAssignmentId is not null) requestInfo.PathParameters.Add("accessPackageAssignment%2Did", accessPackageAssignmentId);
                if (customExtensionHandlerId is not null) requestInfo.PathParameters.Add("customExtensionHandler%2Did", customExtensionHandlerId);
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
        /// Update the navigation property customExtensionHandlers in identityGovernance
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property customExtensionHandlers in identityGovernance";
            var accessPackageAssignmentIdOption = new Option<string>("--access-package-assignment-id", description: "The unique identifier of accessPackageAssignment") {
            };
            accessPackageAssignmentIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentIdOption);
            var customExtensionHandlerIdOption = new Option<string>("--custom-extension-handler-id", description: "The unique identifier of customExtensionHandler") {
            };
            customExtensionHandlerIdOption.IsRequired = true;
            command.AddOption(customExtensionHandlerIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageAssignmentId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentIdOption);
                var customExtensionHandlerId = invocationContext.ParseResult.GetValueForOption(customExtensionHandlerIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CustomExtensionHandler>(CustomExtensionHandler.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (accessPackageAssignmentId is not null) requestInfo.PathParameters.Add("accessPackageAssignment%2Did", accessPackageAssignmentId);
                if (customExtensionHandlerId is not null) requestInfo.PathParameters.Add("customExtensionHandler%2Did", customExtensionHandlerId);
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
        /// Instantiates a new <see cref="CustomExtensionHandlerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CustomExtensionHandlerItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackageAssignmentPolicy/customExtensionHandlers/{customExtensionHandler%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomExtensionHandlerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CustomExtensionHandlerItemRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackageAssignmentPolicy/customExtensionHandlers/{customExtensionHandler%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property customExtensionHandlers for identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackageAssignmentPolicy/customExtensionHandlers/{customExtensionHandler%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomExtensionHandlerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomExtensionHandlerItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property customExtensionHandlers in identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(CustomExtensionHandler body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(CustomExtensionHandler body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackageAssignmentPolicy/customExtensionHandlers/{customExtensionHandler%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        public class CustomExtensionHandlerItemRequestBuilderGetQueryParameters 
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