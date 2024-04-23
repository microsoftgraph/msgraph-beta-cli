// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ErrorCode
    {
        /// <summary>Default Value to indicate no error.</summary>
        [EnumMember(Value = "noError")]
        NoError,
        /// <summary>The current user does not have access due to lack of RBAC permissions on the resource.</summary>
        [EnumMember(Value = "unauthorized")]
        Unauthorized,
        /// <summary>The current user does not have access due to lack of RBAC Scope Tags on the resource.</summary>
        [EnumMember(Value = "notFound")]
        NotFound,
        /// <summary>The resource has been deleted.</summary>
        [EnumMember(Value = "deleted")]
        Deleted,
    }
}