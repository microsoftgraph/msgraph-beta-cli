// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.ChangeCloudCertificationAuthorityStatus;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.CloudCertificationAuthorityLeafCertificate;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.GetAllCloudCertificationAuthority;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.GetAllCloudCertificationAuthorityLeafCertificates;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.GetCloudCertificationAuthority;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.PatchCloudCertificationAuthority;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.PostCloudCertificationAuthority;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.RevokeCloudCertificationAuthorityCertificate;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.RevokeLeafCertificate;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.RevokeLeafCertificateBySerialNumber;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.SearchCloudCertificationAuthorityLeafCertificateBySerialNumber;
using ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.UploadExternallySignedCertificationAuthorityCertificate;
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
namespace ApiSdk.DeviceManagement.CloudCertificationAuthority.Item
{
    /// <summary>
    /// Provides operations to manage the cloudCertificationAuthority property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CloudCertificationAuthorityItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to call the changeCloudCertificationAuthorityStatus method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildChangeCloudCertificationAuthorityStatusNavCommand()
        {
            var command = new Command("change-cloud-certification-authority-status");
            command.Description = "Provides operations to call the changeCloudCertificationAuthorityStatus method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.ChangeCloudCertificationAuthorityStatus.ChangeCloudCertificationAuthorityStatusRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the cloudCertificationAuthorityLeafCertificate property of the microsoft.graph.cloudCertificationAuthority entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCloudCertificationAuthorityLeafCertificateNavCommand()
        {
            var command = new Command("cloud-certification-authority-leaf-certificate");
            command.Description = "Provides operations to manage the cloudCertificationAuthorityLeafCertificate property of the microsoft.graph.cloudCertificationAuthority entity.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.CloudCertificationAuthorityLeafCertificate.CloudCertificationAuthorityLeafCertificateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
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
        /// Delete navigation property cloudCertificationAuthority for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property cloudCertificationAuthority for deviceManagement";
            var cloudCertificationAuthorityIdOption = new Option<string>("--cloud-certification-authority-id", description: "The unique identifier of cloudCertificationAuthority") {
            };
            cloudCertificationAuthorityIdOption.IsRequired = true;
            command.AddOption(cloudCertificationAuthorityIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var cloudCertificationAuthorityId = invocationContext.ParseResult.GetValueForOption(cloudCertificationAuthorityIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (cloudCertificationAuthorityId is not null) requestInfo.PathParameters.Add("cloudCertificationAuthority%2Did", cloudCertificationAuthorityId);
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
        /// Provides operations to call the getAllCloudCertificationAuthorityLeafCertificates method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetAllCloudCertificationAuthorityLeafCertificatesNavCommand()
        {
            var command = new Command("get-all-cloud-certification-authority-leaf-certificates");
            command.Description = "Provides operations to call the getAllCloudCertificationAuthorityLeafCertificates method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.GetAllCloudCertificationAuthorityLeafCertificates.GetAllCloudCertificationAuthorityLeafCertificatesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getAllCloudCertificationAuthority method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetAllCloudCertificationAuthorityNavCommand()
        {
            var command = new Command("get-all-cloud-certification-authority");
            command.Description = "Provides operations to call the getAllCloudCertificationAuthority method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.GetAllCloudCertificationAuthority.GetAllCloudCertificationAuthorityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCloudCertificationAuthority method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCloudCertificationAuthorityNavCommand()
        {
            var command = new Command("get-cloud-certification-authority");
            command.Description = "Provides operations to call the getCloudCertificationAuthority method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.GetCloudCertificationAuthority.GetCloudCertificationAuthorityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Collection of CloudCertificationAuthority records associated with account.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Collection of CloudCertificationAuthority records associated with account.";
            var cloudCertificationAuthorityIdOption = new Option<string>("--cloud-certification-authority-id", description: "The unique identifier of cloudCertificationAuthority") {
            };
            cloudCertificationAuthorityIdOption.IsRequired = true;
            command.AddOption(cloudCertificationAuthorityIdOption);
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
                var cloudCertificationAuthorityId = invocationContext.ParseResult.GetValueForOption(cloudCertificationAuthorityIdOption);
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
                if (cloudCertificationAuthorityId is not null) requestInfo.PathParameters.Add("cloudCertificationAuthority%2Did", cloudCertificationAuthorityId);
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
        /// Provides operations to call the patchCloudCertificationAuthority method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCloudCertificationAuthorityNavCommand()
        {
            var command = new Command("patch-cloud-certification-authority");
            command.Description = "Provides operations to call the patchCloudCertificationAuthority method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.PatchCloudCertificationAuthority.PatchCloudCertificationAuthorityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property cloudCertificationAuthority in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property cloudCertificationAuthority in deviceManagement";
            var cloudCertificationAuthorityIdOption = new Option<string>("--cloud-certification-authority-id", description: "The unique identifier of cloudCertificationAuthority") {
            };
            cloudCertificationAuthorityIdOption.IsRequired = true;
            command.AddOption(cloudCertificationAuthorityIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var cloudCertificationAuthorityId = invocationContext.ParseResult.GetValueForOption(cloudCertificationAuthorityIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = await ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNodeAsync("application/json", stream, cancellationToken);
                var model = parseNode.GetObjectValue<global::ApiSdk.Models.CloudCertificationAuthority>(global::ApiSdk.Models.CloudCertificationAuthority.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (cloudCertificationAuthorityId is not null) requestInfo.PathParameters.Add("cloudCertificationAuthority%2Did", cloudCertificationAuthorityId);
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
        /// Provides operations to call the postCloudCertificationAuthority method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCloudCertificationAuthorityNavCommand()
        {
            var command = new Command("post-cloud-certification-authority");
            command.Description = "Provides operations to call the postCloudCertificationAuthority method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.PostCloudCertificationAuthority.PostCloudCertificationAuthorityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the revokeCloudCertificationAuthorityCertificate method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRevokeCloudCertificationAuthorityCertificateNavCommand()
        {
            var command = new Command("revoke-cloud-certification-authority-certificate");
            command.Description = "Provides operations to call the revokeCloudCertificationAuthorityCertificate method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.RevokeCloudCertificationAuthorityCertificate.RevokeCloudCertificationAuthorityCertificateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the revokeLeafCertificateBySerialNumber method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRevokeLeafCertificateBySerialNumberNavCommand()
        {
            var command = new Command("revoke-leaf-certificate-by-serial-number");
            command.Description = "Provides operations to call the revokeLeafCertificateBySerialNumber method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.RevokeLeafCertificateBySerialNumber.RevokeLeafCertificateBySerialNumberRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the revokeLeafCertificate method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRevokeLeafCertificateNavCommand()
        {
            var command = new Command("revoke-leaf-certificate");
            command.Description = "Provides operations to call the revokeLeafCertificate method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.RevokeLeafCertificate.RevokeLeafCertificateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the searchCloudCertificationAuthorityLeafCertificateBySerialNumber method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSearchCloudCertificationAuthorityLeafCertificateBySerialNumberNavCommand()
        {
            var command = new Command("search-cloud-certification-authority-leaf-certificate-by-serial-number");
            command.Description = "Provides operations to call the searchCloudCertificationAuthorityLeafCertificateBySerialNumber method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.SearchCloudCertificationAuthorityLeafCertificateBySerialNumber.SearchCloudCertificationAuthorityLeafCertificateBySerialNumberRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the uploadExternallySignedCertificationAuthorityCertificate method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUploadExternallySignedCertificationAuthorityCertificateNavCommand()
        {
            var command = new Command("upload-externally-signed-certification-authority-certificate");
            command.Description = "Provides operations to call the uploadExternallySignedCertificationAuthorityCertificate method.";
            var builder = new global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.UploadExternallySignedCertificationAuthorityCertificate.UploadExternallySignedCertificationAuthorityCertificateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.CloudCertificationAuthorityItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CloudCertificationAuthorityItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/cloudCertificationAuthority/{cloudCertificationAuthority%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.CloudCertificationAuthorityItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CloudCertificationAuthorityItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/cloudCertificationAuthority/{cloudCertificationAuthority%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property cloudCertificationAuthority for deviceManagement
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
        /// Collection of CloudCertificationAuthority records associated with account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.CloudCertificationAuthorityItemRequestBuilder.CloudCertificationAuthorityItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.DeviceManagement.CloudCertificationAuthority.Item.CloudCertificationAuthorityItemRequestBuilder.CloudCertificationAuthorityItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property cloudCertificationAuthority in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.CloudCertificationAuthority body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ApiSdk.Models.CloudCertificationAuthority body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Collection of CloudCertificationAuthority records associated with account.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CloudCertificationAuthorityItemRequestBuilderGetQueryParameters 
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