// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./certificate";
export * from "./certificateAuthority";
export * from "./policy";

// Import resources to register:
import { Certificate } from "./certificate";
import { CertificateAuthority } from "./certificateAuthority";
import { Policy } from "./policy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-cloud:privateca/v1beta1:Certificate":
                return new Certificate(name, <any>undefined, { urn })
            case "google-cloud:privateca/v1beta1:CertificateAuthority":
                return new CertificateAuthority(name, <any>undefined, { urn })
            case "google-cloud:privateca/v1beta1:Policy":
                return new Policy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-cloud", "privateca/v1beta1", _module)