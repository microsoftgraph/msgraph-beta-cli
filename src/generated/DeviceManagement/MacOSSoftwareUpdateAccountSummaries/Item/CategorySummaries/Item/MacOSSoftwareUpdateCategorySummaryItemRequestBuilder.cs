// <auto-generated/>
using ApiSdk.DeviceManagement.MacOSSoftwareUpdateAccountSummaries.Item.CategorySummaries.Item.UpdateStateSummaries;
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
namespace ApiSdk.DeviceManagement.MacOSSoftwareUpdateAccountSummaries.Item.CategorySummaries.Item
{
    /// <summary>
    /// Provides operations to manage the categorySummaries property of the microsoft.graph.macOSSoftwareUpdateAccountSummary entity.
    /// </summary>
    public class MacOSSoftwareUpdateCategorySummaryItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property categorySummaries for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property categorySummaries for deviceManagement";
            var macOSSoftwareUpdateAccountSummaryIdOption = new Option<string>("--mac-ossoftware-update-account-summary-id", description: "The unique identifier of macOSSoftwareUpdateAccountSummary") {
            };
            macOSSoftwareUpdateAccountSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateAccountSummaryIdOption);
            var macOSSoftwareUpdateCategorySummaryIdOption = new Option<string>("--mac-ossoftware-update-category-summary-id", description: "The unique identifier of macOSSoftwareUpdateCategorySummary") {
            };
            macOSSoftwareUpdateCategorySummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateCategorySummaryIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var macOSSoftwareUpdateAccountSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateAccountSummaryIdOption);
                var macOSSoftwareUpdateCategorySummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateCategorySummaryIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (macOSSoftwareUpdateAccountSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateAccountSummary%2Did", macOSSoftwareUpdateAccountSummaryId);
                if (macOSSoftwareUpdateCategorySummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateCategorySummary%2Did", macOSSoftwareUpdateCategorySummaryId);
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
        /// Summary of the updates by category.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Summary of the updates by category.";
            var macOSSoftwareUpdateAccountSummaryIdOption = new Option<string>("--mac-ossoftware-update-account-summary-id", description: "The unique identifier of macOSSoftwareUpdateAccountSummary") {
            };
            macOSSoftwareUpdateAccountSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateAccountSummaryIdOption);
            var macOSSoftwareUpdateCategorySummaryIdOption = new Option<string>("--mac-ossoftware-update-category-summary-id", description: "The unique identifier of macOSSoftwareUpdateCategorySummary") {
            };
            macOSSoftwareUpdateCategorySummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateCategorySummaryIdOption);
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
                var macOSSoftwareUpdateAccountSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateAccountSummaryIdOption);
                var macOSSoftwareUpdateCategorySummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateCategorySummaryIdOption);
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
                if (macOSSoftwareUpdateAccountSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateAccountSummary%2Did", macOSSoftwareUpdateAccountSummaryId);
                if (macOSSoftwareUpdateCategorySummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateCategorySummary%2Did", macOSSoftwareUpdateCategorySummaryId);
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
        /// Update the navigation property categorySummaries in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property categorySummaries in deviceManagement";
            var macOSSoftwareUpdateAccountSummaryIdOption = new Option<string>("--mac-ossoftware-update-account-summary-id", description: "The unique identifier of macOSSoftwareUpdateAccountSummary") {
            };
            macOSSoftwareUpdateAccountSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateAccountSummaryIdOption);
            var macOSSoftwareUpdateCategorySummaryIdOption = new Option<string>("--mac-ossoftware-update-category-summary-id", description: "The unique identifier of macOSSoftwareUpdateCategorySummary") {
            };
            macOSSoftwareUpdateCategorySummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateCategorySummaryIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var macOSSoftwareUpdateAccountSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateAccountSummaryIdOption);
                var macOSSoftwareUpdateCategorySummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateCategorySummaryIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<MacOSSoftwareUpdateCategorySummary>(MacOSSoftwareUpdateCategorySummary.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (macOSSoftwareUpdateAccountSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateAccountSummary%2Did", macOSSoftwareUpdateAccountSummaryId);
                if (macOSSoftwareUpdateCategorySummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateCategorySummary%2Did", macOSSoftwareUpdateCategorySummaryId);
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
        /// Provides operations to manage the updateStateSummaries property of the microsoft.graph.macOSSoftwareUpdateCategorySummary entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUpdateStateSummariesNavCommand()
        {
            var command = new Command("update-state-summaries");
            command.Description = "Provides operations to manage the updateStateSummaries property of the microsoft.graph.macOSSoftwareUpdateCategorySummary entity.";
            var builder = new UpdateStateSummariesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
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
        /// Instantiates a new <see cref="MacOSSoftwareUpdateCategorySummaryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MacOSSoftwareUpdateCategorySummaryItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary%2Did}/categorySummaries/{macOSSoftwareUpdateCategorySummary%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MacOSSoftwareUpdateCategorySummaryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MacOSSoftwareUpdateCategorySummaryItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary%2Did}/categorySummaries/{macOSSoftwareUpdateCategorySummary%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property categorySummaries for deviceManagement
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
        /// Summary of the updates by category.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MacOSSoftwareUpdateCategorySummaryItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MacOSSoftwareUpdateCategorySummaryItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property categorySummaries in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(MacOSSoftwareUpdateCategorySummary body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(MacOSSoftwareUpdateCategorySummary body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Summary of the updates by category.
        /// </summary>
        public class MacOSSoftwareUpdateCategorySummaryItemRequestBuilderGetQueryParameters 
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
