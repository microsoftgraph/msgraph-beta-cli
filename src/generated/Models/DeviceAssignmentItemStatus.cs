// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>A list of possible assignment item action status values for the application or configuration regarding their executed action on the managed device. For example, a configuration included in the deviceAssignmentItems list has just been executed the action. Its status starts with inProgress until it&apos;s successfully removed to reflect as removed status or failed to be removed to reflect as error status on the managed device. Similar status change happens for restoration process</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceAssignmentItemStatus
    {
        /// <summary>Default. Indicates that the device assignment action to remove or restore an application or a configuration is &apos;initiated&apos; on the managed device</summary>
        [EnumMember(Value = "initiated")]
        Initiated,
        /// <summary>Indicates that the device assignment action to remove or restore an application or a configuration is &apos;in progress&apos; on the managed device</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>Indicates that the application or configuration has been successfully removed on the managed device</summary>
        [EnumMember(Value = "removed")]
        Removed,
        /// <summary>Indicates that the application or configuration has failed to be removed or restored on the managed device. The error may be retriable depending on the intent action message and error code</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>Indicates that the application or configuration has been successfully restored on the managed device</summary>
        [EnumMember(Value = "succeeded")]
        Succeeded,
        /// <summary>Evolvable enumeration sentinel value. Do not use</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}