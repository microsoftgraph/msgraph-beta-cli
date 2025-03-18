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
namespace ApiSdk.Users.Item.Outlook.TaskGroups.Item.TaskFolders.Item.PermanentDelete
{
    /// <summary>
    /// Provides operations to call the permanentDelete method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PermanentDeleteRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Permanently delete an outlook task folder and remove its items from the user&apos;s mailbox. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/outlooktaskfolder-permanentdelete?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The Outlook tasks API is deprecated and will stop returning data on February 20, 2023. Please use the new To Do API. For more details, please visit https://developer.microsoft.com/en-us/office/blogs/announcing-the-general-availability-of-microsoft-to-do-apis-on-graph/ as of 2020-08/Outlook_Tasks on 2021-02-20 and will be removed 2023-02-20")]
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Permanently delete an outlook task folder and remove its items from the user's mailbox. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/outlooktaskfolder-permanentdelete?view=graph-rest-beta";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var outlookTaskGroupIdOption = new Option<string>("--outlook-task-group-id", description: "The unique identifier of outlookTaskGroup") {
            };
            outlookTaskGroupIdOption.IsRequired = true;
            command.AddOption(outlookTaskGroupIdOption);
            var outlookTaskFolderIdOption = new Option<string>("--outlook-task-folder-id", description: "The unique identifier of outlookTaskFolder") {
            };
            outlookTaskFolderIdOption.IsRequired = true;
            command.AddOption(outlookTaskFolderIdOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var outlookTaskGroupId = invocationContext.ParseResult.GetValueForOption(outlookTaskGroupIdOption);
                var outlookTaskFolderId = invocationContext.ParseResult.GetValueForOption(outlookTaskFolderIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (outlookTaskGroupId is not null) requestInfo.PathParameters.Add("outlookTaskGroup%2Did", outlookTaskGroupId);
                if (outlookTaskFolderId is not null) requestInfo.PathParameters.Add("outlookTaskFolder%2Did", outlookTaskFolderId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Outlook.TaskGroups.Item.TaskFolders.Item.PermanentDelete.PermanentDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PermanentDeleteRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/outlook/taskGroups/{outlookTaskGroup%2Did}/taskFolders/{outlookTaskFolder%2Did}/permanentDelete", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Outlook.TaskGroups.Item.TaskFolders.Item.PermanentDelete.PermanentDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PermanentDeleteRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/outlook/taskGroups/{outlookTaskGroup%2Did}/taskFolders/{outlookTaskFolder%2Did}/permanentDelete", rawUrl)
        {
        }
        /// <summary>
        /// Permanently delete an outlook task folder and remove its items from the user&apos;s mailbox. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Outlook tasks API is deprecated and will stop returning data on February 20, 2023. Please use the new To Do API. For more details, please visit https://developer.microsoft.com/en-us/office/blogs/announcing-the-general-availability-of-microsoft-to-do-apis-on-graph/ as of 2020-08/Outlook_Tasks on 2021-02-20 and will be removed 2023-02-20")]
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
