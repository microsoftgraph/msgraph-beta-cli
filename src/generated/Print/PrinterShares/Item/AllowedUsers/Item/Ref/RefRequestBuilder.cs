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
namespace ApiSdk.Print.PrinterShares.Item.AllowedUsers.Item.Ref
{
    /// <summary>
    /// Provides operations to manage the collection of print entities.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RefRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Revoke the specified user&apos;s access to submit print jobs to the associated printerShare.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/printershare-delete-alloweduser?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The printerShares navigation property is deprecated and will stop returning data on July 31, 2023. Please use the shares navigation property instead of this. as of 2023-06/Tasks_And_Plans on 2023-06-13 and will be removed 2023-07-31")]
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Revoke the specified user's access to submit print jobs to the associated printerShare.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/printershare-delete-alloweduser?view=graph-rest-beta";
            var printerShareIdOption = new Option<string>("--printer-share-id", description: "The unique identifier of printerShare") {
            };
            printerShareIdOption.IsRequired = true;
            command.AddOption(printerShareIdOption);
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var printerShareId = invocationContext.ParseResult.GetValueForOption(printerShareIdOption);
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (printerShareId is not null) requestInfo.PathParameters.Add("printerShare%2Did", printerShareId);
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
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
        /// Instantiates a new <see cref="global::ApiSdk.Print.PrinterShares.Item.AllowedUsers.Item.Ref.RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/printerShares/{printerShare%2Did}/allowedUsers/{user%2Did}/$ref", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Print.PrinterShares.Item.AllowedUsers.Item.Ref.RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder(string rawUrl) : base("{+baseurl}/print/printerShares/{printerShare%2Did}/allowedUsers/{user%2Did}/$ref", rawUrl)
        {
        }
        /// <summary>
        /// Revoke the specified user&apos;s access to submit print jobs to the associated printerShare.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The printerShares navigation property is deprecated and will stop returning data on July 31, 2023. Please use the shares navigation property instead of this. as of 2023-06/Tasks_And_Plans on 2023-06-13 and will be removed 2023-07-31")]
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
