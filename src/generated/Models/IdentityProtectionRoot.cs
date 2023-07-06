using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class IdentityProtectionRoot : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Risk detection in Azure AD Identity Protection and the associated information about the detection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskDetection>? RiskDetections { get; set; }
#nullable restore
#else
        public List<RiskDetection> RiskDetections { get; set; }
#endif
        /// <summary>Azure AD service principals that are at risk.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskyServicePrincipal>? RiskyServicePrincipals { get; set; }
#nullable restore
#else
        public List<RiskyServicePrincipal> RiskyServicePrincipals { get; set; }
#endif
        /// <summary>Users that are flagged as at-risk by Azure AD Identity Protection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskyUser>? RiskyUsers { get; set; }
#nullable restore
#else
        public List<RiskyUser> RiskyUsers { get; set; }
#endif
        /// <summary>Represents information about detected at-risk service principals in an Azure AD tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServicePrincipalRiskDetection>? ServicePrincipalRiskDetections { get; set; }
#nullable restore
#else
        public List<ServicePrincipalRiskDetection> ServicePrincipalRiskDetections { get; set; }
#endif
        /// <summary>
        /// Instantiates a new IdentityProtectionRoot and sets the default values.
        /// </summary>
        public IdentityProtectionRoot() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IdentityProtectionRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityProtectionRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"riskDetections", n => { RiskDetections = n.GetCollectionOfObjectValues<RiskDetection>(RiskDetection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"riskyServicePrincipals", n => { RiskyServicePrincipals = n.GetCollectionOfObjectValues<RiskyServicePrincipal>(RiskyServicePrincipal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"riskyUsers", n => { RiskyUsers = n.GetCollectionOfObjectValues<RiskyUser>(RiskyUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"servicePrincipalRiskDetections", n => { ServicePrincipalRiskDetections = n.GetCollectionOfObjectValues<ServicePrincipalRiskDetection>(ServicePrincipalRiskDetection.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<RiskDetection>("riskDetections", RiskDetections);
            writer.WriteCollectionOfObjectValues<RiskyServicePrincipal>("riskyServicePrincipals", RiskyServicePrincipals);
            writer.WriteCollectionOfObjectValues<RiskyUser>("riskyUsers", RiskyUsers);
            writer.WriteCollectionOfObjectValues<ServicePrincipalRiskDetection>("servicePrincipalRiskDetections", ServicePrincipalRiskDetections);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}