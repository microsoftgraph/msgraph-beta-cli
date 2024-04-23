// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Describes the OfficeSuiteApp file format types that can be selected.</summary>
    public enum OfficeSuiteDefaultFileFormatType
    {
        /// <summary>No file format selected</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Office Open XML Format selected</summary>
        [EnumMember(Value = "officeOpenXMLFormat")]
        OfficeOpenXMLFormat,
        /// <summary>Office Open Document Format selected</summary>
        [EnumMember(Value = "officeOpenDocumentFormat")]
        OfficeOpenDocumentFormat,
        /// <summary>Placeholder for evolvable enum.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}