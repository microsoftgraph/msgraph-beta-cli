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
namespace ApiSdk.DeviceManagement.NotificationMessageTemplates.Item.SendTestMessage
{
    /// <summary>
    /// Provides operations to call the sendTestMessage method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SendTestMessageRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Sends test message using the specified notificationMessageTemplate in the default locale
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Sends test message using the specified notificationMessageTemplate in the default locale";
            var notificationMessageTemplateIdOption = new Option<string>("--notification-message-template-id", description: "The unique identifier of notificationMessageTemplate") {
            };
            notificationMessageTemplateIdOption.IsRequired = true;
            command.AddOption(notificationMessageTemplateIdOption);
            command.SetHandler(async (invocationContext) => {
                var notificationMessageTemplateId = invocationContext.ParseResult.GetValueForOption(notificationMessageTemplateIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (notificationMessageTemplateId is not null) requestInfo.PathParameters.Add("notificationMessageTemplate%2Did", notificationMessageTemplateId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.NotificationMessageTemplates.Item.SendTestMessage.SendTestMessageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SendTestMessageRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/notificationMessageTemplates/{notificationMessageTemplate%2Did}/sendTestMessage", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.NotificationMessageTemplates.Item.SendTestMessage.SendTestMessageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SendTestMessageRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/notificationMessageTemplates/{notificationMessageTemplate%2Did}/sendTestMessage", rawUrl)
        {
        }
        /// <summary>
        /// Sends test message using the specified notificationMessageTemplate in the default locale
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
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
