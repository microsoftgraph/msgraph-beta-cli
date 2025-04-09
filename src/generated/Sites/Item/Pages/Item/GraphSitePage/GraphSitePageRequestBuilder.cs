// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Sites.Item.Pages.Item.GraphSitePage.CanvasLayout;
using ApiSdk.Sites.Item.Pages.Item.GraphSitePage.CreatedByUser;
using ApiSdk.Sites.Item.Pages.Item.GraphSitePage.LastModifiedByUser;
using ApiSdk.Sites.Item.Pages.Item.GraphSitePage.WebParts;
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
namespace ApiSdk.Sites.Item.Pages.Item.GraphSitePage
{
    /// <summary>
    /// Casts the previous resource to sitePage.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GraphSitePageRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the canvasLayout property of the microsoft.graph.sitePage entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCanvasLayoutNavCommand()
        {
            var command = new Command("canvas-layout");
            command.Description = "Provides operations to manage the canvasLayout property of the microsoft.graph.sitePage entity.";
            var builder = new global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.CanvasLayout.CanvasLayoutRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildHorizontalSectionsNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildVerticalSectionNavCommand());
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
        /// Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreatedByUserNavCommand()
        {
            var command = new Command("created-by-user");
            command.Description = "Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.";
            var builder = new global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.CreatedByUser.CreatedByUserRequestBuilder(PathParameters);
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
        /// Returns the metadata for a sitePage in the site pages list in a site.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/sitepage-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Returns the metadata for a sitePage in the site pages list in a site.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/sitepage-get?view=graph-rest-beta";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var baseSitePageIdOption = new Option<string>("--base-site-page-id", description: "The unique identifier of baseSitePage") {
            };
            baseSitePageIdOption.IsRequired = true;
            command.AddOption(baseSitePageIdOption);
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
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var baseSitePageId = invocationContext.ParseResult.GetValueForOption(baseSitePageIdOption);
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
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (baseSitePageId is not null) requestInfo.PathParameters.Add("baseSitePage%2Did", baseSitePageId);
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
        /// Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLastModifiedByUserNavCommand()
        {
            var command = new Command("last-modified-by-user");
            command.Description = "Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.";
            var builder = new global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters);
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
        /// Provides operations to manage the webParts property of the microsoft.graph.sitePage entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWebPartsNavCommand()
        {
            var command = new Command("web-parts");
            command.Description = "Provides operations to manage the webParts property of the microsoft.graph.sitePage entity.";
            var builder = new global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.WebParts.WebPartsRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.GraphSitePageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GraphSitePageRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/sites/{site%2Did}/pages/{baseSitePage%2Did}/graph.sitePage{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.GraphSitePageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GraphSitePageRequestBuilder(string rawUrl) : base("{+baseurl}/sites/{site%2Did}/pages/{baseSitePage%2Did}/graph.sitePage{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the metadata for a sitePage in the site pages list in a site.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.GraphSitePageRequestBuilder.GraphSitePageRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Sites.Item.Pages.Item.GraphSitePage.GraphSitePageRequestBuilder.GraphSitePageRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns the metadata for a sitePage in the site pages list in a site.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GraphSitePageRequestBuilderGetQueryParameters 
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
