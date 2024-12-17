// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Identity.ConditionalAccess.AuthenticationContextClassReferences;
using ApiSdk.Identity.ConditionalAccess.AuthenticationStrength;
using ApiSdk.Identity.ConditionalAccess.AuthenticationStrengths;
using ApiSdk.Identity.ConditionalAccess.Evaluate;
using ApiSdk.Identity.ConditionalAccess.NamedLocations;
using ApiSdk.Identity.ConditionalAccess.Policies;
using ApiSdk.Identity.ConditionalAccess.Templates;
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
namespace ApiSdk.Identity.ConditionalAccess
{
    /// <summary>
    /// Builds and executes requests for operations under \identity\conditionalAccess
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ConditionalAccessRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the authenticationContextClassReferences property of the microsoft.graph.conditionalAccessRoot entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAuthenticationContextClassReferencesNavCommand()
        {
            var command = new Command("authentication-context-class-references");
            command.Description = "Provides operations to manage the authenticationContextClassReferences property of the microsoft.graph.conditionalAccessRoot entity.";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.AuthenticationContextClassReferences.AuthenticationContextClassReferencesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the authenticationStrength property of the microsoft.graph.conditionalAccessRoot entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAuthenticationStrengthNavCommand()
        {
            var command = new Command("authentication-strength");
            command.Description = "Provides operations to manage the authenticationStrength property of the microsoft.graph.conditionalAccessRoot entity.";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.AuthenticationStrength.AuthenticationStrengthRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAuthenticationMethodModesNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPoliciesNavCommand());
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
        /// Provides operations to manage the authenticationStrengths property of the microsoft.graph.conditionalAccessRoot entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAuthenticationStrengthsNavCommand()
        {
            var command = new Command("authentication-strengths");
            command.Description = "Provides operations to manage the authenticationStrengths property of the microsoft.graph.conditionalAccessRoot entity.";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.AuthenticationStrengths.AuthenticationStrengthsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAuthenticationMethodModesNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPoliciesNavCommand());
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
        /// Provides operations to call the evaluate method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildEvaluateNavCommand()
        {
            var command = new Command("evaluate");
            command.Description = "Provides operations to call the evaluate method.";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.Evaluate.EvaluateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the namedLocations property of the microsoft.graph.conditionalAccessRoot entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildNamedLocationsNavCommand()
        {
            var command = new Command("named-locations");
            command.Description = "Provides operations to manage the namedLocations property of the microsoft.graph.conditionalAccessRoot entity.";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.NamedLocations.NamedLocationsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the policies property of the microsoft.graph.conditionalAccessRoot entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPoliciesNavCommand()
        {
            var command = new Command("policies");
            command.Description = "Provides operations to manage the policies property of the microsoft.graph.conditionalAccessRoot entity.";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.Policies.PoliciesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the templates property of the microsoft.graph.conditionalAccessRoot entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTemplatesNavCommand()
        {
            var command = new Command("templates");
            command.Description = "Provides operations to manage the templates property of the microsoft.graph.conditionalAccessRoot entity.";
            var builder = new global::ApiSdk.Identity.ConditionalAccess.Templates.TemplatesRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="global::ApiSdk.Identity.ConditionalAccess.ConditionalAccessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ConditionalAccessRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identity/conditionalAccess", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Identity.ConditionalAccess.ConditionalAccessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConditionalAccessRequestBuilder(string rawUrl) : base("{+baseurl}/identity/conditionalAccess", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
