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
namespace ApiSdk.Identity.B2cUserFlows.Item.IdentityProviders.Item.Ref
{
    /// <summary>
    /// Provides operations to manage the collection of identityContainer entities.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RefRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete an identity provider from a b2cIdentityUserFlow object. For more information about identity providers available for user flows, see the identityProviders API reference.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/b2cidentityuserflow-delete-identityproviders?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The identityProvider API is deprecated and will stop returning data on March 2023. Please use the new identityProviderBase API. as of 2021-05/identityProvider")]
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete an identity provider from a b2cIdentityUserFlow object. For more information about identity providers available for user flows, see the identityProviders API reference.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/b2cidentityuserflow-delete-identityproviders?view=graph-rest-beta";
            var b2cIdentityUserFlowIdOption = new Option<string>("--b2c-identity-user-flow-id", description: "The unique identifier of b2cIdentityUserFlow") {
            };
            b2cIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2cIdentityUserFlowIdOption);
            var identityProviderIdOption = new Option<string>("--identity-provider-id", description: "The unique identifier of identityProvider") {
            };
            identityProviderIdOption.IsRequired = true;
            command.AddOption(identityProviderIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var b2cIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2cIdentityUserFlowIdOption);
                var identityProviderId = invocationContext.ParseResult.GetValueForOption(identityProviderIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (b2cIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2cIdentityUserFlow%2Did", b2cIdentityUserFlowId);
                if (identityProviderId is not null) requestInfo.PathParameters.Add("identityProvider%2Did", identityProviderId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Identity.B2cUserFlows.Item.IdentityProviders.Item.Ref.RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/identityProviders/{identityProvider%2Did}/$ref", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Identity.B2cUserFlows.Item.IdentityProviders.Item.Ref.RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder(string rawUrl) : base("{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/identityProviders/{identityProvider%2Did}/$ref", rawUrl)
        {
        }
        /// <summary>
        /// Delete an identity provider from a b2cIdentityUserFlow object. For more information about identity providers available for user flows, see the identityProviders API reference.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The identityProvider API is deprecated and will stop returning data on March 2023. Please use the new identityProviderBase API. as of 2021-05/identityProvider")]
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
    }
}
#pragma warning restore CS0618
