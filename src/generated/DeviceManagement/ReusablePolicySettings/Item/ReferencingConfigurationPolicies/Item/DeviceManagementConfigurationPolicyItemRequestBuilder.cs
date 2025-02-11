// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Assign;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Assignments;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.ClearEnrollmentTimeDeviceMembershipTarget;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.CreateCopy;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Reorder;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.RetrieveEnrollmentTimeDeviceMembershipTarget;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.RetrieveLatestUpgradeDefaultBaselinePolicy;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.SetEnrollmentTimeDeviceMembershipTarget;
using ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Settings;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item
{
    /// <summary>
    /// Provides operations to manage the referencingConfigurationPolicies property of the microsoft.graph.deviceManagementReusablePolicySetting entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationPolicyItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the assignments property of the microsoft.graph.deviceManagementConfigurationPolicy entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAssignmentsNavCommand()
        {
            var command = new Command("assignments");
            command.Description = "Provides operations to manage the assignments property of the microsoft.graph.deviceManagementConfigurationPolicy entity.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Assignments.AssignmentsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the assign method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAssignNavCommand()
        {
            var command = new Command("assign");
            command.Description = "Provides operations to call the assign method.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Assign.AssignRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the clearEnrollmentTimeDeviceMembershipTarget method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildClearEnrollmentTimeDeviceMembershipTargetNavCommand()
        {
            var command = new Command("clear-enrollment-time-device-membership-target");
            command.Description = "Provides operations to call the clearEnrollmentTimeDeviceMembershipTarget method.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.ClearEnrollmentTimeDeviceMembershipTarget.ClearEnrollmentTimeDeviceMembershipTargetRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the createCopy method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCopyNavCommand()
        {
            var command = new Command("create-copy");
            command.Description = "Provides operations to call the createCopy method.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.CreateCopy.CreateCopyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property referencingConfigurationPolicies for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property referencingConfigurationPolicies for deviceManagement";
            var deviceManagementReusablePolicySettingIdOption = new Option<string>("--device-management-reusable-policy-setting-id", description: "The unique identifier of deviceManagementReusablePolicySetting") {
            };
            deviceManagementReusablePolicySettingIdOption.IsRequired = true;
            command.AddOption(deviceManagementReusablePolicySettingIdOption);
            var deviceManagementConfigurationPolicyIdOption = new Option<string>("--device-management-configuration-policy-id", description: "The unique identifier of deviceManagementConfigurationPolicy") {
            };
            deviceManagementConfigurationPolicyIdOption.IsRequired = true;
            command.AddOption(deviceManagementConfigurationPolicyIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementReusablePolicySettingId = invocationContext.ParseResult.GetValueForOption(deviceManagementReusablePolicySettingIdOption);
                var deviceManagementConfigurationPolicyId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationPolicyIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (deviceManagementReusablePolicySettingId is not null) requestInfo.PathParameters.Add("deviceManagementReusablePolicySetting%2Did", deviceManagementReusablePolicySettingId);
                if (deviceManagementConfigurationPolicyId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationPolicy%2Did", deviceManagementConfigurationPolicyId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
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
        /// configuration policies referencing the current reusable setting. This property is read-only.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "configuration policies referencing the current reusable setting. This property is read-only.";
            var deviceManagementReusablePolicySettingIdOption = new Option<string>("--device-management-reusable-policy-setting-id", description: "The unique identifier of deviceManagementReusablePolicySetting") {
            };
            deviceManagementReusablePolicySettingIdOption.IsRequired = true;
            command.AddOption(deviceManagementReusablePolicySettingIdOption);
            var deviceManagementConfigurationPolicyIdOption = new Option<string>("--device-management-configuration-policy-id", description: "The unique identifier of deviceManagementConfigurationPolicy") {
            };
            deviceManagementConfigurationPolicyIdOption.IsRequired = true;
            command.AddOption(deviceManagementConfigurationPolicyIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementReusablePolicySettingId = invocationContext.ParseResult.GetValueForOption(deviceManagementReusablePolicySettingIdOption);
                var deviceManagementConfigurationPolicyId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationPolicyIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (deviceManagementReusablePolicySettingId is not null) requestInfo.PathParameters.Add("deviceManagementReusablePolicySetting%2Did", deviceManagementReusablePolicySettingId);
                if (deviceManagementConfigurationPolicyId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationPolicy%2Did", deviceManagementConfigurationPolicyId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update the navigation property referencingConfigurationPolicies in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property referencingConfigurationPolicies in deviceManagement";
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
            command.SetHandler(async (invocationContext) => {
                var deviceManagementReusablePolicySettingId = invocationContext.ParseResult.GetValueForOption(deviceManagementReusablePolicySettingIdOption);
                var deviceManagementConfigurationPolicyId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationPolicyIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.DeviceManagementConfigurationPolicy>(global::ApiSdk.Models.DeviceManagementConfigurationPolicy.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (deviceManagementReusablePolicySettingId is not null) requestInfo.PathParameters.Add("deviceManagementReusablePolicySetting%2Did", deviceManagementReusablePolicySettingId);
                if (deviceManagementConfigurationPolicyId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationPolicy%2Did", deviceManagementConfigurationPolicyId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the reorder method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildReorderNavCommand()
        {
            var command = new Command("reorder");
            command.Description = "Provides operations to call the reorder method.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Reorder.ReorderRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the retrieveEnrollmentTimeDeviceMembershipTarget method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRetrieveEnrollmentTimeDeviceMembershipTargetNavCommand()
        {
            var command = new Command("retrieve-enrollment-time-device-membership-target");
            command.Description = "Provides operations to call the retrieveEnrollmentTimeDeviceMembershipTarget method.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.RetrieveEnrollmentTimeDeviceMembershipTarget.RetrieveEnrollmentTimeDeviceMembershipTargetRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the retrieveLatestUpgradeDefaultBaselinePolicy method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRetrieveLatestUpgradeDefaultBaselinePolicyNavCommand()
        {
            var command = new Command("retrieve-latest-upgrade-default-baseline-policy");
            command.Description = "Provides operations to call the retrieveLatestUpgradeDefaultBaselinePolicy method.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.RetrieveLatestUpgradeDefaultBaselinePolicy.RetrieveLatestUpgradeDefaultBaselinePolicyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the setEnrollmentTimeDeviceMembershipTarget method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSetEnrollmentTimeDeviceMembershipTargetNavCommand()
        {
            var command = new Command("set-enrollment-time-device-membership-target");
            command.Description = "Provides operations to call the setEnrollmentTimeDeviceMembershipTarget method.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.SetEnrollmentTimeDeviceMembershipTarget.SetEnrollmentTimeDeviceMembershipTargetRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the settings property of the microsoft.graph.deviceManagementConfigurationPolicy entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSettingsNavCommand()
        {
            var command = new Command("settings");
            command.Description = "Provides operations to manage the settings property of the microsoft.graph.deviceManagementConfigurationPolicy entity.";
            var builder = new global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Settings.SettingsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.DeviceManagementConfigurationPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeviceManagementConfigurationPolicyItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/reusablePolicySettings/{deviceManagementReusablePolicySetting%2Did}/referencingConfigurationPolicies/{deviceManagementConfigurationPolicy%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.DeviceManagementConfigurationPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeviceManagementConfigurationPolicyItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/reusablePolicySettings/{deviceManagementReusablePolicySetting%2Did}/referencingConfigurationPolicies/{deviceManagementConfigurationPolicy%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property referencingConfigurationPolicies for deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// configuration policies referencing the current reusable setting. This property is read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.DeviceManagementConfigurationPolicyItemRequestBuilder.DeviceManagementConfigurationPolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.DeviceManagementConfigurationPolicyItemRequestBuilder.DeviceManagementConfigurationPolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property referencingConfigurationPolicies in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.DeviceManagementConfigurationPolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.DeviceManagementConfigurationPolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// configuration policies referencing the current reusable setting. This property is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DeviceManagementConfigurationPolicyItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
