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
namespace ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.PrimaryChannel.Messages.Item.Replies.ForwardToChat
{
    /// <summary>
    /// Provides operations to call the forwardToChat method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ForwardToChatRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Forward a chat message, a channel message, or a channel message reply to a chat.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/chatmessage-forwardtochat?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Forward a chat message, a channel message, or a channel message reply to a chat.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/chatmessage-forwardtochat?view=graph-rest-beta";
            var teamTemplateIdOption = new Option<string>("--team-template-id", description: "The unique identifier of teamTemplate") {
            };
            teamTemplateIdOption.IsRequired = true;
            command.AddOption(teamTemplateIdOption);
            var teamTemplateDefinitionIdOption = new Option<string>("--team-template-definition-id", description: "The unique identifier of teamTemplateDefinition") {
            };
            teamTemplateDefinitionIdOption.IsRequired = true;
            command.AddOption(teamTemplateDefinitionIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "The unique identifier of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var teamTemplateId = invocationContext.ParseResult.GetValueForOption(teamTemplateIdOption);
                var teamTemplateDefinitionId = invocationContext.ParseResult.GetValueForOption(teamTemplateDefinitionIdOption);
                var chatMessageId = invocationContext.ParseResult.GetValueForOption(chatMessageIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                IPagingService pagingService = invocationContext.BindingContext.GetService(typeof(IPagingService)) as IPagingService ?? throw new ArgumentNullException("pagingService");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatPostRequestBody>(global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (teamTemplateId is not null) requestInfo.PathParameters.Add("teamTemplate%2Did", teamTemplateId);
                if (teamTemplateDefinitionId is not null) requestInfo.PathParameters.Add("teamTemplateDefinition%2Did", teamTemplateDefinitionId);
                if (chatMessageId is not null) requestInfo.PathParameters.Add("chatMessage%2Did", chatMessageId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => reqAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
#nullable enable
                IOutputFormatter? formatter = null;
#nullable restore
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ForwardToChatRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/primaryChannel/messages/{chatMessage%2Did}/replies/forwardToChat", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ForwardToChatRequestBuilder(string rawUrl) : base("{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/primaryChannel/messages/{chatMessage%2Did}/replies/forwardToChat", rawUrl)
        {
        }
        /// <summary>
        /// Forward a chat message, a channel message, or a channel message reply to a chat.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
#pragma warning restore CS0618
