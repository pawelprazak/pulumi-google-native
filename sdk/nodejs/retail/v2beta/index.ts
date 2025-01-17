// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./control";
export * from "./getControl";
export * from "./getProduct";
export * from "./getServingConfig";
export * from "./product";
export * from "./servingConfig";

// Export enums:
export * from "../../types/enums/retail/v2beta";

// Import resources to register:
import { Control } from "./control";
import { Product } from "./product";
import { ServingConfig } from "./servingConfig";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:retail/v2beta:Control":
                return new Control(name, <any>undefined, { urn })
            case "google-native:retail/v2beta:Product":
                return new Product(name, <any>undefined, { urn })
            case "google-native:retail/v2beta:ServingConfig":
                return new ServingConfig(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "retail/v2beta", _module)
