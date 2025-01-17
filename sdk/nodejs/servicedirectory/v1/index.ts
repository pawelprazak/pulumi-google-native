// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./endpoint";
export * from "./getEndpoint";
export * from "./getNamespace";
export * from "./getNamespaceIamPolicy";
export * from "./getNamespaceServiceIamPolicy";
export * from "./getService";
export * from "./namespace";
export * from "./namespaceIamPolicy";
export * from "./namespaceServiceIamPolicy";
export * from "./service";

// Import resources to register:
import { Endpoint } from "./endpoint";
import { Namespace } from "./namespace";
import { NamespaceIamPolicy } from "./namespaceIamPolicy";
import { NamespaceServiceIamPolicy } from "./namespaceServiceIamPolicy";
import { Service } from "./service";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:servicedirectory/v1:Endpoint":
                return new Endpoint(name, <any>undefined, { urn })
            case "google-native:servicedirectory/v1:Namespace":
                return new Namespace(name, <any>undefined, { urn })
            case "google-native:servicedirectory/v1:NamespaceIamPolicy":
                return new NamespaceIamPolicy(name, <any>undefined, { urn })
            case "google-native:servicedirectory/v1:NamespaceServiceIamPolicy":
                return new NamespaceServiceIamPolicy(name, <any>undefined, { urn })
            case "google-native:servicedirectory/v1:Service":
                return new Service(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "servicedirectory/v1", _module)
