// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./device";
export * from "./getDevice";
export * from "./getRegistry";
export * from "./getRegistryGroupIamPolicy";
export * from "./getRegistryIamPolicy";
export * from "./registry";
export * from "./registryGroupIamPolicy";
export * from "./registryIamPolicy";

// Export enums:
export * from "../../types/enums/cloudiot/v1";

// Import resources to register:
import { Device } from "./device";
import { Registry } from "./registry";
import { RegistryGroupIamPolicy } from "./registryGroupIamPolicy";
import { RegistryIamPolicy } from "./registryIamPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:cloudiot/v1:Device":
                return new Device(name, <any>undefined, { urn })
            case "google-native:cloudiot/v1:Registry":
                return new Registry(name, <any>undefined, { urn })
            case "google-native:cloudiot/v1:RegistryGroupIamPolicy":
                return new RegistryGroupIamPolicy(name, <any>undefined, { urn })
            case "google-native:cloudiot/v1:RegistryIamPolicy":
                return new RegistryIamPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "cloudiot/v1", _module)
