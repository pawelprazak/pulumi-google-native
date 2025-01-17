// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./backup";
export * from "./getBackup";
export * from "./getInstance";
export * from "./getShare";
export * from "./getSnapshot";
export * from "./instance";
export * from "./share";
export * from "./snapshot";

// Export enums:
export * from "../../types/enums/file/v1beta1";

// Import resources to register:
import { Backup } from "./backup";
import { Instance } from "./instance";
import { Share } from "./share";
import { Snapshot } from "./snapshot";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:file/v1beta1:Backup":
                return new Backup(name, <any>undefined, { urn })
            case "google-native:file/v1beta1:Instance":
                return new Instance(name, <any>undefined, { urn })
            case "google-native:file/v1beta1:Share":
                return new Share(name, <any>undefined, { urn })
            case "google-native:file/v1beta1:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "file/v1beta1", _module)
