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
namespace ApiSdk.Identity.B2cUserFlows.Item.Languages.Item.OverridesPages.Item.Value
{
    /// <summary>
    /// Provides operations to manage the media for the identityContainer entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ContentRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Deletes the values in an userFlowLanguagePage object. You may only delete the values in an overridesPage, which is used to customize the values shown to a user during a user journey defined by a user flow.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/userflowlanguagepage-delete?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Deletes the values in an userFlowLanguagePage object. You may only delete the values in an overridesPage, which is used to customize the values shown to a user during a user journey defined by a user flow.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/userflowlanguagepage-delete?view=graph-rest-beta";
            var b2cIdentityUserFlowIdOption = new Option<string>("--b2c-identity-user-flow-id", description: "The unique identifier of b2cIdentityUserFlow") {
            };
            b2cIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2cIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--user-flow-language-configuration-id", description: "The unique identifier of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--user-flow-language-page-id", description: "The unique identifier of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var b2cIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2cIdentityUserFlowIdOption);
                var userFlowLanguageConfigurationId = invocationContext.ParseResult.GetValueForOption(userFlowLanguageConfigurationIdOption);
                var userFlowLanguagePageId = invocationContext.ParseResult.GetValueForOption(userFlowLanguagePageIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (b2cIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2cIdentityUserFlow%2Did", b2cIdentityUserFlowId);
                if (userFlowLanguageConfigurationId is not null) requestInfo.PathParameters.Add("userFlowLanguageConfiguration%2Did", userFlowLanguageConfigurationId);
                if (userFlowLanguagePageId is not null) requestInfo.PathParameters.Add("userFlowLanguagePage%2Did", userFlowLanguagePageId);
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
        /// Get the userFlowLanguagePage resources from the overridesPages navigation property. These pages are used to customize the values shown to the user during a user journey in a user flow.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the userFlowLanguagePage resources from the overridesPages navigation property. These pages are used to customize the values shown to the user during a user journey in a user flow.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-beta";
            var b2cIdentityUserFlowIdOption = new Option<string>("--b2c-identity-user-flow-id", description: "The unique identifier of b2cIdentityUserFlow") {
            };
            b2cIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2cIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--user-flow-language-configuration-id", description: "The unique identifier of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--user-flow-language-page-id", description: "The unique identifier of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var b2cIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2cIdentityUserFlowIdOption);
                var userFlowLanguageConfigurationId = invocationContext.ParseResult.GetValueForOption(userFlowLanguageConfigurationIdOption);
                var userFlowLanguagePageId = invocationContext.ParseResult.GetValueForOption(userFlowLanguagePageIdOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (b2cIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2cIdentityUserFlow%2Did", b2cIdentityUserFlowId);
                if (userFlowLanguageConfigurationId is not null) requestInfo.PathParameters.Add("userFlowLanguageConfiguration%2Did", userFlowLanguageConfigurationId);
                if (userFlowLanguagePageId is not null) requestInfo.PathParameters.Add("userFlowLanguagePage%2Did", userFlowLanguagePageId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Update the values in an userFlowLanguagePage object. You may only update the values in an overridesPage, which is used to customize the values shown to a user during a user journey defined by a user flow.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/userflowlanguagepage-put?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPutCommand()
        {
            var command = new Command("put");
            command.Description = "Update the values in an userFlowLanguagePage object. You may only update the values in an overridesPage, which is used to customize the values shown to a user during a user journey defined by a user flow.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/userflowlanguagepage-put?view=graph-rest-beta";
            var b2cIdentityUserFlowIdOption = new Option<string>("--b2c-identity-user-flow-id", description: "The unique identifier of b2cIdentityUserFlow") {
            };
            b2cIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2cIdentityUserFlowIdOption);
            var userFlowLanguageConfigurationIdOption = new Option<string>("--user-flow-language-configuration-id", description: "The unique identifier of userFlowLanguageConfiguration") {
            };
            userFlowLanguageConfigurationIdOption.IsRequired = true;
            command.AddOption(userFlowLanguageConfigurationIdOption);
            var userFlowLanguagePageIdOption = new Option<string>("--user-flow-language-page-id", description: "The unique identifier of userFlowLanguagePage") {
            };
            userFlowLanguagePageIdOption.IsRequired = true;
            command.AddOption(userFlowLanguagePageIdOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var b2cIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2cIdentityUserFlowIdOption);
                var userFlowLanguageConfigurationId = invocationContext.ParseResult.GetValueForOption(userFlowLanguageConfigurationIdOption);
                var userFlowLanguagePageId = invocationContext.ParseResult.GetValueForOption(userFlowLanguagePageIdOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) {
                    Console.Error.WriteLine("No available file to send.");
                    return;
                }
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (b2cIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2cIdentityUserFlow%2Did", b2cIdentityUserFlowId);
                if (userFlowLanguageConfigurationId is not null) requestInfo.PathParameters.Add("userFlowLanguageConfiguration%2Did", userFlowLanguageConfigurationId);
                if (userFlowLanguagePageId is not null) requestInfo.PathParameters.Add("userFlowLanguagePage%2Did", userFlowLanguagePageId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Identity.B2cUserFlows.Item.Languages.Item.OverridesPages.Item.Value.ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/languages/{userFlowLanguageConfiguration%2Did}/overridesPages/{userFlowLanguagePage%2Did}/$value", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Identity.B2cUserFlows.Item.Languages.Item.OverridesPages.Item.Value.ContentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContentRequestBuilder(string rawUrl) : base("{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/languages/{userFlowLanguageConfiguration%2Did}/overridesPages/{userFlowLanguagePage%2Did}/$value", rawUrl)
        {
        }
        /// <summary>
        /// Deletes the values in an userFlowLanguagePage object. You may only delete the values in an overridesPage, which is used to customize the values shown to a user during a user journey defined by a user flow.
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
            return requestInfo;
        }
        /// <summary>
        /// Get the userFlowLanguagePage resources from the overridesPages navigation property. These pages are used to customize the values shown to the user during a user journey in a user flow.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// Update the values in an userFlowLanguagePage object. You may only update the values in an overridesPage, which is used to customize the values shown to a user during a user journey defined by a user flow.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetStreamContent(body, "application/octet-stream");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
