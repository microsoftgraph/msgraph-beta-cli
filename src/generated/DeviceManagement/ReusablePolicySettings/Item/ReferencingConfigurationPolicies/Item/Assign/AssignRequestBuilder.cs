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
namespace ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Assign {
    /// <summary>
    /// Provides operations to call the assign method.
    /// </summary>
    public class AssignRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Invoke action assign
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action assign";
            var deviceManagementReusablePolicySettingIdOption = new Option<string>("--device-management-reusable-policy-setting-id", description: "The unique identifier of deviceManagementReusablePolicySetting") {
            };
            deviceManagementReusablePolicySettingIdOption.IsRequired = true;
            command.AddOption(deviceManagementReusablePolicySettingIdOption);
            var deviceManagementConfigurationPolicyIdOption = new Option<string>("--device-management-configuration-policy-id", description: "The unique identifier of deviceManagementConfigurationPolicy") {
            };
            deviceManagementConfigurationPolicyIdOption.IsRequired = true;
            command.AddOption(deviceManagementConfigurationPolicyIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementReusablePolicySettingId = invocationContext.ParseResult.GetValueForOption(deviceManagementReusablePolicySettingIdOption);
                var deviceManagementConfigurationPolicyId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationPolicyIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                IPagingService pagingService = invocationContext.BindingContext.GetService(typeof(IPagingService)) as IPagingService ?? throw new ArgumentNullException("pagingService");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AssignPostRequestBody>(AssignPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (deviceManagementReusablePolicySettingId is not null) requestInfo.PathParameters.Add("deviceManagementReusablePolicySetting%2Did", deviceManagementReusablePolicySettingId);
                if (deviceManagementConfigurationPolicyId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationPolicy%2Did", deviceManagementConfigurationPolicyId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => reqAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
                IOutputFormatter? formatter = null;
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="AssignRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AssignRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/reusablePolicySettings/{deviceManagementReusablePolicySetting%2Did}/referencingConfigurationPolicies/{deviceManagementConfigurationPolicy%2Did}/assign", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AssignRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AssignRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/reusablePolicySettings/{deviceManagementReusablePolicySetting%2Did}/referencingConfigurationPolicies/{deviceManagementConfigurationPolicy%2Did}/assign", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action assign
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AssignPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AssignPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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