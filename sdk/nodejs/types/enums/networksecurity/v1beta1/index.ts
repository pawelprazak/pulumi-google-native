// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const AuthorizationPolicyAction = {
    /**
     * Default value.
     */
    ActionUnspecified: "ACTION_UNSPECIFIED",
    /**
     * Grant access.
     */
    Allow: "ALLOW",
    /**
     * Deny access. Deny rules should be avoided unless they are used to provide a default "deny all" fallback.
     */
    Deny: "DENY",
} as const;

/**
 * Required. The action to take when a rule match is found. Possible values are "ALLOW" or "DENY".
 */
export type AuthorizationPolicyAction = (typeof AuthorizationPolicyAction)[keyof typeof AuthorizationPolicyAction];

export const GoogleIamV1AuditLogConfigLogType = {
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
export type GoogleIamV1AuditLogConfigLogType = (typeof GoogleIamV1AuditLogConfigLogType)[keyof typeof GoogleIamV1AuditLogConfigLogType];
