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
namespace ApiSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles.Item.SetPriority
{
    /// <summary>
    /// Provides operations to call the setPriority method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SetPriorityRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action setPriority
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action setPriority";
            var appleUserInitiatedEnrollmentProfileIdOption = new Option<string>("--apple-user-initiated-enrollment-profile-id", description: "The unique identifier of appleUserInitiatedEnrollmentProfile") {
            };
            appleUserInitiatedEnrollmentProfileIdOption.IsRequired = true;
            command.AddOption(appleUserInitiatedEnrollmentProfileIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var appleUserInitiatedEnrollmentProfileId = invocationContext.ParseResult.GetValueForOption(appleUserInitiatedEnrollmentProfileIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles.Item.SetPriority.SetPriorityPostRequestBody>(global::ApiSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles.Item.SetPriority.SetPriorityPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (appleUserInitiatedEnrollmentProfileId is not null) requestInfo.PathParameters.Add("appleUserInitiatedEnrollmentProfile%2Did", appleUserInitiatedEnrollmentProfileId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles.Item.SetPriority.SetPriorityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SetPriorityRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/appleUserInitiatedEnrollmentProfiles/{appleUserInitiatedEnrollmentProfile%2Did}/setPriority", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles.Item.SetPriority.SetPriorityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SetPriorityRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/appleUserInitiatedEnrollmentProfiles/{appleUserInitiatedEnrollmentProfile%2Did}/setPriority", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action setPriority
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles.Item.SetPriority.SetPriorityPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.DeviceManagement.AppleUserInitiatedEnrollmentProfiles.Item.SetPriority.SetPriorityPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
