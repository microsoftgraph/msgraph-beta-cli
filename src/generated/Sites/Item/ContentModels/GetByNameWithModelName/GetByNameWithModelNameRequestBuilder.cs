// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.AddToDrive;
using ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.GetAppliedDrives;
using ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.RemoveFromDrive;
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
namespace ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName
{
    /// <summary>
    /// Provides operations to call the getByName method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GetByNameWithModelNameRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to call the addToDrive method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAddToDriveNavCommand()
        {
            var command = new Command("add-to-drive");
            command.Description = "Provides operations to call the addToDrive method.";
            var builder = new global::ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.AddToDrive.AddToDriveRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getAppliedDrives method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetAppliedDrivesNavCommand()
        {
            var command = new Command("get-applied-drives");
            command.Description = "Provides operations to call the getAppliedDrives method.";
            var builder = new global::ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.GetAppliedDrives.GetAppliedDrivesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Read the properties and relationships of a contentModel object by its model name. The name should be the full model filename, including the file extension; for example, exampleModel.classifier.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contentmodel-getbyname?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of a contentModel object by its model name. The name should be the full model filename, including the file extension; for example, exampleModel.classifier.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/contentmodel-getbyname?view=graph-rest-beta";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var modelNameOption = new Option<string>("--model-name", description: "Usage: modelName='{modelName}'") {
            };
            modelNameOption.IsRequired = true;
            command.AddOption(modelNameOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var modelName = invocationContext.ParseResult.GetValueForOption(modelNameOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (modelName is not null) requestInfo.PathParameters.Add("modelName", modelName);
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
        /// Provides operations to call the removeFromDrive method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRemoveFromDriveNavCommand()
        {
            var command = new Command("remove-from-drive");
            command.Description = "Provides operations to call the removeFromDrive method.";
            var builder = new global::ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.RemoveFromDrive.RemoveFromDriveRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.GetByNameWithModelNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GetByNameWithModelNameRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/sites/{site%2Did}/contentModels/getByName(modelName='{modelName}')", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Sites.Item.ContentModels.GetByNameWithModelName.GetByNameWithModelNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetByNameWithModelNameRequestBuilder(string rawUrl) : base("{+baseurl}/sites/{site%2Did}/contentModels/getByName(modelName='{modelName}')", rawUrl)
        {
        }
        /// <summary>
        /// Read the properties and relationships of a contentModel object by its model name. The name should be the full model filename, including the file extension; for example, exampleModel.classifier.
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
