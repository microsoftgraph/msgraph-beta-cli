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
namespace ApiSdk.Users.Item.MailFolders.Item.ChildFolders.Item.PermanentDelete
{
    /// <summary>
    /// Provides operations to call the permanentDelete method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PermanentDeleteRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Permanently delete a mail folder and remove its items from the user&apos;s mailbox. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/mailfolder-permanentdelete?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Permanently delete a mail folder and remove its items from the user's mailbox. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/mailfolder-permanentdelete?view=graph-rest-beta";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var mailFolderIdOption = new Option<string>("--mail-folder-id", description: "The unique identifier of mailFolder") {
            };
            mailFolderIdOption.IsRequired = true;
            command.AddOption(mailFolderIdOption);
            var mailFolderId1Option = new Option<string>("--mail-folder-id1", description: "The unique identifier of mailFolder") {
            };
            mailFolderId1Option.IsRequired = true;
            command.AddOption(mailFolderId1Option);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var mailFolderId = invocationContext.ParseResult.GetValueForOption(mailFolderIdOption);
                var mailFolderId1 = invocationContext.ParseResult.GetValueForOption(mailFolderId1Option);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (mailFolderId is not null) requestInfo.PathParameters.Add("mailFolder%2Did", mailFolderId);
                if (mailFolderId1 is not null) requestInfo.PathParameters.Add("mailFolder%2Did1", mailFolderId1);
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
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.MailFolders.Item.ChildFolders.Item.PermanentDelete.PermanentDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PermanentDeleteRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/childFolders/{mailFolder%2Did1}/permanentDelete", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.MailFolders.Item.ChildFolders.Item.PermanentDelete.PermanentDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PermanentDeleteRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/childFolders/{mailFolder%2Did1}/permanentDelete", rawUrl)
        {
        }
        /// <summary>
        /// Permanently delete a mail folder and remove its items from the user&apos;s mailbox. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.
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
