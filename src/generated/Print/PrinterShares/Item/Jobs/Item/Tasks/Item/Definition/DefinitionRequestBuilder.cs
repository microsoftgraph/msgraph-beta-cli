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
namespace ApiSdk.Print.PrinterShares.Item.Jobs.Item.Tasks.Item.Definition
{
    /// <summary>
    /// Provides operations to manage the definition property of the microsoft.graph.printTask entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DefinitionRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The printerShares navigation property is deprecated and will stop returning data on July 31, 2023. Please use the shares navigation property instead of this. as of 2023-06/Tasks_And_Plans on 2023-06-13 and will be removed 2023-07-31")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The printTaskDefinition that was used to create this task. Read-only.";
            var printerShareIdOption = new Option<string>("--printer-share-id", description: "The unique identifier of printerShare") {
            };
            printerShareIdOption.IsRequired = true;
            command.AddOption(printerShareIdOption);
            var printJobIdOption = new Option<string>("--print-job-id", description: "The unique identifier of printJob") {
            };
            printJobIdOption.IsRequired = true;
            command.AddOption(printJobIdOption);
            var printTaskIdOption = new Option<string>("--print-task-id", description: "The unique identifier of printTask") {
            };
            printTaskIdOption.IsRequired = true;
            command.AddOption(printTaskIdOption);
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
                var printerShareId = invocationContext.ParseResult.GetValueForOption(printerShareIdOption);
                var printJobId = invocationContext.ParseResult.GetValueForOption(printJobIdOption);
                var printTaskId = invocationContext.ParseResult.GetValueForOption(printTaskIdOption);
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
                if (printerShareId is not null) requestInfo.PathParameters.Add("printerShare%2Did", printerShareId);
                if (printJobId is not null) requestInfo.PathParameters.Add("printJob%2Did", printJobId);
                if (printTaskId is not null) requestInfo.PathParameters.Add("printTask%2Did", printTaskId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Print.PrinterShares.Item.Jobs.Item.Tasks.Item.Definition.DefinitionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DefinitionRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/printerShares/{printerShare%2Did}/jobs/{printJob%2Did}/tasks/{printTask%2Did}/definition{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Print.PrinterShares.Item.Jobs.Item.Tasks.Item.Definition.DefinitionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DefinitionRequestBuilder(string rawUrl) : base("{+baseurl}/print/printerShares/{printerShare%2Did}/jobs/{printJob%2Did}/tasks/{printTask%2Did}/definition{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The printerShares navigation property is deprecated and will stop returning data on July 31, 2023. Please use the shares navigation property instead of this. as of 2023-06/Tasks_And_Plans on 2023-06-13 and will be removed 2023-07-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Print.PrinterShares.Item.Jobs.Item.Tasks.Item.Definition.DefinitionRequestBuilder.DefinitionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Print.PrinterShares.Item.Jobs.Item.Tasks.Item.Definition.DefinitionRequestBuilder.DefinitionRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DefinitionRequestBuilderGetQueryParameters 
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
