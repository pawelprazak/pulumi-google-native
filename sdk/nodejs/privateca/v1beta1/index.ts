// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./certificate";
export * from "./certificateAuthority";
export * from "./certificateAuthorityCertificateRevocationListIamPolicy";
export * from "./certificateAuthorityIamPolicy";
export * from "./getCertificate";
export * from "./getCertificateAuthority";
export * from "./getCertificateAuthorityCertificateRevocationListIamPolicy";
export * from "./getCertificateAuthorityIamPolicy";
export * from "./getReusableConfigIamPolicy";
export * from "./reusableConfigIamPolicy";

// Export enums:
export * from "../../types/enums/privateca/v1beta1";

// Import resources to register:
import { Certificate } from "./certificate";
import { CertificateAuthority } from "./certificateAuthority";
import { CertificateAuthorityCertificateRevocationListIamPolicy } from "./certificateAuthorityCertificateRevocationListIamPolicy";
import { CertificateAuthorityIamPolicy } from "./certificateAuthorityIamPolicy";
import { ReusableConfigIamPolicy } from "./reusableConfigIamPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:privateca/v1beta1:Certificate":
                return new Certificate(name, <any>undefined, { urn })
            case "google-native:privateca/v1beta1:CertificateAuthority":
                return new CertificateAuthority(name, <any>undefined, { urn })
            case "google-native:privateca/v1beta1:CertificateAuthorityCertificateRevocationListIamPolicy":
                return new CertificateAuthorityCertificateRevocationListIamPolicy(name, <any>undefined, { urn })
            case "google-native:privateca/v1beta1:CertificateAuthorityIamPolicy":
                return new CertificateAuthorityIamPolicy(name, <any>undefined, { urn })
            case "google-native:privateca/v1beta1:ReusableConfigIamPolicy":
                return new ReusableConfigIamPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "privateca/v1beta1", _module)
