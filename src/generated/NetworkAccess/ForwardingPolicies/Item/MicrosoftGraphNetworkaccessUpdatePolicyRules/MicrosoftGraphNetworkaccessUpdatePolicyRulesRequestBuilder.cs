// <auto-generated/>
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.NetworkAccess.ForwardingPolicies.Item.MicrosoftGraphNetworkaccessUpdatePolicyRules
{
    /// <summary>
    /// Provides operations to call the updatePolicyRules method.
    /// </summary>
    public class MicrosoftGraphNetworkaccessUpdatePolicyRulesRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Update the rules within a forwarding policy.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/networkaccess-forwardingpolicy-updatepolicyrules?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Update the rules within a forwarding policy.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/networkaccess-forwardingpolicy-updatepolicyrules?view=graph-rest-beta";
            var forwardingPolicyIdOption = new Option<string>("--forwarding-policy-id", description: "The unique identifier of forwardingPolicy") {
            };
            forwardingPolicyIdOption.IsRequired = true;
            command.AddOption(forwardingPolicyIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var forwardingPolicyId = invocationContext.ParseResult.GetValueForOption(forwardingPolicyIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<UpdatePolicyRulesPostRequestBody>(UpdatePolicyRulesPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (forwardingPolicyId is not null) requestInfo.PathParameters.Add("forwardingPolicy%2Did", forwardingPolicyId);
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
        /// Instantiates a new <see cref="MicrosoftGraphNetworkaccessUpdatePolicyRulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphNetworkaccessUpdatePolicyRulesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/networkAccess/forwardingPolicies/{forwardingPolicy%2Did}/microsoft.graph.networkaccess.updatePolicyRules", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphNetworkaccessUpdatePolicyRulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphNetworkaccessUpdatePolicyRulesRequestBuilder(string rawUrl) : base("{+baseurl}/networkAccess/forwardingPolicies/{forwardingPolicy%2Did}/microsoft.graph.networkaccess.updatePolicyRules", rawUrl)
        {
        }
        /// <summary>
        /// Update the rules within a forwarding policy.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UpdatePolicyRulesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UpdatePolicyRulesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
