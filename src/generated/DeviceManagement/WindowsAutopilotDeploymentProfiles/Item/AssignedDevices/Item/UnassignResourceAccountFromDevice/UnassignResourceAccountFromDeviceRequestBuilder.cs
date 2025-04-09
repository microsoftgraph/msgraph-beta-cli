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
namespace ApiSdk.DeviceManagement.WindowsAutopilotDeploymentProfiles.Item.AssignedDevices.Item.UnassignResourceAccountFromDevice
{
    /// <summary>
    /// Provides operations to call the unassignResourceAccountFromDevice method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnassignResourceAccountFromDeviceRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Unassigns the resource account from an Autopilot device.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Unassigns the resource account from an Autopilot device.";
            var windowsAutopilotDeploymentProfileIdOption = new Option<string>("--windows-autopilot-deployment-profile-id", description: "The unique identifier of windowsAutopilotDeploymentProfile") {
            };
            windowsAutopilotDeploymentProfileIdOption.IsRequired = true;
            command.AddOption(windowsAutopilotDeploymentProfileIdOption);
            var windowsAutopilotDeviceIdentityIdOption = new Option<string>("--windows-autopilot-device-identity-id", description: "The unique identifier of windowsAutopilotDeviceIdentity") {
            };
            windowsAutopilotDeviceIdentityIdOption.IsRequired = true;
            command.AddOption(windowsAutopilotDeviceIdentityIdOption);
            command.SetHandler(async (invocationContext) => {
                var windowsAutopilotDeploymentProfileId = invocationContext.ParseResult.GetValueForOption(windowsAutopilotDeploymentProfileIdOption);
                var windowsAutopilotDeviceIdentityId = invocationContext.ParseResult.GetValueForOption(windowsAutopilotDeviceIdentityIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (windowsAutopilotDeploymentProfileId is not null) requestInfo.PathParameters.Add("windowsAutopilotDeploymentProfile%2Did", windowsAutopilotDeploymentProfileId);
                if (windowsAutopilotDeviceIdentityId is not null) requestInfo.PathParameters.Add("windowsAutopilotDeviceIdentity%2Did", windowsAutopilotDeviceIdentityId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.WindowsAutopilotDeploymentProfiles.Item.AssignedDevices.Item.UnassignResourceAccountFromDevice.UnassignResourceAccountFromDeviceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UnassignResourceAccountFromDeviceRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/windowsAutopilotDeploymentProfiles/{windowsAutopilotDeploymentProfile%2Did}/assignedDevices/{windowsAutopilotDeviceIdentity%2Did}/unassignResourceAccountFromDevice", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.WindowsAutopilotDeploymentProfiles.Item.AssignedDevices.Item.UnassignResourceAccountFromDevice.UnassignResourceAccountFromDeviceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UnassignResourceAccountFromDeviceRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/windowsAutopilotDeploymentProfiles/{windowsAutopilotDeploymentProfile%2Did}/assignedDevices/{windowsAutopilotDeviceIdentity%2Did}/unassignResourceAccountFromDevice", rawUrl)
        {
        }
        /// <summary>
        /// Unassigns the resource account from an Autopilot device.
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
