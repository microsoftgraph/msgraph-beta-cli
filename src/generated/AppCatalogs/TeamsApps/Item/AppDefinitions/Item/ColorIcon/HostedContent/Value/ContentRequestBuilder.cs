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
namespace ApiSdk.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.ColorIcon.HostedContent.Value
{
    /// <summary>
    /// Provides operations to manage the media for the appCatalogs entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ContentRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The contents of the app icon if the icon is hosted within the Teams infrastructure.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "The contents of the app icon if the icon is hosted within the Teams infrastructure.";
            var teamsAppIdOption = new Option<string>("--teams-app-id", description: "The unique identifier of teamsApp") {
            };
            teamsAppIdOption.IsRequired = true;
            command.AddOption(teamsAppIdOption);
            var teamsAppDefinitionIdOption = new Option<string>("--teams-app-definition-id", description: "The unique identifier of teamsAppDefinition") {
            };
            teamsAppDefinitionIdOption.IsRequired = true;
            command.AddOption(teamsAppDefinitionIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var teamsAppId = invocationContext.ParseResult.GetValueForOption(teamsAppIdOption);
                var teamsAppDefinitionId = invocationContext.ParseResult.GetValueForOption(teamsAppDefinitionIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (teamsAppId is not null) requestInfo.PathParameters.Add("teamsApp%2Did", teamsAppId);
                if (teamsAppDefinitionId is not null) requestInfo.PathParameters.Add("teamsAppDefinition%2Did", teamsAppDefinitionId);
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
        /// Retrieve the hosted content in an app&apos;s icon.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/teamworkhostedcontent-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Retrieve the hosted content in an app's icon.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/teamworkhostedcontent-get?view=graph-rest-beta";
            var teamsAppIdOption = new Option<string>("--teams-app-id", description: "The unique identifier of teamsApp") {
            };
            teamsAppIdOption.IsRequired = true;
            command.AddOption(teamsAppIdOption);
            var teamsAppDefinitionIdOption = new Option<string>("--teams-app-definition-id", description: "The unique identifier of teamsAppDefinition") {
            };
            teamsAppDefinitionIdOption.IsRequired = true;
            command.AddOption(teamsAppDefinitionIdOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var teamsAppId = invocationContext.ParseResult.GetValueForOption(teamsAppIdOption);
                var teamsAppDefinitionId = invocationContext.ParseResult.GetValueForOption(teamsAppDefinitionIdOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (teamsAppId is not null) requestInfo.PathParameters.Add("teamsApp%2Did", teamsAppId);
                if (teamsAppDefinitionId is not null) requestInfo.PathParameters.Add("teamsAppDefinition%2Did", teamsAppDefinitionId);
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
        /// The contents of the app icon if the icon is hosted within the Teams infrastructure.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPutCommand()
        {
            var command = new Command("put");
            command.Description = "The contents of the app icon if the icon is hosted within the Teams infrastructure.";
            var teamsAppIdOption = new Option<string>("--teams-app-id", description: "The unique identifier of teamsApp") {
            };
            teamsAppIdOption.IsRequired = true;
            command.AddOption(teamsAppIdOption);
            var teamsAppDefinitionIdOption = new Option<string>("--teams-app-definition-id", description: "The unique identifier of teamsAppDefinition") {
            };
            teamsAppDefinitionIdOption.IsRequired = true;
            command.AddOption(teamsAppDefinitionIdOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var teamsAppId = invocationContext.ParseResult.GetValueForOption(teamsAppIdOption);
                var teamsAppDefinitionId = invocationContext.ParseResult.GetValueForOption(teamsAppDefinitionIdOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) {
                    Console.Error.WriteLine("No available file to send.");
                    return;
                }
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (teamsAppId is not null) requestInfo.PathParameters.Add("teamsApp%2Did", teamsAppId);
                if (teamsAppDefinitionId is not null) requestInfo.PathParameters.Add("teamsAppDefinition%2Did", teamsAppDefinitionId);
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
        /// Instantiates a new <see cref="global::ApiSdk.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.ColorIcon.HostedContent.Value.ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/appCatalogs/teamsApps/{teamsApp%2Did}/appDefinitions/{teamsAppDefinition%2Did}/colorIcon/hostedContent/$value", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.ColorIcon.HostedContent.Value.ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContentRequestBuilder(string rawUrl) : base("{+baseurl}/appCatalogs/teamsApps/{teamsApp%2Did}/appDefinitions/{teamsAppDefinition%2Did}/colorIcon/hostedContent/$value", rawUrl)
        {
        }
        /// <summary>
        /// The contents of the app icon if the icon is hosted within the Teams infrastructure.
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
        /// Retrieve the hosted content in an app&apos;s icon.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream, application/json");
            return requestInfo;
        }
        /// <summary>
        /// The contents of the app icon if the icon is hosted within the Teams infrastructure.
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
    }
}
#pragma warning restore CS0618
