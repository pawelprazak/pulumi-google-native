// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./api";
export * from "./apiArtifactIamPolicy";
export * from "./apiDeploymentIamPolicy";
export * from "./apiIamPolicy";
export * from "./apiVersionArtifactIamPolicy";
export * from "./apiVersionIamPolicy";
export * from "./apiVersionSpecArtifactIamPolicy";
export * from "./apiVersionSpecIamPolicy";
export * from "./artifact";
export * from "./artifactIamPolicy";
export * from "./deployment";
export * from "./deploymentArtifact";
export * from "./getApi";
export * from "./getApiArtifactIamPolicy";
export * from "./getApiDeploymentIamPolicy";
export * from "./getApiIamPolicy";
export * from "./getApiVersionArtifactIamPolicy";
export * from "./getApiVersionIamPolicy";
export * from "./getApiVersionSpecArtifactIamPolicy";
export * from "./getApiVersionSpecIamPolicy";
export * from "./getArtifact";
export * from "./getArtifactIamPolicy";
export * from "./getDeployment";
export * from "./getDeploymentArtifact";
export * from "./getInstance";
export * from "./getInstanceIamPolicy";
export * from "./getRuntimeIamPolicy";
export * from "./getSpec";
export * from "./getVersion";
export * from "./getVersionArtifact";
export * from "./instance";
export * from "./instanceIamPolicy";
export * from "./runtimeIamPolicy";
export * from "./spec";
export * from "./version";
export * from "./versionArtifact";

// Import resources to register:
import { Api } from "./api";
import { ApiArtifactIamPolicy } from "./apiArtifactIamPolicy";
import { ApiDeploymentIamPolicy } from "./apiDeploymentIamPolicy";
import { ApiIamPolicy } from "./apiIamPolicy";
import { ApiVersionArtifactIamPolicy } from "./apiVersionArtifactIamPolicy";
import { ApiVersionIamPolicy } from "./apiVersionIamPolicy";
import { ApiVersionSpecArtifactIamPolicy } from "./apiVersionSpecArtifactIamPolicy";
import { ApiVersionSpecIamPolicy } from "./apiVersionSpecIamPolicy";
import { Artifact } from "./artifact";
import { ArtifactIamPolicy } from "./artifactIamPolicy";
import { Deployment } from "./deployment";
import { DeploymentArtifact } from "./deploymentArtifact";
import { Instance } from "./instance";
import { InstanceIamPolicy } from "./instanceIamPolicy";
import { RuntimeIamPolicy } from "./runtimeIamPolicy";
import { Spec } from "./spec";
import { Version } from "./version";
import { VersionArtifact } from "./versionArtifact";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:apigeeregistry/v1:Api":
                return new Api(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ApiArtifactIamPolicy":
                return new ApiArtifactIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ApiDeploymentIamPolicy":
                return new ApiDeploymentIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ApiIamPolicy":
                return new ApiIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ApiVersionArtifactIamPolicy":
                return new ApiVersionArtifactIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ApiVersionIamPolicy":
                return new ApiVersionIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ApiVersionSpecArtifactIamPolicy":
                return new ApiVersionSpecArtifactIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ApiVersionSpecIamPolicy":
                return new ApiVersionSpecIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:Artifact":
                return new Artifact(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:ArtifactIamPolicy":
                return new ArtifactIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:Deployment":
                return new Deployment(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:DeploymentArtifact":
                return new DeploymentArtifact(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:Instance":
                return new Instance(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:InstanceIamPolicy":
                return new InstanceIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:RuntimeIamPolicy":
                return new RuntimeIamPolicy(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:Spec":
                return new Spec(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:Version":
                return new Version(name, <any>undefined, { urn })
            case "google-native:apigeeregistry/v1:VersionArtifact":
                return new VersionArtifact(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "apigeeregistry/v1", _module)
