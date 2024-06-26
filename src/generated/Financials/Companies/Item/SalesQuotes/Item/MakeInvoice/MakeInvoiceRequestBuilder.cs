// <auto-generated/>
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Financials.Companies.Item.SalesQuotes.Item.MakeInvoice
{
    /// <summary>
    /// Provides operations to call the makeInvoice method.
    /// </summary>
    public class MakeInvoiceRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action makeInvoice
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action makeInvoice";
            var companyIdOption = new Option<Guid?>("--company-id", description: "The unique identifier of company") {
            };
            companyIdOption.IsRequired = true;
            command.AddOption(companyIdOption);
            var salesQuoteIdOption = new Option<Guid?>("--sales-quote-id", description: "The unique identifier of salesQuote") {
            };
            salesQuoteIdOption.IsRequired = true;
            command.AddOption(salesQuoteIdOption);
            command.SetHandler(async (invocationContext) => {
                var companyId = invocationContext.ParseResult.GetValueForOption(companyIdOption);
                var salesQuoteId = invocationContext.ParseResult.GetValueForOption(salesQuoteIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (companyId is not null) requestInfo.PathParameters.Add("company%2Did", companyId);
                if (salesQuoteId is not null) requestInfo.PathParameters.Add("salesQuote%2Did", salesQuoteId);
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
        /// Instantiates a new <see cref="MakeInvoiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MakeInvoiceRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/financials/companies/{company%2Did}/salesQuotes/{salesQuote%2Did}/makeInvoice", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MakeInvoiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MakeInvoiceRequestBuilder(string rawUrl) : base("{+baseurl}/financials/companies/{company%2Did}/salesQuotes/{salesQuote%2Did}/makeInvoice", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action makeInvoice
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
