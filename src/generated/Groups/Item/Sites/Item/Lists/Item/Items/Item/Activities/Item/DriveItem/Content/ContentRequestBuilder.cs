// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.Groups.Item.Sites.Item.Lists.Item.Items.Item.Activities.Item.DriveItem.Content
{
    /// <summary>
    /// Provides operations to manage the media for the group entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ContentRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
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
            var itemActivityOLDIdOption = new Option<string>("--item-activity-oldid", description: "The unique identifier of itemActivityOLD") {
            };
            itemActivityOLDIdOption.IsRequired = true;
            command.AddOption(itemActivityOLDIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var listId = invocationContext.ParseResult.GetValueForOption(listIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var itemActivityOLDId = invocationContext.ParseResult.GetValueForOption(itemActivityOLDIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (listId is not null) requestInfo.PathParameters.Add("list%2Did", listId);
                if (listItemId is not null) requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                if (itemActivityOLDId is not null) requestInfo.PathParameters.Add("itemActivityOLD%2Did", itemActivityOLDId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
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
        /// The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
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
            var itemActivityOLDIdOption = new Option<string>("--item-activity-oldid", description: "The unique identifier of itemActivityOLD") {
            };
            itemActivityOLDIdOption.IsRequired = true;
            command.AddOption(itemActivityOLDIdOption);
            var formatOption = new Option<string>("--format", description: "Format of the content") {
            };
            formatOption.IsRequired = false;
            command.AddOption(formatOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var listId = invocationContext.ParseResult.GetValueForOption(listIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var itemActivityOLDId = invocationContext.ParseResult.GetValueForOption(itemActivityOLDIdOption);
                var format = invocationContext.ParseResult.GetValueForOption(formatOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(format)) q.QueryParameters.Format = format;
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (listId is not null) requestInfo.PathParameters.Add("list%2Did", listId);
                if (listItemId is not null) requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                if (itemActivityOLDId is not null) requestInfo.PathParameters.Add("itemActivityOLD%2Did", itemActivityOLDId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPutCommand()
        {
            var command = new Command("put");
            command.Description = "The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
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
            var itemActivityOLDIdOption = new Option<string>("--item-activity-oldid", description: "The unique identifier of itemActivityOLD") {
            };
            itemActivityOLDIdOption.IsRequired = true;
            command.AddOption(itemActivityOLDIdOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var listId = invocationContext.ParseResult.GetValueForOption(listIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var itemActivityOLDId = invocationContext.ParseResult.GetValueForOption(itemActivityOLDIdOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) {
                    Console.Error.WriteLine("No available file to send.");
                    return;
                }
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (listId is not null) requestInfo.PathParameters.Add("list%2Did", listId);
                if (listItemId is not null) requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                if (itemActivityOLDId is not null) requestInfo.PathParameters.Add("itemActivityOLD%2Did", itemActivityOLDId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Groups.Item.Sites.Item.Lists.Item.Items.Item.Activities.Item.DriveItem.Content.ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/lists/{list%2Did}/items/{listItem%2Did}/activities/{itemActivityOLD%2Did}/driveItem/content{?%24format*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Groups.Item.Sites.Item.Lists.Item.Items.Item.Activities.Item.DriveItem.Content.ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContentRequestBuilder(string rawUrl) : base("{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/lists/{list%2Did}/items/{listItem%2Did}/activities/{itemActivityOLD%2Did}/driveItem/content{?%24format*}", rawUrl)
        {
        }
        /// <summary>
        /// The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Groups.Item.Sites.Item.Lists.Item.Items.Item.Activities.Item.DriveItem.Content.ContentRequestBuilder.ContentRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Groups.Item.Sites.Item.Lists.Item.Items.Item.Activities.Item.DriveItem.Content.ContentRequestBuilder.ContentRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream, application/json");
            return requestInfo;
        }
        /// <summary>
        /// The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// The content stream, if the item represents a file. The content property will have a potentially breaking change in behavior in the future. It will stream content directly instead of redirecting. To proactively opt in to the new behavior ahead of time, use the contentStream property instead.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ContentRequestBuilderGetQueryParameters 
        {
            /// <summary>Format of the content</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("%24format")]
            public string Format { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
