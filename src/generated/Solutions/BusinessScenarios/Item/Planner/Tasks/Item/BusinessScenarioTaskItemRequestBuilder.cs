// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Solutions.BusinessScenarios.Item.Planner.Tasks.Item.AssignedToTaskBoardFormat;
using ApiSdk.Solutions.BusinessScenarios.Item.Planner.Tasks.Item.BucketTaskBoardFormat;
using ApiSdk.Solutions.BusinessScenarios.Item.Planner.Tasks.Item.Details;
using ApiSdk.Solutions.BusinessScenarios.Item.Planner.Tasks.Item.ProgressTaskBoardFormat;
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
namespace ApiSdk.Solutions.BusinessScenarios.Item.Planner.Tasks.Item {
    /// <summary>
    /// Provides operations to manage the tasks property of the microsoft.graph.businessScenarioPlanner entity.
    /// </summary>
    public class BusinessScenarioTaskItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the assignedToTaskBoardFormat property of the microsoft.graph.plannerTask entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAssignedToTaskBoardFormatNavCommand()
        {
            var command = new Command("assigned-to-task-board-format");
            command.Description = "Provides operations to manage the assignedToTaskBoardFormat property of the microsoft.graph.plannerTask entity.";
            var builder = new AssignedToTaskBoardFormatRequestBuilder(PathParameters);
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
        /// Provides operations to manage the bucketTaskBoardFormat property of the microsoft.graph.plannerTask entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBucketTaskBoardFormatNavCommand()
        {
            var command = new Command("bucket-task-board-format");
            command.Description = "Provides operations to manage the bucketTaskBoardFormat property of the microsoft.graph.plannerTask entity.";
            var builder = new BucketTaskBoardFormatRequestBuilder(PathParameters);
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
        /// Delete a businessScenarioTask object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/businessscenarioplanner-delete-tasks?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete a businessScenarioTask object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/businessscenarioplanner-delete-tasks?view=graph-rest-1.0";
            var businessScenarioIdOption = new Option<string>("--business-scenario-id", description: "The unique identifier of businessScenario") {
            };
            businessScenarioIdOption.IsRequired = true;
            command.AddOption(businessScenarioIdOption);
            var businessScenarioTaskIdOption = new Option<string>("--business-scenario-task-id", description: "The unique identifier of businessScenarioTask") {
            };
            businessScenarioTaskIdOption.IsRequired = true;
            command.AddOption(businessScenarioTaskIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var businessScenarioId = invocationContext.ParseResult.GetValueForOption(businessScenarioIdOption);
                var businessScenarioTaskId = invocationContext.ParseResult.GetValueForOption(businessScenarioTaskIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (businessScenarioId is not null) requestInfo.PathParameters.Add("businessScenario%2Did", businessScenarioId);
                if (businessScenarioTaskId is not null) requestInfo.PathParameters.Add("businessScenarioTask%2Did", businessScenarioTaskId);
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
        /// Provides operations to manage the details property of the microsoft.graph.plannerTask entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDetailsNavCommand()
        {
            var command = new Command("details");
            command.Description = "Provides operations to manage the details property of the microsoft.graph.plannerTask entity.";
            var builder = new DetailsRequestBuilder(PathParameters);
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
        /// Read the properties and relationships of a businessScenarioTask object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/businessscenariotask-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of a businessScenarioTask object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/businessscenariotask-get?view=graph-rest-1.0";
            var businessScenarioIdOption = new Option<string>("--business-scenario-id", description: "The unique identifier of businessScenario") {
            };
            businessScenarioIdOption.IsRequired = true;
            command.AddOption(businessScenarioIdOption);
            var businessScenarioTaskIdOption = new Option<string>("--business-scenario-task-id", description: "The unique identifier of businessScenarioTask") {
            };
            businessScenarioTaskIdOption.IsRequired = true;
            command.AddOption(businessScenarioTaskIdOption);
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
                var businessScenarioId = invocationContext.ParseResult.GetValueForOption(businessScenarioIdOption);
                var businessScenarioTaskId = invocationContext.ParseResult.GetValueForOption(businessScenarioTaskIdOption);
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
                if (businessScenarioId is not null) requestInfo.PathParameters.Add("businessScenario%2Did", businessScenarioId);
                if (businessScenarioTaskId is not null) requestInfo.PathParameters.Add("businessScenarioTask%2Did", businessScenarioTaskId);
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
        /// Update the properties of a businessScenarioTask object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/businessscenariotask-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the properties of a businessScenarioTask object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/businessscenariotask-update?view=graph-rest-1.0";
            var businessScenarioIdOption = new Option<string>("--business-scenario-id", description: "The unique identifier of businessScenario") {
            };
            businessScenarioIdOption.IsRequired = true;
            command.AddOption(businessScenarioIdOption);
            var businessScenarioTaskIdOption = new Option<string>("--business-scenario-task-id", description: "The unique identifier of businessScenarioTask") {
            };
            businessScenarioTaskIdOption.IsRequired = true;
            command.AddOption(businessScenarioTaskIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var businessScenarioId = invocationContext.ParseResult.GetValueForOption(businessScenarioIdOption);
                var businessScenarioTaskId = invocationContext.ParseResult.GetValueForOption(businessScenarioTaskIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<BusinessScenarioTask>(BusinessScenarioTask.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (businessScenarioId is not null) requestInfo.PathParameters.Add("businessScenario%2Did", businessScenarioId);
                if (businessScenarioTaskId is not null) requestInfo.PathParameters.Add("businessScenarioTask%2Did", businessScenarioTaskId);
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
        /// Provides operations to manage the progressTaskBoardFormat property of the microsoft.graph.plannerTask entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildProgressTaskBoardFormatNavCommand()
        {
            var command = new Command("progress-task-board-format");
            command.Description = "Provides operations to manage the progressTaskBoardFormat property of the microsoft.graph.plannerTask entity.";
            var builder = new ProgressTaskBoardFormatRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="BusinessScenarioTaskItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public BusinessScenarioTaskItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/solutions/businessScenarios/{businessScenario%2Did}/planner/tasks/{businessScenarioTask%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BusinessScenarioTaskItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BusinessScenarioTaskItemRequestBuilder(string rawUrl) : base("{+baseurl}/solutions/businessScenarios/{businessScenario%2Did}/planner/tasks/{businessScenarioTask%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a businessScenarioTask object.
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/solutions/businessScenarios/{businessScenario%2Did}/planner/tasks/{businessScenarioTask%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a businessScenarioTask object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BusinessScenarioTaskItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BusinessScenarioTaskItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a businessScenarioTask object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(BusinessScenarioTask body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(BusinessScenarioTask body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/solutions/businessScenarios/{businessScenario%2Did}/planner/tasks/{businessScenarioTask%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a businessScenarioTask object.
        /// </summary>
        public class BusinessScenarioTaskItemRequestBuilderGetQueryParameters 
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