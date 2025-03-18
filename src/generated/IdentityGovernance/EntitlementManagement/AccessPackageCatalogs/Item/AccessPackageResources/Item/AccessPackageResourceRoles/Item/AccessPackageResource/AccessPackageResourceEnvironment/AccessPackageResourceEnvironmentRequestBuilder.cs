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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageResources.Item.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment
{
    /// <summary>
    /// Provides operations to manage the accessPackageResourceEnvironment property of the microsoft.graph.accessPackageResource entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccessPackageResourceEnvironmentRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Contains the environment information for the resource. This environment can be set using either the @odata.bind annotation or the environment&apos;s originId. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Contains the environment information for the resource. This environment can be set using either the @odata.bind annotation or the environment's originId. Supports $expand.";
            var accessPackageCatalogIdOption = new Option<string>("--access-package-catalog-id", description: "The unique identifier of accessPackageCatalog") {
            };
            accessPackageCatalogIdOption.IsRequired = true;
            command.AddOption(accessPackageCatalogIdOption);
            var accessPackageResourceIdOption = new Option<string>("--access-package-resource-id", description: "The unique identifier of accessPackageResource") {
            };
            accessPackageResourceIdOption.IsRequired = true;
            command.AddOption(accessPackageResourceIdOption);
            var accessPackageResourceRoleIdOption = new Option<string>("--access-package-resource-role-id", description: "The unique identifier of accessPackageResourceRole") {
            };
            accessPackageResourceRoleIdOption.IsRequired = true;
            command.AddOption(accessPackageResourceRoleIdOption);
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
                var accessPackageCatalogId = invocationContext.ParseResult.GetValueForOption(accessPackageCatalogIdOption);
                var accessPackageResourceId = invocationContext.ParseResult.GetValueForOption(accessPackageResourceIdOption);
                var accessPackageResourceRoleId = invocationContext.ParseResult.GetValueForOption(accessPackageResourceRoleIdOption);
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
                if (accessPackageCatalogId is not null) requestInfo.PathParameters.Add("accessPackageCatalog%2Did", accessPackageCatalogId);
                if (accessPackageResourceId is not null) requestInfo.PathParameters.Add("accessPackageResource%2Did", accessPackageResourceId);
                if (accessPackageResourceRoleId is not null) requestInfo.PathParameters.Add("accessPackageResourceRole%2Did", accessPackageResourceRoleId);
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
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageResources.Item.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment.AccessPackageResourceEnvironmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AccessPackageResourceEnvironmentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/accessPackageResources/{accessPackageResource%2Did}/accessPackageResourceRoles/{accessPackageResourceRole%2Did}/accessPackageResource/accessPackageResourceEnvironment{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageResources.Item.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment.AccessPackageResourceEnvironmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AccessPackageResourceEnvironmentRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/accessPackageResources/{accessPackageResource%2Did}/accessPackageResourceRoles/{accessPackageResourceRole%2Did}/accessPackageResource/accessPackageResourceEnvironment{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Contains the environment information for the resource. This environment can be set using either the @odata.bind annotation or the environment&apos;s originId. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions on 2023-03-01 and will be removed 2023-12-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageResources.Item.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment.AccessPackageResourceEnvironmentRequestBuilder.AccessPackageResourceEnvironmentRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.AccessPackageResources.Item.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment.AccessPackageResourceEnvironmentRequestBuilder.AccessPackageResourceEnvironmentRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Contains the environment information for the resource. This environment can be set using either the @odata.bind annotation or the environment&apos;s originId. Supports $expand.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccessPackageResourceEnvironmentRequestBuilderGetQueryParameters 
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
