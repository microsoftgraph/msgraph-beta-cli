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
namespace ApiSdk.Groups.Item.Sites.Item.Archive
{
    /// <summary>
    /// Provides operations to call the archive method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ArchiveRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Archive an active SharePoint site.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-archive?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Archive an active SharePoint site.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/site-archive?view=graph-rest-beta";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Groups.Item.Sites.Item.Archive.ArchiveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ArchiveRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/archive", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Groups.Item.Sites.Item.Archive.ArchiveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ArchiveRequestBuilder(string rawUrl) : base("{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/archive", rawUrl)
        {
        }
        /// <summary>
        /// Archive an active SharePoint site.
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
