// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WorkbookWorksheet : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of charts that are part of the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookChart>? Charts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookChart> Charts { get; set; }
#endif
        /// <summary>The display name of the worksheet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The list of names that are associated with the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookNamedItem>? Names { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookNamedItem> Names { get; set; }
#endif
        /// <summary>The list of piot tables that are part of the worksheet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookPivotTable>? PivotTables { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookPivotTable> PivotTables { get; set; }
#endif
        /// <summary>The zero-based position of the worksheet within the workbook.</summary>
        public int? Position { get; set; }
        /// <summary>The sheet protection object for a worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkbookWorksheetProtection? Protection { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkbookWorksheetProtection Protection { get; set; }
#endif
        /// <summary>The list of tables that are part of the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookTable>? Tables { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookTable> Tables { get; set; }
#endif
        /// <summary>Collection of document tasks on this worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookDocumentTask>? Tasks { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookDocumentTask> Tasks { get; set; }
#endif
        /// <summary>The visibility of the worksheet. The possible values are: Visible, Hidden, VeryHidden.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility { get; set; }
#nullable restore
#else
        public string Visibility { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WorkbookWorksheet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WorkbookWorksheet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WorkbookWorksheet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "charts", n => { Charts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookChart>(global::ApiSdk.Models.WorkbookChart.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "names", n => { Names = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookNamedItem>(global::ApiSdk.Models.WorkbookNamedItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pivotTables", n => { PivotTables = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookPivotTable>(global::ApiSdk.Models.WorkbookPivotTable.CreateFromDiscriminatorValue)?.AsList(); } },
                { "position", n => { Position = n.GetIntValue(); } },
                { "protection", n => { Protection = n.GetObjectValue<global::ApiSdk.Models.WorkbookWorksheetProtection>(global::ApiSdk.Models.WorkbookWorksheetProtection.CreateFromDiscriminatorValue); } },
                { "tables", n => { Tables = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookTable>(global::ApiSdk.Models.WorkbookTable.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookDocumentTask>(global::ApiSdk.Models.WorkbookDocumentTask.CreateFromDiscriminatorValue)?.AsList(); } },
                { "visibility", n => { Visibility = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookChart>("charts", Charts);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookPivotTable>("pivotTables", PivotTables);
            writer.WriteIntValue("position", Position);
            writer.WriteObjectValue<global::ApiSdk.Models.WorkbookWorksheetProtection>("protection", Protection);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookTable>("tables", Tables);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookDocumentTask>("tasks", Tasks);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
#pragma warning restore CS0618
