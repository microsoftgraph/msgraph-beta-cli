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
namespace ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Pause
{
    /// <summary>
    /// Provides operations to call the pause method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PauseRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Temporarily stop a running synchronization job. All the progress, including job state, is persisted, and the job continues from where it left off when a start call is made.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/synchronization-synchronizationjob-pause?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Temporarily stop a running synchronization job. All the progress, including job state, is persisted, and the job continues from where it left off when a start call is made.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/synchronization-synchronizationjob-pause?view=graph-rest-beta";
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "The unique identifier of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var synchronizationJobIdOption = new Option<string>("--synchronization-job-id", description: "The unique identifier of synchronizationJob") {
            };
            synchronizationJobIdOption.IsRequired = true;
            command.AddOption(synchronizationJobIdOption);
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var synchronizationJobId = invocationContext.ParseResult.GetValueForOption(synchronizationJobIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                if (synchronizationJobId is not null) requestInfo.PathParameters.Add("synchronizationJob%2Did", synchronizationJobId);
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
        /// Instantiates a new <see cref="global::ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Pause.PauseRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PauseRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/jobs/{synchronizationJob%2Did}/pause", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.Pause.PauseRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PauseRequestBuilder(string rawUrl) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/jobs/{synchronizationJob%2Did}/pause", rawUrl)
        {
        }
        /// <summary>
        /// Temporarily stop a running synchronization job. All the progress, including job state, is persisted, and the job continues from where it left off when a start call is made.
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
