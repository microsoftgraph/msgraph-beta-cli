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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackagesWithUniqueName.MoveToCatalog
{
    /// <summary>
    /// Provides operations to call the moveToCatalog method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MoveToCatalogRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// In Microsoft Entra entitlement management, this action moves the accessPackage to a specified target accessPackageCatalog. The resources in the access package must be present in the target catalog.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackage-movetocatalog?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "In Microsoft Entra entitlement management, this action moves the accessPackage to a specified target accessPackageCatalog. The resources in the access package must be present in the target catalog.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accesspackage-movetocatalog?view=graph-rest-beta";
            var uniqueNameOption = new Option<string>("--unique-name", description: "Alternate key of accessPackage") {
            };
            uniqueNameOption.IsRequired = true;
            command.AddOption(uniqueNameOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var uniqueName = invocationContext.ParseResult.GetValueForOption(uniqueNameOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackagesWithUniqueName.MoveToCatalog.MoveToCatalogPostRequestBody>(global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackagesWithUniqueName.MoveToCatalog.MoveToCatalogPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (uniqueName is not null) requestInfo.PathParameters.Add("uniqueName", uniqueName);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackagesWithUniqueName.MoveToCatalog.MoveToCatalogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MoveToCatalogRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackages(uniqueName='{uniqueName}')/moveToCatalog", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackagesWithUniqueName.MoveToCatalog.MoveToCatalogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MoveToCatalogRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackages(uniqueName='{uniqueName}')/moveToCatalog", rawUrl)
        {
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, this action moves the accessPackage to a specified target accessPackageCatalog. The resources in the access package must be present in the target catalog.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackagesWithUniqueName.MoveToCatalog.MoveToCatalogPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackagesWithUniqueName.MoveToCatalog.MoveToCatalogPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
#pragma warning restore CS0618