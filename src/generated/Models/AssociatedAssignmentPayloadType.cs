// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>This enum represents associated assignment payload type</summary>
    public enum AssociatedAssignmentPayloadType
    {
        /// <summary>Invalid payload type</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that this filter is associated with a configuration or compliance policy payload type</summary>
        [EnumMember(Value = "deviceConfigurationAndCompliance")]
        DeviceConfigurationAndCompliance,
        /// <summary>Indicates that this assignment filter is associated with an application payload type</summary>
        [EnumMember(Value = "application")]
        Application,
        /// <summary>Indicates that this filter is associated with a Android Enterprise application payload type</summary>
        [EnumMember(Value = "androidEnterpriseApp")]
        AndroidEnterpriseApp,
        /// <summary>Indicates that this filter is associated with an enrollment restriction or enrollment status page policy payload type</summary>
        [EnumMember(Value = "enrollmentConfiguration")]
        EnrollmentConfiguration,
        /// <summary>Indicates that this filter is associated with an Administrative Template policy payload type</summary>
        [EnumMember(Value = "groupPolicyConfiguration")]
        GroupPolicyConfiguration,
        /// <summary>Indicates that this assignment filter is associated with Zero touch deployment Device Configuration Profile payload type</summary>
        [EnumMember(Value = "zeroTouchDeploymentDeviceConfigProfile")]
        ZeroTouchDeploymentDeviceConfigProfile,
        /// <summary>Indicates that this filter is associated with an Android Enterprise Configuration policy payload type</summary>
        [EnumMember(Value = "androidEnterpriseConfiguration")]
        AndroidEnterpriseConfiguration,
        /// <summary>Indicates that this assignment filter is associated with Device Firmware Configuration Interface(DCFI) payload type</summary>
        [EnumMember(Value = "deviceFirmwareConfigurationInterfacePolicy")]
        DeviceFirmwareConfigurationInterfacePolicy,
        /// <summary>Indicates that this filter is associated with a resource access policy (Wifi, VPN, Certificate) payload type</summary>
        [EnumMember(Value = "resourceAccessPolicy")]
        ResourceAccessPolicy,
        /// <summary>Indicates that this filter is associated with a Win32 app payload type</summary>
        [EnumMember(Value = "win32app")]
        Win32app,
        /// <summary>Indicates that this filter is associated with a configuration or compliance policy on Device Configuration v2 Infrastructure payload type</summary>
        [EnumMember(Value = "deviceManagmentConfigurationAndCompliancePolicy")]
        DeviceManagmentConfigurationAndCompliancePolicy,
    }
}