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
namespace ApiSdk.External.IndustryData.DataConnectors.Item.MicrosoftGraphIndustryDataValidate
{
    /// <summary>
    /// Provides operations to call the validate method.
    /// </summary>
    public class MicrosoftGraphIndustryDataValidateRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Perform validations applicable for the specific instance of the data connector.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/industrydata-industrydataconnector-validate?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Perform validations applicable for the specific instance of the data connector.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/industrydata-industrydataconnector-validate?view=graph-rest-beta";
            var industryDataConnectorIdOption = new Option<string>("--industry-data-connector-id", description: "The unique identifier of industryDataConnector") {
            };
            industryDataConnectorIdOption.IsRequired = true;
            command.AddOption(industryDataConnectorIdOption);
            command.SetHandler(async (invocationContext) => {
                var industryDataConnectorId = invocationContext.ParseResult.GetValueForOption(industryDataConnectorIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (industryDataConnectorId is not null) requestInfo.PathParameters.Add("industryDataConnector%2Did", industryDataConnectorId);
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
        /// Instantiates a new <see cref="MicrosoftGraphIndustryDataValidateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphIndustryDataValidateRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/external/industryData/dataConnectors/{industryDataConnector%2Did}/microsoft.graph.industryData.validate", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphIndustryDataValidateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphIndustryDataValidateRequestBuilder(string rawUrl) : base("{+baseurl}/external/industryData/dataConnectors/{industryDataConnector%2Did}/microsoft.graph.industryData.validate", rawUrl)
        {
        }
        /// <summary>
        /// Perform validations applicable for the specific instance of the data connector.
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
