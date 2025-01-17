// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const AuditLogConfigLogType = {
    /**
     * Default case. Should never be this.
     */
    LogTypeUnspecified: "LOG_TYPE_UNSPECIFIED",
    /**
     * Admin reads. Example: CloudIAM getIamPolicy
     */
    AdminRead: "ADMIN_READ",
    /**
     * Data writes. Example: CloudSQL Users create
     */
    DataWrite: "DATA_WRITE",
    /**
     * Data reads. Example: CloudSQL Users list
     */
    DataRead: "DATA_READ",
} as const;

/**
 * The log type that this config enables.
 */
export type AuditLogConfigLogType = (typeof AuditLogConfigLogType)[keyof typeof AuditLogConfigLogType];

export const FeatureSpecProvisionGoogleCa = {
    /**
     * Disable default Google managed CA.
     */
    GoogleCaProvisioningUnspecified: "GOOGLE_CA_PROVISIONING_UNSPECIFIED",
    /**
     * Disable default Google managed CA.
     */
    Disabled: "DISABLED",
    /**
     * Use default Google managed CA.
     */
    Enabled: "ENABLED",
} as const;

/**
 * Immutable. Specifies CA configuration.
 */
export type FeatureSpecProvisionGoogleCa = (typeof FeatureSpecProvisionGoogleCa)[keyof typeof FeatureSpecProvisionGoogleCa];

export const MembershipSpecCertificateManagement = {
    /**
     * Disable workload certificate feature.
     */
    CertificateManagementUnspecified: "CERTIFICATE_MANAGEMENT_UNSPECIFIED",
    /**
     * Disable workload certificate feature.
     */
    Disabled: "DISABLED",
    /**
     * Enable workload certificate feature.
     */
    Enabled: "ENABLED",
} as const;

/**
 * Specifies workload certificate management.
 */
export type MembershipSpecCertificateManagement = (typeof MembershipSpecCertificateManagement)[keyof typeof MembershipSpecCertificateManagement];

export const MultiClusterIngressFeatureSpecBilling = {
    /**
     * Unknown
     */
    BillingUnspecified: "BILLING_UNSPECIFIED",
    /**
     * User pays a fee per-endpoint.
     */
    PayAsYouGo: "PAY_AS_YOU_GO",
    /**
     * User is paying for Anthos as a whole.
     */
    AnthosLicense: "ANTHOS_LICENSE",
} as const;

/**
 * Deprecated: This field will be ignored and should not be set. Customer's billing structure.
 */
export type MultiClusterIngressFeatureSpecBilling = (typeof MultiClusterIngressFeatureSpecBilling)[keyof typeof MultiClusterIngressFeatureSpecBilling];

export const OnPremClusterClusterType = {
    /**
     * The ClusterType is not set.
     */
    ClustertypeUnspecified: "CLUSTERTYPE_UNSPECIFIED",
    /**
     * The ClusterType is bootstrap cluster.
     */
    Bootstrap: "BOOTSTRAP",
    /**
     * The ClusterType is baremetal hybrid cluster.
     */
    Hybrid: "HYBRID",
    /**
     * The ClusterType is baremetal standalone cluster.
     */
    Standalone: "STANDALONE",
    /**
     * The ClusterType is user cluster.
     */
    User: "USER",
} as const;

/**
 * Immutable. The on prem cluster's type.
 */
export type OnPremClusterClusterType = (typeof OnPremClusterClusterType)[keyof typeof OnPremClusterClusterType];
