// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const GoogleCloudAssuredworkloadsV1WorkloadResourceSettingsResourceType = {
    /**
     * Unknown resource type.
     */
    ResourceTypeUnspecified: "RESOURCE_TYPE_UNSPECIFIED",
    /**
     * Consumer project. AssuredWorkloads Projects are no longer supported. This field will be ignored only in CreateWorkload requests. ListWorkloads and GetWorkload will continue to provide projects information. Use CONSUMER_FOLDER instead.
     */
    ConsumerProject: "CONSUMER_PROJECT",
    /**
     * Consumer Folder.
     */
    ConsumerFolder: "CONSUMER_FOLDER",
    /**
     * Consumer project containing encryption keys.
     */
    EncryptionKeysProject: "ENCRYPTION_KEYS_PROJECT",
    /**
     * Keyring resource that hosts encryption keys.
     */
    Keyring: "KEYRING",
} as const;

/**
 * Indicates the type of resource. This field should be specified to correspond the id to the right project type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT)
 */
export type GoogleCloudAssuredworkloadsV1WorkloadResourceSettingsResourceType = (typeof GoogleCloudAssuredworkloadsV1WorkloadResourceSettingsResourceType)[keyof typeof GoogleCloudAssuredworkloadsV1WorkloadResourceSettingsResourceType];

export const WorkloadComplianceRegime = {
    /**
     * Unknown compliance regime.
     */
    ComplianceRegimeUnspecified: "COMPLIANCE_REGIME_UNSPECIFIED",
    /**
     * Information protection as per DoD IL4 requirements.
     */
    Il4: "IL4",
    /**
     * Criminal Justice Information Services (CJIS) Security policies.
     */
    Cjis: "CJIS",
    /**
     * FedRAMP High data protection controls
     */
    FedrampHigh: "FEDRAMP_HIGH",
    /**
     * FedRAMP Moderate data protection controls
     */
    FedrampModerate: "FEDRAMP_MODERATE",
    /**
     * Assured Workloads For US Regions data protection controls
     */
    UsRegionalAccess: "US_REGIONAL_ACCESS",
    /**
     * Health Insurance Portability and Accountability Act controls
     */
    Hipaa: "HIPAA",
    /**
     * Health Information Trust Alliance controls
     */
    Hitrust: "HITRUST",
    /**
     * Assured Workloads For EU Regions and Support controls
     */
    EuRegionsAndSupport: "EU_REGIONS_AND_SUPPORT",
    /**
     * Assured Workloads For Canada Regions and Support controls
     */
    CaRegionsAndSupport: "CA_REGIONS_AND_SUPPORT",
    /**
     * International Traffic in Arms Regulations
     */
    Itar: "ITAR",
} as const;

/**
 * Required. Immutable. Compliance Regime associated with this workload.
 */
export type WorkloadComplianceRegime = (typeof WorkloadComplianceRegime)[keyof typeof WorkloadComplianceRegime];
