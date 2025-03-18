// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Identity.ApiConnectors;
using ApiSdk.Identity.AuthenticationEventListeners;
using ApiSdk.Identity.AuthenticationEventsFlows;
using ApiSdk.Identity.B2cUserFlows;
using ApiSdk.Identity.B2xUserFlows;
using ApiSdk.Identity.ConditionalAccess;
using ApiSdk.Identity.ContinuousAccessEvaluationPolicy;
using ApiSdk.Identity.CustomAuthenticationExtensions;
using ApiSdk.Identity.IdentityProviders;
using ApiSdk.Identity.ProductChanges;
using ApiSdk.Identity.UserFlowAttributes;
using ApiSdk.Identity.UserFlows;
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
namespace ApiSdk.Identity
{
    /// <summary>
    /// Provides operations to manage the identityContainer singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IdentityRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the apiConnectors property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildApiConnectorsNavCommand()
        {
            var command = new Command("api-connectors");
            command.Description = "Provides operations to manage the apiConnectors property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.ApiConnectors.ApiConnectorsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the authenticationEventListeners property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAuthenticationEventListenersNavCommand()
        {
            var command = new Command("authentication-event-listeners");
            command.Description = "Provides operations to manage the authenticationEventListeners property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.AuthenticationEventListeners.AuthenticationEventListenersRequestBuilder(PathParameters);
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
        /// Provides operations to manage the authenticationEventsFlows property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAuthenticationEventsFlowsNavCommand()
        {
            var command = new Command("authentication-events-flows");
            command.Description = "Provides operations to manage the authenticationEventsFlows property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.AuthenticationEventsFlows.AuthenticationEventsFlowsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGraphExternalUsersSelfServiceSignUpEventsFlowNavCommand());
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
        /// Provides operations to manage the b2cUserFlows property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildB2cUserFlowsNavCommand()
        {
            var command = new Command("b2c-user-flows");
            command.Description = "Provides operations to manage the b2cUserFlows property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.B2cUserFlows.B2cUserFlowsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the b2xUserFlows property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildB2xUserFlowsNavCommand()
        {
            var command = new Command("b2x-user-flows");
            command.Description = "Provides operations to manage the b2xUserFlows property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.B2xUserFlows.B2xUserFlowsRequestBuilder(PathParameters);
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
        /// The conditionalAccess property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildConditionalAccessNavCommand()
        {
            var command = new Command("conditional-access");
            command.Description = "The conditionalAccess property";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.ConditionalAccessRequestBuilder(PathParameters);
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAuthenticationContextClassReferencesNavCommand());
            nonExecCommands.Add(builder.BuildAuthenticationStrengthNavCommand());
            nonExecCommands.Add(builder.BuildAuthenticationStrengthsNavCommand());
            nonExecCommands.Add(builder.BuildEvaluateNavCommand());
            nonExecCommands.Add(builder.BuildNamedLocationsNavCommand());
            nonExecCommands.Add(builder.BuildPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildTemplatesNavCommand());
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the continuousAccessEvaluationPolicy property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildContinuousAccessEvaluationPolicyNavCommand()
        {
            var command = new Command("continuous-access-evaluation-policy");
            command.Description = "Provides operations to manage the continuousAccessEvaluationPolicy property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.ContinuousAccessEvaluationPolicy.ContinuousAccessEvaluationPolicyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the customAuthenticationExtensions property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCustomAuthenticationExtensionsNavCommand()
        {
            var command = new Command("custom-authentication-extensions");
            command.Description = "Provides operations to manage the customAuthenticationExtensions property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.CustomAuthenticationExtensions.CustomAuthenticationExtensionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidateAuthenticationConfigurationNavCommand());
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
        /// Get identity
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get identity";
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
        /// Provides operations to manage the identityProviders property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildIdentityProvidersNavCommand()
        {
            var command = new Command("identity-providers");
            command.Description = "Provides operations to manage the identityProviders property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.IdentityProviders.IdentityProvidersRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAvailableProviderTypesNavCommand());
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
        /// Update identity
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update identity";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.IdentityContainer>(global::ApiSdk.Models.IdentityContainer.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
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
        /// Provides operations to manage the productChanges property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildProductChangesNavCommand()
        {
            var command = new Command("product-changes");
            command.Description = "Provides operations to manage the productChanges property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.ProductChanges.ProductChangesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the userFlowAttributes property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUserFlowAttributesNavCommand()
        {
            var command = new Command("user-flow-attributes");
            command.Description = "Provides operations to manage the userFlowAttributes property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.UserFlowAttributes.UserFlowAttributesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the userFlows property of the microsoft.graph.identityContainer entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUserFlowsNavCommand()
        {
            var command = new Command("user-flows");
            command.Description = "Provides operations to manage the userFlows property of the microsoft.graph.identityContainer entity.";
            var builder = new global::ApiSdk.Identity.UserFlows.UserFlowsRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="global::ApiSdk.Identity.IdentityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public IdentityRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identity{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Identity.IdentityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public IdentityRequestBuilder(string rawUrl) : base("{+baseurl}/identity{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get identity
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Identity.IdentityRequestBuilder.IdentityRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Identity.IdentityRequestBuilder.IdentityRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update identity
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.IdentityContainer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.IdentityContainer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get identity
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityRequestBuilderGetQueryParameters 
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
