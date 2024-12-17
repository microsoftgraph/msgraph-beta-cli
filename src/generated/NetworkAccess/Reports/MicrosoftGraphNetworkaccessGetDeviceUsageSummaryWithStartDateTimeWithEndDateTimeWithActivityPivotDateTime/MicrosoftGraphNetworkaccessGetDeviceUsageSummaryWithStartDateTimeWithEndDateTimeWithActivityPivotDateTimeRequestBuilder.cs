// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.Networkaccess;
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
namespace ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTime
{
    /// <summary>
    /// Provides operations to call the getDeviceUsageSummary method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTimeRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get a summary of device onboarding and offboarding within a specified timeframe. This summary includes the total number of devices, active devices, and inactive devices.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get a summary of device onboarding and offboarding within a specified timeframe. This summary includes the total number of devices, active devices, and inactive devices.";
            var startDateTimeOption = new Option<DateTimeOffset?>("--start-date-time", description: "Usage: startDateTime={startDateTime}") {
            };
            startDateTimeOption.IsRequired = true;
            command.AddOption(startDateTimeOption);
            var endDateTimeOption = new Option<DateTimeOffset?>("--end-date-time", description: "Usage: endDateTime={endDateTime}") {
            };
            endDateTimeOption.IsRequired = true;
            command.AddOption(endDateTimeOption);
            var activityPivotDateTimeOption = new Option<DateTimeOffset?>("--activity-pivot-date-time", description: "Usage: activityPivotDateTime={activityPivotDateTime}") {
            };
            activityPivotDateTimeOption.IsRequired = true;
            command.AddOption(activityPivotDateTimeOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var startDateTime = invocationContext.ParseResult.GetValueForOption(startDateTimeOption);
                var endDateTime = invocationContext.ParseResult.GetValueForOption(endDateTimeOption);
                var activityPivotDateTime = invocationContext.ParseResult.GetValueForOption(activityPivotDateTimeOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (startDateTime is not null) requestInfo.PathParameters.Add("startDateTime", startDateTime);
                if (endDateTime is not null) requestInfo.PathParameters.Add("endDateTime", endDateTime);
                if (activityPivotDateTime is not null) requestInfo.PathParameters.Add("activityPivotDateTime", activityPivotDateTime);
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
        /// Instantiates a new <see cref="global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTime.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTimeRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/networkAccess/reports/microsoft.graph.networkaccess.getDeviceUsageSummary(startDateTime={startDateTime},endDateTime={endDateTime},activityPivotDateTime={activityPivotDateTime})", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTime.MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphNetworkaccessGetDeviceUsageSummaryWithStartDateTimeWithEndDateTimeWithActivityPivotDateTimeRequestBuilder(string rawUrl) : base("{+baseurl}/networkAccess/reports/microsoft.graph.networkaccess.getDeviceUsageSummary(startDateTime={startDateTime},endDateTime={endDateTime},activityPivotDateTime={activityPivotDateTime})", rawUrl)
        {
        }
        /// <summary>
        /// Get a summary of device onboarding and offboarding within a specified timeframe. This summary includes the total number of devices, active devices, and inactive devices.
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
#pragma warning restore CS0618
