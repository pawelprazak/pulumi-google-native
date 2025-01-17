// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./feature";
export * from "./featureIamPolicy";
export * from "./fleet";
export * from "./getFeature";
export * from "./getFeatureIamPolicy";
export * from "./getFleet";
export * from "./getMembership";
export * from "./getMembershipIamPolicy";
export * from "./membership";
export * from "./membershipIamPolicy";

// Export enums:
export * from "../../types/enums/gkehub/v1alpha";

// Import resources to register:
import { Feature } from "./feature";
import { FeatureIamPolicy } from "./featureIamPolicy";
import { Fleet } from "./fleet";
import { Membership } from "./membership";
import { MembershipIamPolicy } from "./membershipIamPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:gkehub/v1alpha:Feature":
                return new Feature(name, <any>undefined, { urn })
            case "google-native:gkehub/v1alpha:FeatureIamPolicy":
                return new FeatureIamPolicy(name, <any>undefined, { urn })
            case "google-native:gkehub/v1alpha:Fleet":
                return new Fleet(name, <any>undefined, { urn })
            case "google-native:gkehub/v1alpha:Membership":
                return new Membership(name, <any>undefined, { urn })
            case "google-native:gkehub/v1alpha:MembershipIamPolicy":
                return new MembershipIamPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "gkehub/v1alpha", _module)
