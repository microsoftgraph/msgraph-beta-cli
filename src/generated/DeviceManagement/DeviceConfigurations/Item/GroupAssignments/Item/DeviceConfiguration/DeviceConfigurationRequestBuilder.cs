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
namespace ApiSdk.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration
{
    /// <summary>
    /// Provides operations to manage the deviceConfiguration property of the microsoft.graph.deviceConfigurationGroupAssignment entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceConfigurationRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The navigation link to the Device Configuration being targeted.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The navigation link to the Device Configuration being targeted.";
            var deviceConfigurationIdOption = new Option<string>("--device-configuration-id", description: "The unique identifier of deviceConfiguration") {
            };
            deviceConfigurationIdOption.IsRequired = true;
            command.AddOption(deviceConfigurationIdOption);
            var deviceConfigurationGroupAssignmentIdOption = new Option<string>("--device-configuration-group-assignment-id", description: "The unique identifier of deviceConfigurationGroupAssignment") {
            };
            deviceConfigurationGroupAssignmentIdOption.IsRequired = true;
            command.AddOption(deviceConfigurationGroupAssignmentIdOption);
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
                var deviceConfigurationId = invocationContext.ParseResult.GetValueForOption(deviceConfigurationIdOption);
                var deviceConfigurationGroupAssignmentId = invocationContext.ParseResult.GetValueForOption(deviceConfigurationGroupAssignmentIdOption);
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
                if (deviceConfigurationId is not null) requestInfo.PathParameters.Add("deviceConfiguration%2Did", deviceConfigurationId);
                if (deviceConfigurationGroupAssignmentId is not null) requestInfo.PathParameters.Add("deviceConfigurationGroupAssignment%2Did", deviceConfigurationGroupAssignmentId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.DeviceConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeviceConfigurationRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration%2Did}/groupAssignments/{deviceConfigurationGroupAssignment%2Did}/deviceConfiguration{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.DeviceConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeviceConfigurationRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration%2Did}/groupAssignments/{deviceConfigurationGroupAssignment%2Did}/deviceConfiguration{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The navigation link to the Device Configuration being targeted.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.DeviceConfigurationRequestBuilder.DeviceConfigurationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.DeviceConfigurations.Item.GroupAssignments.Item.DeviceConfiguration.DeviceConfigurationRequestBuilder.DeviceConfigurationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The navigation link to the Device Configuration being targeted.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DeviceConfigurationRequestBuilderGetQueryParameters 
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
