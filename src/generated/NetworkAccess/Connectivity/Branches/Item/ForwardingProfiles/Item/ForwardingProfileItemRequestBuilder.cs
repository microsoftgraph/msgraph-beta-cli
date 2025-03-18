// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.Networkaccess;
using ApiSdk.Models.ODataErrors;
using ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.Policies;
using ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.ServicePrincipal;
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
namespace ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item
{
    /// <summary>
    /// Provides operations to manage the forwardingProfiles property of the microsoft.graph.networkaccess.branchSite entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ForwardingProfileItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property forwardingProfiles for networkAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess on 2023-12-19 and will be removed 2024-03-20")]
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property forwardingProfiles for networkAccess";
            var branchSiteIdOption = new Option<string>("--branch-site-id", description: "The unique identifier of branchSite") {
            };
            branchSiteIdOption.IsRequired = true;
            command.AddOption(branchSiteIdOption);
            var forwardingProfileIdOption = new Option<string>("--forwarding-profile-id", description: "The unique identifier of forwardingProfile") {
            };
            forwardingProfileIdOption.IsRequired = true;
            command.AddOption(forwardingProfileIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var branchSiteId = invocationContext.ParseResult.GetValueForOption(branchSiteIdOption);
                var forwardingProfileId = invocationContext.ParseResult.GetValueForOption(forwardingProfileIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (branchSiteId is not null) requestInfo.PathParameters.Add("branchSite%2Did", branchSiteId);
                if (forwardingProfileId is not null) requestInfo.PathParameters.Add("forwardingProfile%2Did", forwardingProfileId);
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
        /// Each forwarding profile associated with a branch site is specified. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess on 2023-12-19 and will be removed 2024-03-20")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Each forwarding profile associated with a branch site is specified. Supports $expand.";
            var branchSiteIdOption = new Option<string>("--branch-site-id", description: "The unique identifier of branchSite") {
            };
            branchSiteIdOption.IsRequired = true;
            command.AddOption(branchSiteIdOption);
            var forwardingProfileIdOption = new Option<string>("--forwarding-profile-id", description: "The unique identifier of forwardingProfile") {
            };
            forwardingProfileIdOption.IsRequired = true;
            command.AddOption(forwardingProfileIdOption);
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
                var branchSiteId = invocationContext.ParseResult.GetValueForOption(branchSiteIdOption);
                var forwardingProfileId = invocationContext.ParseResult.GetValueForOption(forwardingProfileIdOption);
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
                if (branchSiteId is not null) requestInfo.PathParameters.Add("branchSite%2Did", branchSiteId);
                if (forwardingProfileId is not null) requestInfo.PathParameters.Add("forwardingProfile%2Did", forwardingProfileId);
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
        /// Update the navigation property forwardingProfiles in networkAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess on 2023-12-19 and will be removed 2024-03-20")]
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property forwardingProfiles in networkAccess";
            var branchSiteIdOption = new Option<string>("--branch-site-id", description: "The unique identifier of branchSite") {
            };
            branchSiteIdOption.IsRequired = true;
            command.AddOption(branchSiteIdOption);
            var forwardingProfileIdOption = new Option<string>("--forwarding-profile-id", description: "The unique identifier of forwardingProfile") {
            };
            forwardingProfileIdOption.IsRequired = true;
            command.AddOption(forwardingProfileIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var branchSiteId = invocationContext.ParseResult.GetValueForOption(branchSiteIdOption);
                var forwardingProfileId = invocationContext.ParseResult.GetValueForOption(forwardingProfileIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.Networkaccess.ForwardingProfile>(global::ApiSdk.Models.Networkaccess.ForwardingProfile.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (branchSiteId is not null) requestInfo.PathParameters.Add("branchSite%2Did", branchSiteId);
                if (forwardingProfileId is not null) requestInfo.PathParameters.Add("forwardingProfile%2Did", forwardingProfileId);
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
        /// Provides operations to manage the policies property of the microsoft.graph.networkaccess.profile entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPoliciesNavCommand()
        {
            var command = new Command("policies");
            command.Description = "Provides operations to manage the policies property of the microsoft.graph.networkaccess.profile entity.";
            var builder = new global::ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.Policies.PoliciesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the servicePrincipal property of the microsoft.graph.networkaccess.forwardingProfile entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildServicePrincipalNavCommand()
        {
            var command = new Command("service-principal");
            command.Description = "Provides operations to manage the servicePrincipal property of the microsoft.graph.networkaccess.forwardingProfile entity.";
            var builder = new global::ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.ServicePrincipal.ServicePrincipalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.ForwardingProfileItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ForwardingProfileItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/networkAccess/connectivity/branches/{branchSite%2Did}/forwardingProfiles/{forwardingProfile%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.ForwardingProfileItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ForwardingProfileItemRequestBuilder(string rawUrl) : base("{+baseurl}/networkAccess/connectivity/branches/{branchSite%2Did}/forwardingProfiles/{forwardingProfile%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property forwardingProfiles for networkAccess
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess on 2023-12-19 and will be removed 2024-03-20")]
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
        /// Each forwarding profile associated with a branch site is specified. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess on 2023-12-19 and will be removed 2024-03-20")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.ForwardingProfileItemRequestBuilder.ForwardingProfileItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.NetworkAccess.Connectivity.Branches.Item.ForwardingProfiles.Item.ForwardingProfileItemRequestBuilder.ForwardingProfileItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property forwardingProfiles in networkAccess
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess on 2023-12-19 and will be removed 2024-03-20")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.Networkaccess.ForwardingProfile body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.Networkaccess.ForwardingProfile body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Each forwarding profile associated with a branch site is specified. Supports $expand.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ForwardingProfileItemRequestBuilderGetQueryParameters 
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
