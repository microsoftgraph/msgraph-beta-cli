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
namespace ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId
{
    /// <summary>
    /// Provides operations to call the getRealTimeRemoteConnectionStatus method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get the real-time connection status information, such as signInStatus or daysSinceLastUse, for a Cloud PC.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpcreports-getrealtimeremoteconnectionstatus?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the real-time connection status information, such as signInStatus or daysSinceLastUse, for a Cloud PC.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/cloudpcreports-getrealtimeremoteconnectionstatus?view=graph-rest-beta";
            var cloudPcIdOption = new Option<string>("--cloud-pc-id", description: "Usage: cloudPcId='{cloudPcId}'") {
            };
            cloudPcIdOption.IsRequired = true;
            command.AddOption(cloudPcIdOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var cloudPcId = invocationContext.ParseResult.GetValueForOption(cloudPcIdOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (cloudPcId is not null) requestInfo.PathParameters.Add("cloudPcId", cloudPcId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId.GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/virtualEndpoint/reports/getRealTimeRemoteConnectionStatus(cloudPcId='{cloudPcId}')", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId.GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/virtualEndpoint/reports/getRealTimeRemoteConnectionStatus(cloudPcId='{cloudPcId}')", rawUrl)
        {
        }
        /// <summary>
        /// Get the real-time connection status information, such as signInStatus or daysSinceLastUse, for a Cloud PC.
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
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
