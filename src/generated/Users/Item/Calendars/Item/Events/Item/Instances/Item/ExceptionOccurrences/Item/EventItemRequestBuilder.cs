// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Accept;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Attachments;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Calendar;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Cancel;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Decline;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.DismissReminder;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Extensions;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Forward;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.PermanentDelete;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.SnoozeReminder;
using ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.TentativelyAccept;
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
namespace ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item
{
    /// <summary>
    /// Provides operations to manage the exceptionOccurrences property of the microsoft.graph.event entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EventItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to call the accept method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAcceptNavCommand()
        {
            var command = new Command("accept");
            command.Description = "Provides operations to call the accept method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Accept.AcceptRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the attachments property of the microsoft.graph.event entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAttachmentsNavCommand()
        {
            var command = new Command("attachments");
            command.Description = "Provides operations to manage the attachments property of the microsoft.graph.event entity.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Attachments.AttachmentsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildCreateUploadSessionNavCommand());
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
        /// Provides operations to manage the calendar property of the microsoft.graph.event entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCalendarNavCommand()
        {
            var command = new Command("calendar");
            command.Description = "Provides operations to manage the calendar property of the microsoft.graph.event entity.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Calendar.CalendarRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the cancel method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCancelNavCommand()
        {
            var command = new Command("cancel");
            command.Description = "Provides operations to call the cancel method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Cancel.CancelRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the decline method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeclineNavCommand()
        {
            var command = new Command("decline");
            command.Description = "Provides operations to call the decline method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Decline.DeclineRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the dismissReminder method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDismissReminderNavCommand()
        {
            var command = new Command("dismiss-reminder");
            command.Description = "Provides operations to call the dismissReminder method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.DismissReminder.DismissReminderRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the extensions property of the microsoft.graph.event entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildExtensionsNavCommand()
        {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.event entity.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Extensions.ExtensionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
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
        /// Provides operations to call the forward method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildForwardNavCommand()
        {
            var command = new Command("forward");
            command.Description = "Provides operations to call the forward method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.Forward.ForwardRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Get exceptionOccurrences from users
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get exceptionOccurrences from users";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var calendarIdOption = new Option<string>("--calendar-id", description: "The unique identifier of calendar") {
            };
            calendarIdOption.IsRequired = true;
            command.AddOption(calendarIdOption);
            var eventIdOption = new Option<string>("--event-id", description: "The unique identifier of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var eventId1Option = new Option<string>("--event-id1", description: "The unique identifier of event") {
            };
            eventId1Option.IsRequired = true;
            command.AddOption(eventId1Option);
            var eventId2Option = new Option<string>("--event-id2", description: "The unique identifier of event") {
            };
            eventId2Option.IsRequired = true;
            command.AddOption(eventId2Option);
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var calendarId = invocationContext.ParseResult.GetValueForOption(calendarIdOption);
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var eventId1 = invocationContext.ParseResult.GetValueForOption(eventId1Option);
                var eventId2 = invocationContext.ParseResult.GetValueForOption(eventId2Option);
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
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (calendarId is not null) requestInfo.PathParameters.Add("calendar%2Did", calendarId);
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
                if (eventId1 is not null) requestInfo.PathParameters.Add("event%2Did1", eventId1);
                if (eventId2 is not null) requestInfo.PathParameters.Add("event%2Did2", eventId2);
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
        /// Provides operations to call the permanentDelete method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPermanentDeleteNavCommand()
        {
            var command = new Command("permanent-delete");
            command.Description = "Provides operations to call the permanentDelete method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.PermanentDelete.PermanentDeleteRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the snoozeReminder method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSnoozeReminderNavCommand()
        {
            var command = new Command("snooze-reminder");
            command.Description = "Provides operations to call the snoozeReminder method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.SnoozeReminder.SnoozeReminderRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the tentativelyAccept method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTentativelyAcceptNavCommand()
        {
            var command = new Command("tentatively-accept");
            command.Description = "Provides operations to call the tentativelyAccept method.";
            var builder = new global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.TentativelyAccept.TentativelyAcceptRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EventItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/calendars/{calendar%2Did}/events/{event%2Did}/instances/{event%2Did1}/exceptionOccurrences/{event%2Did2}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EventItemRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/calendars/{calendar%2Did}/events/{event%2Did}/instances/{event%2Did1}/exceptionOccurrences/{event%2Did2}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get exceptionOccurrences from users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Users.Item.Calendars.Item.Events.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get exceptionOccurrences from users
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class EventItemRequestBuilderGetQueryParameters 
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
