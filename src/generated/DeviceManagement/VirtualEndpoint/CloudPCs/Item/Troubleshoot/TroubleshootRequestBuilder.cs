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
namespace ApiSdk.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Troubleshoot
{
    /// <summary>
    /// Provides operations to call the troubleshoot method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TroubleshootRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Troubleshoot a specific Cloud PC. Use this API to check the health status of the Cloud PC and the session host.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-troubleshoot?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Troubleshoot a specific Cloud PC. Use this API to check the health status of the Cloud PC and the session host.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/cloudpc-troubleshoot?view=graph-rest-beta";
            var cloudPCIdOption = new Option<string>("--cloud-pcid", description: "The unique identifier of cloudPC") {
            };
            cloudPCIdOption.IsRequired = true;
            command.AddOption(cloudPCIdOption);
            command.SetHandler(async (invocationContext) => {
                var cloudPCId = invocationContext.ParseResult.GetValueForOption(cloudPCIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Troubleshoot.TroubleshootRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public TroubleshootRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}/troubleshoot", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Troubleshoot.TroubleshootRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TroubleshootRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}/troubleshoot", rawUrl)
        {
        }
        /// <summary>
        /// Troubleshoot a specific Cloud PC. Use this API to check the health status of the Cloud PC and the session host.
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
