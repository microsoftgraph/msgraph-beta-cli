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
namespace ApiSdk.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.Count
{
    /// <summary>
    /// Provides operations to count the resources in the collection.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CountRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the number of the resource";
            var deviceManagementCompliancePolicyIdOption = new Option<string>("--device-management-compliance-policy-id", description: "The unique identifier of deviceManagementCompliancePolicy") {
            };
            deviceManagementCompliancePolicyIdOption.IsRequired = true;
            command.AddOption(deviceManagementCompliancePolicyIdOption);
            var deviceManagementComplianceScheduledActionForRuleIdOption = new Option<string>("--device-management-compliance-scheduled-action-for-rule-id", description: "The unique identifier of deviceManagementComplianceScheduledActionForRule") {
            };
            deviceManagementComplianceScheduledActionForRuleIdOption.IsRequired = true;
            command.AddOption(deviceManagementComplianceScheduledActionForRuleIdOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementCompliancePolicyId = invocationContext.ParseResult.GetValueForOption(deviceManagementCompliancePolicyIdOption);
                var deviceManagementComplianceScheduledActionForRuleId = invocationContext.ParseResult.GetValueForOption(deviceManagementComplianceScheduledActionForRuleIdOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                });
                if (deviceManagementCompliancePolicyId is not null) requestInfo.PathParameters.Add("deviceManagementCompliancePolicy%2Did", deviceManagementCompliancePolicyId);
                if (deviceManagementComplianceScheduledActionForRuleId is not null) requestInfo.PathParameters.Add("deviceManagementComplianceScheduledActionForRule%2Did", deviceManagementComplianceScheduledActionForRuleId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                var formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.Count.CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CountRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy%2Did}/scheduledActionsForRule/{deviceManagementComplianceScheduledActionForRule%2Did}/scheduledActionConfigurations/$count{?%24filter,%24search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.Count.CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CountRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy%2Did}/scheduledActionsForRule/{deviceManagementComplianceScheduledActionForRule%2Did}/scheduledActionConfigurations/$count{?%24filter,%24search}", rawUrl)
        {
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CountRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
