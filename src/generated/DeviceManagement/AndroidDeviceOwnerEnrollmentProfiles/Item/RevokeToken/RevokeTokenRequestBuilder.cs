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
namespace ApiSdk.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles.Item.RevokeToken
{
    /// <summary>
    /// Provides operations to call the revokeToken method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RevokeTokenRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action revokeToken
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action revokeToken";
            var androidDeviceOwnerEnrollmentProfileIdOption = new Option<string>("--android-device-owner-enrollment-profile-id", description: "The unique identifier of androidDeviceOwnerEnrollmentProfile") {
            };
            androidDeviceOwnerEnrollmentProfileIdOption.IsRequired = true;
            command.AddOption(androidDeviceOwnerEnrollmentProfileIdOption);
            command.SetHandler(async (invocationContext) => {
                var androidDeviceOwnerEnrollmentProfileId = invocationContext.ParseResult.GetValueForOption(androidDeviceOwnerEnrollmentProfileIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (androidDeviceOwnerEnrollmentProfileId is not null) requestInfo.PathParameters.Add("androidDeviceOwnerEnrollmentProfile%2Did", androidDeviceOwnerEnrollmentProfileId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles.Item.RevokeToken.RevokeTokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RevokeTokenRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/androidDeviceOwnerEnrollmentProfiles/{androidDeviceOwnerEnrollmentProfile%2Did}/revokeToken", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles.Item.RevokeToken.RevokeTokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RevokeTokenRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/androidDeviceOwnerEnrollmentProfiles/{androidDeviceOwnerEnrollmentProfile%2Did}/revokeToken", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action revokeToken
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
