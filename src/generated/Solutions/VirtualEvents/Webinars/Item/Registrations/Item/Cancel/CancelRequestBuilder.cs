// <auto-generated/>
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Solutions.VirtualEvents.Webinars.Item.Registrations.Item.Cancel
{
    /// <summary>
    /// Provides operations to call the cancel method.
    /// </summary>
    public class CancelRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action cancel
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action cancel";
            var virtualEventWebinarIdOption = new Option<string>("--virtual-event-webinar-id", description: "The unique identifier of virtualEventWebinar") {
            };
            virtualEventWebinarIdOption.IsRequired = true;
            command.AddOption(virtualEventWebinarIdOption);
            var virtualEventRegistrationIdOption = new Option<string>("--virtual-event-registration-id", description: "The unique identifier of virtualEventRegistration") {
            };
            virtualEventRegistrationIdOption.IsRequired = true;
            command.AddOption(virtualEventRegistrationIdOption);
            command.SetHandler(async (invocationContext) => {
                var virtualEventWebinarId = invocationContext.ParseResult.GetValueForOption(virtualEventWebinarIdOption);
                var virtualEventRegistrationId = invocationContext.ParseResult.GetValueForOption(virtualEventRegistrationIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (virtualEventWebinarId is not null) requestInfo.PathParameters.Add("virtualEventWebinar%2Did", virtualEventWebinarId);
                if (virtualEventRegistrationId is not null) requestInfo.PathParameters.Add("virtualEventRegistration%2Did", virtualEventRegistrationId);
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
        /// Instantiates a new <see cref="CancelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CancelRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/registrations/{virtualEventRegistration%2Did}/cancel", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CancelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CancelRequestBuilder(string rawUrl) : base("{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/registrations/{virtualEventRegistration%2Did}/cancel", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action cancel
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
