// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.Storage.FileStorage.DeletedContainers.Item.Drive.List.Items.Item.CreateLink
{
    /// <summary>
    /// Provides operations to call the createLink method.
    /// </summary>
    public class CreateLinkRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Create a sharing link for a listItem. The createLink action creates a new sharing link if the specified link type doesn&apos;t already exist for the calling application.If a sharing link of the specified type already exists for the app, this action returns the existing sharing link. listItem resources inherit sharing permissions from the list the item resides in.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/listitem-createlink?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Create a sharing link for a listItem. The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.If a sharing link of the specified type already exists for the app, this action returns the existing sharing link. listItem resources inherit sharing permissions from the list the item resides in.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/listitem-createlink?view=graph-rest-beta";
            var fileStorageContainerIdOption = new Option<string>("--file-storage-container-id", description: "The unique identifier of fileStorageContainer") {
            };
            fileStorageContainerIdOption.IsRequired = true;
            command.AddOption(fileStorageContainerIdOption);
            var listItemIdOption = new Option<string>("--list-item-id", description: "The unique identifier of listItem") {
            };
            listItemIdOption.IsRequired = true;
            command.AddOption(listItemIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var fileStorageContainerId = invocationContext.ParseResult.GetValueForOption(fileStorageContainerIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CreateLinkPostRequestBody>(CreateLinkPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (fileStorageContainerId is not null) requestInfo.PathParameters.Add("fileStorageContainer%2Did", fileStorageContainerId);
                if (listItemId is not null) requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="CreateLinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CreateLinkRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/storage/fileStorage/deletedContainers/{fileStorageContainer%2Did}/drive/list/items/{listItem%2Did}/createLink", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CreateLinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CreateLinkRequestBuilder(string rawUrl) : base("{+baseurl}/storage/fileStorage/deletedContainers/{fileStorageContainer%2Did}/drive/list/items/{listItem%2Did}/createLink", rawUrl)
        {
        }
        /// <summary>
        /// Create a sharing link for a listItem. The createLink action creates a new sharing link if the specified link type doesn&apos;t already exist for the calling application.If a sharing link of the specified type already exists for the app, this action returns the existing sharing link. listItem resources inherit sharing permissions from the list the item resides in.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateLinkPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateLinkPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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