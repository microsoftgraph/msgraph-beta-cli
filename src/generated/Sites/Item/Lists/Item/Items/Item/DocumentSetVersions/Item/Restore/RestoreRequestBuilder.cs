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
namespace ApiSdk.Sites.Item.Lists.Item.Items.Item.DocumentSetVersions.Item.Restore
{
    /// <summary>
    /// Provides operations to call the restore method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RestoreRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Restore a document set version.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/documentsetversion-restore?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Restore a document set version.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/documentsetversion-restore?view=graph-rest-beta";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var listIdOption = new Option<string>("--list-id", description: "The unique identifier of list") {
            };
            listIdOption.IsRequired = true;
            command.AddOption(listIdOption);
            var listItemIdOption = new Option<string>("--list-item-id", description: "The unique identifier of listItem") {
            };
            listItemIdOption.IsRequired = true;
            command.AddOption(listItemIdOption);
            var documentSetVersionIdOption = new Option<string>("--document-set-version-id", description: "The unique identifier of documentSetVersion") {
            };
            documentSetVersionIdOption.IsRequired = true;
            command.AddOption(documentSetVersionIdOption);
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var listId = invocationContext.ParseResult.GetValueForOption(listIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var documentSetVersionId = invocationContext.ParseResult.GetValueForOption(documentSetVersionIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (listId is not null) requestInfo.PathParameters.Add("list%2Did", listId);
                if (listItemId is not null) requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                if (documentSetVersionId is not null) requestInfo.PathParameters.Add("documentSetVersion%2Did", documentSetVersionId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.Lists.Item.Items.Item.DocumentSetVersions.Item.Restore.RestoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RestoreRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/items/{listItem%2Did}/documentSetVersions/{documentSetVersion%2Did}/restore", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.Lists.Item.Items.Item.DocumentSetVersions.Item.Restore.RestoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RestoreRequestBuilder(string rawUrl) : base("{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/items/{listItem%2Did}/documentSetVersions/{documentSetVersion%2Did}/restore", rawUrl)
        {
        }
        /// <summary>
        /// Restore a document set version.
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
