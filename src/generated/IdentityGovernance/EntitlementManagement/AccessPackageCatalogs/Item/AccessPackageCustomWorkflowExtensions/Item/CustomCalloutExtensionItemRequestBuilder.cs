// <auto-generated/>
#pragma warning disable CS0618
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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageCustomWorkflowExtensions.Item
{
    /// <summary>
    /// Provides operations to manage the accessPackageCustomWorkflowExtensions property of the microsoft.graph.accessPackageCatalog entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CustomCalloutExtensionItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property accessPackageCustomWorkflowExtensions for identityGovernance
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property accessPackageCustomWorkflowExtensions for identityGovernance";
            var accessPackageCatalogIdOption = new Option<string>("--access-package-catalog-id", description: "The unique identifier of accessPackageCatalog") {
            };
            accessPackageCatalogIdOption.IsRequired = true;
            command.AddOption(accessPackageCatalogIdOption);
            var customCalloutExtensionIdOption = new Option<string>("--custom-callout-extension-id", description: "The unique identifier of customCalloutExtension") {
            };
            customCalloutExtensionIdOption.IsRequired = true;
            command.AddOption(customCalloutExtensionIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageCatalogId = invocationContext.ParseResult.GetValueForOption(accessPackageCatalogIdOption);
                var customCalloutExtensionId = invocationContext.ParseResult.GetValueForOption(customCalloutExtensionIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (accessPackageCatalogId is not null) requestInfo.PathParameters.Add("accessPackageCatalog%2Did", accessPackageCatalogId);
                if (customCalloutExtensionId is not null) requestInfo.PathParameters.Add("customCalloutExtension%2Did", customCalloutExtensionId);
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
        /// Read the properties and relationships of an accessPackageAssignmentWorkflowExtension object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackageassignmentworkflowextension-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of an accessPackageAssignmentWorkflowExtension object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accesspackageassignmentworkflowextension-get?view=graph-rest-beta";
            var accessPackageCatalogIdOption = new Option<string>("--access-package-catalog-id", description: "The unique identifier of accessPackageCatalog") {
            };
            accessPackageCatalogIdOption.IsRequired = true;
            command.AddOption(accessPackageCatalogIdOption);
            var customCalloutExtensionIdOption = new Option<string>("--custom-callout-extension-id", description: "The unique identifier of customCalloutExtension") {
            };
            customCalloutExtensionIdOption.IsRequired = true;
            command.AddOption(customCalloutExtensionIdOption);
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
                var accessPackageCatalogId = invocationContext.ParseResult.GetValueForOption(accessPackageCatalogIdOption);
                var customCalloutExtensionId = invocationContext.ParseResult.GetValueForOption(customCalloutExtensionIdOption);
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
                if (accessPackageCatalogId is not null) requestInfo.PathParameters.Add("accessPackageCatalog%2Did", accessPackageCatalogId);
                if (customCalloutExtensionId is not null) requestInfo.PathParameters.Add("customCalloutExtension%2Did", customCalloutExtensionId);
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
        /// Update the properties of an accessPackageAssignmentRequestWorkflowExtension object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackageassignmentrequestworkflowextension-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the properties of an accessPackageAssignmentRequestWorkflowExtension object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accesspackageassignmentrequestworkflowextension-update?view=graph-rest-beta";
            var accessPackageCatalogIdOption = new Option<string>("--access-package-catalog-id", description: "The unique identifier of accessPackageCatalog") {
            };
            accessPackageCatalogIdOption.IsRequired = true;
            command.AddOption(accessPackageCatalogIdOption);
            var customCalloutExtensionIdOption = new Option<string>("--custom-callout-extension-id", description: "The unique identifier of customCalloutExtension") {
            };
            customCalloutExtensionIdOption.IsRequired = true;
            command.AddOption(customCalloutExtensionIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageCatalogId = invocationContext.ParseResult.GetValueForOption(accessPackageCatalogIdOption);
                var customCalloutExtensionId = invocationContext.ParseResult.GetValueForOption(customCalloutExtensionIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.CustomCalloutExtension>(global::ApiSdk.Models.CustomCalloutExtension.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (accessPackageCatalogId is not null) requestInfo.PathParameters.Add("accessPackageCatalog%2Did", accessPackageCatalogId);
                if (customCalloutExtensionId is not null) requestInfo.PathParameters.Add("customCalloutExtension%2Did", customCalloutExtensionId);
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
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageCustomWorkflowExtensions.Item.CustomCalloutExtensionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CustomCalloutExtensionItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/accessPackageCustomWorkflowExtensions/{customCalloutExtension%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageCustomWorkflowExtensions.Item.CustomCalloutExtensionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CustomCalloutExtensionItemRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/accessPackageCustomWorkflowExtensions/{customCalloutExtension%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property accessPackageCustomWorkflowExtensions for identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
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
        /// Read the properties and relationships of an accessPackageAssignmentWorkflowExtension object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageCustomWorkflowExtensions.Item.CustomCalloutExtensionItemRequestBuilder.CustomCalloutExtensionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageCustomWorkflowExtensions.Item.CustomCalloutExtensionItemRequestBuilder.CustomCalloutExtensionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an accessPackageAssignmentRequestWorkflowExtension object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.CustomCalloutExtension body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.CustomCalloutExtension body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of an accessPackageAssignmentWorkflowExtension object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomCalloutExtensionItemRequestBuilderGetQueryParameters 
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
