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
namespace ApiSdk.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId
{
    /// <summary>
    /// Provides operations to call the wipeManagedAppRegistrationsByAzureAdDeviceId method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Issues a wipe operation on an app registration with specified aad device Id.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Issues a wipe operation on an app registration with specified aad device Id.";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId.WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody>(global::ApiSdk.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId.WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId.WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/wipeManagedAppRegistrationsByAzureAdDeviceId", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId.WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/wipeManagedAppRegistrationsByAzureAdDeviceId", rawUrl)
        {
        }
        /// <summary>
        /// Issues a wipe operation on an app registration with specified aad device Id.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId.WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Users.Item.WipeManagedAppRegistrationsByAzureAdDeviceId.WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
