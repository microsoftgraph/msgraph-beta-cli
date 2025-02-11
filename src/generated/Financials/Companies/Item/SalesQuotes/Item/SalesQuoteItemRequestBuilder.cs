// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Financials.Companies.Item.SalesQuotes.Item.Currency;
using ApiSdk.Financials.Companies.Item.SalesQuotes.Item.Customer;
using ApiSdk.Financials.Companies.Item.SalesQuotes.Item.MakeInvoice;
using ApiSdk.Financials.Companies.Item.SalesQuotes.Item.PaymentTerm;
using ApiSdk.Financials.Companies.Item.SalesQuotes.Item.SalesQuoteLines;
using ApiSdk.Financials.Companies.Item.SalesQuotes.Item.Send;
using ApiSdk.Financials.Companies.Item.SalesQuotes.Item.ShipmentMethod;
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
namespace ApiSdk.Financials.Companies.Item.SalesQuotes.Item
{
    /// <summary>
    /// Provides operations to manage the salesQuotes property of the microsoft.graph.company entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SalesQuoteItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the currency property of the microsoft.graph.salesQuote entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCurrencyNavCommand()
        {
            var command = new Command("currency");
            command.Description = "Provides operations to manage the currency property of the microsoft.graph.salesQuote entity.";
            var builder = new global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.Currency.CurrencyRequestBuilder(PathParameters);
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
        /// Provides operations to manage the customer property of the microsoft.graph.salesQuote entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCustomerNavCommand()
        {
            var command = new Command("customer");
            command.Description = "Provides operations to manage the customer property of the microsoft.graph.salesQuote entity.";
            var builder = new global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.Customer.CustomerRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCurrencyNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPaymentMethodNavCommand());
            nonExecCommands.Add(builder.BuildPaymentTermNavCommand());
            nonExecCommands.Add(builder.BuildPictureNavCommand());
            nonExecCommands.Add(builder.BuildShipmentMethodNavCommand());
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
        /// Get salesQuotes from financials
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get salesQuotes from financials";
            var companyIdOption = new Option<Guid?>("--company-id", description: "The unique identifier of company") {
            };
            companyIdOption.IsRequired = true;
            command.AddOption(companyIdOption);
            var salesQuoteIdOption = new Option<Guid?>("--sales-quote-id", description: "The unique identifier of salesQuote") {
            };
            salesQuoteIdOption.IsRequired = true;
            command.AddOption(salesQuoteIdOption);
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
                var companyId = invocationContext.ParseResult.GetValueForOption(companyIdOption);
                var salesQuoteId = invocationContext.ParseResult.GetValueForOption(salesQuoteIdOption);
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
                if (companyId is not null) requestInfo.PathParameters.Add("company%2Did", companyId);
                if (salesQuoteId is not null) requestInfo.PathParameters.Add("salesQuote%2Did", salesQuoteId);
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
        /// Provides operations to call the makeInvoice method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMakeInvoiceNavCommand()
        {
            var command = new Command("make-invoice");
            command.Description = "Provides operations to call the makeInvoice method.";
            var builder = new global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.MakeInvoice.MakeInvoiceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property salesQuotes in financials
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property salesQuotes in financials";
            var companyIdOption = new Option<Guid?>("--company-id", description: "The unique identifier of company") {
            };
            companyIdOption.IsRequired = true;
            command.AddOption(companyIdOption);
            var salesQuoteIdOption = new Option<Guid?>("--sales-quote-id", description: "The unique identifier of salesQuote") {
            };
            salesQuoteIdOption.IsRequired = true;
            command.AddOption(salesQuoteIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var companyId = invocationContext.ParseResult.GetValueForOption(companyIdOption);
                var salesQuoteId = invocationContext.ParseResult.GetValueForOption(salesQuoteIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.SalesQuote>(global::ApiSdk.Models.SalesQuote.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (companyId is not null) requestInfo.PathParameters.Add("company%2Did", companyId);
                if (salesQuoteId is not null) requestInfo.PathParameters.Add("salesQuote%2Did", salesQuoteId);
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
        /// Provides operations to manage the paymentTerm property of the microsoft.graph.salesQuote entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPaymentTermNavCommand()
        {
            var command = new Command("payment-term");
            command.Description = "Provides operations to manage the paymentTerm property of the microsoft.graph.salesQuote entity.";
            var builder = new global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.PaymentTerm.PaymentTermRequestBuilder(PathParameters);
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
        /// Provides operations to manage the salesQuoteLines property of the microsoft.graph.salesQuote entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSalesQuoteLinesNavCommand()
        {
            var command = new Command("sales-quote-lines");
            command.Description = "Provides operations to manage the salesQuoteLines property of the microsoft.graph.salesQuote entity.";
            var builder = new global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.SalesQuoteLines.SalesQuoteLinesRequestBuilder(PathParameters);
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
        /// Provides operations to call the send method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSendNavCommand()
        {
            var command = new Command("send");
            command.Description = "Provides operations to call the send method.";
            var builder = new global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.Send.SendRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the shipmentMethod property of the microsoft.graph.salesQuote entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildShipmentMethodNavCommand()
        {
            var command = new Command("shipment-method");
            command.Description = "Provides operations to manage the shipmentMethod property of the microsoft.graph.salesQuote entity.";
            var builder = new global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.ShipmentMethod.ShipmentMethodRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.SalesQuoteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SalesQuoteItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/financials/companies/{company%2Did}/salesQuotes/{salesQuote%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.SalesQuoteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SalesQuoteItemRequestBuilder(string rawUrl) : base("{+baseurl}/financials/companies/{company%2Did}/salesQuotes/{salesQuote%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get salesQuotes from financials
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.SalesQuoteItemRequestBuilder.SalesQuoteItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Financials.Companies.Item.SalesQuotes.Item.SalesQuoteItemRequestBuilder.SalesQuoteItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property salesQuotes in financials
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.SalesQuote body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.SalesQuote body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get salesQuotes from financials
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SalesQuoteItemRequestBuilderGetQueryParameters 
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
