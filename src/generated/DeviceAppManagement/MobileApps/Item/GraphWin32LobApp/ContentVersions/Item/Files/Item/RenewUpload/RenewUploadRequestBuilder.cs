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
namespace ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.RenewUpload
{
    /// <summary>
    /// Provides operations to call the renewUpload method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RenewUploadRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Renews the SAS URI for an application file upload.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Renews the SAS URI for an application file upload.";
            var mobileAppIdOption = new Option<string>("--mobile-app-id", description: "The unique identifier of mobileApp") {
            };
            mobileAppIdOption.IsRequired = true;
            command.AddOption(mobileAppIdOption);
            var mobileAppContentIdOption = new Option<string>("--mobile-app-content-id", description: "The unique identifier of mobileAppContent") {
            };
            mobileAppContentIdOption.IsRequired = true;
            command.AddOption(mobileAppContentIdOption);
            var mobileAppContentFileIdOption = new Option<string>("--mobile-app-content-file-id", description: "The unique identifier of mobileAppContentFile") {
            };
            mobileAppContentFileIdOption.IsRequired = true;
            command.AddOption(mobileAppContentFileIdOption);
            command.SetHandler(async (invocationContext) => {
                var mobileAppId = invocationContext.ParseResult.GetValueForOption(mobileAppIdOption);
                var mobileAppContentId = invocationContext.ParseResult.GetValueForOption(mobileAppContentIdOption);
                var mobileAppContentFileId = invocationContext.ParseResult.GetValueForOption(mobileAppContentFileIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (mobileAppId is not null) requestInfo.PathParameters.Add("mobileApp%2Did", mobileAppId);
                if (mobileAppContentId is not null) requestInfo.PathParameters.Add("mobileAppContent%2Did", mobileAppContentId);
                if (mobileAppContentFileId is not null) requestInfo.PathParameters.Add("mobileAppContentFile%2Did", mobileAppContentFileId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.RenewUpload.RenewUploadRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RenewUploadRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.win32LobApp/contentVersions/{mobileAppContent%2Did}/files/{mobileAppContentFile%2Did}/renewUpload", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp.ContentVersions.Item.Files.Item.RenewUpload.RenewUploadRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RenewUploadRequestBuilder(string rawUrl) : base("{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.win32LobApp/contentVersions/{mobileAppContent%2Did}/files/{mobileAppContentFile%2Did}/renewUpload", rawUrl)
        {
        }
        /// <summary>
        /// Renews the SAS URI for an application file upload.
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
