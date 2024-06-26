// <auto-generated/>
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Policies.CrossTenantAccessPolicy.Templates.MultiTenantOrganizationPartnerConfiguration.ResetToDefaultSettings
{
    /// <summary>
    /// Provides operations to call the resetToDefaultSettings method.
    /// </summary>
    public class ResetToDefaultSettingsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Reset the cross-tenant access policy template with inbound and outbound partner configuration settings for a multitenant organization to the default values. In its reset state, the template has no impact on partner configuration settings, other than that an unconfigured partner configuration is created if needed, for every multitenant organization tenant.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/multitenantorganizationpartnerconfigurationtemplate-resettodefaultsettings?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Reset the cross-tenant access policy template with inbound and outbound partner configuration settings for a multitenant organization to the default values. In its reset state, the template has no impact on partner configuration settings, other than that an unconfigured partner configuration is created if needed, for every multitenant organization tenant.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/multitenantorganizationpartnerconfigurationtemplate-resettodefaultsettings?view=graph-rest-beta";
            command.SetHandler(async (invocationContext) => {
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
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
        /// Instantiates a new <see cref="ResetToDefaultSettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ResetToDefaultSettingsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationPartnerConfiguration/resetToDefaultSettings", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ResetToDefaultSettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ResetToDefaultSettingsRequestBuilder(string rawUrl) : base("{+baseurl}/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationPartnerConfiguration/resetToDefaultSettings", rawUrl)
        {
        }
        /// <summary>
        /// Reset the cross-tenant access policy template with inbound and outbound partner configuration settings for a multitenant organization to the default values. In its reset state, the template has no impact on partner configuration settings, other than that an unconfigured partner configuration is created if needed, for every multitenant organization tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
