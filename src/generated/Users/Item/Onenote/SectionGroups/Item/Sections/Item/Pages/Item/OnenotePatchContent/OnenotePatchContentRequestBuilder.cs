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
namespace ApiSdk.Users.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent
{
    /// <summary>
    /// Provides operations to call the onenotePatchContent method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OnenotePatchContentRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action onenotePatchContent
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action onenotePatchContent";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var sectionGroupIdOption = new Option<string>("--section-group-id", description: "The unique identifier of sectionGroup") {
            };
            sectionGroupIdOption.IsRequired = true;
            command.AddOption(sectionGroupIdOption);
            var onenoteSectionIdOption = new Option<string>("--onenote-section-id", description: "The unique identifier of onenoteSection") {
            };
            onenoteSectionIdOption.IsRequired = true;
            command.AddOption(onenoteSectionIdOption);
            var onenotePageIdOption = new Option<string>("--onenote-page-id", description: "The unique identifier of onenotePage") {
            };
            onenotePageIdOption.IsRequired = true;
            command.AddOption(onenotePageIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var sectionGroupId = invocationContext.ParseResult.GetValueForOption(sectionGroupIdOption);
                var onenoteSectionId = invocationContext.ParseResult.GetValueForOption(onenoteSectionIdOption);
                var onenotePageId = invocationContext.ParseResult.GetValueForOption(onenotePageIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Users.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent.OnenotePatchContentPostRequestBody>(global::ApiSdk.Users.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent.OnenotePatchContentPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (sectionGroupId is not null) requestInfo.PathParameters.Add("sectionGroup%2Did", sectionGroupId);
                if (onenoteSectionId is not null) requestInfo.PathParameters.Add("onenoteSection%2Did", onenoteSectionId);
                if (onenotePageId is not null) requestInfo.PathParameters.Add("onenotePage%2Did", onenotePageId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent.OnenotePatchContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public OnenotePatchContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/onenote/sectionGroups/{sectionGroup%2Did}/sections/{onenoteSection%2Did}/pages/{onenotePage%2Did}/onenotePatchContent", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent.OnenotePatchContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OnenotePatchContentRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/onenote/sectionGroups/{sectionGroup%2Did}/sections/{onenoteSection%2Did}/pages/{onenotePage%2Did}/onenotePatchContent", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action onenotePatchContent
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Users.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent.OnenotePatchContentPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Users.Item.Onenote.SectionGroups.Item.Sections.Item.Pages.Item.OnenotePatchContent.OnenotePatchContentPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
