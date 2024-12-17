// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.AppHealthMetrics;
using ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.BatteryHealthMetrics;
using ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.BestPracticesMetrics;
using ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.DeviceBootPerformanceMetrics;
using ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.RebootAnalyticsMetrics;
using ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.ResourcePerformanceMetrics;
using ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.WorkFromAnywhereMetrics;
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
namespace ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item
{
    /// <summary>
    /// Provides operations to manage the userExperienceAnalyticsBaselines property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserExperienceAnalyticsBaselineItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the appHealthMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAppHealthMetricsNavCommand()
        {
            var command = new Command("app-health-metrics");
            command.Description = "Provides operations to manage the appHealthMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.";
            var builder = new global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.AppHealthMetrics.AppHealthMetricsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the batteryHealthMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBatteryHealthMetricsNavCommand()
        {
            var command = new Command("battery-health-metrics");
            command.Description = "Provides operations to manage the batteryHealthMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.";
            var builder = new global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.BatteryHealthMetrics.BatteryHealthMetricsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the bestPracticesMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBestPracticesMetricsNavCommand()
        {
            var command = new Command("best-practices-metrics");
            command.Description = "Provides operations to manage the bestPracticesMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.";
            var builder = new global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.BestPracticesMetrics.BestPracticesMetricsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property userExperienceAnalyticsBaselines for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property userExperienceAnalyticsBaselines for deviceManagement";
            var userExperienceAnalyticsBaselineIdOption = new Option<string>("--user-experience-analytics-baseline-id", description: "The unique identifier of userExperienceAnalyticsBaseline") {
            };
            userExperienceAnalyticsBaselineIdOption.IsRequired = true;
            command.AddOption(userExperienceAnalyticsBaselineIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var userExperienceAnalyticsBaselineId = invocationContext.ParseResult.GetValueForOption(userExperienceAnalyticsBaselineIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (userExperienceAnalyticsBaselineId is not null) requestInfo.PathParameters.Add("userExperienceAnalyticsBaseline%2Did", userExperienceAnalyticsBaselineId);
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
        /// Provides operations to manage the deviceBootPerformanceMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeviceBootPerformanceMetricsNavCommand()
        {
            var command = new Command("device-boot-performance-metrics");
            command.Description = "Provides operations to manage the deviceBootPerformanceMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.";
            var builder = new global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.DeviceBootPerformanceMetrics.DeviceBootPerformanceMetricsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// User experience analytics baselines
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "User experience analytics baselines";
            var userExperienceAnalyticsBaselineIdOption = new Option<string>("--user-experience-analytics-baseline-id", description: "The unique identifier of userExperienceAnalyticsBaseline") {
            };
            userExperienceAnalyticsBaselineIdOption.IsRequired = true;
            command.AddOption(userExperienceAnalyticsBaselineIdOption);
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
                var userExperienceAnalyticsBaselineId = invocationContext.ParseResult.GetValueForOption(userExperienceAnalyticsBaselineIdOption);
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
                if (userExperienceAnalyticsBaselineId is not null) requestInfo.PathParameters.Add("userExperienceAnalyticsBaseline%2Did", userExperienceAnalyticsBaselineId);
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
        /// Update the navigation property userExperienceAnalyticsBaselines in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property userExperienceAnalyticsBaselines in deviceManagement";
            var userExperienceAnalyticsBaselineIdOption = new Option<string>("--user-experience-analytics-baseline-id", description: "The unique identifier of userExperienceAnalyticsBaseline") {
            };
            userExperienceAnalyticsBaselineIdOption.IsRequired = true;
            command.AddOption(userExperienceAnalyticsBaselineIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var userExperienceAnalyticsBaselineId = invocationContext.ParseResult.GetValueForOption(userExperienceAnalyticsBaselineIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.UserExperienceAnalyticsBaseline>(global::ApiSdk.Models.UserExperienceAnalyticsBaseline.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (userExperienceAnalyticsBaselineId is not null) requestInfo.PathParameters.Add("userExperienceAnalyticsBaseline%2Did", userExperienceAnalyticsBaselineId);
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
        /// Provides operations to manage the rebootAnalyticsMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRebootAnalyticsMetricsNavCommand()
        {
            var command = new Command("reboot-analytics-metrics");
            command.Description = "Provides operations to manage the rebootAnalyticsMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.";
            var builder = new global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.RebootAnalyticsMetrics.RebootAnalyticsMetricsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the resourcePerformanceMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResourcePerformanceMetricsNavCommand()
        {
            var command = new Command("resource-performance-metrics");
            command.Description = "Provides operations to manage the resourcePerformanceMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.";
            var builder = new global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.ResourcePerformanceMetrics.ResourcePerformanceMetricsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the workFromAnywhereMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWorkFromAnywhereMetricsNavCommand()
        {
            var command = new Command("work-from-anywhere-metrics");
            command.Description = "Provides operations to manage the workFromAnywhereMetrics property of the microsoft.graph.userExperienceAnalyticsBaseline entity.";
            var builder = new global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.WorkFromAnywhereMetrics.WorkFromAnywhereMetricsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.UserExperienceAnalyticsBaselineItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UserExperienceAnalyticsBaselineItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/userExperienceAnalyticsBaselines/{userExperienceAnalyticsBaseline%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.UserExperienceAnalyticsBaselineItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UserExperienceAnalyticsBaselineItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/userExperienceAnalyticsBaselines/{userExperienceAnalyticsBaseline%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property userExperienceAnalyticsBaselines for deviceManagement
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
        /// User experience analytics baselines
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.UserExperienceAnalyticsBaselineItemRequestBuilder.UserExperienceAnalyticsBaselineItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.UserExperienceAnalyticsBaselines.Item.UserExperienceAnalyticsBaselineItemRequestBuilder.UserExperienceAnalyticsBaselineItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property userExperienceAnalyticsBaselines in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UserExperienceAnalyticsBaseline body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.UserExperienceAnalyticsBaseline body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// User experience analytics baselines
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UserExperienceAnalyticsBaselineItemRequestBuilderGetQueryParameters 
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
