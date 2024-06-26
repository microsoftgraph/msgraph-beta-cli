// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models.WindowsUpdates;
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
namespace ApiSdk.Admin.Windows.Updates.DeploymentAudiences.Item.ApplicableContent.Item.MatchedDevices.Item
{
    /// <summary>
    /// Provides operations to manage the matchedDevices property of the microsoft.graph.windowsUpdates.applicableContent entity.
    /// </summary>
    public class ApplicableContentDeviceMatchDeviceItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property matchedDevices for admin
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property matchedDevices for admin";
            var deploymentAudienceIdOption = new Option<string>("--deployment-audience-id", description: "The unique identifier of deploymentAudience") {
            };
            deploymentAudienceIdOption.IsRequired = true;
            command.AddOption(deploymentAudienceIdOption);
            var applicableContentCatalogEntryIdOption = new Option<string>("--applicable-content-catalog-entry-id", description: "The unique identifier of applicableContent") {
            };
            applicableContentCatalogEntryIdOption.IsRequired = true;
            command.AddOption(applicableContentCatalogEntryIdOption);
            var applicableContentDeviceMatchDeviceIdOption = new Option<string>("--applicable-content-device-match-device-id", description: "The unique identifier of applicableContentDeviceMatch") {
            };
            applicableContentDeviceMatchDeviceIdOption.IsRequired = true;
            command.AddOption(applicableContentDeviceMatchDeviceIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var deploymentAudienceId = invocationContext.ParseResult.GetValueForOption(deploymentAudienceIdOption);
                var applicableContentCatalogEntryId = invocationContext.ParseResult.GetValueForOption(applicableContentCatalogEntryIdOption);
                var applicableContentDeviceMatchDeviceId = invocationContext.ParseResult.GetValueForOption(applicableContentDeviceMatchDeviceIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (deploymentAudienceId is not null) requestInfo.PathParameters.Add("deploymentAudience%2Did", deploymentAudienceId);
                if (applicableContentCatalogEntryId is not null) requestInfo.PathParameters.Add("applicableContent%2DcatalogEntryId", applicableContentCatalogEntryId);
                if (applicableContentDeviceMatchDeviceId is not null) requestInfo.PathParameters.Add("applicableContentDeviceMatch%2DdeviceId", applicableContentDeviceMatchDeviceId);
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
        /// Collection of devices and recommendations for applicable catalog content.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Collection of devices and recommendations for applicable catalog content.";
            var deploymentAudienceIdOption = new Option<string>("--deployment-audience-id", description: "The unique identifier of deploymentAudience") {
            };
            deploymentAudienceIdOption.IsRequired = true;
            command.AddOption(deploymentAudienceIdOption);
            var applicableContentCatalogEntryIdOption = new Option<string>("--applicable-content-catalog-entry-id", description: "The unique identifier of applicableContent") {
            };
            applicableContentCatalogEntryIdOption.IsRequired = true;
            command.AddOption(applicableContentCatalogEntryIdOption);
            var applicableContentDeviceMatchDeviceIdOption = new Option<string>("--applicable-content-device-match-device-id", description: "The unique identifier of applicableContentDeviceMatch") {
            };
            applicableContentDeviceMatchDeviceIdOption.IsRequired = true;
            command.AddOption(applicableContentDeviceMatchDeviceIdOption);
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
                var deploymentAudienceId = invocationContext.ParseResult.GetValueForOption(deploymentAudienceIdOption);
                var applicableContentCatalogEntryId = invocationContext.ParseResult.GetValueForOption(applicableContentCatalogEntryIdOption);
                var applicableContentDeviceMatchDeviceId = invocationContext.ParseResult.GetValueForOption(applicableContentDeviceMatchDeviceIdOption);
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
                if (deploymentAudienceId is not null) requestInfo.PathParameters.Add("deploymentAudience%2Did", deploymentAudienceId);
                if (applicableContentCatalogEntryId is not null) requestInfo.PathParameters.Add("applicableContent%2DcatalogEntryId", applicableContentCatalogEntryId);
                if (applicableContentDeviceMatchDeviceId is not null) requestInfo.PathParameters.Add("applicableContentDeviceMatch%2DdeviceId", applicableContentDeviceMatchDeviceId);
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
        /// Update the navigation property matchedDevices in admin
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property matchedDevices in admin";
            var deploymentAudienceIdOption = new Option<string>("--deployment-audience-id", description: "The unique identifier of deploymentAudience") {
            };
            deploymentAudienceIdOption.IsRequired = true;
            command.AddOption(deploymentAudienceIdOption);
            var applicableContentCatalogEntryIdOption = new Option<string>("--applicable-content-catalog-entry-id", description: "The unique identifier of applicableContent") {
            };
            applicableContentCatalogEntryIdOption.IsRequired = true;
            command.AddOption(applicableContentCatalogEntryIdOption);
            var applicableContentDeviceMatchDeviceIdOption = new Option<string>("--applicable-content-device-match-device-id", description: "The unique identifier of applicableContentDeviceMatch") {
            };
            applicableContentDeviceMatchDeviceIdOption.IsRequired = true;
            command.AddOption(applicableContentDeviceMatchDeviceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var deploymentAudienceId = invocationContext.ParseResult.GetValueForOption(deploymentAudienceIdOption);
                var applicableContentCatalogEntryId = invocationContext.ParseResult.GetValueForOption(applicableContentCatalogEntryIdOption);
                var applicableContentDeviceMatchDeviceId = invocationContext.ParseResult.GetValueForOption(applicableContentDeviceMatchDeviceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApplicableContentDeviceMatch>(ApplicableContentDeviceMatch.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (deploymentAudienceId is not null) requestInfo.PathParameters.Add("deploymentAudience%2Did", deploymentAudienceId);
                if (applicableContentCatalogEntryId is not null) requestInfo.PathParameters.Add("applicableContent%2DcatalogEntryId", applicableContentCatalogEntryId);
                if (applicableContentDeviceMatchDeviceId is not null) requestInfo.PathParameters.Add("applicableContentDeviceMatch%2DdeviceId", applicableContentDeviceMatchDeviceId);
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
        /// Instantiates a new <see cref="ApplicableContentDeviceMatchDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ApplicableContentDeviceMatchDeviceItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/admin/windows/updates/deploymentAudiences/{deploymentAudience%2Did}/applicableContent/{applicableContent%2DcatalogEntryId}/matchedDevices/{applicableContentDeviceMatch%2DdeviceId}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ApplicableContentDeviceMatchDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ApplicableContentDeviceMatchDeviceItemRequestBuilder(string rawUrl) : base("{+baseurl}/admin/windows/updates/deploymentAudiences/{deploymentAudience%2Did}/applicableContent/{applicableContent%2DcatalogEntryId}/matchedDevices/{applicableContentDeviceMatch%2DdeviceId}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property matchedDevices for admin
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
        /// Collection of devices and recommendations for applicable catalog content.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ApplicableContentDeviceMatchDeviceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ApplicableContentDeviceMatchDeviceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property matchedDevices in admin
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApplicableContentDeviceMatch body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApplicableContentDeviceMatch body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Collection of devices and recommendations for applicable catalog content.
        /// </summary>
        public class ApplicableContentDeviceMatchDeviceItemRequestBuilderGetQueryParameters 
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
