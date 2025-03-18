// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.Networkaccess;
using ApiSdk.Models.ODataErrors;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessCrossTenantAccessReportWithStartDateTimeWithEndDateTime;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessDestinationReportWithStartDateTimeWithEndDateTime;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessDeviceReportWithStartDateTimeWithEndDateTime;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessEntitiesSummariesWithStartDateTimeWithEndDateTime;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetCrossTenantSummaryWithStartDateTimeWithEndDateTimeWithDiscoveryPivotDateTime;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDestinationSummariesWithStartDateTimeWithEndDateTimeWithAggregatedBy;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTime;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserId;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessTransactionSummariesWithStartDateTimeWithEndDateTime;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessUsageProfilingWithStartDateTimeWithEndDateTimeWithAggregatedBydiscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationId;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessUserReportWithStartDateTimeWithEndDateTimediscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationId;
using ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessWebCategoryReportWithStartDateTimeWithEndDateTime;
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
namespace ApiSdk.NetworkAccess.Reports
{
    /// <summary>
    /// Provides operations to manage the reports property of the microsoft.graph.networkaccess.networkAccessRoot entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReportsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property reports for networkAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property reports for networkAccess";
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
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
        /// Represents the status of the Global Secure Access services for the tenant.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Represents the status of the Global Secure Access services for the tenant.";
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
        /// Provides operations to call the crossTenantAccessReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessCrossTenantAccessReportWithStartDateTimeWithEndDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-cross-tenant-access-report-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the crossTenantAccessReport method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessCrossTenantAccessReportWithStartDateTimeWithEndDateTime.MicrosoftGraphNetworkaccessCrossTenantAccessReportWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the destinationReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessDestinationReportWithStartDateTimeWithEndDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-destination-report-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the destinationReport method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessDestinationReportWithStartDateTimeWithEndDateTime.MicrosoftGraphNetworkaccessDestinationReportWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the deviceReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessDeviceReportWithStartDateTimeWithEndDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-device-report-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the deviceReport method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessDeviceReportWithStartDateTimeWithEndDateTime.MicrosoftGraphNetworkaccessDeviceReportWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the entitiesSummaries method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessEntitiesSummariesWithStartDateTimeWithEndDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-entities-summaries-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the entitiesSummaries method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessEntitiesSummariesWithStartDateTimeWithEndDateTime.MicrosoftGraphNetworkaccessEntitiesSummariesWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCrossTenantSummary method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessGetCrossTenantSummaryWithStartDateTimeWithEndDateTimeWithDiscoveryPivotDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-get-cross-tenant-summary-with-start-date-time-with-end-date-time-with-discovery-pivot-date-time");
            command.Description = "Provides operations to call the getCrossTenantSummary method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetCrossTenantSummaryWithStartDateTimeWithEndDateTimeWithDiscoveryPivotDateTime.MicrosoftGraphNetworkaccessGetCrossTenantSummaryWithStartDateTimeWithEndDateTimeWithDiscoveryPivotDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDestinationSummaries method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessGetDestinationSummariesWithStartDateTimeWithEndDateTimeWithAggregatedByRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-get-destination-summaries-with-start-date-time-with-end-date-time-with-aggregated-by");
            command.Description = "Provides operations to call the getDestinationSummaries method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDestinationSummariesWithStartDateTimeWithEndDateTimeWithAggregatedBy.MicrosoftGraphNetworkaccessGetDestinationSummariesWithStartDateTimeWithEndDateTimeWithAggregatedByRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDeviceUsageSummary method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-get-device-usage-summary-with-start-date-time-with-end-date-time-with-activity-pivot-date-time");
            command.Description = "Provides operations to call the getDeviceUsageSummary method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTime.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDiscoveredApplicationSegmentReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserIdRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-get-discovered-application-segment-report-with-start-date-time-with-end-date-timeuser-id-user-id");
            command.Description = "Provides operations to call the getDiscoveredApplicationSegmentReport method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserId.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeuserIdUserIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the transactionSummaries method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessTransactionSummariesWithStartDateTimeWithEndDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-transaction-summaries-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the transactionSummaries method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessTransactionSummariesWithStartDateTimeWithEndDateTime.MicrosoftGraphNetworkaccessTransactionSummariesWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the usageProfiling method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessUsageProfilingWithStartDateTimeWithEndDateTimeWithAggregatedBydiscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationIdRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-usage-profiling-with-start-date-time-with-end-date-time-with-aggregated-bydiscovered-application-segment-id-discovered-application-segment-id-application-id-application-id");
            command.Description = "Provides operations to call the usageProfiling method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessUsageProfilingWithStartDateTimeWithEndDateTimeWithAggregatedBydiscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationId.MicrosoftGraphNetworkaccessUsageProfilingWithStartDateTimeWithEndDateTimeWithAggregatedBydiscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the userReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessUserReportWithStartDateTimeWithEndDateTimediscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationIdRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-user-report-with-start-date-time-with-end-date-timediscovered-application-segment-id-discovered-application-segment-id-application-id-application-id");
            command.Description = "Provides operations to call the userReport method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessUserReportWithStartDateTimeWithEndDateTimediscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationId.MicrosoftGraphNetworkaccessUserReportWithStartDateTimeWithEndDateTimediscoveredApplicationSegmentIdDiscoveredApplicationSegmentIdApplicationIdApplicationIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the webCategoryReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphNetworkaccessWebCategoryReportWithStartDateTimeWithEndDateTimeRbCommand()
        {
            var command = new Command("microsoft-graph-networkaccess-web-category-report-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the webCategoryReport method.";
            var builder = new global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessWebCategoryReportWithStartDateTimeWithEndDateTime.MicrosoftGraphNetworkaccessWebCategoryReportWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property reports in networkAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property reports in networkAccess";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.Networkaccess.Reports>(global::ApiSdk.Models.Networkaccess.Reports.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
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
        /// Instantiates a new <see cref="global::ApiSdk.NetworkAccess.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/networkAccess/reports{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.NetworkAccess.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ReportsRequestBuilder(string rawUrl) : base("{+baseurl}/networkAccess/reports{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property reports for networkAccess
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
        /// Represents the status of the Global Secure Access services for the tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.NetworkAccess.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.NetworkAccess.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reports in networkAccess
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.Networkaccess.Reports body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.Networkaccess.Reports body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Represents the status of the Global Secure Access services for the tenant.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReportsRequestBuilderGetQueryParameters 
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
