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
namespace ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.SendActivityNotification {
    /// <summary>
    /// Provides operations to call the sendActivityNotification method.
    /// </summary>
    public class SendActivityNotificationRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Send an activity feed notification in the scope of a team. For more information, see sending Teams activity notifications.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/team-sendactivitynotification?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Send an activity feed notification in the scope of a team. For more information, see sending Teams activity notifications.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/team-sendactivitynotification?view=graph-rest-1.0";
            var teamTemplateDefinitionIdOption = new Option<string>("--team-template-definition-id", description: "The unique identifier of teamTemplateDefinition") {
            };
            teamTemplateDefinitionIdOption.IsRequired = true;
            command.AddOption(teamTemplateDefinitionIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var teamTemplateDefinitionId = invocationContext.ParseResult.GetValueForOption(teamTemplateDefinitionIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<SendActivityNotificationPostRequestBody>(SendActivityNotificationPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (teamTemplateDefinitionId is not null) requestInfo.PathParameters.Add("teamTemplateDefinition%2Did", teamTemplateDefinitionId);
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
        /// Instantiates a new <see cref="SendActivityNotificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SendActivityNotificationRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/sendActivityNotification", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SendActivityNotificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SendActivityNotificationRequestBuilder(string rawUrl) : base("{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/sendActivityNotification", rawUrl)
        {
        }
        /// <summary>
        /// Send an activity feed notification in the scope of a team. For more information, see sending Teams activity notifications.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(SendActivityNotificationPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(SendActivityNotificationPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}