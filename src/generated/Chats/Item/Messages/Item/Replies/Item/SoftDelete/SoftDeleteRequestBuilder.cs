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
namespace ApiSdk.Chats.Item.Messages.Item.Replies.Item.SoftDelete
{
    /// <summary>
    /// Provides operations to call the softDelete method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SoftDeleteRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete a single chatMessage or a chat message reply in a channel or a chat.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/chatmessage-softdelete?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Delete a single chatMessage or a chat message reply in a channel or a chat.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/chatmessage-softdelete?view=graph-rest-beta";
            var chatIdOption = new Option<string>("--chat-id", description: "The unique identifier of chat") {
            };
            chatIdOption.IsRequired = true;
            command.AddOption(chatIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "The unique identifier of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            var chatMessageId1Option = new Option<string>("--chat-message-id1", description: "The unique identifier of chatMessage") {
            };
            chatMessageId1Option.IsRequired = true;
            command.AddOption(chatMessageId1Option);
            command.SetHandler(async (invocationContext) => {
                var chatId = invocationContext.ParseResult.GetValueForOption(chatIdOption);
                var chatMessageId = invocationContext.ParseResult.GetValueForOption(chatMessageIdOption);
                var chatMessageId1 = invocationContext.ParseResult.GetValueForOption(chatMessageId1Option);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (chatId is not null) requestInfo.PathParameters.Add("chat%2Did", chatId);
                if (chatMessageId is not null) requestInfo.PathParameters.Add("chatMessage%2Did", chatMessageId);
                if (chatMessageId1 is not null) requestInfo.PathParameters.Add("chatMessage%2Did1", chatMessageId1);
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
        /// Instantiates a new <see cref="global::ApiSdk.Chats.Item.Messages.Item.Replies.Item.SoftDelete.SoftDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SoftDeleteRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/chats/{chat%2Did}/messages/{chatMessage%2Did}/replies/{chatMessage%2Did1}/softDelete", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Chats.Item.Messages.Item.Replies.Item.SoftDelete.SoftDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SoftDeleteRequestBuilder(string rawUrl) : base("{+baseurl}/chats/{chat%2Did}/messages/{chatMessage%2Did}/replies/{chatMessage%2Did1}/softDelete", rawUrl)
        {
        }
        /// <summary>
        /// Delete a single chatMessage or a chat message reply in a channel or a chat.
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
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
