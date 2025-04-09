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
namespace ApiSdk.Templates.DeviceTemplates.Item.Owners.Item
{
    /// <summary>
    /// Provides operations to manage the owners property of the microsoft.graph.deviceTemplate entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DirectoryObjectItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Collection of directory objects that can manage the device template and the related deviceInstances. Owners can be represented as service principals, users, or applications. An owner has full privileges over the device template and doesn&apos;t require other administrator roles to create, update, or delete devices from this template, as well as to add or remove template owners. There can be a maximum of 100 owners on a device template.  Supports $expand.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Collection of directory objects that can manage the device template and the related deviceInstances. Owners can be represented as service principals, users, or applications. An owner has full privileges over the device template and doesn't require other administrator roles to create, update, or delete devices from this template, as well as to add or remove template owners. There can be a maximum of 100 owners on a device template.  Supports $expand.";
            var deviceTemplateIdOption = new Option<string>("--device-template-id", description: "The unique identifier of deviceTemplate") {
            };
            deviceTemplateIdOption.IsRequired = true;
            command.AddOption(deviceTemplateIdOption);
            var directoryObjectIdOption = new Option<string>("--directory-object-id", description: "The unique identifier of directoryObject") {
            };
            directoryObjectIdOption.IsRequired = true;
            command.AddOption(directoryObjectIdOption);
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
                var deviceTemplateId = invocationContext.ParseResult.GetValueForOption(deviceTemplateIdOption);
                var directoryObjectId = invocationContext.ParseResult.GetValueForOption(directoryObjectIdOption);
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
                if (deviceTemplateId is not null) requestInfo.PathParameters.Add("deviceTemplate%2Did", deviceTemplateId);
                if (directoryObjectId is not null) requestInfo.PathParameters.Add("directoryObject%2Did", directoryObjectId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Templates.DeviceTemplates.Item.Owners.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/templates/deviceTemplates/{deviceTemplate%2Did}/owners/{directoryObject%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Templates.DeviceTemplates.Item.Owners.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl) : base("{+baseurl}/templates/deviceTemplates/{deviceTemplate%2Did}/owners/{directoryObject%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Collection of directory objects that can manage the device template and the related deviceInstances. Owners can be represented as service principals, users, or applications. An owner has full privileges over the device template and doesn&apos;t require other administrator roles to create, update, or delete devices from this template, as well as to add or remove template owners. There can be a maximum of 100 owners on a device template.  Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Templates.DeviceTemplates.Item.Owners.Item.DirectoryObjectItemRequestBuilder.DirectoryObjectItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Templates.DeviceTemplates.Item.Owners.Item.DirectoryObjectItemRequestBuilder.DirectoryObjectItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Collection of directory objects that can manage the device template and the related deviceInstances. Owners can be represented as service principals, users, or applications. An owner has full privileges over the device template and doesn&apos;t require other administrator roles to create, update, or delete devices from this template, as well as to add or remove template owners. There can be a maximum of 100 owners on a device template.  Supports $expand.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DirectoryObjectItemRequestBuilderGetQueryParameters 
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
