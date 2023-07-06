using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Print : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of available print connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintConnector>? Connectors { get; set; }
#nullable restore
#else
        public List<PrintConnector> Connectors { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The list of print long running operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintOperation>? Operations { get; set; }
#nullable restore
#else
        public List<PrintOperation> Operations { get; set; }
#endif
        /// <summary>The list of printers registered in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Printer>? Printers { get; set; }
#nullable restore
#else
        public List<Printer> Printers { get; set; }
#endif
        /// <summary>The list of available Universal Print service endpoints.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintService>? Services { get; set; }
#nullable restore
#else
        public List<PrintService> Services { get; set; }
#endif
        /// <summary>Tenant-wide settings for the Universal Print service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintSettings? Settings { get; set; }
#nullable restore
#else
        public PrintSettings Settings { get; set; }
#endif
        /// <summary>The list of printer shares registered in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrinterShare>? Shares { get; set; }
#nullable restore
#else
        public List<PrinterShare> Shares { get; set; }
#endif
        /// <summary>List of abstract definition for a task that can be triggered when various events occur within Universal Print.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintTaskDefinition>? TaskDefinitions { get; set; }
#nullable restore
#else
        public List<PrintTaskDefinition> TaskDefinitions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Print and sets the default values.
        /// </summary>
        public Print() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Print CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Print();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"connectors", n => { Connectors = n.GetCollectionOfObjectValues<PrintConnector>(PrintConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<PrintOperation>(PrintOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"printers", n => { Printers = n.GetCollectionOfObjectValues<Printer>(Printer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"services", n => { Services = n.GetCollectionOfObjectValues<PrintService>(PrintService.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<PrintSettings>(PrintSettings.CreateFromDiscriminatorValue); } },
                {"shares", n => { Shares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taskDefinitions", n => { TaskDefinitions = n.GetCollectionOfObjectValues<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PrintConnector>("connectors", Connectors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<PrintOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Printer>("printers", Printers);
            writer.WriteCollectionOfObjectValues<PrintService>("services", Services);
            writer.WriteObjectValue<PrintSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<PrinterShare>("shares", Shares);
            writer.WriteCollectionOfObjectValues<PrintTaskDefinition>("taskDefinitions", TaskDefinitions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}