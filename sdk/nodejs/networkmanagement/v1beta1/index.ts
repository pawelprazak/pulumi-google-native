// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./connectivityTest";
export * from "./connectivityTestIamPolicy";
export * from "./getConnectivityTest";
export * from "./getConnectivityTestIamPolicy";

// Export enums:
export * from "../../types/enums/networkmanagement/v1beta1";

// Import resources to register:
import { ConnectivityTest } from "./connectivityTest";
import { ConnectivityTestIamPolicy } from "./connectivityTestIamPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:networkmanagement/v1beta1:ConnectivityTest":
                return new ConnectivityTest(name, <any>undefined, { urn })
            case "google-native:networkmanagement/v1beta1:ConnectivityTestIamPolicy":
                return new ConnectivityTestIamPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "networkmanagement/v1beta1", _module)
