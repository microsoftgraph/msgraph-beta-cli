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
namespace ApiSdk.Communications.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl {
    /// <summary>
    /// Provides operations to call the getVirtualAppointmentJoinWebUrl method.
    /// </summary>
    public class GetVirtualAppointmentJoinWebUrlRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Invoke function getVirtualAppointmentJoinWebUrl
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Invoke function getVirtualAppointmentJoinWebUrl";
            var joinWebUrlOption = new Option<string>("--join-web-url", description: "Alternate key of onlineMeeting") {
            };
            joinWebUrlOption.IsRequired = true;
            command.AddOption(joinWebUrlOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var joinWebUrl = invocationContext.ParseResult.GetValueForOption(joinWebUrlOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (joinWebUrl is not null) requestInfo.PathParameters.Add("joinWebUrl", joinWebUrl);
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
        /// Instantiates a new <see cref="GetVirtualAppointmentJoinWebUrlRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GetVirtualAppointmentJoinWebUrlRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/communications/onlineMeetings(joinWebUrl='{joinWebUrl}')/getVirtualAppointmentJoinWebUrl()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GetVirtualAppointmentJoinWebUrlRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetVirtualAppointmentJoinWebUrlRequestBuilder(string rawUrl) : base("{+baseurl}/communications/onlineMeetings(joinWebUrl='{joinWebUrl}')/getVirtualAppointmentJoinWebUrl()", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function getVirtualAppointmentJoinWebUrl
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
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}