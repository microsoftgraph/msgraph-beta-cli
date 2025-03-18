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
namespace ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item.Presentation
{
    /// <summary>
    /// Provides operations to manage the presentation property of the microsoft.graph.groupPolicyPresentationValue entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PresentationRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The group policy presentation associated with the presentation value.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The group policy presentation associated with the presentation value.";
            var groupPolicyConfigurationIdOption = new Option<string>("--group-policy-configuration-id", description: "The unique identifier of groupPolicyConfiguration") {
            };
            groupPolicyConfigurationIdOption.IsRequired = true;
            command.AddOption(groupPolicyConfigurationIdOption);
            var groupPolicyDefinitionValueIdOption = new Option<string>("--group-policy-definition-value-id", description: "The unique identifier of groupPolicyDefinitionValue") {
            };
            groupPolicyDefinitionValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyDefinitionValueIdOption);
            var groupPolicyPresentationValueIdOption = new Option<string>("--group-policy-presentation-value-id", description: "The unique identifier of groupPolicyPresentationValue") {
            };
            groupPolicyPresentationValueIdOption.IsRequired = true;
            command.AddOption(groupPolicyPresentationValueIdOption);
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
                var groupPolicyConfigurationId = invocationContext.ParseResult.GetValueForOption(groupPolicyConfigurationIdOption);
                var groupPolicyDefinitionValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyDefinitionValueIdOption);
                var groupPolicyPresentationValueId = invocationContext.ParseResult.GetValueForOption(groupPolicyPresentationValueIdOption);
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
                if (groupPolicyConfigurationId is not null) requestInfo.PathParameters.Add("groupPolicyConfiguration%2Did", groupPolicyConfigurationId);
                if (groupPolicyDefinitionValueId is not null) requestInfo.PathParameters.Add("groupPolicyDefinitionValue%2Did", groupPolicyDefinitionValueId);
                if (groupPolicyPresentationValueId is not null) requestInfo.PathParameters.Add("groupPolicyPresentationValue%2Did", groupPolicyPresentationValueId);
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
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item.Presentation.PresentationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PresentationRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration%2Did}/definitionValues/{groupPolicyDefinitionValue%2Did}/presentationValues/{groupPolicyPresentationValue%2Did}/presentation{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item.Presentation.PresentationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PresentationRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration%2Did}/definitionValues/{groupPolicyDefinitionValue%2Did}/presentationValues/{groupPolicyPresentationValue%2Did}/presentation{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The group policy presentation associated with the presentation value.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item.Presentation.PresentationRequestBuilder.PresentationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.GroupPolicyConfigurations.Item.DefinitionValues.Item.PresentationValues.Item.Presentation.PresentationRequestBuilder.PresentationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The group policy presentation associated with the presentation value.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PresentationRequestBuilderGetQueryParameters 
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
