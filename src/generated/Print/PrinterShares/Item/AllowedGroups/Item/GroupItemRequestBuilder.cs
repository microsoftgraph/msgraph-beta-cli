// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Print.PrinterShares.Item.AllowedGroups.Item.Ref;
using ApiSdk.Print.PrinterShares.Item.AllowedGroups.Item.ServiceProvisioningErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ApiSdk.Print.PrinterShares.Item.AllowedGroups.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \print\printerShares\{printerShare-id}\allowedGroups\{group-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GroupItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the collection of print entities.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRefByIdNavCommand()
        {
            var command = new Command("ref-by-id");
            command.Description = "Provides operations to manage the collection of print entities.";
            var builder = new global::ApiSdk.Print.PrinterShares.Item.AllowedGroups.Item.Ref.RefRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The serviceProvisioningErrors property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildServiceProvisioningErrorsNavCommand()
        {
            var command = new Command("service-provisioning-errors");
            command.Description = "The serviceProvisioningErrors property";
            var builder = new global::ApiSdk.Print.PrinterShares.Item.AllowedGroups.Item.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Print.PrinterShares.Item.AllowedGroups.Item.GroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/printerShares/{printerShare%2Did}/allowedGroups/{group%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Print.PrinterShares.Item.AllowedGroups.Item.GroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GroupItemRequestBuilder(string rawUrl) : base("{+baseurl}/print/printerShares/{printerShare%2Did}/allowedGroups/{group%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
