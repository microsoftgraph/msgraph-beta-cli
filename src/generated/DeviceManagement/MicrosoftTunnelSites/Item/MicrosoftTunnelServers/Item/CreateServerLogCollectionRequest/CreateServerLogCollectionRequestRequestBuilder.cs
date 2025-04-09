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
namespace ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.CreateServerLogCollectionRequest
{
    /// <summary>
    /// Provides operations to call the createServerLogCollectionRequest method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CreateServerLogCollectionRequestRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action createServerLogCollectionRequest
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action createServerLogCollectionRequest";
            var microsoftTunnelSiteIdOption = new Option<string>("--microsoft-tunnel-site-id", description: "The unique identifier of microsoftTunnelSite") {
            };
            microsoftTunnelSiteIdOption.IsRequired = true;
            command.AddOption(microsoftTunnelSiteIdOption);
            var microsoftTunnelServerIdOption = new Option<string>("--microsoft-tunnel-server-id", description: "The unique identifier of microsoftTunnelServer") {
            };
            microsoftTunnelServerIdOption.IsRequired = true;
            command.AddOption(microsoftTunnelServerIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var microsoftTunnelSiteId = invocationContext.ParseResult.GetValueForOption(microsoftTunnelSiteIdOption);
                var microsoftTunnelServerId = invocationContext.ParseResult.GetValueForOption(microsoftTunnelServerIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.CreateServerLogCollectionRequest.CreateServerLogCollectionRequestPostRequestBody>(global::ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.CreateServerLogCollectionRequest.CreateServerLogCollectionRequestPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (microsoftTunnelSiteId is not null) requestInfo.PathParameters.Add("microsoftTunnelSite%2Did", microsoftTunnelSiteId);
                if (microsoftTunnelServerId is not null) requestInfo.PathParameters.Add("microsoftTunnelServer%2Did", microsoftTunnelServerId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.CreateServerLogCollectionRequest.CreateServerLogCollectionRequestRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CreateServerLogCollectionRequestRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite%2Did}/microsoftTunnelServers/{microsoftTunnelServer%2Did}/createServerLogCollectionRequest", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.CreateServerLogCollectionRequest.CreateServerLogCollectionRequestRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CreateServerLogCollectionRequestRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite%2Did}/microsoftTunnelServers/{microsoftTunnelServer%2Did}/createServerLogCollectionRequest", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action createServerLogCollectionRequest
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.CreateServerLogCollectionRequest.CreateServerLogCollectionRequestPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.CreateServerLogCollectionRequest.CreateServerLogCollectionRequestPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
