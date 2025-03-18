// <auto-generated/>
#pragma warning disable CS0618
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
namespace ApiSdk.DataClassification.ExactMatchDataStores.Item.Sessions.Item.Commit
{
    /// <summary>
    /// Provides operations to call the commit method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CommitRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action commit
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action commit";
            var exactMatchDataStoreIdOption = new Option<string>("--exact-match-data-store-id", description: "The unique identifier of exactMatchDataStore") {
            };
            exactMatchDataStoreIdOption.IsRequired = true;
            command.AddOption(exactMatchDataStoreIdOption);
            var exactMatchSessionIdOption = new Option<string>("--exact-match-session-id", description: "The unique identifier of exactMatchSession") {
            };
            exactMatchSessionIdOption.IsRequired = true;
            command.AddOption(exactMatchSessionIdOption);
            command.SetHandler(async (invocationContext) => {
                var exactMatchDataStoreId = invocationContext.ParseResult.GetValueForOption(exactMatchDataStoreIdOption);
                var exactMatchSessionId = invocationContext.ParseResult.GetValueForOption(exactMatchSessionIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (exactMatchDataStoreId is not null) requestInfo.PathParameters.Add("exactMatchDataStore%2Did", exactMatchDataStoreId);
                if (exactMatchSessionId is not null) requestInfo.PathParameters.Add("exactMatchSession%2Did", exactMatchSessionId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DataClassification.ExactMatchDataStores.Item.Sessions.Item.Commit.CommitRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CommitRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/dataClassification/exactMatchDataStores/{exactMatchDataStore%2Did}/sessions/{exactMatchSession%2Did}/commit", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DataClassification.ExactMatchDataStores.Item.Sessions.Item.Commit.CommitRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CommitRequestBuilder(string rawUrl) : base("{+baseurl}/dataClassification/exactMatchDataStores/{exactMatchDataStore%2Did}/sessions/{exactMatchSession%2Did}/commit", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action commit
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
#pragma warning restore CS0618
