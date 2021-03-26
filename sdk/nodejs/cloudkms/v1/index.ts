// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./cryptoKey";
export * from "./cryptoKeyVersion";
export * from "./importJob";
export * from "./keyRing";
export * from "./policy";

// Import resources to register:
import { CryptoKey } from "./cryptoKey";
import { CryptoKeyVersion } from "./cryptoKeyVersion";
import { ImportJob } from "./importJob";
import { KeyRing } from "./keyRing";
import { Policy } from "./policy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-cloud:cloudkms/v1:CryptoKey":
                return new CryptoKey(name, <any>undefined, { urn })
            case "google-cloud:cloudkms/v1:CryptoKeyVersion":
                return new CryptoKeyVersion(name, <any>undefined, { urn })
            case "google-cloud:cloudkms/v1:ImportJob":
                return new ImportJob(name, <any>undefined, { urn })
            case "google-cloud:cloudkms/v1:KeyRing":
                return new KeyRing(name, <any>undefined, { urn })
            case "google-cloud:cloudkms/v1:Policy":
                return new Policy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-cloud", "cloudkms/v1", _module)