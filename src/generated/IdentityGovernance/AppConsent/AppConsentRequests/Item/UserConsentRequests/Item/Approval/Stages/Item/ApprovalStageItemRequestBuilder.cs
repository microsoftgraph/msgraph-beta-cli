using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.IdentityGovernance.AppConsent.AppConsentRequests.Item.UserConsentRequests.Item.Approval.Stages.Item {
    /// <summary>
    /// Provides operations to manage the stages property of the microsoft.graph.approval entity.
    /// </summary>
    public class ApprovalStageItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Delete navigation property stages for identityGovernance
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property stages for identityGovernance";
            var appConsentRequestIdOption = new Option<string>("--app-consent-request-id", description: "The unique identifier of appConsentRequest") {
            };
            appConsentRequestIdOption.IsRequired = true;
            command.AddOption(appConsentRequestIdOption);
            var userConsentRequestIdOption = new Option<string>("--user-consent-request-id", description: "The unique identifier of userConsentRequest") {
            };
            userConsentRequestIdOption.IsRequired = true;
            command.AddOption(userConsentRequestIdOption);
            var approvalStageIdOption = new Option<string>("--approval-stage-id", description: "The unique identifier of approvalStage") {
            };
            approvalStageIdOption.IsRequired = true;
            command.AddOption(approvalStageIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var appConsentRequestId = invocationContext.ParseResult.GetValueForOption(appConsentRequestIdOption);
                var userConsentRequestId = invocationContext.ParseResult.GetValueForOption(userConsentRequestIdOption);
                var approvalStageId = invocationContext.ParseResult.GetValueForOption(approvalStageIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (appConsentRequestId is not null) requestInfo.PathParameters.Add("appConsentRequest%2Did", appConsentRequestId);
                if (userConsentRequestId is not null) requestInfo.PathParameters.Add("userConsentRequest%2Did", userConsentRequestId);
                if (approvalStageId is not null) requestInfo.PathParameters.Add("approvalStage%2Did", approvalStageId);
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
        /// In Azure AD entitlement management, retrieve the properties of an approvalStage object. An approval stage is contained within an approval object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/approvalstage-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "In Azure AD entitlement management, retrieve the properties of an approvalStage object. An approval stage is contained within an approval object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/approvalstage-get?view=graph-rest-1.0";
            var appConsentRequestIdOption = new Option<string>("--app-consent-request-id", description: "The unique identifier of appConsentRequest") {
            };
            appConsentRequestIdOption.IsRequired = true;
            command.AddOption(appConsentRequestIdOption);
            var userConsentRequestIdOption = new Option<string>("--user-consent-request-id", description: "The unique identifier of userConsentRequest") {
            };
            userConsentRequestIdOption.IsRequired = true;
            command.AddOption(userConsentRequestIdOption);
            var approvalStageIdOption = new Option<string>("--approval-stage-id", description: "The unique identifier of approvalStage") {
            };
            approvalStageIdOption.IsRequired = true;
            command.AddOption(approvalStageIdOption);
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
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var appConsentRequestId = invocationContext.ParseResult.GetValueForOption(appConsentRequestIdOption);
                var userConsentRequestId = invocationContext.ParseResult.GetValueForOption(userConsentRequestIdOption);
                var approvalStageId = invocationContext.ParseResult.GetValueForOption(approvalStageIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (appConsentRequestId is not null) requestInfo.PathParameters.Add("appConsentRequest%2Did", appConsentRequestId);
                if (userConsentRequestId is not null) requestInfo.PathParameters.Add("userConsentRequest%2Did", userConsentRequestId);
                if (approvalStageId is not null) requestInfo.PathParameters.Add("approvalStage%2Did", approvalStageId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// In Azure AD entitlement management, approve or deny an approvalStage object in an approval.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/approvalstage-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "In Azure AD entitlement management, approve or deny an approvalStage object in an approval.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/approvalstage-update?view=graph-rest-1.0";
            var appConsentRequestIdOption = new Option<string>("--app-consent-request-id", description: "The unique identifier of appConsentRequest") {
            };
            appConsentRequestIdOption.IsRequired = true;
            command.AddOption(appConsentRequestIdOption);
            var userConsentRequestIdOption = new Option<string>("--user-consent-request-id", description: "The unique identifier of userConsentRequest") {
            };
            userConsentRequestIdOption.IsRequired = true;
            command.AddOption(userConsentRequestIdOption);
            var approvalStageIdOption = new Option<string>("--approval-stage-id", description: "The unique identifier of approvalStage") {
            };
            approvalStageIdOption.IsRequired = true;
            command.AddOption(approvalStageIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var appConsentRequestId = invocationContext.ParseResult.GetValueForOption(appConsentRequestIdOption);
                var userConsentRequestId = invocationContext.ParseResult.GetValueForOption(userConsentRequestIdOption);
                var approvalStageId = invocationContext.ParseResult.GetValueForOption(approvalStageIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApprovalStage>(ApprovalStage.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (appConsentRequestId is not null) requestInfo.PathParameters.Add("appConsentRequest%2Did", appConsentRequestId);
                if (userConsentRequestId is not null) requestInfo.PathParameters.Add("userConsentRequest%2Did", userConsentRequestId);
                if (approvalStageId is not null) requestInfo.PathParameters.Add("approvalStage%2Did", approvalStageId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new ApprovalStageItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ApprovalStageItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/appConsent/appConsentRequests/{appConsentRequest%2Did}/userConsentRequests/{userConsentRequest%2Did}/approval/stages/{approvalStage%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Delete navigation property stages for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// In Azure AD entitlement management, retrieve the properties of an approvalStage object. An approval stage is contained within an approval object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ApprovalStageItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ApprovalStageItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<ApprovalStageItemRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// In Azure AD entitlement management, approve or deny an approvalStage object in an approval.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApprovalStage body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApprovalStage body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// In Azure AD entitlement management, retrieve the properties of an approvalStage object. An approval stage is contained within an approval object.
        /// </summary>
        public class ApprovalStageItemRequestBuilderGetQueryParameters {
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