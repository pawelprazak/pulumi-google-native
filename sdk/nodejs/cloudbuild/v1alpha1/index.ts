// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getWorkerPool";
export * from "./workerPool";

// Export enums:
export * from "../../types/enums/cloudbuild/v1alpha1";

// Import resources to register:
import { WorkerPool } from "./workerPool";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:cloudbuild/v1alpha1:WorkerPool":
                return new WorkerPool(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "cloudbuild/v1alpha1", _module)
