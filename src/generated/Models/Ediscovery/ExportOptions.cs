// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Ediscovery {
    [Flags]
    public enum ExportOptions
    {
        [EnumMember(Value = "originalFiles")]
        OriginalFiles = 1,
        [EnumMember(Value = "text")]
        Text = 2,
        [EnumMember(Value = "pdfReplacement")]
        PdfReplacement = 4,
        [EnumMember(Value = "fileInfo")]
        FileInfo = 8,
        [EnumMember(Value = "tags")]
        Tags = 16,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 32,
    }
}