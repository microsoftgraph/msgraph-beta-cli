// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.AddToReviewSetOperation;
using ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.AdditionalSources;
using ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.CustodianSources;
using ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.LastEstimateStatisticsOperation;
using ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.MicrosoftGraphEdiscoveryEstimateStatistics;
using ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.MicrosoftGraphEdiscoveryPurgeData;
using ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.NoncustodialSources;
using ApiSdk.Models.Ediscovery;
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item
{
    /// <summary>
    /// Provides operations to manage the sourceCollections property of the microsoft.graph.ediscovery.case entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SourceCollectionItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the additionalSources property of the microsoft.graph.ediscovery.sourceCollection entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAdditionalSourcesNavCommand()
        {
            var command = new Command("additional-sources");
            command.Description = "Provides operations to manage the additionalSources property of the microsoft.graph.ediscovery.sourceCollection entity.";
            var builder = new global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.AdditionalSources.AdditionalSourcesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the addToReviewSetOperation property of the microsoft.graph.ediscovery.sourceCollection entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAddToReviewSetOperationNavCommand()
        {
            var command = new Command("add-to-review-set-operation");
            command.Description = "Provides operations to manage the addToReviewSetOperation property of the microsoft.graph.ediscovery.sourceCollection entity.";
            var builder = new global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.AddToReviewSetOperation.AddToReviewSetOperationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the custodianSources property of the microsoft.graph.ediscovery.sourceCollection entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCustodianSourcesNavCommand()
        {
            var command = new Command("custodian-sources");
            command.Description = "Provides operations to manage the custodianSources property of the microsoft.graph.ediscovery.sourceCollection entity.";
            var builder = new global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.CustodianSources.CustodianSourcesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
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
        /// Delete a sourceCollection object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/ediscovery-sourcecollection-delete?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete a sourceCollection object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/ediscovery-sourcecollection-delete?view=graph-rest-beta";
            var caseIdOption = new Option<string>("--case-id", description: "The unique identifier of case") {
            };
            caseIdOption.IsRequired = true;
            command.AddOption(caseIdOption);
            var sourceCollectionIdOption = new Option<string>("--source-collection-id", description: "The unique identifier of sourceCollection") {
            };
            sourceCollectionIdOption.IsRequired = true;
            command.AddOption(sourceCollectionIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var caseId = invocationContext.ParseResult.GetValueForOption(caseIdOption);
                var sourceCollectionId = invocationContext.ParseResult.GetValueForOption(sourceCollectionIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (caseId is not null) requestInfo.PathParameters.Add("case%2Did", caseId);
                if (sourceCollectionId is not null) requestInfo.PathParameters.Add("sourceCollection%2Did", sourceCollectionId);
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
        /// Returns a list of sourceCollection objects associated with this case.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Returns a list of sourceCollection objects associated with this case.";
            var caseIdOption = new Option<string>("--case-id", description: "The unique identifier of case") {
            };
            caseIdOption.IsRequired = true;
            command.AddOption(caseIdOption);
            var sourceCollectionIdOption = new Option<string>("--source-collection-id", description: "The unique identifier of sourceCollection") {
            };
            sourceCollectionIdOption.IsRequired = true;
            command.AddOption(sourceCollectionIdOption);
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
                var caseId = invocationContext.ParseResult.GetValueForOption(caseIdOption);
                var sourceCollectionId = invocationContext.ParseResult.GetValueForOption(sourceCollectionIdOption);
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
                if (caseId is not null) requestInfo.PathParameters.Add("case%2Did", caseId);
                if (sourceCollectionId is not null) requestInfo.PathParameters.Add("sourceCollection%2Did", sourceCollectionId);
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
        /// Provides operations to manage the lastEstimateStatisticsOperation property of the microsoft.graph.ediscovery.sourceCollection entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLastEstimateStatisticsOperationNavCommand()
        {
            var command = new Command("last-estimate-statistics-operation");
            command.Description = "Provides operations to manage the lastEstimateStatisticsOperation property of the microsoft.graph.ediscovery.sourceCollection entity.";
            var builder = new global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.LastEstimateStatisticsOperation.LastEstimateStatisticsOperationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the estimateStatistics method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphEdiscoveryEstimateStatisticsNavCommand()
        {
            var command = new Command("microsoft-graph-ediscovery-estimate-statistics");
            command.Description = "Provides operations to call the estimateStatistics method.";
            var builder = new global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.MicrosoftGraphEdiscoveryEstimateStatistics.MicrosoftGraphEdiscoveryEstimateStatisticsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the purgeData method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphEdiscoveryPurgeDataNavCommand()
        {
            var command = new Command("microsoft-graph-ediscovery-purge-data");
            command.Description = "Provides operations to call the purgeData method.";
            var builder = new global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.MicrosoftGraphEdiscoveryPurgeData.MicrosoftGraphEdiscoveryPurgeDataRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the noncustodialSources property of the microsoft.graph.ediscovery.sourceCollection entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildNoncustodialSourcesNavCommand()
        {
            var command = new Command("noncustodial-sources");
            command.Description = "Provides operations to manage the noncustodialSources property of the microsoft.graph.ediscovery.sourceCollection entity.";
            var builder = new global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.NoncustodialSources.NoncustodialSourcesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
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
        /// Update the properties of a sourceCollection object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/ediscovery-sourcecollection-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the properties of a sourceCollection object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/ediscovery-sourcecollection-update?view=graph-rest-beta";
            var caseIdOption = new Option<string>("--case-id", description: "The unique identifier of case") {
            };
            caseIdOption.IsRequired = true;
            command.AddOption(caseIdOption);
            var sourceCollectionIdOption = new Option<string>("--source-collection-id", description: "The unique identifier of sourceCollection") {
            };
            sourceCollectionIdOption.IsRequired = true;
            command.AddOption(sourceCollectionIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var caseId = invocationContext.ParseResult.GetValueForOption(caseIdOption);
                var sourceCollectionId = invocationContext.ParseResult.GetValueForOption(sourceCollectionIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.Ediscovery.SourceCollection>(global::ApiSdk.Models.Ediscovery.SourceCollection.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (caseId is not null) requestInfo.PathParameters.Add("case%2Did", caseId);
                if (sourceCollectionId is not null) requestInfo.PathParameters.Add("sourceCollection%2Did", sourceCollectionId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.SourceCollectionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SourceCollectionItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/compliance/ediscovery/cases/{case%2Did}/sourceCollections/{sourceCollection%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.SourceCollectionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SourceCollectionItemRequestBuilder(string rawUrl) : base("{+baseurl}/compliance/ediscovery/cases/{case%2Did}/sourceCollections/{sourceCollection%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a sourceCollection object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
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
        /// Returns a list of sourceCollection objects associated with this case.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.SourceCollectionItemRequestBuilder.SourceCollectionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Compliance.Ediscovery.Cases.Item.SourceCollections.Item.SourceCollectionItemRequestBuilder.SourceCollectionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a sourceCollection object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.Ediscovery.SourceCollection body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.Ediscovery.SourceCollection body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a list of sourceCollection objects associated with this case.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SourceCollectionItemRequestBuilderGetQueryParameters 
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
