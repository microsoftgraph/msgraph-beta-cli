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
namespace ApiSdk.Users.Item.Authentication.HardwareOathMethods.Item.Deactivate
{
    /// <summary>
    /// Provides operations to call the deactivate method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeactivateRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Deactive a hardware OATH token. It remains assigned to a user.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/hardwareoathauthenticationmethod-deactivate?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Deactive a hardware OATH token. It remains assigned to a user.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/hardwareoathauthenticationmethod-deactivate?view=graph-rest-beta";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var hardwareOathAuthenticationMethodIdOption = new Option<string>("--hardware-oath-authentication-method-id", description: "The unique identifier of hardwareOathAuthenticationMethod") {
            };
            hardwareOathAuthenticationMethodIdOption.IsRequired = true;
            command.AddOption(hardwareOathAuthenticationMethodIdOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var hardwareOathAuthenticationMethodId = invocationContext.ParseResult.GetValueForOption(hardwareOathAuthenticationMethodIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (hardwareOathAuthenticationMethodId is not null) requestInfo.PathParameters.Add("hardwareOathAuthenticationMethod%2Did", hardwareOathAuthenticationMethodId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Authentication.HardwareOathMethods.Item.Deactivate.DeactivateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeactivateRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/authentication/hardwareOathMethods/{hardwareOathAuthenticationMethod%2Did}/deactivate", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Authentication.HardwareOathMethods.Item.Deactivate.DeactivateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeactivateRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/authentication/hardwareOathMethods/{hardwareOathAuthenticationMethod%2Did}/deactivate", rawUrl)
        {
        }
        /// <summary>
        /// Deactive a hardware OATH token. It remains assigned to a user.
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