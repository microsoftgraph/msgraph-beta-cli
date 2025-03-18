// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.AuthenticationMethodDevices.Item.HardwareOathDevices.Item.AssignTo;
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
namespace ApiSdk.AuthenticationMethodDevices.Item.HardwareOathDevices.Item
{
    /// <summary>
    /// Provides operations to manage the hardwareOathDevices property of the microsoft.graph.authenticationMethodDevice entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the assignTo property of the microsoft.graph.hardwareOathTokenAuthenticationMethodDevice entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAssignToNavCommand()
        {
            var command = new Command("assign-to");
            command.Description = "Provides operations to manage the assignTo property of the microsoft.graph.hardwareOathTokenAuthenticationMethodDevice entity.";
            var builder = new global::ApiSdk.AuthenticationMethodDevices.Item.HardwareOathDevices.Item.AssignTo.AssignToRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildMailboxSettingsNavCommand());
            nonExecCommands.Add(builder.BuildServiceProvisioningErrorsNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property hardwareOathDevices for authenticationMethodDevices
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property hardwareOathDevices for authenticationMethodDevices";
            var authenticationMethodDeviceIdOption = new Option<string>("--authentication-method-device-id", description: "The unique identifier of authenticationMethodDevice") {
            };
            authenticationMethodDeviceIdOption.IsRequired = true;
            command.AddOption(authenticationMethodDeviceIdOption);
            var hardwareOathTokenAuthenticationMethodDeviceIdOption = new Option<string>("--hardware-oath-token-authentication-method-device-id", description: "The unique identifier of hardwareOathTokenAuthenticationMethodDevice") {
            };
            hardwareOathTokenAuthenticationMethodDeviceIdOption.IsRequired = true;
            command.AddOption(hardwareOathTokenAuthenticationMethodDeviceIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var authenticationMethodDeviceId = invocationContext.ParseResult.GetValueForOption(authenticationMethodDeviceIdOption);
                var hardwareOathTokenAuthenticationMethodDeviceId = invocationContext.ParseResult.GetValueForOption(hardwareOathTokenAuthenticationMethodDeviceIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (authenticationMethodDeviceId is not null) requestInfo.PathParameters.Add("authenticationMethodDevice%2Did", authenticationMethodDeviceId);
                if (hardwareOathTokenAuthenticationMethodDeviceId is not null) requestInfo.PathParameters.Add("hardwareOathTokenAuthenticationMethodDevice%2Did", hardwareOathTokenAuthenticationMethodDeviceId);
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
        /// Exposes the hardware OATH method in the directory.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Exposes the hardware OATH method in the directory.";
            var authenticationMethodDeviceIdOption = new Option<string>("--authentication-method-device-id", description: "The unique identifier of authenticationMethodDevice") {
            };
            authenticationMethodDeviceIdOption.IsRequired = true;
            command.AddOption(authenticationMethodDeviceIdOption);
            var hardwareOathTokenAuthenticationMethodDeviceIdOption = new Option<string>("--hardware-oath-token-authentication-method-device-id", description: "The unique identifier of hardwareOathTokenAuthenticationMethodDevice") {
            };
            hardwareOathTokenAuthenticationMethodDeviceIdOption.IsRequired = true;
            command.AddOption(hardwareOathTokenAuthenticationMethodDeviceIdOption);
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
                var authenticationMethodDeviceId = invocationContext.ParseResult.GetValueForOption(authenticationMethodDeviceIdOption);
                var hardwareOathTokenAuthenticationMethodDeviceId = invocationContext.ParseResult.GetValueForOption(hardwareOathTokenAuthenticationMethodDeviceIdOption);
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
                if (authenticationMethodDeviceId is not null) requestInfo.PathParameters.Add("authenticationMethodDevice%2Did", authenticationMethodDeviceId);
                if (hardwareOathTokenAuthenticationMethodDeviceId is not null) requestInfo.PathParameters.Add("hardwareOathTokenAuthenticationMethodDevice%2Did", hardwareOathTokenAuthenticationMethodDeviceId);
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
        /// Update the navigation property hardwareOathDevices in authenticationMethodDevices
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property hardwareOathDevices in authenticationMethodDevices";
            var authenticationMethodDeviceIdOption = new Option<string>("--authentication-method-device-id", description: "The unique identifier of authenticationMethodDevice") {
            };
            authenticationMethodDeviceIdOption.IsRequired = true;
            command.AddOption(authenticationMethodDeviceIdOption);
            var hardwareOathTokenAuthenticationMethodDeviceIdOption = new Option<string>("--hardware-oath-token-authentication-method-device-id", description: "The unique identifier of hardwareOathTokenAuthenticationMethodDevice") {
            };
            hardwareOathTokenAuthenticationMethodDeviceIdOption.IsRequired = true;
            command.AddOption(hardwareOathTokenAuthenticationMethodDeviceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var authenticationMethodDeviceId = invocationContext.ParseResult.GetValueForOption(authenticationMethodDeviceIdOption);
                var hardwareOathTokenAuthenticationMethodDeviceId = invocationContext.ParseResult.GetValueForOption(hardwareOathTokenAuthenticationMethodDeviceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice>(global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (authenticationMethodDeviceId is not null) requestInfo.PathParameters.Add("authenticationMethodDevice%2Did", authenticationMethodDeviceId);
                if (hardwareOathTokenAuthenticationMethodDeviceId is not null) requestInfo.PathParameters.Add("hardwareOathTokenAuthenticationMethodDevice%2Did", hardwareOathTokenAuthenticationMethodDeviceId);
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
        /// Instantiates a new <see cref="global::ApiSdk.AuthenticationMethodDevices.Item.HardwareOathDevices.Item.HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/authenticationMethodDevices/{authenticationMethodDevice%2Did}/hardwareOathDevices/{hardwareOathTokenAuthenticationMethodDevice%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.AuthenticationMethodDevices.Item.HardwareOathDevices.Item.HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilder(string rawUrl) : base("{+baseurl}/authenticationMethodDevices/{authenticationMethodDevice%2Did}/hardwareOathDevices/{hardwareOathTokenAuthenticationMethodDevice%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property hardwareOathDevices for authenticationMethodDevices
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
        /// Exposes the hardware OATH method in the directory.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.AuthenticationMethodDevices.Item.HardwareOathDevices.Item.HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilder.HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.AuthenticationMethodDevices.Item.HardwareOathDevices.Item.HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilder.HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property hardwareOathDevices in authenticationMethodDevices
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.HardwareOathTokenAuthenticationMethodDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Exposes the hardware OATH method in the directory.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class HardwareOathTokenAuthenticationMethodDeviceItemRequestBuilderGetQueryParameters 
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
