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
namespace ApiSdk.Communications.Presences.Item.SetStatusMessage
{
    /// <summary>
    /// Provides operations to call the setStatusMessage method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SetStatusMessageRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Set a presence status message for a user. An optional expiration date and time can be supplied.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/presence-setstatusmessage?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Set a presence status message for a user. An optional expiration date and time can be supplied.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/presence-setstatusmessage?view=graph-rest-beta";
            var presenceIdOption = new Option<string>("--presence-id", description: "The unique identifier of presence") {
            };
            presenceIdOption.IsRequired = true;
            command.AddOption(presenceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var presenceId = invocationContext.ParseResult.GetValueForOption(presenceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Communications.Presences.Item.SetStatusMessage.SetStatusMessagePostRequestBody>(global::ApiSdk.Communications.Presences.Item.SetStatusMessage.SetStatusMessagePostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (presenceId is not null) requestInfo.PathParameters.Add("presence%2Did", presenceId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="global::ApiSdk.Communications.Presences.Item.SetStatusMessage.SetStatusMessageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SetStatusMessageRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/communications/presences/{presence%2Did}/setStatusMessage", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Communications.Presences.Item.SetStatusMessage.SetStatusMessageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SetStatusMessageRequestBuilder(string rawUrl) : base("{+baseurl}/communications/presences/{presence%2Did}/setStatusMessage", rawUrl)
        {
        }
        /// <summary>
        /// Set a presence status message for a user. An optional expiration date and time can be supplied.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Communications.Presences.Item.SetStatusMessage.SetStatusMessagePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Communications.Presences.Item.SetStatusMessage.SetStatusMessagePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
