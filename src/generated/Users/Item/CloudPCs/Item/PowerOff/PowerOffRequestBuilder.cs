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
namespace ApiSdk.Users.Item.CloudPCs.Item.PowerOff
{
    /// <summary>
    /// Provides operations to call the powerOff method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PowerOffRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Power off a Windows 365 Frontline Cloud PC. This action supports Microsoft Endpoint Manager (MEM) admin scenarios.  After a Windows 365 Frontline Cloud PC is powered off, it&apos;s deallocated, and licenses are revoked immediately. Only IT admin users can perform this action. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-poweroff?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Power off a Windows 365 Frontline Cloud PC. This action supports Microsoft Endpoint Manager (MEM) admin scenarios.  After a Windows 365 Frontline Cloud PC is powered off, it's deallocated, and licenses are revoked immediately. Only IT admin users can perform this action. \n\nFind more info here:\n  https://learn.microsoft.com/graph/api/cloudpc-poweroff?view=graph-rest-beta";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var cloudPCIdOption = new Option<string>("--cloud-pcid", description: "The unique identifier of cloudPC") {
            };
            cloudPCIdOption.IsRequired = true;
            command.AddOption(cloudPCIdOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var cloudPCId = invocationContext.ParseResult.GetValueForOption(cloudPCIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (cloudPCId is not null) requestInfo.PathParameters.Add("cloudPC%2Did", cloudPCId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.CloudPCs.Item.PowerOff.PowerOffRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PowerOffRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/cloudPCs/{cloudPC%2Did}/powerOff", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.CloudPCs.Item.PowerOff.PowerOffRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PowerOffRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/cloudPCs/{cloudPC%2Did}/powerOff", rawUrl)
        {
        }
        /// <summary>
        /// Power off a Windows 365 Frontline Cloud PC. This action supports Microsoft Endpoint Manager (MEM) admin scenarios.  After a Windows 365 Frontline Cloud PC is powered off, it&apos;s deallocated, and licenses are revoked immediately. Only IT admin users can perform this action. 
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
