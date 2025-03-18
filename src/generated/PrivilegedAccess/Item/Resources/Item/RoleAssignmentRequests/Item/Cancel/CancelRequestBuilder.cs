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
namespace ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.Cancel
{
    /// <summary>
    /// Provides operations to call the cancel method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CancelRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action cancel
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action cancel";
            var privilegedAccessIdOption = new Option<string>("--privileged-access-id", description: "The unique identifier of privilegedAccess") {
            };
            privilegedAccessIdOption.IsRequired = true;
            command.AddOption(privilegedAccessIdOption);
            var governanceResourceIdOption = new Option<string>("--governance-resource-id", description: "The unique identifier of governanceResource") {
            };
            governanceResourceIdOption.IsRequired = true;
            command.AddOption(governanceResourceIdOption);
            var governanceRoleAssignmentRequestIdOption = new Option<string>("--governance-role-assignment-request-id", description: "The unique identifier of governanceRoleAssignmentRequest") {
            };
            governanceRoleAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(governanceRoleAssignmentRequestIdOption);
            command.SetHandler(async (invocationContext) => {
                var privilegedAccessId = invocationContext.ParseResult.GetValueForOption(privilegedAccessIdOption);
                var governanceResourceId = invocationContext.ParseResult.GetValueForOption(governanceResourceIdOption);
                var governanceRoleAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(governanceRoleAssignmentRequestIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (privilegedAccessId is not null) requestInfo.PathParameters.Add("privilegedAccess%2Did", privilegedAccessId);
                if (governanceResourceId is not null) requestInfo.PathParameters.Add("governanceResource%2Did", governanceResourceId);
                if (governanceRoleAssignmentRequestId is not null) requestInfo.PathParameters.Add("governanceRoleAssignmentRequest%2Did", governanceRoleAssignmentRequestId);
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
        /// Instantiates a new <see cref="global::ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.Cancel.CancelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CancelRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/privilegedAccess/{privilegedAccess%2Did}/resources/{governanceResource%2Did}/roleAssignmentRequests/{governanceRoleAssignmentRequest%2Did}/cancel", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.Cancel.CancelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CancelRequestBuilder(string rawUrl) : base("{+baseurl}/privilegedAccess/{privilegedAccess%2Did}/resources/{governanceResource%2Did}/roleAssignmentRequests/{governanceRoleAssignmentRequest%2Did}/cancel", rawUrl)
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
#pragma warning restore CS0618
