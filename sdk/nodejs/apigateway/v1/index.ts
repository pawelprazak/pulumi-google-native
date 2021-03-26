// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./apigatewayOperation";
export * from "./apigatewayPolicy";

// Import resources to register:
import { ApigatewayOperation } from "./apigatewayOperation";
import { ApigatewayPolicy } from "./apigatewayPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-cloud:apigateway/v1:ApigatewayOperation":
                return new ApigatewayOperation(name, <any>undefined, { urn })
            case "google-cloud:apigateway/v1:ApigatewayPolicy":
                return new ApigatewayPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-cloud", "apigateway/v1", _module)