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
namespace ApiSdk.Users.Item.PendingAccessReviewInstances.Item.Decisions.Item.Instance.ApplyDecisions
{
    /// <summary>
    /// Provides operations to call the applyDecisions method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ApplyDecisionsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is false in the review&apos;s accessReviewScheduleSettings. The status of the accessReviewInstance must be Completed to call this method.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewinstance-applydecisions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is false in the review's accessReviewScheduleSettings. The status of the accessReviewInstance must be Completed to call this method.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accessreviewinstance-applydecisions?view=graph-rest-beta";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            var accessReviewInstanceDecisionItemIdOption = new Option<string>("--access-review-instance-decision-item-id", description: "The unique identifier of accessReviewInstanceDecisionItem") {
            };
            accessReviewInstanceDecisionItemIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceDecisionItemIdOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
                var accessReviewInstanceDecisionItemId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceDecisionItemIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
                if (accessReviewInstanceDecisionItemId is not null) requestInfo.PathParameters.Add("accessReviewInstanceDecisionItem%2Did", accessReviewInstanceDecisionItemId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.PendingAccessReviewInstances.Item.Decisions.Item.Instance.ApplyDecisions.ApplyDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ApplyDecisionsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}/decisions/{accessReviewInstanceDecisionItem%2Did}/instance/applyDecisions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.PendingAccessReviewInstances.Item.Decisions.Item.Instance.ApplyDecisions.ApplyDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ApplyDecisionsRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}/decisions/{accessReviewInstanceDecisionItem%2Did}/instance/applyDecisions", rawUrl)
        {
        }
        /// <summary>
        /// Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is false in the review&apos;s accessReviewScheduleSettings. The status of the accessReviewInstance must be Completed to call this method.
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
