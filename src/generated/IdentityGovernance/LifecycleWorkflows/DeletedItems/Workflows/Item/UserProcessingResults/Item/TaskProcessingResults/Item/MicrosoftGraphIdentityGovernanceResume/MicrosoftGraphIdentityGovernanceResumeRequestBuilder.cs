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
namespace ApiSdk.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume
{
    /// <summary>
    /// Provides operations to call the resume method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MicrosoftGraphIdentityGovernanceResumeRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Resume a task processing result that&apos;s inProgress. In the default case an Azure Logic Apps system-assigned managed identity calls this API. For more information, see: Lifecycle Workflows extensibility approach.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identitygovernance-taskprocessingresult-resume?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Resume a task processing result that's inProgress. In the default case an Azure Logic Apps system-assigned managed identity calls this API. For more information, see: Lifecycle Workflows extensibility approach.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/identitygovernance-taskprocessingresult-resume?view=graph-rest-beta";
            var workflowIdOption = new Option<string>("--workflow-id", description: "The unique identifier of workflow") {
            };
            workflowIdOption.IsRequired = true;
            command.AddOption(workflowIdOption);
            var userProcessingResultIdOption = new Option<string>("--user-processing-result-id", description: "The unique identifier of userProcessingResult") {
            };
            userProcessingResultIdOption.IsRequired = true;
            command.AddOption(userProcessingResultIdOption);
            var taskProcessingResultIdOption = new Option<string>("--task-processing-result-id", description: "The unique identifier of taskProcessingResult") {
            };
            taskProcessingResultIdOption.IsRequired = true;
            command.AddOption(taskProcessingResultIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var workflowId = invocationContext.ParseResult.GetValueForOption(workflowIdOption);
                var userProcessingResultId = invocationContext.ParseResult.GetValueForOption(userProcessingResultIdOption);
                var taskProcessingResultId = invocationContext.ParseResult.GetValueForOption(taskProcessingResultIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume.ResumePostRequestBody>(global::ApiSdk.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume.ResumePostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (workflowId is not null) requestInfo.PathParameters.Add("workflow%2Did", workflowId);
                if (userProcessingResultId is not null) requestInfo.PathParameters.Add("userProcessingResult%2Did", userProcessingResultId);
                if (taskProcessingResultId is not null) requestInfo.PathParameters.Add("taskProcessingResult%2Did", taskProcessingResultId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume.MicrosoftGraphIdentityGovernanceResumeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphIdentityGovernanceResumeRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/userProcessingResults/{userProcessingResult%2Did}/taskProcessingResults/{taskProcessingResult%2Did}/microsoft.graph.identityGovernance.resume", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume.MicrosoftGraphIdentityGovernanceResumeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphIdentityGovernanceResumeRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/userProcessingResults/{userProcessingResult%2Did}/taskProcessingResults/{taskProcessingResult%2Did}/microsoft.graph.identityGovernance.resume", rawUrl)
        {
        }
        /// <summary>
        /// Resume a task processing result that&apos;s inProgress. In the default case an Azure Logic Apps system-assigned managed identity calls this API. For more information, see: Lifecycle Workflows extensibility approach.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume.ResumePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume.ResumePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
