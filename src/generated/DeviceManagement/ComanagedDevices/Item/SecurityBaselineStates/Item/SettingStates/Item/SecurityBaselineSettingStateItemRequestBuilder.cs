// <auto-generated/>
#pragma warning disable CS0618
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
namespace ApiSdk.DeviceManagement.ComanagedDevices.Item.SecurityBaselineStates.Item.SettingStates.Item
{
    /// <summary>
    /// Provides operations to manage the settingStates property of the microsoft.graph.securityBaselineState entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SecurityBaselineSettingStateItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property settingStates for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property settingStates for deviceManagement";
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var securityBaselineStateIdOption = new Option<string>("--security-baseline-state-id", description: "The unique identifier of securityBaselineState") {
            };
            securityBaselineStateIdOption.IsRequired = true;
            command.AddOption(securityBaselineStateIdOption);
            var securityBaselineSettingStateIdOption = new Option<string>("--security-baseline-setting-state-id", description: "The unique identifier of securityBaselineSettingState") {
            };
            securityBaselineSettingStateIdOption.IsRequired = true;
            command.AddOption(securityBaselineSettingStateIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var securityBaselineStateId = invocationContext.ParseResult.GetValueForOption(securityBaselineStateIdOption);
                var securityBaselineSettingStateId = invocationContext.ParseResult.GetValueForOption(securityBaselineSettingStateIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                if (securityBaselineStateId is not null) requestInfo.PathParameters.Add("securityBaselineState%2Did", securityBaselineStateId);
                if (securityBaselineSettingStateId is not null) requestInfo.PathParameters.Add("securityBaselineSettingState%2Did", securityBaselineSettingStateId);
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
        /// The security baseline state for different settings for a device
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The security baseline state for different settings for a device";
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var securityBaselineStateIdOption = new Option<string>("--security-baseline-state-id", description: "The unique identifier of securityBaselineState") {
            };
            securityBaselineStateIdOption.IsRequired = true;
            command.AddOption(securityBaselineStateIdOption);
            var securityBaselineSettingStateIdOption = new Option<string>("--security-baseline-setting-state-id", description: "The unique identifier of securityBaselineSettingState") {
            };
            securityBaselineSettingStateIdOption.IsRequired = true;
            command.AddOption(securityBaselineSettingStateIdOption);
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
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var securityBaselineStateId = invocationContext.ParseResult.GetValueForOption(securityBaselineStateIdOption);
                var securityBaselineSettingStateId = invocationContext.ParseResult.GetValueForOption(securityBaselineSettingStateIdOption);
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
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                if (securityBaselineStateId is not null) requestInfo.PathParameters.Add("securityBaselineState%2Did", securityBaselineStateId);
                if (securityBaselineSettingStateId is not null) requestInfo.PathParameters.Add("securityBaselineSettingState%2Did", securityBaselineSettingStateId);
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
        /// Update the navigation property settingStates in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property settingStates in deviceManagement";
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var securityBaselineStateIdOption = new Option<string>("--security-baseline-state-id", description: "The unique identifier of securityBaselineState") {
            };
            securityBaselineStateIdOption.IsRequired = true;
            command.AddOption(securityBaselineStateIdOption);
            var securityBaselineSettingStateIdOption = new Option<string>("--security-baseline-setting-state-id", description: "The unique identifier of securityBaselineSettingState") {
            };
            securityBaselineSettingStateIdOption.IsRequired = true;
            command.AddOption(securityBaselineSettingStateIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var securityBaselineStateId = invocationContext.ParseResult.GetValueForOption(securityBaselineStateIdOption);
                var securityBaselineSettingStateId = invocationContext.ParseResult.GetValueForOption(securityBaselineSettingStateIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.SecurityBaselineSettingState>(global::ApiSdk.Models.SecurityBaselineSettingState.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                if (securityBaselineStateId is not null) requestInfo.PathParameters.Add("securityBaselineState%2Did", securityBaselineStateId);
                if (securityBaselineSettingStateId is not null) requestInfo.PathParameters.Add("securityBaselineSettingState%2Did", securityBaselineSettingStateId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.ComanagedDevices.Item.SecurityBaselineStates.Item.SettingStates.Item.SecurityBaselineSettingStateItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SecurityBaselineSettingStateItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/comanagedDevices/{managedDevice%2Did}/securityBaselineStates/{securityBaselineState%2Did}/settingStates/{securityBaselineSettingState%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.ComanagedDevices.Item.SecurityBaselineStates.Item.SettingStates.Item.SecurityBaselineSettingStateItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SecurityBaselineSettingStateItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/comanagedDevices/{managedDevice%2Did}/securityBaselineStates/{securityBaselineState%2Did}/settingStates/{securityBaselineSettingState%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property settingStates for deviceManagement
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
            return requestInfo;
        }
        /// <summary>
        /// The security baseline state for different settings for a device
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.ComanagedDevices.Item.SecurityBaselineStates.Item.SettingStates.Item.SecurityBaselineSettingStateItemRequestBuilder.SecurityBaselineSettingStateItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.ComanagedDevices.Item.SecurityBaselineStates.Item.SettingStates.Item.SecurityBaselineSettingStateItemRequestBuilder.SecurityBaselineSettingStateItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property settingStates in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.SecurityBaselineSettingState body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.SecurityBaselineSettingState body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The security baseline state for different settings for a device
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SecurityBaselineSettingStateItemRequestBuilderGetQueryParameters 
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
